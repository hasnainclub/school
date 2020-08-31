#include "Vector3.h"
//include the header file, and all it's namespace and #includes will be added

#include <iostream>
Vector3::Vector3(const double& newX, const double& newY,  const double& newZ)
{
//	if (newX < 0 || newX > 0)
		setX(newX);
//	else x = 0;
	
//	if (newY < 0 || newY > 0)
		setY(newY);
//	else x = 0;
	
//	if (newZ < 0 || newZ > 0)
		setZ(newZ);
//	else x = 0;
}


/*
The stream insertion operator should be overloaded so that a Vector3 can be sent to the standard output. 
should be like (0, 0, 0)
*/
ostream& operator<<(ostream& output, const Vector3& objectName)
  {
  //This is a standalone function, so it cannot call these 
  //private attributes.
  //Which is why we made a friend
//output << "( " << alpha.n << " / " << alpha.d << " )";

	//why output? is that a special name? can give anything i want to in first argument
	output << "("<< objectName.x << ", " << objectName.y << ", " << objectName.z << ")" ;

//then why return output? so we can chain modification streams, so first print someting then print something
  return output;
  }


/*  dont really need this puppy unless, doing something weird like what he did in rational class, but dont fully get the output thing
//better to leave this puppy alone, later play with it. 
void Vector3::print(ostream& output) const  //don't need the '= cout' here
  {
  //output is a more generic stream, when compared to cout. should be like (0, 0, 0)
  output << "("<< x << ", " << y << ", " << s << ")";
  } */

//set methods, just sets the datamember to whatever value we pass it with. 
void Vector3::setX(const double& newX)
  {
  x = newX;
  }

void Vector3::setY(const double& newY)
  {
  y = newY;

  }
  
void Vector3::setZ(const double& newZ)
  {
  z = newZ;
  }
  
Vector3 Vector3::operator+(const Vector3& rhsObject) const
{
	Vector3 returnObject; //Ask prof is correct, becasue our default const makes the data members to 0 of that object, we can just
	//set an empty object and xyz will be set to 0.  then we can either += or =
	/*
	returnObject.x = object1.x + object2.x;
	returnObject.y = object1.x + object2.y;
	returnObject.z = object1.x + object2.z; */
	
	returnObject.x += (x + rhsObject.x);
	returnObject.y += (y + rhsObject.y);
	returnObject.z += (z + rhsObject.z);
	
	return returnObject;
}

Vector3 Vector3::operator-(const Vector3& rhsObject) const
{
	Vector3 returnObject;
	returnObject.x += (x - rhsObject.x);
	returnObject.y += (y - rhsObject.y);
	returnObject.z += (z - rhsObject.z);
	
	//if we don't return, then it shows addresses, pretty cool ask prof! shoulndt really compile
	
	return returnObject;
}

   /*
    The binary multiplication operator should be overloaded three times. 
	The first form, called the scalar product takes two Vector3s and produces a single floating point value. 
	The scalar product is computed by multiplying the corresponding components of the two vectors and adding the results.
	 For example the scalar product of (1, 2, 3) and (4, 5, 6) is (1 · 4) + (2 · 5) + (3 · 6) which equals 4 + 10 + 18 
	 which gives a final result of 32.

	As with other arithmetic operators, the operands should not be altered. */
	
float Vector3::operator*(const Vector3& rhsObject) const
{
	Vector3 returnObject;
	float sum;
	returnObject.x = (x * rhsObject.x);	
	returnObject.y = (y * rhsObject.y);
	returnObject.z = (z * rhsObject.z);
	
	sum = (returnObject.x + returnObject.y + returnObject.z);	
	return sum;
}

/*  that friend stuff
double Vector3::operator*(const double&, const Vector3&)
{
	return double 2.4;
}

{
	Vector3 returnObject;
	float sum;
	returnObject.x = (x * rhsObject.x);	
	returnObject.y = (y * rhsObject.y);
	returnObject.z = (z * rhsObject.z);
	
	sum = (returnObject.x + returnObject.y + returnObject.z);	
	return sum;
} */

//one to handle multiplication of the vector by the constant in that order,
Vector3 Vector3::operator*(const float& rhsVar) const
{
	Vector3 returnObject;
	
	returnObject.x += (x * rhsVar);
	returnObject.y += (y * rhsVar);
	returnObject.z += (z * rhsVar);
	
	return returnObject;
}

//two to handle multiplication of the constant by the vector in that order. 

//return vector 3 object 
//friend function noneed for :: nonsense

Vector3 operator*(float lhsVar,const Vector3& rhsObject) 
{
//	double lhsVar = (*this);
	Vector3 returnObject= rhsObject; //means returnObject will be of vector3class
//	cout << endl << endl << endl << lhsVar  << endl << endl << endl;//test
//	cout << endl << endl << endl << rhsObject  << endl << endl << endl;
	
	
	returnObject.x = (lhsVar * rhsObject.x);	
	returnObject.y = (lhsVar * rhsObject.y);
	returnObject.z = (lhsVar * rhsObject.z);
	
	return returnObject; 
} 

double Vector3::operator[](int index) const //const for reading
{
	if (index == 0)
	{
		return x;
	}
	else if (index == 1)
	{
		return y;
	}
	else if (index == 2)
	{
		return z;
	}
}
double& Vector3::operator[](int index)  //ask prof, whats going on with double&  bhavana put it up there...
{
//	cout << endl << endl << endl << index << endl << endl;
	
//	cout << endl << endl << endl << x << endl << endl;
	if (index == 0)
	{
		return x;
	}
	else if (index == 1)
	{
		return y;
	}
	else if (index == 2)
	{
		return z;
	}
}

bool Vector3::operator==(const Vector3& rhsObject) const
{
	if (x== rhsObject.x && y == rhsObject.y && z == rhsObject.z)
	{
		return true;
	}
	
return false;
}
