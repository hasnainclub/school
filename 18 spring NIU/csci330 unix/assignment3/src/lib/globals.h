#if !defined(_GLOBALS_H_)
#define _GLOBALS_H_

#include <string>

// globals.h

// common definitions
#define SIN_PORT	5000
#define MAX_STR_SZ	1024
#define PROMPT "Your message (or exit):"
#define PASSWORD (unsigned char*) "c450D1"
#define PASSWD_LEN	6
#define SHA1_LEN	40

/* Prototypes */
int kbhit();
const unsigned char* generateRandomString (void);						// the random 160 bits string				
const char* generateSharedKey (unsigned char *NA, unsigned char *NB);	// computes the shared key K
const unsigned char* prepareCiphertext (char *K, char *M, int& len);	// computer the ciphertext
char* calculateh (char *K, char *M);
const char* validateMessage (std::string K, std::string D);
#endif
