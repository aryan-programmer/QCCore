namespace QCCore
{
	using System;

	public static partial class MainCls
	{
		public const double Pi = 3.14159265358979323846;
		public const double Tau = 6.283185307179586;
		public const double PiOver2 = 1.57079632679489661923;
		public const double PiOver4 = 0.785398163397448309616;
		public const double OneOverPi = 0.318309886183790671538;
		public const double TwoOverPi = 0.636619772367581343076;
		public const double TwoOverSqrtPi = 1.12837916709551257390;
		public const double Sqrt2 = 1.41421356237309504880;
		public const double OneOverSqrt2 = 0.707106781186547524401;
		public const double E = 2.71828182845904523536;
		public const double Log2OfE = 1.44269504088896340736;
		public const double Log10OfE = 0.434294481903251827651;
		public const double LnOf2 = 0.693147180559945309417;
		public const double LnOf10 = 2.30258509299404568402;
		public const double NanD = double.NaN;
		public const float NanF = float.NaN;
		public const double InfD = double.PositiveInfinity;
		public const float InfF = float.PositiveInfinity;
		public const double NegInfD = double.PositiveInfinity;
		public const float NegInfF = float.PositiveInfinity;

		#region Basic Operations
		#region Abs
		public static double Abs( double value ) => Math.Abs( value );
		public static float Abs( float value ) => Math.Abs( value );
		public static int Abs( int value ) => Math.Abs( value );
		public static short Abs( short value ) => Math.Abs( value );
		public static sbyte Abs( sbyte value ) => Math.Abs( value );
		public static long Abs( long value ) => Math.Abs( value );
		#endregion

		#region Max
		public static short Max( short val1 , short val2 ) => Math.Max( val1 , val2 );
		public static ushort Max( ushort val1 , ushort val2 ) => Math.Max( val1 , val2 );
		public static int Max( int val1 , int val2 ) => Math.Max( val1 , val2 );
		public static long Max( long val1 , long val2 ) => Math.Max( val1 , val2 );
		public static ulong Max( ulong val1 , ulong val2 ) => Math.Max( val1 , val2 );
		public static float Max( float val1 , float val2 ) => Math.Max( val1 , val2 );
		public static double Max( double val1 , double val2 ) => Math.Max( val1 , val2 );
		public static uint Max( uint val1 , uint val2 ) => Math.Max( val1 , val2 );
		public static sbyte Max( sbyte val1 , sbyte val2 ) => Math.Max( val1 , val2 );
		public static byte Max( byte val1 , byte val2 ) => Math.Max( val1 , val2 );
		#endregion

		#region Min
		public static int Min( int val1 , int val2 ) => Math.Min( val1 , val2 );
		public static double Min( double val1 , double val2 ) => Math.Min( val1 , val2 );
		public static float Min( float val1 , float val2 ) => Math.Min( val1 , val2 );
		public static ulong Min( ulong val1 , ulong val2 ) => Math.Min( val1 , val2 );
		public static long Min( long val1 , long val2 ) => Math.Min( val1 , val2 );
		public static uint Min( uint val1 , uint val2 ) => Math.Min( val1 , val2 );
		public static ushort Min( ushort val1 , ushort val2 ) => Math.Min( val1 , val2 );
		public static short Min( short val1 , short val2 ) => Math.Min( val1 , val2 );
		public static sbyte Min( sbyte val1 , sbyte val2 ) => Math.Min( val1 , val2 );
		public static byte Min( byte val1 , byte val2 ) => Math.Min( val1 , val2 );
		#endregion

		#region IsNan
		public static bool IsNan( float f ) => float.IsNaN( f );
		public static bool IsNan( double d ) => double.IsNaN( d );
		#endregion

		#region IsInf
		public static bool IsInf( float f ) => float.IsInfinity( f );
		public static bool IsInf( double d ) => double.IsInfinity( d );
		#endregion
		#endregion

		#region Exponential functions
		public static double Exp( double d ) => Math.Exp( d );
		public static double Ln( double d ) => Math.Log( d );
		public static double Log10( double d ) => Math.Log10( d );
		public static double Log( double _base , double a ) => Math.Log( a , _base );
		#endregion

		#region Power functions
		public static double Sqrt( double d ) => Math.Sqrt( d );
		public static double Pow( double x , double y ) => Math.Pow( x , y );
		#endregion

		#region Trigonometric functions
		public static double Sin( double a ) => Math.Sin( a );
		public static double Cos( double d ) => Math.Cos( d );
		public static double Tan( double a ) => Math.Tan( a );
		#endregion

		#region Inverse Trigonometric functions
		public static double Asin( double d ) => Math.Asin( d );
		public static double Acos( double d ) => Math.Acos( d );
		public static double Atan( double d ) => Math.Atan( d );
		public static double Atan2( double y , double x ) => Math.Atan2( y , x );
		#endregion

		#region Hyperbolic Trigonometric functions
		public static double Sinh( double value ) => Math.Sinh( value );
		public static double Cosh( double d ) => Math.Cosh( d );
		public static double Tanh( double value ) => Math.Tanh( value );
		#endregion

		#region Nearest integer floating point operations
		public static double Ceil( double a ) => Math.Ceiling( a );
		public static double Floor( double d ) => Math.Floor( d );
		public static double Round( double a ) => Math.Round( a );
		public static double Trunc( double d ) => Math.Truncate( d );
		#endregion

		#region Sign
		public static int Sign( sbyte value ) => Math.Sign( value );
		public static int Sign( decimal value ) => Math.Sign( value );
		public static int Sign( double value ) => Math.Sign( value );
		public static int Sign( float value ) => Math.Sign( value );
		public static int Sign( long value ) => Math.Sign( value );
		public static int Sign( short value ) => Math.Sign( value );
		public static int Sign( int value ) => Math.Sign( value );
		#endregion
	}
}