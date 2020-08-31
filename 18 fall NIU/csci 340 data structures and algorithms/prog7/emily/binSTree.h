/***************************************************************
Programmer: Emily Ducatte
Program: Program 7
Due Date: 11/08/2018
Class: CSCI 340
Section: 3
Instructor: Ibrahim Onyuksel
TA: Nicholas James Swanson
***************************************************************/

#ifndef BST_H
#define BST_H

#include "binTree.h"
#include "prog7.h"

template < class T >
class binSTree : public binTree < T >
{
public:
void insert ( const T& x ); // inserts node with value x
bool search ( const T& x ) const; // searches leaf with value x
bool remove ( const T& x ); // removes leaf with value x
unsigned int size();

private:
void insert ( Node < T >*&, const T& ); // private version of insert
bool search ( Node < T >*, const T& ) const; // private version of search
void remove ( Node < T >*&, const T& ); // private version of remove
bool leaf ( Node < T >* node ) const; // checks if node is leaf
unsigned int size(Node<T>*& node);
};

template <class T>
unsigned int binSTree<T>::size()
{    return size(this->root);    }

template <class T>
unsigned int binSTree<T>::size(Node<T>*& node)
{    if (node != nullptr)
     {    return(size(node->left) + size(node->right))  + 1;   }   
	 else return 0; }

template <class T>
void binSTree<T>::insert(const T& x)
{    insert(this->root, x);    }

template <class T>
void binSTree<T>::insert(Node<T>*& node, const T& x)
{    if (node == NULL)
     {    node = new Node<T>(x);    }
     else if  (x > node -> data)
     {    insert(node -> right, x);    }
     else if (x < node -> data)
     {    insert(node -> left, x);    }    
	 else
		{
	        return; // duplicate 
		}
}

template <class T>
bool binSTree<T>::search(const T& x) const
{    return search(this->root, x);    }

template <class T>
bool binSTree<T>::search(Node<T>* node, const T& x) const
{    if (node == nullptr)
     {    return false;    }
     else if (node -> data == x)
     {    return true;    }
     else if (node -> data > x)
     {    return (search(node -> left, x));    }
     else if (node -> data < x)
     {    return (search(node -> right, x));    }
     else
     {    return false;    }    }

template <class T>
bool binSTree<T>::remove(const T& x)
{    if (search(x))
     {    remove(this->root, x);
	 return true;    }
     else
     {    return false;    }    }

template <class T>
void binSTree<T>::remove(Node<T>*& node, const T& x)
{  if(node -> data == x)
	    {
	        delete node;
	        node = nullptr;
	    }
	    else if(x < node -> data)
	    {
	        remove(node -> left, x);
	    }
	    else if(x > node -> data)
	    {
	        remove(node -> right, x);
	    }   }

template <class T>
bool binSTree<T>::leaf(Node<T>* node) const
{    if (node -> right == nullptr && node -> left == nullptr)
     {    return true;    }
     else
     {    return false;    }    }

#endif
