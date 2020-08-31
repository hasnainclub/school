/*********************************************************************
   PROGRAM:    CSCI 466 Assignment 12
   PROGRAMMER: Hasnain Attarwala
   LOGON ID:   z1697740
   DUE DATE:   oct 7th 2018

******************************************************************/

#include <cstdlib>
#include <iostream>
#include <map>
#include <string>

#include <mysql.h>

using namespace std;

// Utility class for looking up authors I have pre-cached
// into a lookup table by their AuthorNum.
class Author
{
public:
	int AuthorNum;
	string AuthorLast;
	string AuthorFirst;
	
	Author() = default;

	Author(int authorNum, string authorLast, string authorFirst)
	{
		AuthorNum = authorNum;
		AuthorLast = authorLast;
		AuthorFirst = authorFirst;
	}
};

// Utility function for querying and grabbing the result of a mysql query.
// Returns the MYSQL_RES that is returned from a call to mysql_store_result,
// following a call to mysql_query.
MYSQL_RES* queryDatabase(MYSQL* mysql, const char* query)
{
	// Query the database.
	mysql_query(mysql, query);

	// Return the result.
	return mysql_store_result(mysql);
}

// Main routine for the program.
int main()
{
	// Initialize author lookup table.
	map<int, Author> authors;
	
	// Initialize MYSQL
	mysql_library_init(0, nullptr, nullptr);

	// Connect to the database.
	MYSQL* mysql = mysql_init(nullptr);
	mysql_real_connect(mysql, "courses", "z1697740", "1989Aug01", "henrybooks", 0, nullptr, 0);

	// Query authors and add them to the lookup table.
	MYSQL_RES* authorResult = queryDatabase(mysql, "SELECT * FROM Author;");

	while (MYSQL_ROW row = mysql_fetch_row(authorResult))
	{
		int authorId = atoi(row[0]);

		const char* lastName = row[1];
		const char* firstName = row[2];

		Author author(authorId, lastName, firstName);
		authors.emplace(authorId, author);
	}

	// Query books and their authors
	MYSQL_RES* bookResult = queryDatabase(mysql, "SELECT BookCode, Title, Price FROM Book ORDER BY Title;");
	
	printf("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
	printf(  "~ BOOKS IN THE HENRYBOOKS DATABASE ~\n");
	printf(  "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");

	while (MYSQL_ROW row = mysql_fetch_row(bookResult))
	{
		// Write information about the book.
		string bookCode = row[0];
		string bookTitle = row[1];
		double bookPrice = stod(row[2]);
		
		printf("Title: %s\n", bookTitle.c_str());
		printf("Price: $%.2f\n", bookPrice);
		
		// Query the author(s) of the book.
		string query = "SELECT AuthorNum FROM Wrote WHERE BookCode = '" + bookCode + "';";
		MYSQL_RES* wroteResult = queryDatabase(mysql, query.c_str());
		
		int numAuthors = mysql_num_rows(wroteResult);
		printf("%s: ", numAuthors > 1 ? "Authors" : "Author");

		int authorRowId = 0;

		while (MYSQL_ROW getAuthorNum = mysql_fetch_row(wroteResult))
		{
			int authorNum = stoi(getAuthorNum[0]);
			Author author = authors[authorNum];

			// If this is > 0 when we are running through the loop,
			// then it means there were multiple results in the query.
			if (authorRowId > 0)
				printf(", ");

			printf("%s %s", author.AuthorFirst.c_str(), author.AuthorLast.c_str());

			// Increment this in case the loop continues.
			authorRowId++;
		}

		printf("\n\n");
	}

	// Clean up when we are done.
	mysql_library_end();

	return 0;
}
