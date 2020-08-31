#ifndef VECTOR3_H
#define VECTOR3_H

#include <iostream>

using std::cout; using std::cerr; using std::cin; using std::endl;
using std::ostream;

class Vector3
{
	public: 
	 friend ostream& operator<<(ostream&, const Vector3&); //ask professor like whats ostream& and why's it defined twice
	 														//why pass by reference the objectName because arent objects always passed
	 														//by reference anyways? becasuse it'ss passed by copy/vaolue
	/*
	Constructor
	The class should have one constructor that takes three arguments which should set the x, y, and z vector components in that order. 
	There should be only one constructor. Default argument values of 0.0 should be used for this constructor. 
	Implementations with more than one constructor will be penalized. */
	
	//Vector3() : x(0), y(0), z(0) {x=NeX so fought so on}  // will have to delete this somehow!
	//if no argument given to first parameter, it becomes 0 so fought and so on
	Vector3(const double& = 0, const double& = 0,  const double& = 0); //: x(0), y(0), z(0) { } //setting constructor in 
											//fancy way! don't forget to declare the data members
									//will have to do something like, if no values are passed, then dataMember = 0
	//headers for setmethods
	void setX(const double&);
    void setY(const double&);
    void setZ(const double&);
    
    /*The addition operator should be overloaded to take two Vector3s and return a Vector3. */
	//returns a vector3 object, because overloading function, we have to use keywoard operator, right after what operator we want to over
	//load it with. then passing datatype vector3 in this
	//Vector3 operator+(const Vector3&, const Vector3&);
    Vector3 operator+(const Vector3&) const;
    Vector3 operator-(const Vector3&) const;
    
    /*
    
    
    The binary multiplication operator should be overloaded three times. 
	The first form, called the scalar product takes two Vector3s and produces a single floating point value. 
	The scalar product is computed by multiplying the corresponding components of the two vectors and adding the results.
	 For example the scalar product of (1, 2, 3) and (4, 5, 6) is (1 · 4) + (2 · 5) + (3 · 6) which equals 4 + 10 + 18 
	 which gives a final result of 32. */	
	float operator*(const Vector3&) const;  //nned this

	 /*
	The other two overloaded multiplication operators allow multiplication of a Vector3 with a floating point constant. 
	For example, multiplying the vector (1, 2, 3) by 3 wresults in the vector (3, 6, 9). 
	
	Two overloaded operators are needed here, one to handle multiplication of the vector by the constant in that order, */
	Vector3 operator*(const float&) const; //need this
	
	/*
	the other to handle multiplication of the constant by the vector in that order. The results should be the same in both cases. 
	As with other arithmetic operators, the operands should not be altered. */
	friend Vector3 operator*(float,const Vector3&) ;
	//since the compiler was getting confused which method to call since we have to operator* with same arguments, i made this monkey
	//into a friend, so the compiler will know that, oh we are doing multiplication with a constant(float), and that's why we need two 
	//arguments, first argument is lhs

/*
The indexing operator should be overloaded to provide accessor methods for the class. Subscript 0 should provide access to the 
x component value of the vector; subscript 1 to the y component and subscript 2 to the z component. 
Subscript values other than 0, 1, or 2 produce undefined results. For speed, no error checking needs to be done.

The choice of how the data members are implemented in the class could greatly affect the complexity of overloading this particular 
operator.

Don't forget that this operator needs to be overloaded twice, once for getting a value and once for setting a value.
*/
	double operator[](int) const; //const for reading  //ask prof, why we need two, why not do one???
	double& operator[](int); //reference for writing
	
/*	The equality operator should be overloaded to compare two Vector3s. The two vectors are considered equal only if they are 
componentwise equal. For example, (1, 2, 3) is equal to (1, 2, 3), but not to (4, 3, 2) or to (3, 2, 1). All components must be equal. 
The operands should not be altered. */

	bool operator==(const Vector3&) const;
	
//	void print(ostream& = cout) const;
	private:
		double x, y, z;
};

#endif
