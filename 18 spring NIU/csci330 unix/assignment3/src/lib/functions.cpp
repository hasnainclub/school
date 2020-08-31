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
#include <string>
#include <random>
#include <chrono>
#include <ctime>
#include <string>
#include "globals.h"	
#include "sha1.h"
#include "rc4.h"

// Detect if there are some pending input from the keyboard

int kbhit(void)
{
  struct timeval tv;
  fd_set read_fd;

  /* Do not wait at all, not even a microsecond */
  tv.tv_sec=0;
  tv.tv_usec=0;

  /* Must be done first to initialize read_fd */
  FD_ZERO(&read_fd);

  /* Makes select() ask if input is ready:
   * 0 is the file descriptor for stdin    */
  FD_SET(0,&read_fd);
  /* The first parameter is the number of the
   * largest file descriptor to check + 1. */
  if(select(1, &read_fd,NULL, /*No writes*/NULL, /*No exceptions*/&tv) == -1)
    return 0;  /* An error occured */
  /*  read_fd now holds a bit map of files that are
   * readable. We test the entry for the standard
   * input (file 0). */
  
if(FD_ISSET(0,&read_fd))
    /* Character pending on stdin */
    return 1;

  /* no characters were pending */
  return 0;
}

// generate a random 160 bits string
// we use only upper or lower case English letters or numbers between 0-9.
const unsigned char* generateRandomString (void)
{
	std::basic_string<unsigned char> salt = (const unsigned char*)"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
	// the randoim function will generate numbers between 0 and size of the salt string.
	std::uniform_int_distribution<int> uniform_distrib(0, salt.size());
	std::random_device rd;
	std::default_random_engine generator( rd() ); // randomize
	std::basic_string<unsigned char> resultStr;
	int stringSz = 160 / 8; // we need 160 bits, each char has 8 bits, the string size is 20

	for (int i = 0; i < stringSz; i++) {
		resultStr += salt[uniform_distrib(generator)];		
	}
	return resultStr.c_str ();
}

// computes the shared key K
const char* generateSharedKey (unsigned char *NA, unsigned char *NB)
{
	std::basic_string<unsigned char> concatenation;
	static char K[MAX_STR_SZ];

	memset (K, 0, MAX_STR_SZ);
	concatenation = NA;
	concatenation += NB;
	CSHA1 sha1;					// our sha1 processor
	// add the string to the processor
	sha1.Update(concatenation.c_str (), concatenation.size ());
	// calculate the final sha1
	sha1.Final();

	// and get the result
	sha1.ReportHash(K, CSHA1::REPORT_HEX_SHORT);

	return K;
}


// Compute: h = sha1(K||M||K)
char* calculateh (char *K, char *M)
{
	std::basic_string<unsigned char> concatenation;
	static char h[MAX_STR_SZ];

	concatenation = (unsigned char*) K;
	concatenation += (unsigned char*) M;
	concatenation += (unsigned char*) K;

	// clear all the memories. We don't want garbage in it.
	memset (h, 0, MAX_STR_SZ);
	CSHA1 sha1;					// our sha1 processor
	// add the string to the processor
	sha1.Update(concatenation.c_str (), concatenation.size ());
	// calculate the final sha1
	sha1.Final();

	// and get the result
	sha1.ReportHash(h, CSHA1::REPORT_HEX_SHORT);

	return h;
}

// Compute: h = sha1(K||M||K) and C = RC4(M||h)
const unsigned char* prepareCiphertext (char *K, char *M, int& len)
{
	std::string concatenation;
	static unsigned char C[MAX_STR_SZ];
	char *h;
	rc4_key rc4key;		// rc4 key

	h = calculateh (K, M);

	concatenation = M;
	concatenation += h;

	memset(C, 0, MAX_STR_SZ); 
	memcpy (C, concatenation.c_str (), concatenation.size ());
	memset (&rc4key, 0, sizeof (rc4_key));	
	prepare_key(PASSWORD, PASSWD_LEN, &rc4key);			// prepare the rc4 key
	rc4(C, concatenation.size (), &rc4key);				// encrypt NA using rc4 -> store in NA_rc4
	len = concatenation.size ();
	return C;
}

// D=M||h
// This function Compute: h = sha1(K||M||K) and validate h == h'
// we use std::string to do string manipulation
const char* validateMessage (std::string K, std::string D)
{

	if (D.size () <= SHA1_LEN) {
		return "corrupted message";
	}

	// D=M||h => M = remove h from D
	static std::string M;

	M = D.substr (0, D.size () - SHA1_LEN); 	// h is SHA1_LEN bytes because is a sha1 code
	std::string h = D.substr (D.size () - SHA1_LEN, SHA1_LEN); // extract h from D

	std::string h2 = std::string (calculateh ((char*)K.c_str (), (char*)M.c_str ()));
	
	if (h != h2) {
		M = "decryption error";
	}

	return M.c_str ();
}
