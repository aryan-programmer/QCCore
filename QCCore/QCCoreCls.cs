namespace QCCore
{
	public static partial class MainCls
	{
		#region Limits
		public const short Int16Min = short.MinValue;
		public const short Int16Max = short.MaxValue;
		public const int Int32Min = int.MinValue;
		public const int Int32Max = int.MaxValue;
		public const long Int64Min = long.MinValue;
		public const long Int64Max = long.MaxValue;
		public const ushort UInt16Min = 0;
		public const ushort UInt16Max = ushort.MaxValue;
		public const uint UInt32Min = 0;
		public const uint UInt32Max = uint.MaxValue;
		public const ulong UInt64Min = 0;
		public const ulong UInt64Max = ulong.MaxValue;
		public const short ShortMin = short.MinValue;
		public const short ShortMax = short.MaxValue;
		public const int IntMin = int.MinValue;
		public const int IntMax = int.MaxValue;
		public const long LongMin = long.MinValue;
		public const long LongMax = long.MaxValue;
		public const ushort UShortMin = 0;
		public const ushort UShortMax = ushort.MaxValue;
		public const uint UIntMin = 0;
		public const uint UIntMax = uint.MaxValue;
		public const ulong ULongMin = 0;
		public const ulong ULongMax = ulong.MaxValue;
		public const char CharMin = char.MinValue;
		public const char CharMax = char.MaxValue;
		public const char WCharMin = char.MinValue;
		public const char WCharMax = char.MaxValue;
		public const byte ByteMin = byte.MinValue;
		public const byte ByteMax = byte.MaxValue;
		public const sbyte SByteMin = sbyte.MinValue;
		public const sbyte SByteMax = sbyte.MaxValue;
		#endregion

		public static T As<T>( object obj ) => ( T ) obj;
		public static string TypeName<T>( T v ) => typeof( T ).FullName;
		public static string TypeNameNoCVR<T>( T v ) => typeof( T ).FullName;
		public static string TypeName<T>( ) => typeof( T ).FullName;
		public static string TypeNameNoCVR<T>( ) => typeof( T ).FullName;
		public static string RTTITypeName<T>( T v ) => v.GetType().FullName;

		public static FPipable<TReturn , TArg> MFPipable<TReturn, TArg>( Function<TReturn , TArg> function ) => new FPipable<TReturn , TArg>( function );

		public static int CombineHashCodes( params int[ ] hashCodes )
		{
			int hash1 = ( 5381 << 16 ) + 5381;
			int hash2 = hash1;

			int i = 0;
			foreach ( int hashCode in hashCodes )
			{
				if ( i % 2 == 0 )
					hash1 = ( ( hash1 << 5 ) + hash1 + ( hash1 >> 27 ) ) ^ hashCode;
				else
					hash2 = ( ( hash2 << 5 ) + hash2 + ( hash2 >> 27 ) ) ^ hashCode;

				++i;
			}

			return hash1 + ( hash2 * 1566083941 );
		}

		public static int Length( this string s ) => s.Length;
		public static int Count( this string s ) => s.Length;
		public static int Size( this string s ) => s.Length;

		public static int Hash<T>( T v ) => v.GetHashCode();
	}
}
