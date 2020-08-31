#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <sys/ioctl.h>
#include <sys/select.h>
#include <stdio.h>
#include <unistd.h>
#include <fcntl.h>
#include <errno.h>
#include <string.h>
#include <stdlib.h>
#include "../lib/globals.h"
#include "../lib/sha1.h"
#include "../lib/rc4.h"

int main()
{
        int sd;
        int addr_len, bytes_read;
        unsigned char recv_data[MAX_STR_SZ];
		char send_data[MAX_STR_SZ];
        // we use "unsigned char" because RC4 require it
		unsigned char NA[MAX_STR_SZ], NA_rc4[MAX_STR_SZ];
		unsigned char NB[MAX_STR_SZ], NB_rc4[MAX_STR_SZ];
		unsigned char ciphertext[MAX_STR_SZ];
		char K[MAX_STR_SZ];
		char D[MAX_STR_SZ];
		struct sockaddr_in server_addr , client_addr;
		rc4_key rc4key;		// rc4 key
		int rc4_len = 160/8;
		// we have 2 stages, 0 == comm not secured, 1 == secure channel is established.
		int stage = 0;		// flag to indicate in which stage of the comm we are.

		// clear variables
		memset (NA, 0, MAX_STR_SZ);
		memset (NA_rc4, 0, MAX_STR_SZ);
		memset (NB, 0, MAX_STR_SZ);
		memset (NB_rc4, 0, MAX_STR_SZ);
		memset (K, 0, MAX_STR_SZ);
		memset (ciphertext, 0, MAX_STR_SZ);
		//  choose the 160-bit random string
		memcpy (NA, generateRandomString (), rc4_len); // and copy it in NA
		memcpy (NA_rc4, NA, rc4_len); // save it
		
		// rc4 processing
		prepare_key((unsigned char*)PASSWORD, PASSWD_LEN, &rc4key);	// prepare the rc4 key
		rc4((unsigned char*)NA_rc4, rc4_len, &rc4key);				// encrypt NA using rc4 -> store in NA_rc4

		// network setup
        if ((sd = socket(AF_INET, SOCK_DGRAM, 0)) == -1) { 
            perror("Socket");
            exit(1);
        }

        server_addr.sin_family = AF_INET;
        server_addr.sin_port = htons(SIN_PORT);
        server_addr.sin_addr.s_addr = INADDR_ANY;
        bzero(&(server_addr.sin_zero),8);


        if (bind(sd,(struct sockaddr *)&server_addr,
            sizeof(struct sockaddr)) == -1)
        {
            perror("Bind");
            exit(1);
        }

        addr_len = sizeof(struct sockaddr);

        printf("\nWaiting for connections...\n");
        fflush(stdout);

		fd_set readfds; 
		
		struct timeval tv;
		tv.tv_sec = 0;
    	tv.tv_usec = 0;

		printf(PROMPT); fflush (stdout);
		while (1)
        {
			FD_ZERO(&readfds);
			FD_SET(sd, &readfds);
			int rv = select(sd + 1, &readfds, NULL, NULL, &tv); 

			if(rv == 1){
				memset (recv_data, 0, MAX_STR_SZ);
				bytes_read = recvfrom(sd,recv_data,MAX_STR_SZ,0,
							(struct sockaddr *)&client_addr, (socklen_t*)&addr_len);
				
				recv_data[bytes_read] = '\0';
				
				if (stage == 0) {
					// line not secure we only accept the NB value from client
					memset (&rc4key, 0, sizeof (rc4_key));		// be sure this is clean from previous attempts
					prepare_key(PASSWORD, PASSWD_LEN, &rc4key);	// prepare the rc4 key
					rc4(recv_data, bytes_read, &rc4key);			// decrypt NA using rc4 -> store in NA_rc4
					memcpy (NB, recv_data, rc4_len);			// copy
					memcpy (K, generateSharedKey (NA, NB), MAX_STR_SZ);		// computes the shared key K
					// now send NA to client
					memset (&rc4key, 0, sizeof (rc4_key));		// be sure this is clean from previous attempts
					prepare_key(PASSWORD, PASSWD_LEN, &rc4key);	// prepare the rc4 key
					memcpy(NA_rc4, NA,rc4_len); 				// save it
					rc4(NA_rc4, rc4_len, &rc4key);				// encrypt NA using rc4 -> store in NA_rc4
					/* send */
          			sendto(sd,NA_rc4,rc4_len,0,(struct sockaddr *)&client_addr,sizeof(struct sockaddr));
					stage = 1;									// secure channel is established
				} else {	// secure channel
					memset (&rc4key, 0, sizeof (rc4_key));		// be sure this is clean from previous attempts
					prepare_key(PASSWORD, PASSWD_LEN, &rc4key);	// prepare the rc4 key
					rc4(recv_data, bytes_read, &rc4key);			// decrypt NA using rc4 -> store in NA_rc4
					memset (D, 0, MAX_STR_SZ);
					memcpy (D, recv_data, bytes_read);			// copy
					// validate message a displaye result
					memset (recv_data, 0, MAX_STR_SZ);
					memcpy (recv_data, validateMessage (K, D), MAX_STR_SZ);	
					printf("\nReceived :%s\n",recv_data);
					printf(PROMPT); fflush (stdout);
				}
				
				
			}
			
			if (kbhit()) {
				memset(&send_data, 0, MAX_STR_SZ);
				fgets(send_data, MAX_STR_SZ, stdin); /* read input from the user */

				if (send_data[strlen (send_data)-1] == '\n') send_data[strlen (send_data)-1] = '\0';

          		if ((strncmp(send_data , "exit", 4) == 0) || strncmp(send_data , "EXIT", 4) == 0) {
					printf("Exit received closing...\n");
					break;
				}
				if (stage == 1) {
					int len;
					
					memset(ciphertext, 0, MAX_STR_SZ); 
					memcpy (ciphertext, prepareCiphertext (K, send_data, len), MAX_STR_SZ);
					int bytes_sent = sendto(sd, ciphertext, len, 0,
							(struct sockaddr *)&client_addr, sizeof(struct sockaddr));
					if (bytes_sent != len) {
						printf("transmission error bytes sent :%d correct qty: %d\n",bytes_sent, len);fflush (stdout);
					}
					
				} else {
					printf ("Line not secure\n");
				}
				printf(PROMPT); fflush (stdout);

			}
        }
		return 0;
}

