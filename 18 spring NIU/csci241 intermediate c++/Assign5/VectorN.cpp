#include "VectorN.h"
/*********************************************************************
   PROGRAM:    CSCI 241 Assignment 5
   PROGRAMMER: Hasnain attarwala
   LOGON ID:   z1697740
   DUE DATE:   03272018

   FUNCTION:   This program tests the functionality of the VectorN
               class.
*********************************************************************/  

ostream& operator<<(ostream& output, const VectorN& objectName)
  {
  	if (objectName.vectorCapacity==0)
  	{
  		output << "()" ;
  		return output;
	  }
	  
	  output << "(";
	  
  for (unsigned int i =0; i < objectName.vectorCapacity; i++)
  {
	output << objectName.vectorArrayPointer[i];
	if(i!= objectName.vectorCapacity-1 ) //otherwise that last comma comes, but we want last number, not comma after that
	{
		output << ", ";
	}
  }
  output << ")";
  
  return output; 
  }
  
  
/* The default constructor for the VectorN class takes no arguments and should initialize a new VectorN object to an 
empty vector array with a capacity of 0. The required logic is:

Set the vector capacity for the new object to 0.
Set the vector array pointer for the new object to the special value nullptr.
*/
VectorN::VectorN()
{
	vectorCapacity = 0;
	vectorArrayPointer = NULL;		//technically can set it to 0, but bad synthetic programming habit to do so
//	vectorArrayPointer = new double{NULL};
}
/*
This constructor for the VectorN class should initialize a new VectorN object to the values stored in the array values. 
The required logic is:

Set the vector capacity for the new object to n.
If the vector capacity is 0, set the vector array pointer for the new object to nullptr. 
Otherwise, use the vector array pointer for the new object to allocate an array of double. 
The number of elements in the new string array should be equal to the vector capacity.
Copy the elements of the array values into the vector array.
*/

VectorN::VectorN(const double values[], size_t n)
{
	vectorCapacity = n;
	if (vectorCapacity==0)
	{
		vectorArrayPointer = NULL;
	}
	else 
	{
		vectorArrayPointer = new double [vectorCapacity];
		//cout << "why three values?";
		for (unsigned int i = 0; i < vectorCapacity; i++)
		{
			vectorArrayPointer[i] = values[i];
		}
	}
}
/*

This "copy constructor" for the VectorN class should initialize a new VectorN object to the same capacity and array contents as 
the existing VectorN object other. The required logic is:

Set the vector capacity for the new object to the vector capacity of other.
If the vector capacity is 0, set the vector array pointer for the new object to nullptr. \

Otherwise, use the vector array pointer for the new object to allocate an array of double. 
The number of elements in the new vector array should be equal to the vector capacity.

Copy the contents of the vector array of other into the vector array of the new object. If other has a vector capacity of 0, 
this loop will exit immediately.
*/
VectorN::VectorN(const VectorN& other)
{
	/*	if (this == &other) //step1 
	{
		return *this;
	} */
	
	//step2
//	delete [] vectorArrayPointer;
	
	//step 3
	vectorCapacity = other.vectorCapacity;
	//step 4
	if (vectorCapacity == 0)
	{
		vectorArrayPointer = NULL;
	}
	else
	{
		vectorArrayPointer = new double [other.vectorCapacity];
	}
	//step 5
	for (unsigned i = 0; i < vectorCapacity; i++)
	{
		vectorArrayPointer[i] = other.vectorArrayPointer[i];
	}
	
	//step 6
   //  return *this;
}

//
//The destructor for the VectorN class can simply call the clear() method described below.
VectorN::~VectorN()
{
	clear ();
}

/*
This method should properly set the instance back to a vector of zero elements. 
Delete the vector array, set the vector array pointer to nullptr, and set the vector capacity to 0.

*/
void VectorN::clear()
{ 
	if (vectorArrayPointer!= NULL)	//	can seg fault, it if it's already null.
	{
		delete [] vectorArrayPointer;
	}
	
	vectorArrayPointer = NULL;
	vectorCapacity = 0;
}


//Returns the size of the vector, which is equal to the vector capacity.
size_t VectorN::size() const
{
	return vectorCapacity; //returns the size
}

