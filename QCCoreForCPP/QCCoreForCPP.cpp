// QCCoreForCPP.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

int main( )
{
	using namespace QCCore;
	using namespace std;
	using namespace std::string_literals;
	using namespace std::string_view_literals;
	DynArray<Long> arrLong( 25 );
	for ( Long i = 0; i < arrLong.Capacity( ); i++ ) arrLong.Add( i );
	arrLong.Reverse( );
	arrLong.Reverse( 1 , 3 );
	return 0;
}

