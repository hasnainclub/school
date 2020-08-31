#ifndef QUEUE_H
#define QUEUE_H

#include <iostream>
//#include <fstream>
#include <stdexcept>

using namespace std;

//#define nullptr NULL

//*****************************************************************
// FILE:      Queue.h
//   PROGRAMMER: Hasnain Attarwala
 //  LOGON ID:   z1697740
//   DUE DATE:   april 18 2018
//
// PURPOSE:   Declaration for the template Queue Class
//
//*****************************************************************/

/*
struct Node
Data members

This template structure should have two data members: a member of the template parameter type to store an item to be inserted into 
the queue, and a pointer to a Node. The pointer next will point to the next node in the linked list (or be nullptr if this is the 
last node in the list).

Since the Queue class will need access to these data members, make them public (the default for a struct).
*/
template <class T>
struct Node //is like a class, but assignment wants us to use this
{
	public: //default is public this is reduntandt
		Node<T>* next;
		T data;
		Node(const T& = T(), Node<T>* next = nullptr);
};
/*
Constructor
The structure should have one constructor that takes an argument of the template parameter type. Make this argument a reference to 
const data. The constructor should copy the argument into the queue node and set the node's pointer to nullptr.
*/
template <class T>
Node<T>::Node(const T& newData, Node<T>* newNext)
{
	data = newData;
	next = newNext;
}



/*
class Queue
Data members

This class should have three data members. The first two are pointers to Nodes. 
The pointer qFront will point to the front node in the queue (or be nullptr if the queue is empty); 
the pointer qBack will point to the back or rear node in the queue (or be nullptr if the queue is empty). 
The third data member is used to keep track of the number of data items currently stored in the vector (the queue size). 
This data member should be declared as data type size_t (which corresponds to an unsigned integer).
*/

// Forward declaration of the Queue template class
template <class T>
class Queue;
// Forward declaration of the operator<< template function
template <class T>
std::ostream& operator<<(std::ostream&, const Queue<T>&);

/*
This class should have three data members. The first two are pointers to Nodes
*/
template <class T>
class Queue
{


// friend declaration for the template function - note the
// special syntax
   friend std::ostream& operator<< <>(std::ostream&, const Queue<T>&);

private:
//	The pointer qFront will point to the front node in the queue (or be nullptr if the queue is empty);
	Node<T>* qFront;
	
//the pointer qBack will point to the back or rear node in the queue (or be nullptr if the queue is empty).
	Node<T>* qBack;
	
//The third data member is used to keep track of the number of data items currently stored in the vector (the queue size). 
//This data member should be declared as data type size_t (which corresponds to an unsigned integer).
	size_t qSize;
	
public:
	Queue(); //const
	~Queue(); //dest
	void clear(); 
	size_t size() const {return qSize;}  // returns size!
	bool empty() const;
	const T& front() const;
	const T& back() const;
	void push(const T& );
	void pop() ;
	Queue(const Queue<T>& ); // copy cat constructor!
	void copyList(const Queue<T>& );
};
/*
constructor
The class should have a default constructor that takes no arguments. 
The constructor should set both pointer data members to nullptr and the queue size to 0. */
template <class T>
Queue<T>::Queue()
{
	qFront = qBack = nullptr;
	qSize = 0;
}

//Destructor
//The class should have a destructor. The destructor can simply call the clear() method described below.
template <class T>
Queue<T>::~Queue()
{
	clear();
}

/*
This method takes no arguments and returns nothing. It should properly set the queue back to the empty state. 
That means deleting all of the nodes in the queue, setting the front and back pointers back to nullptr, and setting the queue 
size back to 0.
*/
template <class T>
void Queue<T>::clear() 
{
	qFront=nullptr;
	qBack=nullptr;
	qSize = 0;

}

/*
Returns true if there are no data items currently stored in the queue; otherwise returns false.
*/
template <class T>
bool Queue<T>::empty() const
{

	if (qSize == 0)
		return true;
	else
		return false;

}

/*
front()

This method takes no arguments and returns a reference to a constant item of the template parameter type. 
If the queue is empty, this method should throw an underflow_error exception. Otherwise, it should return the data stored in the
 front node of the queue.
*/
template <class T>
const T& Queue<T>::front() const 
{
if (empty())

   throw std::underflow_error("underflow error.");
   return qFront->data;
}

//samething as front but back
template <class T>
const T& Queue<T>::back() const 
{
if (empty())

   throw std::underflow_error("underflow error.");
   return qBack->data;
}


