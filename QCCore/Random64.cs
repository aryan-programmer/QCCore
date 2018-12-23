using System.Security.Cryptography;

namespace QCCore
{
	public class Random64
	{
		private const long PowVal = 1 << 15;

		private readonly RandomNumberGenerator rndNG;
		public Random64( ) => rndNG = RandomNumberGenerator.Create();

		private static long Repeat( ulong i , long start , long end ) =>
			( long ) ( ( i % ( decimal ) ( end - start + 1 ) ) + start );

		public ulong Get( )
		{
			var data = new byte[ sizeof( ulong ) ];
			rndNG.GetNonZeroBytes( data );
			return System.BitConverter.ToUInt64( data , 0 );
		}
		public long GetLong( long start , long end ) => Repeat( Get() , start , end );
		public double GetDbl( ) => ( ( double ) GetLong( 0 , PowVal ) ) / PowVal;
		public Array<byte> GetBytes( int len )
		{
			var bytes = new Array<byte>( ( ulong ) len );
			rndNG.GetBytes( bytes.__NATIVE() );
			return bytes;
		}

		public static Random64 GetInst( ) => MainCls.Random64Inst;
	}

	public static partial class MainCls
	{
		public static readonly Random64 Random64Inst = new Random64();

		public static ulong GetRandomULong( ) => Random64Inst.Get();
		public static long GetRandomLong( long start , long end ) => Random64Inst.GetLong( start , end );
		public static double GetRandomDbl( ) => Random64Inst.GetDbl();
		public static Array<byte> GetRandomBytes( int len ) => Random64Inst.GetBytes( len );
	}
}
