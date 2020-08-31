#ifndef VECTORN_H
#define VECTORN_H


#include <iostream>
#include <stdexcept> //for throw and catching stuff

/*********************************************************************
   PROGRAM:    CSCI 241 Assignment 5
   PROGRAMMER: Hasnain attarwala
   LOGON ID:   z1697740
   DUE DATE:   03272018

   FUNCTION:   This program tests the functionality of the VectorN
               class.
*********************************************************************/  

using std::cout; using std::cerr; using std::cin; using std::endl;
using std::ostream; using std::out_of_range;
class VectorN
{
	public:
		friend ostream& operator<<(ostream&, const VectorN&);
		
		VectorN(); //The default constructor for the VectorN class takes no arguments and should initialize a new 
		//					VectorN object to an empty vector array with a capacity of 0.
		
		VectorN(const double values[], size_t n); // This constructor for the VectorN class should initialize a new VectorN object to 
												//the values stored in the array values. 
												
		VectorN(const VectorN& other); //	this "copy constructor" for the VectorN class should initialize a new VectorN object 
				//							to the same capacity and array contents as the existing VectorN object other.
		~VectorN() 	;				//destructor, calls clear
		void clear();				//	This method should properly set the instance back to a vector of zero elements. 
		
		size_t size() const;	//Returns the size of the vector, which is equal to the vector capacity.
		
		VectorN& operator=(const VectorN& other);	//This overloaded copy assignment operator should assign one VectorN object 
		//													(the object other) to another (the object that called the method, 
		//													which is pointed to by this)
		VectorN operator+(const VectorN&) const; //	The addition operator should be overloaded to take 
		//														two VectorNs and return a VectorN
		VectorN operator-(const VectorN&) const; //similar to addition
		double operator[](int) const;
		double& operator[](int);
		
		double operator*(const VectorN&) const;
		VectorN operator*(const double&) const;
		friend VectorN operator*(double,const VectorN&);
		bool operator==(const VectorN&) const;
		
		
		double at(int sub) const;
		double& at(int sub);
	
	

	private:
	double* vectorArrayPointer;	//	a pointer to a double. I'll refer to this data member as the vector array pointer. 
	//								It will be used to dynamically allocate an array of double
	size_t vectorCapacity; //	an unsigned integer or size_t variable used to keep track of the number of elements in the vector array. 
	//								I'll refer to this data member as the vector capacity.
	
	
	
		
};

#endif
