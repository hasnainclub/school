/*
 NAME: Hasnain Attarwala
 ASSIGNMENT: 7
DUE: 11/7/2018

For this computer assignment, implement a derived class (as a template) to represent a
binary search tree. Since a binary search tree is a binary tree, implement your binary
search tree class from the base class of the binary tree as you implemented in your
previous assignment.

*/
#ifndef BINSTREE_H
#define BINSTREE_H

#include "binTree.h"

#include "prog7.h"
//#include "/home/cs340/progs/18f/p7/prog7.h"


template < class T >
class binSTree : public binTree < T > {
	public:
	void insert ( const T& x ); // inserts node with value x
	bool search ( const T& x ) const; // searches leaf with value x
	bool remove ( const T& x ); // removes leaf with value x
	unsigned size ( ) const; // returns height of tree
	
	private:
	void insert ( Node < T >*&, const T& ); // private version of insert
	bool search ( Node < T >*, const T& ) const;// private version of search
	void remove ( Node < T >*&, const T& ); // private version of remove
	bool leaf ( Node < T >* node ) const; // checks if node is leaf
	unsigned size ( Node < T >* ) const; // private version of height ( )
	
};

	template < class T >
	unsigned binSTree <T>::size ( ) const // returns size of tree
	{
		return size( this->root );
	}

	template < class T >
	unsigned binSTree <T>::size ( Node < T >* ptr) const // private version of size ( )
	{
		if (ptr==NULL)  
  		  return 0; 
 		else     
   			return(size(ptr->left) + size(ptr->right))  + 1;
	}
	
	
	template < class T >
	void binSTree <T>::insert ( const T& x ) // inserts node with value x
	{
		insert( this->root, x );
	}
	
	//private version
	template < class T >
	void binSTree <T>::insert ( Node < T >*& p, const T& v)
	{
		if(p == NULL)
		{
		    p = new Node<T>( v );
		}
		else if( v < p->data)
		{
		    insert( p->left, v );
		}
		else if( v > p->data )
		{
		    insert( p->right, v );
		}
		else
		{
	        return; // duplicate 
		}
	}
	
	template < class T >
	bool binSTree <T>::search ( const T& x ) const // searches leaf with value x
	{
		return search( this->root, x );
	}
	
	//private version
	template < class T >
	bool binSTree <T>::search ( Node < T >* p, const T& v) const
	{
		if( p == NULL ) 
			return false;
	    else
	    {
	        if( v == p->data )
			{
				if( leaf( p ) ) 
					return true;
				else 
					return false;
			}
	        else if( v < p->data )
				return search( p->left, v );
	        else
	            return search( p->right, v );
	    }
	    /* THIS CODE WORKS, BUT TRY THE BOTTOM ONE FOR SEG FAULT ISSUE
		
	    if(ptr == nullptr)
        return false;
	    //if pointer to data is the value we're looking for
	    else if(ptr -> data == x)
	    {
	        //check if pointer is a leaf
	        if(leaf(ptr))
	            return true;
	        else
	            return false;
	    }
	    
	    //if value we're looking for is less than the pointer to data
	    else if(x < ptr -> data)
	        return search(ptr -> left, x);
	    
	    //if value we're looking for is greater than the pointer to data
	    else if(x > ptr -> data)
	        return search(ptr -> right, x);
	    
	    else
	        return false; */
	    
	}
	
	template < class T >
	bool binSTree <T>::remove ( const T& x ) // removes leaf with value x
	{
		//if leaf call remove
	    if(search(x))
	    {
	        remove(this -> root, x);
	        return true;
	    }
	    
	    else
	        return false;
	}
	
	//private version
	template < class T >
	void binSTree <T>::remove ( Node < T >*& ptr, const T& x)
	{
		if(ptr -> data == x)
	    {
	        delete ptr;
	        ptr = nullptr;
	    }
	    else if(x < ptr -> data)
	    {
	        remove(ptr -> left, x);
	    }
	    else if(x > ptr -> data)
	    {
	        remove(ptr -> right, x);
	    }
	}
	
	// checks if node is leaf
	template < class T >
	bool binSTree <T>::leaf ( Node < T >* p) const
	{
		if(p == nullptr)
		    return false;
		if( p->left == NULL && p->right == NULL ) 
		{
			return true; // node is a leaf
		} 
		else
		{
			return false; // node is not a leaf
		}
	}
	
#endif