/*

This overloaded copy assignment operator should assign one VectorN object (the object other) to another 
(the object that called the method, which is pointed to by this). The required logic is:

1.	Check for self-assignment. If the address stored in the pointer this is the same as the address of the object other, 
then skip to the final step.
2. 	Delete the vector array for the object pointed to by this.
3. 	Set the vector capacity for the object pointed to by this to the vector capacity of other.
4.	If the vector capacity is 0, set the vector array pointer for the object pointed to by this to nullptr. 
Otherwise, use the vector array pointer to allocate an array of double. The number of elements in the new vector array should be equal 
to the vector capacity.
5. Copy the contents of the vector array of other into the vector array of the object pointed to by this.
6.	Return *this.
*/

VectorN& VectorN::operator=(const VectorN& other) //if follows data type, it means refernce, or address in step 1
{
//	cout << *this << endl << endl << endl;
//	cout << other  << endl << endl << endl;
//	cout << "what f dj";

	if (this == &other) //step1 
	{
		return *this;
	} 
	
	//step2
	clear(); //delete [] vectorArrayPointer; better to do this, because using same code
	
	//step 3
	vectorCapacity = other.vectorCapacity;
	//step 4
	if (vectorCapacity > 0)
	
	//	vectorArrayPointer = NULL;
	{
		vectorArrayPointer = new double [other.vectorCapacity];

	//step 5
		for (unsigned i = 0; i < vectorCapacity; i++)
		{
		vectorArrayPointer[i] = other.vectorArrayPointer[i];
		}
	}
	
	//step 6
     return *this;
}

/*
operator+

The addition operator should be overloaded to take two VectorNs and return a VectorN. 
The components of the result are computed by simply adding the components of the operands. For example (1, 2, 3) + (4, 5, 6)
 should have a result of (5, 7, 9). The operands should not be altered.

If the two operands are of different capacities, then only the first n components of each vector should be used in the product 
where n is the capacity of the smaller of the two vectors. For example, (1, 2, 3) + (4, 5) should have a result of (5, 7).

Implementation Hint: In any of the arithmetic operators, if you use a local VectorN variable to hold the result result, 
it may be necessary to first create an empty VectorN and then directly manipulate the vector array pointer and capacity to allocate 
memory for the vector array.
*/
VectorN VectorN::operator+(const VectorN& rhsObject) const
{
	VectorN returnObject; 
	
	if (rhsObject.vectorCapacity < vectorCapacity)
	{
		returnObject.vectorArrayPointer = new double [rhsObject.vectorCapacity];
		returnObject.vectorCapacity = rhsObject.vectorCapacity;
	}
	else
	{
		returnObject.vectorArrayPointer = new double [vectorCapacity];
		returnObject.vectorCapacity = vectorCapacity;
	}
	
	for (unsigned i = 0; i < returnObject.vectorCapacity; i++)
	{
		returnObject.vectorArrayPointer[i]=vectorArrayPointer[i] + rhsObject.vectorArrayPointer[i];
	}
	

	return returnObject;
}
/*
The binary subtraction operator should also be overloaded to take two VectorNs and return a VectorN. 
The result is the component-wise difference of the operands. For example (1, 2, 3) - (4, 6, 8) should have a result of (-3, -4, -5). 
As with addition, the result should have the capacity of the smaller operand.
*/
VectorN VectorN::operator-(const VectorN& rhsObject) const
{
	VectorN returnObject; 
	if (rhsObject.vectorCapacity < vectorCapacity)
	{
		returnObject.vectorArrayPointer = new double [rhsObject.vectorCapacity];
		returnObject.vectorCapacity = rhsObject.vectorCapacity;
	}
	else
	{
		returnObject.vectorArrayPointer = new double [vectorCapacity];
		returnObject.vectorCapacity = vectorCapacity;
	}
	for (unsigned i = 0; i < returnObject.vectorCapacity; i++)
	{
		returnObject.vectorArrayPointer[i]=vectorArrayPointer[i] - rhsObject.vectorArrayPointer[i];
	}

	return returnObject;
}

/*
The subscript operator should be overloaded to provide accessor methods for the class. The provided subscript indicates which value 
should be accessed from the dynamically-allocated array. For speed, no error checking needs to be done.

Don't forget that this operator needs to be overloaded twice, once for getting a value and once for setting a value.
*/
double VectorN::operator[](int index) const //const for reading
{
	return vectorArrayPointer[index];
}

double& VectorN::operator[](int index)  //no const for setting
{

	return vectorArrayPointer[index];
}


/*****************************************/

