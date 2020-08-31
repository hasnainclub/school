/***************************************************************
CSCI 240         Program      Fall 2016

Programmer: Hasnain Attarwala

Section: 240 - 2

Date Due: Nov 6th

Purpose: class and methods
***************************************************************/

#include <iostream>
#include <iomanip>
#include <cstdlib>
#include <ctime>
using namespace std;

//Place the class definition after this line

class Rectangle
{
public:
  Rectangle( int , int ); //constructor

  void print();
  
  void setWidth( int );
  void setHeight( int );

  int getWidth();
  int getHeight();
  
  int calcArea();
  
  bool isSquare();
  void draw();
  
private:
  int width, height; 
};




int main()
{

int testNum =1;

cout << "Test " << testNum++ << ": the constructor and print method" << endl;

//Create two objects
Rectangle rec1(0, 0);
Rectangle rec2(12, 5);

//Display the two objects by calling the print method.

cout << endl << "Rectangle 1:" << endl;
rec1.print();

cout << endl << "Rectangle 2:" << endl;
rec2.print();


cout << endl << endl << "Test " << testNum++ << ": the set methods" << endl;

//use valid values to set the width and height of the first Rectangle object
rec1.setWidth(30);
rec1.setHeight(15);

//display the first rectangle
cout << endl << "Rectangle 1:" << endl;
rec1.print();


//use negative values with the second Rectangle object. This should result in
//the use of default values.

rec2.setWidth(-5);
rec2.setHeight(-10);

//display the second rectangle
cout << endl << "Rectangle 2:" << endl;
rec2.print();


//Create a third Rectangle object using values that are too large. This
//should result in the use of default values and make sure that the
//constructor is calling the set methods

Rectangle rec3 = Rectangle(99, 99);

//display the third rectangle
cout << endl << "Rectangle 3:" << endl;
rec3.print();



cout << endl << endl << "Test " << testNum++ << ": the get methods" << endl;

//Call the get methods and display the values for the first and second
//rectangle

cout << endl << "For rectangle 1, the width is " << rec1.getWidth()
     << " and the height is " << rec1.getHeight() << "." << endl;

cout << endl << "For rectangle 2, the width is " << rec2.getWidth()
     << " and the height is " << rec2.getHeight() << "." << endl;
     
//Change the width and height of the third rectangle and then display

rec3.setWidth(5);
rec3.setHeight(5);

cout << endl << "For rectangle 3, the width is " << rec3.getWidth()
     << " and the height is " << rec3.getHeight() << "." << endl;


cout << endl << endl << "Test " << testNum++ << ": the calcArea method" << endl;

//Display the area for all three of the Rectangle objects
cout << endl << "The area of rectangle 1 is " << rec1.calcArea() << endl
     << endl << "The area of rectangle 2 is " << rec2.calcArea() << endl
     << endl << "The area of rectangle 3 is " << rec3.calcArea() << endl;
//GOOD UNTIL NOW

cout << endl << endl << "Test " << testNum++ << ": the isSquare method" << endl;

//Display all three of the Rectangle objects
cout << endl << "Rectangle 1:" << endl;
rec1.print();

cout << endl << "Rectangle 2:" << endl;
rec2.print();

cout << endl << "Rectangle 3:" << endl;
rec3.print();

//Determine if any of the Rectangle objects are square
if( rec1.isSquare() )
  {
  cout << endl << "Rectangle 1 is a square.";
  }
else
  {
  cout << endl << "Rectangle 1 is not a square.";
  }

if( rec2.isSquare() )
  {
  cout << endl << "Rectangle 2 is a square.";
  }
else
  {
  cout << endl << "Rectangle 2 is not a square.";
  }

if( rec3.isSquare() )
  {
  cout << endl << "Rectangle 3 is a square.";
  }
else
  {
  cout << endl << "Rectangle 3 is not a square.";
  }


//The test of the extra credit method is below. Remove the /* and */
//if attempting the extra credit


cout << endl << endl << endl
     << "EXTRA CREDIT Test " << testNum++ << ": the draw method" << endl;

cout << endl << "Rectangle 1:" << endl;
rec1.print();
rec1.draw();

cout << endl << "Rectangle 2:" << endl;
rec2.print();
rec2.draw();

cout << endl << "Rectangle 3:" << endl;
rec3.print();
rec3.draw();


return 0;
system ("pause"); //pausing for debugging
}


