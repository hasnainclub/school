#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <netdb.h>
#include <stdio.h>
#include <unistd.h>
#include <errno.h>
#include <string.h>
#include <stdlib.h>
#include "../lib/globals.h"	
#include "../lib/sha1.h"
#include "../lib/rc4.h"

int main()
{
	int sd, bytes_recv,sin_size;
	struct sockaddr_in server_addr;
	struct hostent *host;
	char send_data[MAX_STR_SZ];
	unsigned char recv_data[MAX_STR_SZ];
	// we use "unsigned char" because RC4 require it
	unsigned char NA[MAX_STR_SZ];
	unsigned char NB[MAX_STR_SZ], NB_rc4[MAX_STR_SZ];
	unsigned char ciphertext[MAX_STR_SZ];
	char D[MAX_STR_SZ];
	char K[MAX_STR_SZ]; 
	rc4_key rc4key;		// rc4 key
	int rc4_len = 160/8;

	// we have 2 stages, 0 == comm not secured, 1 ==  secure channel is established.
	int stage = 0;		// flag to indicate in which stage of the comm we are.

	// clear variables
	memset (NB, 0, MAX_STR_SZ);
	memset (NB_rc4, 0, MAX_STR_SZ);
	memset (NA, 0, MAX_STR_SZ);
	memset (K, 0, MAX_STR_SZ);
	memset (ciphertext, 0, MAX_STR_SZ);
	//  choose the 160-bit random string
	memcpy(NB, generateRandomString (),rc4_len); // and copy it in NA
	memcpy(NB_rc4, NB,rc4_len); // save it
	
	// rc4 processing
	memset (&rc4key, 0, sizeof (rc4_key));
	prepare_key(PASSWORD, PASSWD_LEN, &rc4key);	// prepare the rc4 key
	rc4(NB_rc4, rc4_len, &rc4key);				// encrypt NA using rc4 -> store in NA_rc4
		
	// network setup
	host= (struct hostent *) gethostbyname((char *)"127.0.0.1");

	if ((sd = socket(AF_INET, SOCK_DGRAM, 0)) == -1) // 
	{
		perror("socket");
		exit(1);
	}

	server_addr.sin_family = AF_INET;
	server_addr.sin_port = htons(SIN_PORT);
	server_addr.sin_addr = *((struct in_addr *)host->h_addr);
	bzero(&(server_addr.sin_zero),8);
	sin_size = sizeof(struct sockaddr);
	
	// make it asynchronous
	fd_set readfds;
	struct timeval tv;
	tv.tv_sec = 0;
	tv.tv_usec = 0;

	// send the NB string to the server
	
	sendto(sd, NB_rc4, rc4_len, 0,
						(struct sockaddr *)&server_addr, sizeof(struct sockaddr));
			
	printf(PROMPT); fflush (stdout);
	while (1) {
		if (kbhit()) {
			memset(&send_data, 0, MAX_STR_SZ);
			fgets(send_data, MAX_STR_SZ, stdin); /* read input from the user */
			if (send_data[strlen (send_data)-1] == '\n') send_data[strlen (send_data)-1] = '\0';
			
			if ((strncmp(send_data , "exit", 4) == 0) || strncmp(send_data , "EXIT", 4) == 0) {
					printf("Exit received closing...\n");
					break;
			} else {
				if (stage == 1) {
					int len;
					memset(ciphertext, 0, MAX_STR_SZ); 
					memcpy (ciphertext, prepareCiphertext (K, send_data, len), MAX_STR_SZ);
					sendto(sd, ciphertext, len, 0,
							(struct sockaddr *)&server_addr, sizeof(struct sockaddr));
				} else {
					printf ("Line not secure\n");
				}
				printf(PROMPT); fflush (stdout);
			}
		}
		FD_ZERO(&readfds);
		FD_SET(sd, &readfds);
		int rv = select(sd + 1, &readfds, NULL, NULL, &tv); 

		if(rv == 1){
			memset (recv_data, 0, MAX_STR_SZ);
			bytes_recv = recvfrom(sd,recv_data,MAX_STR_SZ,0,(struct sockaddr *)&server_addr, (socklen_t*) &sin_size);
			recv_data[bytes_recv]= '\0';
		
			if (stage == 0) {
				// line not secure we only accept the NA value from server
				memset (&rc4key, 0, sizeof (rc4_key));		// be sure this is clean from previous attempts
				prepare_key(PASSWORD, PASSWD_LEN, &rc4key);	// prepare the rc4 key
				rc4(recv_data, bytes_recv, &rc4key);			// decrypt NA using rc4 -> store in NA_rc4
				memcpy (NA, recv_data, rc4_len);			// copy
				memcpy (K, generateSharedKey (NA, NB), MAX_STR_SZ);		// computes the shared key K
				stage = 1;									// secure channel is established
			} else {	// secure channel
				memset (D, 0, MAX_STR_SZ);
				memcpy (D, recv_data, bytes_recv);				// copy

				memset (&rc4key, 0, sizeof (rc4_key));		// be sure this is clean from previous attempts
				prepare_key(PASSWORD, PASSWD_LEN, &rc4key);	// prepare the rc4 key
				rc4((unsigned char *)D, bytes_recv, &rc4key);			// decrypt NA using rc4 -> store in NA_rc4
				

				// validate message and display result
				memset (recv_data, 0, MAX_STR_SZ);
				memcpy (recv_data, validateMessage (K, D), MAX_STR_SZ);
				
				printf("\nReceived :(%s)\n",recv_data);fflush (stdout);	
			}
			
			printf(PROMPT); fflush (stdout);
		}
	}

}

