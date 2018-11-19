#pragma once
#include "predef_and_include.hpp"
#include "Array.hpp"
#include <chrono>
#include <cfloat>
#include <random>

namespace QCCore
{
	class Random64
	{
		static constexpr Int PowVal = 1 << DBL_DIG;
		std::mt19937_64 rnn;
	public:
		forceinline Random64( ) :rnn( ULong( std::chrono::steady_clock::now( ).time_since_epoch( ).count( ) ) ) { }

		forceinline ULong Get( ) { return rnn( ); }
		forceinline Long GetLong( Long start , Long end )
		{ return std::uniform_int_distribution<Long>( start , end )( rnn ); }
		forceinline Double GetDbl( )
		{ return static_cast< double >( GetLong( 0 , PowVal ) ) / PowVal; }
		Array<Byte> GetBytes( Int count )
		{
			Array<Byte> retVal( count );
			for ( size_t i = 0; i < count; i++ )
				retVal[ i ] = Byte( GetLong( Int( ByteMin ) , Int( ByteMax ) ) );
			return std::move( retVal );
		}

		static Random64& GetInst( );
	};

	Random64 & QCCore::Random64::GetInst( )
	{
		static Random64 inst;
		return inst;
	}

	Random64& Random64Inst = Random64::GetInst( );

	forceinline ULong GetRandomULong( ) { return Random64Inst.Get( ); }
	forceinline Long GetRandomLong( long start , long end ) { return Random64Inst.GetLong( start , end ); }
	forceinline Double GetRandomDbl( ) { return Random64Inst.GetDbl( ); }
	forceinline Array<Byte> GetRandomBytes( int len ) { return Random64Inst.GetBytes( len ); }
}