/*
This method takes a reference to a constant item of the template parameter type as its argument (the item to insert into the queue). 
It returns nothing. The method should insert the item at the back of the queue and increment the queue size.
*/
template <class T>
void Queue<T>::push(const T& val)
{
	Node<T>* newNode = new Node<T>(val);

	if (qFront == nullptr)
	{
		 qFront = newNode; //nullptr or NULL dont know which one, but program crashes (seg fault!)
	}
	
	else
	{
		qBack->next = newNode;
	}
  
	qBack = newNode;

++qSize; 
}

//the printing fnction
template <class T>
std::ostream& operator<<(std::ostream& lhs, const Queue<T>& rhs)
{
	Node<T>* ptr;
	
	for (ptr=rhs.qFront; ptr!=nullptr; ptr=ptr->next)
	{   
		lhs << ptr->data << ' ';
	}	
return lhs;
}

/*
This method takes no arguments and returns nothing. If the queue is empty, this method should throw an underflow_error exception. 
Otherwise, it should remove the item at the front of the queue and decrement the queue size.
*/
template <class T>
void Queue<T>::pop() 
{

	bool test = empty();
	if (test == true) 
	{//can really do if (empty()) but ... it!
		throw underflow_error("queue underflow error on pop()");
	}

	// Remove first node in list
	Node<T>* delNode = qFront;
	qFront = qFront->next;
	
	// If queue is now empty, make sure both pointers are nullptr
	if (qFront == nullptr)
	{
		qBack = nullptr;
	}
	  
	delete delNode;
	--qSize;	
	
}


/*
The class should also have a proper copy constructor. If you choose to make a copy of the linked list by using the push() method, 
make sure you set both the front and back pointers for the new queue to nullptr and the queue size to 0 before you attempt to insert
 any nodes into it.
*/
template <class T>

Queue<T>::Queue(const Queue<T>& other)
{
   qFront = qBack = nullptr;
   qSize = 0;
   copyList(other);
} 


template <class T>