//Code the methods below this line
//constructor
Rectangle::Rectangle(int newWidth, int newHeight)
{
 //width = newWidth;
 //height = newHeight;
 
 setWidth(newWidth);
 setHeight(newHeight);
 
}

/*This method displays the rectangle information. It takes no arguments and returns nothing. It should display the information as follows:

Width:   10      Height:    5
assuming that a Rectangle object has a width data member with the value 10 and a height data member with the value 5.
*/

void Rectangle::print()
{
	cout << "Width:   " << width << "      Height:    " << height ;
}


/*
This method changes a Rectangle object's width data member. It takes one argument: an integer that represents the new width for the object. It returns nothing.

If the passed in new width is less than 0 or greater than 40, set the width data member to 15. If the passed in new width is between 0 and 40, inclusive, 
set the width data member to the passed in new width.
*/
void Rectangle::setWidth( int newWidth )
{
	if (newWidth < 0 || newWidth > 40 )
	{
		width = 15 ;
	}
	else
	{
		width = newWidth;
	}
}

/*
This method changes a Rectangle object's height data member. It takes one argument: an integer that represents the new height for the object. It returns nothing.

If the passed in new height is less than 0 or greater than 30, set the height data member to 10. If the passed in new height is between 0 and 30, inclusive, 
set the height data member to the passed in new height.
*/
void Rectangle::setHeight( int newHeight )
{
	if (newHeight < 0 || newHeight > 30 )
	{
		height = 10 ;
	}
	else
	{
		height = newHeight;
	}
}

/*
This method returns a Rectangle object's width. It takes no arguments and returns an integer: the width of the object.
*/
int Rectangle::getWidth()
{
	return width;
}

/*
This method returns a Rectangle object's height. It takes no arguments and returns an integer: the height of the object.
*/
int Rectangle::getHeight()
{
	return height;
}


/*
This method calculates the area of a Rectangle object. It takes no argument. It returns an integer: the calculated area of the rectangle.

The area of a rectangle is the product of multiplying the width of the rectangle by the height of the rectangle.
*/
int Rectangle::calcArea()
{
	int area = width*height;
	return area;
}

/*
This method determines if a Rectangle object is a square. It takes no argument. It returns a boolean value: true if the rectangle is a square or false if the rectangle is not a square.

A rectangle is considered to be a square if width and the height are equal.
*/
bool Rectangle::isSquare()
{
	if (height == width)
	{
		return true;
	}
	else
	{
		return false;
	}
	
}
//extraCredit
/*
This method draws a Rectangle object. It takes no argument and returns nothing.

The rectangle border should be drawn using periods ('.'). The inside of the rectangle should be empty.
*/
void Rectangle::draw()
{
	cout << endl;
	
	// Draw row of 'width' dots for top side
	//call string function, pass howManyTimesIntegear, charType go to next line
    cout << string( width, '.' ) << endl;
    
    // Draw height: width-2 spaces  because width already has a dot on top and bottom which is being double used in first line
    //technically if we want 5 dots, just add 3 because the other two will come from widht's ka dot
    for( int dot = 0; dot < height-2 ; dot++ )
    cout<< '.'<< string(width-2, ' ')<< '.' << endl; //width-2 for formating only, dot's arent as fat as endl
        
	// Draw row of 'width' dots for bottom side
	//call string function, pass howManyTimesIntegear, charType go to next line
    cout << string( width, '.' ) << endl;
}

