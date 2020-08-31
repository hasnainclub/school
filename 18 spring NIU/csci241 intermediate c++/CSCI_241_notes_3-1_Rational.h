#ifndef RATIONAL_H
#define RATIONAL_H

#include <iostream>

using std::cout; using std::cerr; using std::cin; using std::endl;
using std::ostream;

//This is a macro - it is stored differently in memory.
//This PAUSE method can pause during a loop, so that you can see what
//  is happening during that loop.
#define PAUSE cout << "Press enter to continue. "; cin.ignore();

class Rational
  {
  //a function can be a friend of a class! How cute.
  friend ostream& operator<<(ostream&, const Rational&);
//friend class Student; //Doing something like this will make it so
			//Student can access Rational. Not the converse

  public:
    Rational() : n(0), d(1) { }
    Rational(const int& newN, const int& newD) : n(newN), d(newD) 
	{ simplify(); }

    void setN(const int&);
    void setD(const int&);

    //we are returning a fraction, so we want it to return a new object
    Rational add(const Rational&) const;
    Rational subtract(const Rational&) const;
    
    //lets us call print as we usually do, but now we can redirect the 
    //output from to a file;
    void print(ostream& = cout) const;

  private:
    int n; //numerator
    int d; //denomenator

    //OPERATOR OVERLOADS
    Rational operator+(const Rational& alpha) const { return add(alpha);      }
    Rational operator-(const Rational& alpha) const { return subtract(alpha); } 
    Rational(ostream = cout) const;

    void simplify();
    int gcd(int, int) const; //Greatest Common Denominator
  };

#endif