void Queue<T>::copyList(const Queue<T>& other)
{
	Node<T>* ptr;
   for (ptr = other.qFront; ptr != nullptr; ptr = ptr->next)
	{
		push(ptr->data);
	}

}
#endif 
//assignment6 to use as reference, delete this later
/*
template <class T>
class Queue;

template <class T>
std::ostream& operator<< (std::ostream&, const Queue<T>&);

template <class T>
class Queue
{
	friend std::ostream& operator<< <>(std::ostream&, const Queue<T>&);

private:

	T* queueArray;
	size_t queueSize, queueCapacity;
	int queueFrontSub, queueBackSub;

public:

	Queue();
	Queue(const Queue<T>&);
	~Queue();
	Queue<T>& operator=(const Queue<T>&);
	void clear();
	size_t size() const;
	size_t capacity() const;
	bool empty() const;
	const T& front() const;
	const T& back() const;
	void push(const T& val);
	void pop();
	void reserve(size_t n);
};


// Queue Constructor
/***************************************************************
Queue::Queue()
Use: set the queue size to and queue capacity to 0 and queue array pointer
to nullptr
Parameters: nothing
Returns: nothing
***************************************************************/
/*
template <class T>
Queue<T>::Queue()
{
	queueCapacity = 0;
	queueSize = 0;
	queueArray = nullptr;
	queueFrontSub = 0;
	queueBackSub = queueCapacity - 1;

}

// Queue Destructor
/***************************************************************
Queue::~Queue()
Use: deletes the dynamic memory for the Queue array
Parameters: nothing
Returns: nothing
***************************************************************/
/*
template <class T>
Queue<T>::~Queue()
{
	delete[] queueArray;
}

// Queue Copy Constructor
/***************************************************************
Queue::Queue()
Use: copies queue
Parameters: other queue
Returns: nothing
***************************************************************/
/*
template <class T>
Queue<T>::Queue(const Queue& other) {

	queueCapacity = other.queueCapacity;
	queueSize = other.queueSize;
        queueFrontSub = other.queueFrontSub;
	queueBackSub = other.queueBackSub;

	if (queueSize == 0) {
		queueArray = nullptr;
	}
	else
		queueArray = new int[queueCapacity];

	for (size_t i = 0; i < queueCapacity - 1; ++i)
		queueArray[i] = other.queueArray[i];

}

// Queue Assignment Operator
/***************************************************************
Queue& Queue::operator=()
Use: overloads assignment operator to be able to assign queues
Parameters: other queue
Returns: nothing
***************************************************************/
/*
template <class T>
Queue<T>& Queue<T>::operator=(const Queue<T>& other) {

	if (this != &other) {
		delete[] queueArray;
		queueCapacity = other.queueCapacity;
		queueSize = other.queueSize;
		if (queueCapacity == 0) {
			queueArray = nullptr;
		}
		else
			queueArray = new int[queueCapacity];
		for (size_t i = 0; i < queueCapacity - 1; ++i) 
			queueArray[i] = other.queueArray[i];

	}

	return *this;

}

// Queue Output Operator
/***************************************************************
ostream& operator<< ()
Use: overloads output operator to be able to print queue
Parameters: reference to ostream representing left hand side and
reference to queue representing right hand side
Returns: left hand side
***************************************************************/
/*
template <class T>
std::ostream& operator<< (std::ostream& lhs, const Queue<T>& rhs) {

	size_t current, i;

	for (current = rhs.queueFrontSub, i = 0; i < rhs.queueSize; ++i) {
		// Print queue element at subscript i
		lhs << rhs.queueArray[current] << ' ';
		// Increment i, wrapping around to front of queue array if n$
		current = (current + 1) % rhs.queueCapacity;
	}

	return lhs;

}

// Queue Clear Function
/***************************************************************
Stack::clear()
Use: clear the queue
Parameters: nothing
Returns: nothing
***************************************************************/
/*
template <class T>
void Queue<T>::clear() {

	queueSize = 0;
	queueFrontSub = 0;
	queueBackSub = queueCapacity - 1;

}

// Queue Size Function
/***************************************************************
Queue::size()
Use: returns the size
Parameters: nothing
Returns: queue size
***************************************************************/
/*
template <class T>
size_t Queue<T>::size() const {

	return queueSize;

}

// Queue Capacity Function
/***************************************************************
Queue::capacity()
Use: returns the capacity
Parameters: nothing
Returns: queue capacity
***************************************************************/
/*
template <class T>
size_t Queue<T>::capacity() const {

	return queueCapacity;

}

// Queue Empty Function
/***************************************************************
Queue::empty()
Use: check to see if queue is empty
Parameters: nothing
Returns: true if empty and false if not empty
***************************************************************/
/*
template <class T>
bool Queue<T>::empty() const {

	if (queueSize == 0)
		return true;
	else
		return false;

}

// Queue Front Function
/***************************************************************
Queue::front()
Use: return the front element
Parameters: nothing
Returns: front element
***************************************************************/
/*
template <class T>
const T& Queue<T>::front() const {

	bool test = empty();
	if (test == true)
		throw underflow_error("queue underflow error on front()");
	else
		return queueArray[queueFrontSub];

}

// Queue Back Function
/***************************************************************
Queue::back()
Use: return the back element
Parameters: nothing
Returns: back element
***************************************************************/
/*
template <class T>
const T& Queue<T>::back() const {

	bool test = empty();
	if (test == true)
		throw underflow_error("queue underflow error on back()");
	else
		return queueArray[queueBackSub];

}

// Queue Push Function
/***************************************************************
Queue::push()
Use: inserts a value in queue
Parameters: value to be inserted
Returns: nothing
***************************************************************/
/*
template <class T>
void Queue<T>::push(const T& val) {
	if (queueSize == queueCapacity)
	{
		if (queueCapacity == 0)
			reserve(1);
		else
			reserve(queueCapacity * 2);
	}
	queueBackSub = (queueBackSub + 1) % queueCapacity;
	queueArray[queueBackSub] = val;
	++queueSize;

}

// Queue Pop Function
/***************************************************************
Queue::pop()
Use: remove the front of queue
Parameters: nothing
Returns: nothing
***************************************************************/
/*
template <class T>
void Queue<T>::pop() {

	bool test = empty();
	if (test == true)
		throw underflow_error("queue underflow error on pop()");
	queueFrontSub = (queueFrontSub + 1) % queueCapacity;
	queueSize = queueSize - 1;

}

// Queue Reserve Function
/***************************************************************
Queue::reserve()
Use: creates space for another value to be inserted
Parameters: new capacity
Returns: nothing
***************************************************************/
/*
template <class T>
void Queue<T>::reserve(size_t n) {

	if (n < queueCapacity || n == queueCapacity)
		return;

	T* tempArray;
	tempArray = new T[n];

	//if (queueCapacity == 0)
	//tempArray = nullptr; //not needed prof said

	int current;
	current = queueFrontSub;
	for (size_t i = 0; i < queueSize; ++i) { //checking
		tempArray[i] = queueArray[current];
		current = (current + 1) % queueCapacity;
	}

	queueCapacity = n;
	queueBackSub = queueSize - 1;
	queueFrontSub = 0;

	delete[] queueArray;
	queueArray = tempArray;


}
*/

