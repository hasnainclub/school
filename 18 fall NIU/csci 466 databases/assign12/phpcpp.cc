#include <iostream>
#include <mysql/mysql.h>
#include <iomanip>
#include <string>

using namespace std;

#define SERVER "courses"
#define USER "z1831554"
#define PASSWORD "1992May14"
#define DATABASE "henrybooks"

int main()
{ 
	MYSQL *connection, mysql;

	connection = mysql_init(&mysql);
	connection = mysql_real_connect(connection, SERVER, USER, PASSWORD, DATABASE, 0, NULL, 0);
	if (connection)
		 {    
			 cout << "Connected successfully!" << endl;

			 /*
			 mysql_query(connection, "SELECT Title, Price, BookCode FROM Book;");
			 MYSQL_RES *resultset1;
			 MYSQL_ROW firstrow;
			 while ((firstrow = mysql_fetch_row(resultset1)) != NULL)
			 {  
			//	string statement = 
			//	SELECT Title, Price, AuthorFirst, AuthorLast FROM Author INNER JOIN Wrote ON Author.AuthorNum=Wrote.AuthorNum 
			//	INNER JOIN Book ON Book.BookCode=Wrote.BookCode AND Wrote.BookCode = ";
			//
				string statement = "SELECT AuthorLast, AuthorFirst FROM Book, Wrote, Author WHERE Book.BookCode = Wrote.BookCode AND Wrote.AuthorNum = Author.AuthorNum AND Wrote.BookCode = ";
				statement = statement + "'" + firstrow[2];
				statement = statement + "';";

				mysql_query(connection, statement.c_str());

				MYSQL_RES *resulttwo;
				MYSQL_ROW secondrow;
				
				resulttwo = mysql_store_result(connection);
				while ((secondrow = mysql_fetch_row(resulttwo)) != NULL)
				{ cout << secondrow[0] << "           " << secondrow[1] << "         " << secondrow[2] << "          " << secondrow[3] << endl;  } }

			 


		 }

			 */
			 mysql_query(connection, "SELECT Title, Price, AuthorFirst, AuthorLast FROM Author INNER JOIN Wrote ON Author.AuthorNum=Wrote.AuthorNum INNER JOIN Book ON Book.BookCode=Wrote.BookCode;");

			 //mysql_query(connection, "select Title from Book;");
			 MYSQL_RES *resultset;
			 MYSQL_ROW row;
			 resultset = mysql_store_result(connection);

			 while ((row = mysql_fetch_row(resultset)) != NULL)
                         { 
				 cout << row[0] <<"               "<<row[1]<<"                        "<<row[2]<<"                              "<<row[3]<<endl; 
			 }



		 }
	else
	{ cout << "Error, no connection." << endl; }
/*	
  MYSQL_RES *result;
  MYSQL_ROW row;

int statement = mysql_query(connection, "SELECT Title, Price, AuthorFirst, AuthorLast FROM Author INNER JOIN Wrote ON Author.AuthorNum=Wrote.AuthorNum INNER JOIN Book ON Book.BookCode=Wrote.BookCode");
result = mysql_store_result(connection);
row = mysql_fetch_row(result);

//print results


mysql_free_result(result);
mysql_close(connection);
mysql_library_end(void);
*/
return 0;
}
