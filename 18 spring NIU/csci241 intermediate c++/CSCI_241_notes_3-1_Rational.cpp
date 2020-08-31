#include "Rational.h"

ostream& operator<<(ostream& output, const Rational& alpha)
  {
  //This is a standalone function, so it cannot call these 
  //private attributes.
  //Which is why we made a friend
//output << "( " << alpha.n << " / " << alpha.d << " )";
  
  return output;
  }

void Rational::print(ostream& output) const  //don't need the '= cout' here
  {
  //output is a more generic stream, when compared to cout.
  output << "( " << n << " / " << d << " )"; //printing a fraction.
  }

void Rational::setN(const int& newN)
  {
  n = newN;

  simplify();
  }

void Rational::setD(const int& newD)
  {
  //Denominator can never equal 0;
  if (newD == 0) return; //reject that value

  //else, we'll do this:
  d = newD;
  simplify();
  }

Rational Rational::add(const Rational& alpha) const
  {
  Rational result; //create an object to store the answer
  if(d == alpha.d)
    {
    result.d = d;
    result.n = (n + alpha.n); //adding the numerators of the two 
			      //fractions.
    result.simplify();
    return result;
    }
  return result;
  }

Rational Rational::subtract(const Rational& alpha) const;
  {
  Rational right = alpha;
  right.n *= -1; //make it negative, so that we can add the negative 
		 //instead of subracting.
  return (*this).add(right); //we could actually leave 'this' out of it
  //works the same as slacker.add(test);, but we don't have a slacker
  }

void Rational::print(ostream& output) const
  {
  output << "( " << n << " / " << d << " )";
  }

void Rational::simplify()
  {
  int temp = gcd(n, d);
  n = n / temp;
  d = d / temp;
  }

int Rational::gcd(int alpha, int beta) const
  {
  int rem;

  while (beta > 0)
    {
    rem = alpha % beta;
    alpha = beta;
    beta = rem;
    }

  return alpha;
  }
