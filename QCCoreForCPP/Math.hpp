#pragma once

#include "predef_and_include.hpp"
#include <cmath>

namespace QCCore
{
	static constexpr Double Pi = 3.14159265358979323846;
	static constexpr Double Tau = 6.283185307179586;
	static constexpr Double SqrtPi = 1.77245385091;
	static constexpr Double PiOver2 = 1.57079632679489661923;
	static constexpr Double PiOver4 = 0.785398163397448309616;
	static constexpr Double OneOverPi = 0.318309886183790671538;
	static constexpr Double TwoOverPi = 0.636619772367581343076;
	static constexpr Double TwoOverSqrtPi = 1.12837916709551257390;
	static constexpr Double Sqrt2 = 1.41421356237309504880;
	static constexpr Double OneOverSqrt2 = 0.707106781186547524401;
	static constexpr Double E = 2.71828182845904523536;
	static constexpr Double Log2OfE = 1.44269504088896340736;
	static constexpr Double Log10OfE = 0.434294481903251827651;
	static constexpr Double LnOf2 = 0.693147180559945309417;
	static constexpr Double LnOf10 = 2.30258509299404568402;
	static constexpr Double NanD = std::numeric_limits<Double>::signaling_NaN( );
	static constexpr Float NanF = std::numeric_limits<Float>::signaling_NaN( );
	static constexpr Double InfD = std::numeric_limits<Double>::infinity( );
	static constexpr Float InfF = std::numeric_limits<Float>::infinity( );
	static constexpr Double NegInfD = -std::numeric_limits<Double>::infinity( );
	static constexpr Float NegInfF = -std::numeric_limits<Float>::infinity( );

#pragma region Basic Operations
#pragma region Abs
	___NODISCARD___ forceinline static Double Abs( Double value ) { return abs( value ); }
	___NODISCARD___ forceinline static Float Abs( Float value ) { return abs( value ); }
	___NODISCARD___ forceinline static Int Abs( Int value ) { return abs( value ); }
	___NODISCARD___ forceinline static Short Abs( Short value ) { return abs( value ); }
	___NODISCARD___ forceinline static SByte Abs( SByte value ) { return static_cast< SByte >( abs( static_cast< Int >( value ) ) ); }
	___NODISCARD___ forceinline static Long Abs( Long value ) { return abs( value ); }
#pragma endregion

#pragma region Max
	___NODISCARD___ forceinline static Short Max( Short val1 , Short val2 ) { return std::max( val1 , val2 ); }
	___NODISCARD___ forceinline static UShort Max( UShort val1 , UShort val2 ) { return std::max( val1 , val2 ); }
	___NODISCARD___ forceinline static Int Max( Int val1 , Int val2 ) { return std::max( val1 , val2 ); }
	___NODISCARD___ forceinline static Long Max( Long val1 , Long val2 ) { return std::max( val1 , val2 ); }
	___NODISCARD___ forceinline static ULong Max( ULong val1 , ULong val2 ) { return std::max( val1 , val2 ); }
	___NODISCARD___ forceinline static Float Max( Float val1 , Float val2 ) { return std::max( val1 , val2 ); }
	___NODISCARD___ forceinline static Double Max( Double val1 , Double val2 ) { return std::max( val1 , val2 ); }
	___NODISCARD___ forceinline static UInt Max( UInt val1 , UInt val2 ) { return std::max( val1 , val2 ); }
	___NODISCARD___ forceinline static SByte Max( SByte val1 , SByte val2 ) { return std::max( val1 , val2 ); }
	___NODISCARD___ forceinline static Byte Max( Byte val1 , Byte val2 ) { return std::max( val1 , val2 ); }
#pragma endregion

#pragma region Min
	___NODISCARD___ forceinline static Int Min( Int val1 , Int val2 ) { return std::min( val1 , val2 ); }
	___NODISCARD___ forceinline static Double Min( Double val1 , Double val2 ) { return std::min( val1 , val2 ); }
	___NODISCARD___ forceinline static Float Min( Float val1 , Float val2 ) { return std::min( val1 , val2 ); }
	___NODISCARD___ forceinline static ULong Min( ULong val1 , ULong val2 ) { return std::min( val1 , val2 ); }
	___NODISCARD___ forceinline static Long Min( Long val1 , Long val2 ) { return std::min( val1 , val2 ); }
	___NODISCARD___ forceinline static UInt Min( UInt val1 , UInt val2 ) { return std::min( val1 , val2 ); }
	___NODISCARD___ forceinline static UShort Min( UShort val1 , UShort val2 ) { return std::min( val1 , val2 ); }
	___NODISCARD___ forceinline static Short Min( Short val1 , Short val2 ) { return std::min( val1 , val2 ); }
	___NODISCARD___ forceinline static SByte Min( SByte val1 , SByte val2 ) { return std::min( val1 , val2 ); }
	___NODISCARD___ forceinline static Byte Min( Byte val1 , Byte val2 ) { return std::min( val1 , val2 ); }
#pragma endregion

#pragma region IsNan
	___NODISCARD___ forceinline static bool IsNan( Float f ) { return isnan( f ); }
	___NODISCARD___ forceinline static bool IsNan( Double d ) { return isnan( d ); }
#pragma endregion

#pragma region IsInf
	___NODISCARD___ forceinline static bool IsInf( Float f ) { return isnan( f ); }
	___NODISCARD___ forceinline static bool IsInf( Double d ) { return isnan( d ); }
#pragma endregion
#pragma endregion

#pragma region Exponential functions
	___NODISCARD___ forceinline static Double Exp( Double d ) { return exp( d ); }
	___NODISCARD___ forceinline static Double Ln( Double d ) { return log( d ); }
	___NODISCARD___ forceinline static Double Log10( Double d ) { return log10( d ); }
	___NODISCARD___ forceinline static Double Log( Double b , Double x ) { return Ln( x ) / Ln( b ); }
#pragma endregion

#pragma region Power functions
	___NODISCARD___ forceinline static Double Sqrt( Double d ) { return sqrt( d ); }
	___NODISCARD___ forceinline static Double Pow( Double x , Double y ) { return pow( x , y ); }
#pragma endregion

#pragma region Trigonometric functions
	___NODISCARD___ forceinline static Double Sin( Double a ) { return sin( a ); }
	___NODISCARD___ forceinline static Double Cos( Double d ) { return cos( d ); }
	___NODISCARD___ forceinline static Double Tan( Double a ) { return tan( a ); }
#pragma endregion

#pragma region Inverse Trigonometric functions
	___NODISCARD___ forceinline static Double Asin( Double d ) { return asin( d ); }
	___NODISCARD___ forceinline static Double Acos( Double d ) { return acos( d ); }
	___NODISCARD___ forceinline static Double Atan( Double d ) { return atan( d ); }
	___NODISCARD___ forceinline static Double Atan2( Double y , Double x ) { return atan2( y , x ); }
#pragma endregion

#pragma region Hyperbolic Trigonometric functions
	___NODISCARD___ forceinline static Double Sinh( Double value ) { return sinh( value ); }
	___NODISCARD___ forceinline static Double Cosh( Double d ) { return cosh( d ); }
	___NODISCARD___ forceinline static Double Tanh( Double value ) { return tanh( value ); }
#pragma endregion

#pragma region Nearest Integer Floating poInt operations
	___NODISCARD___ forceinline static Double Ceil( Double a ) { return ceil( a ); }
	___NODISCARD___ forceinline static Double Floor( Double d ) { return floor( d ); }
	___NODISCARD___ forceinline static Double Round( Double a ) { return round( a ); }
	___NODISCARD___ forceinline static Double Trunc( Double d ) { return trunc( d ); }
#pragma endregion

#pragma region Sign
	template<typename T>
	Int sign( T v , T zero , T one , T negOne )
	{
		if ( v == zero )return 0;
		if ( v >= one )return 1;
		if ( v <= negOne )return -1;
	}

	template<typename T>
	___NODISCARD___ forceinline static Int sign( T v , T zero , T one ) { return ::QCCore::sign<T>( v , zero , one , -one ); }

	___NODISCARD___ forceinline static Int Sign( SByte value ) { return sign( value , ( SByte ) 0 , ( SByte ) 1 ); }
	___NODISCARD___ forceinline static Int Sign( Double value ) { return sign( value , 0.0 , 1.0 ); }
	___NODISCARD___ forceinline static Int Sign( Float value ) { return sign( value , 0.0f , 1.0f ); }
	___NODISCARD___ forceinline static Int Sign( Long value ) { return sign( value , 0i64 , 1i64 ); }
	___NODISCARD___ forceinline static Int Sign( Short value ) { return sign( value , 0i16 , 1i16 ); }
	___NODISCARD___ forceinline static Int Sign( Int value ) { return sign( value , 0 , 0 ); }
#pragma endregion
}
