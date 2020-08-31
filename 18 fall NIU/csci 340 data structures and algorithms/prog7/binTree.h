/*
 NAME: Hasnain Attarwala
 ASSIGNMENT: 7
DUE: 11/7/2018
For this computer assignment, you are to write a C++ program to implement a class for binary
trees. To deal with variety of data types, implement this class as a template.
*/

#ifndef BINTREE_H
#define BINTREE_H

#include "Node.H"
//#include "/home/cs340/progs/18f/p7/Node.h"


template < class T > 
class binTree {
	public:
	binTree ( ); // default constructor
	
	unsigned height ( ) const; // returns height of tree
	
	virtual void insert ( const T& ); // inserts node in tree
	
	void inorder(void (*fn)(T&)); // inorder traversal of tree
	
	protected:
	Node < T >* root; // root of tree
	
	
	private:
	unsigned height ( Node < T >* ) const; // private version of height ( )
	
	void insert ( Node < T >*&, const T& ); // private version of insert ( )     
	  
	void inorder ( Node < T >*, void ( *fn ) (T& ) );// private version of inorder ( )
};

typedef enum { left_side, right_side } SIDE;
SIDE rnd ( ) { return rand ( ) % 2 ? right_side : left_side; }

// default constructor
template <class T>
binTree <T>::binTree( )
{
	root = nullptr; // initialize root
	
	/*
	Node* n = new Node; // dynamically allocate new objects of type Node
	n->data = data;
	n->left = nullptr;
	n->right = nullptr;
	return(n); */

}



// returns height of tree
template <class T>
unsigned binTree <T>::height( ) const
{
    return height( root ); // call recursive
}

// inserts a node in shortest subtree PUBLIC
template <class T>
void binTree <T>::insert( const T& v )
{
	insert (root, v);

}


// private version of insert
template <class T> 
void binTree <T>::insert ( Node < T >*& p, const T& v)
{
	
		//Node<T>* temp = new Node<T>;
		
		if (p == nullptr)
			p = new Node <T> (v);
		else
			{
				if (rnd()==0)
				{
					insert(p->left, v);
				}
				else //if (rnd()==1)
				{
					insert(p->right, v);
				}
			}
		/*
			{
			if (v < p->data)
			insert(p->left, v);
			else
			insert(p->right, v);
			} */
}

// private version of height     
template <class T>
unsigned binTree <T>::height ( Node < T >* ptr) const
//int binTree <T>::height( binTree <T>*  ) const
//unsigned binTree binTree <T>::height ( Node < T >* ptr) const
{
	if( ptr == nullptr )
	{
		return 0; // empty tree
	}
	else
	{
		int lHeight = height( ptr->left ); // left side
		int rHeight = height( ptr->right ); // right side
	  
		if( lHeight > rHeight ) // which is greater
		{
			return 1 + lHeight; // return left
		}
		else
		{
			return 1 + rHeight; // return right 
		}   
	}
}


// private version of inOrder
template <class T>
void binTree <T>::inorder ( Node < T >* p, void ( *fn ) (T& ) )
{
//	Node *root = newNode();
	if( p != NULL )
	{
		inorder( p->left, fn );
		fn( p->data );
		inorder( p->right, fn );
	}
	
	/* NOTES
	if (ptr != nullptr)
	{
	inorder(ptr->left);
	cout << ptr->data << " ";
	inorder(ptr->right);
	} */
}
 
template <class T>
void binTree <T>::inorder(void (*fn)(T&))
{
	inorder( root, fn ); // call recursive
	/* TEST FOR SEG FAULT CRAP -- yup that's the problem, had it right in my first try!
	//stupid rand crap...  
	//only gets called on root -- prints
    inorder( root->left, fn ); // call recursive
    fn(root->data);
    inorder( root->right, fn ); */
    
}


#endif