double VectorN::operator*(const VectorN& rhsObject) const
{
	VectorN returnObject;
	double sum = 0;
	
	if (rhsObject.vectorCapacity < vectorCapacity)
	{
		returnObject.vectorArrayPointer = new double [rhsObject.vectorCapacity];
		returnObject.vectorCapacity = rhsObject.vectorCapacity;
	}
	else
	{
		returnObject.vectorArrayPointer = new double [vectorCapacity];
		returnObject.vectorCapacity = vectorCapacity;
	}
	
	for (unsigned i = 0; i < returnObject.vectorCapacity; i++)
	{
		returnObject.vectorArrayPointer[i]=vectorArrayPointer[i] * rhsObject.vectorArrayPointer[i];
		sum += returnObject[i];	
	}

	return sum;
}


//one to handle multiplication of the vector by the constant in that order,
VectorN VectorN::operator*(const double& rhsVar) const
{
	VectorN returnObject (*this);	//	calls copy constructor without *this, uses default constructor
	
	
	for (unsigned i = 0; i < returnObject.vectorCapacity; i++)
	{
		returnObject.vectorArrayPointer[i] =vectorArrayPointer[i] * rhsVar;
	}
	
	
	returnObject.vectorCapacity=vectorCapacity;
	
	return returnObject;
}

//two to handle multiplication of the constant by the vector in that order. 

//return vector 3 object 
//friend function noneed for :: nonsense

VectorN operator*(double lhsVar,const VectorN& rhsObject) 
{
	return rhsObject*lhsVar;
//	double lhsVar = (*this); 
/*
	VectorN returnObject= rhsObject; //means returnObject will be of vector3class
//	cout << endl << endl << endl << lhsVar  << endl << endl << endl;//test
//	cout << endl << endl << endl << rhsObject  << endl << endl << endl;
	if (rhsObject.vectorCapacity < vectorCapacity)
	{
		returnObject.vectorArrayPointer = new double [rhsObject.vectorCapacity];
		returnObject.vectorCapacity = rhsObject.vectorCapacity;
	}
	else
	{
		returnObject.vectorArrayPointer = new double [vectorCapacity];
		returnObject.vectorCapacity = vectorCapacity;
	}

	
	for (unsigned i = 0; i < rhsObject.vectorCapacity; i++)
	{
		returnObject.vectorArrayPointer[i] = lhsVar * rhsObject.vectorArrayPointer[i];
	}
	
	returnObject.vectorCapacity = rhsObject.vectorCapacity;
	return returnObject; */
}

/*
The equality operator should be overloaded to compare two VectorNs. The two vectors are considered equal only if they are 
componentwise equal. For example, (1, 2, 3) is equal to (1, 2, 3), but not to (4, 3, 2). All components must be equal. 
If the operands have different capacities, then the vectors are automatically not equal, regardless of the component values.
*/
bool VectorN::operator==(const VectorN& rhsObject) const
{
	bool returnVal = true;
	
	if (rhsObject.vectorCapacity != vectorCapacity)
	{
		returnVal = false;
		return returnVal; //end here, no need to check for rest
	}
	
	//since we know vectorCapacity of both are same, no need to do ||
	for (unsigned i = 0; i < rhsObject.vectorCapacity; i++)
	{
		if(vectorArrayPointer[i] != rhsObject.vectorArrayPointer[i])
		{
			returnVal = false;
			break;		//good idea to break loop if values are different, why waste time?
		}
	}
	

	return returnVal;
}

/*

This method is a variant of the read form of operator[] that provides some error checking.

If sub is less than 0 or greater than or equal to the capacity of the vector array, this method should throw an out_of_range exception, 
like so:

   throw out_of_range("subscript out of range");
Otherwise, the method should return element sub of the vector array.

To make use of the existing standard exception class out_of_range, you will need to #include <stdexcept>; and code a using declaration 
for the class name. If you're confused about how to do this, take a look at the driver program.

*/
double VectorN::at(int sub) const
{
	if (sub < 0 || sub >= vectorCapacity)
	{
		throw out_of_range ("subscript out of range");
	}
	return vectorArrayPointer[sub];
}
/*

This method is a variant of the write form of operator[] that provides some error checking.

If sub is less than 0 or greater than or equal to the capacity of the vector array, this method should throw an out_of_range exception. 
Otherwise, it should return element sub of the vector array.
*/
double& VectorN::at(int sub)
{
	if (sub<0 || sub >= vectorCapacity)
	{
	//	cout <<  "woof woof;";
		throw out_of_range ("subscript out of range"); 
		
	}
	else
	{
		return vectorArrayPointer[sub];
	}

}
