// QCCoreForCPP.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

struct s
{
	int a;
	s( int a ) :a( a ) { }
};

int main( )
{
	using namespace QCCore;
	using namespace std;
	using namespace std::string_literals;
	using namespace std::string_view_literals;
	using namespace boost::phoenix::arg_names;
	return 0;
}

