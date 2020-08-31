/***************************************************************
Programmer: Emily Ducatte
Program: Program 6
Due Date: 10/30/2018
Class: CSCI 340
Section: 3
Instructor: Ibrahim Onyuksel
TA: Nicholas James Swanson
***************************************************************/
#ifndef BT_H
#define BT_H

//#include "/home/cs340/progs/18f/p6/Node.h"
#include "Node.h"

typedef enum {    left_side, right_side    } SIDE;
SIDE rnd() {    return rand() % 2 ? right_side : left_side;   }

//class binTree prototypes
template < class T >
class binTree
{
public:
binTree ( ); // default constructor
unsigned height ( ) const; // returns height of tree
virtual void insert ( const T& );  // inserts node in tree
void inorder ( void ( * ) ( T& ) ); // inorder traversal of tree

protected:
Node < T >* root; // root of tree

private:
unsigned height ( Node < T >* ) const; // private version of height( )
void insert ( Node < T >*&, const T& );   // private version of insert( )
void inorder ( Node < T >*, void ( * ) ( T& ) ); //private version of inorder ( )
};

/***************************************************************
Function:   binTree

Use:        default constructor for the binary tree class

Arguments:  no arguments

Returns:    no return type
***************************************************************/
template <class T>
binTree<T>::binTree()
{    root = NULL;    } //set the root to NULL by default


/***************************************************************
Function:   private version of height()

Use:        calculates the height of the binary tree

Arguments:  a pointer to a node

Returns:    an unsigned integer
***************************************************************/
template <class T>
unsigned binTree<T>::height(Node<T>* root) const
{    if(!root) //if there is no root present
     {    return 0;   }

     unsigned left = height(root->left); //counts through the left side of the tree
     unsigned right = height(root -> right); //counts through the right side of the tree

     if(left > right) //if the left side has more nodes than the right
     {    return 1 + left;    } //the height of the tree is then the height is the number of nodes of the left side plus the root
     else
     {    return 1 + right;    }    } //else the right side has more nodes and the height is the number of nodes to the right side of the tree plus the root


/***************************************************************
Function:   public version of height()

Use:        the private version of height()

Arguments:  none

Returns:    an unsigned integer
***************************************************************/
template <class T>
unsigned binTree<T>::height() const
{    return height(root);    }


/***************************************************************
Function:   private version of insert

Use:        inserts nodes into the binary tree, whether they are
            inserted into the left or the right side of the tree
            will be determined at random

Arguments:  a Node<T> pointer, and a const T& value

Returns:    nothing
***************************************************************/
template <class T>
void binTree<T>::insert(Node<T>*& root, const T& x)
{    if(root == NULL) //if the root of the tree is NULL, insert a new node value to become the root
     {    root = new Node<T>(x);    }
     else
     {    SIDE s = rnd(); //chooses randomly with rnd function which side to place the node into
          if(s == left_side) //if the side chosen is left, insert the node into the left side of the tree
          {    insert(root->left, x);    }
          else //if the side chosen is right, insert the node into the right side of three
          {    insert(root->right, x);    }    }    }

/***************************************************************
Function:   public version of the inorder function

Use:        calls the private inorder function

Arguments:  pointer to a function that takes a const T& value as it's
            argument

Returns:    nothing
***************************************************************/
template <class T>
void binTree<T>::inorder(void (*p)(T&))
{    inorder(root, p);    }

/***************************************************************
Function:   private version of inorder()

Use:        traverses the binary tree in-order

Arguments:  a pointer to a node and a pointer to a function that
            takes a const T& object as it's argument

Returns:    nothing
***************************************************************/
template <class T>
void binTree<T>::inorder(Node<T>* root, void(*p)(T& node))
{    if(root != NULL) //if the root is not not null, then continue with traversal of tree
     {    inorder(root->left,p); //inorder starts at the leftmost side of the tree then goes to the root and then, finally, the rightside
          p(root->data); //get value of data at each node
          inorder(root->right, p);    }    }

/***************************************************************
Function:   public version of insert()

Use:        makes a call on the private version of insert

Arguments:  a const T& value to hold the value being inserted

Returns:    nothing
***************************************************************/
template <class T>
void binTree<T>::insert(const T& x)
{    insert(root, x);    }

#endif
