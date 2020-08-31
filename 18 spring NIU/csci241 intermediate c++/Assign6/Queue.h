#ifndef QUEUE_H
#define QUEUE_H

#include <iostream>
#include <fstream>
#include <stdexcept>

using namespace std;

#define nullptr NULL;

//*****************************************************************
// FILE:      Queue.h
// AUTHOR:    Hasnain Attarwala
// LOGON ID:  z1697740
// DUE DATE:  april 9 2018
//
// PURPOSE:   Declaration for the template Queue Class
//
//*****************************************************************/

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

#endif
