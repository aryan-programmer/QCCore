namespace QCCore
{
	public static partial class QCCoreCls
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
		#endregion

		public static T As<T>( object obj ) => ( T ) obj;
		public static T AsPtr<T>( object obj ) where T : class => obj as T;
		public static string TypeName<T>( T v ) => typeof( T ).FullName;
		public static string TypeNameNoCVR<T>( T v ) => typeof( T ).FullName;
		public static string TypeName<T>( ) => typeof( T ).FullName;
		public static string TypeNameNoCVR<T>( ) => typeof( T ).FullName;
		public static string RTTITypeName<T>( T v ) => v.GetType().FullName;

		public static FPipable<TReturn , TArg> MFPipable<TReturn, TArg>( Function<TReturn , TArg> function ) => new FPipable<TReturn , TArg>( function );

		#region Pipable
		public static Function<FPipable<TReturn , TArg1>> Pipable<TReturn, TArg1>( Function<TReturn , TArg1> function ) => ( ) => MFPipable( function );
		public static Function<FPipable<TReturn , TArg1> , TArg2> Pipable<TReturn, TArg1, TArg2>( Function<TReturn , TArg1 , TArg2> function ) => ( arg2 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3> Pipable<TReturn, TArg1, TArg2, TArg3>( Function<TReturn , TArg1 , TArg2 , TArg3> function ) => ( arg2 , arg3 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3 , TArg4> Pipable<TReturn, TArg1, TArg2, TArg3, TArg4>( Function<TReturn , TArg1 , TArg2 , TArg3 , TArg4> function ) => ( arg2 , arg3 , arg4 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 , arg4 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3 , TArg4 , TArg5> Pipable<TReturn, TArg1, TArg2, TArg3, TArg4, TArg5>( Function<TReturn , TArg1 , TArg2 , TArg3 , TArg4 , TArg5> function ) => ( arg2 , arg3 , arg4 , arg5 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 , arg4 , arg5 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3 , TArg4 , TArg5 , TArg6> Pipable<TReturn, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>( Function<TReturn , TArg1 , TArg2 , TArg3 , TArg4 , TArg5 , TArg6> function ) => ( arg2 , arg3 , arg4 , arg5 , arg6 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 , arg4 , arg5 , arg6 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7> Pipable<TReturn, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>( Function<TReturn , TArg1 , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7> function ) => ( arg2 , arg3 , arg4 , arg5 , arg6 , arg7 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 , arg4 , arg5 , arg6 , arg7 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8> Pipable<TReturn, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>( Function<TReturn , TArg1 , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8> function ) => ( arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9> Pipable<TReturn, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>( Function<TReturn , TArg1 , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9> function ) => ( arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9 , TArg10> Pipable<TReturn, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>( Function<TReturn , TArg1 , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9 , TArg10> function ) => ( arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 , arg10 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 , arg10 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9 , TArg10 , TArg11> Pipable<TReturn, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>( Function<TReturn , TArg1 , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9 , TArg10 , TArg11> function ) => ( arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 , arg10 , arg11 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 , arg10 , arg11 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9 , TArg10 , TArg11 , TArg12> Pipable<TReturn, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>( Function<TReturn , TArg1 , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9 , TArg10 , TArg11 , TArg12> function ) => ( arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 , arg10 , arg11 , arg12 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 , arg10 , arg11 , arg12 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9 , TArg10 , TArg11 , TArg12 , TArg13> Pipable<TReturn, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>( Function<TReturn , TArg1 , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9 , TArg10 , TArg11 , TArg12 , TArg13> function ) => ( arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 , arg10 , arg11 , arg12 , arg13 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 , arg10 , arg11 , arg12 , arg13 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9 , TArg10 , TArg11 , TArg12 , TArg13 , TArg14> Pipable<TReturn, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>( Function<TReturn , TArg1 , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9 , TArg10 , TArg11 , TArg12 , TArg13 , TArg14> function ) => ( arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 , arg10 , arg11 , arg12 , arg13 , arg14 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 , arg10 , arg11 , arg12 , arg13 , arg14 ) );
		public static Function<FPipable<TReturn , TArg1> , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9 , TArg10 , TArg11 , TArg12 , TArg13 , TArg14 , TArg15> Pipable<TReturn, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>( Function<TReturn , TArg1 , TArg2 , TArg3 , TArg4 , TArg5 , TArg6 , TArg7 , TArg8 , TArg9 , TArg10 , TArg11 , TArg12 , TArg13 , TArg14 , TArg15> function ) => ( arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 , arg10 , arg11 , arg12 , arg13 , arg14 , arg15 ) => MFPipable<TReturn , TArg1>( arg1 => function( arg1 , arg2 , arg3 , arg4 , arg5 , arg6 , arg7 , arg8 , arg9 , arg10 , arg11 , arg12 , arg13 , arg14 , arg15 ) );
		#endregion

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

		#region _DECOMPOSE_QS.!_NNV!.
		public static void _DECOMPOSE_QS<T1>( QStruct<T1> tup , out T1 Item1 ) => Item1 = tup.Item1;

		public static void _DECOMPOSE_QS<T1, T2>( QStruct<T1 , T2> tup , out T1 Item1 , out T2 Item2 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3>( QStruct<T1 , T2 , T3> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3, T4>( QStruct<T1 , T2 , T3 , T4> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3, T4, T5>( QStruct<T1 , T2 , T3 , T4 , T5> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3, T4, T5, T6>( QStruct<T1 , T2 , T3 , T4 , T5 , T6> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3, T4, T5, T6, T7>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3, T4, T5, T6, T7, T8>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3, T4, T5, T6, T7, T8, T9>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 , out T10 Item10 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
			Item10 = tup.Item10;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 , out T10 Item10 , out T11 Item11 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
			Item10 = tup.Item10;
			Item11 = tup.Item11;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 , out T10 Item10 , out T11 Item11 , out T12 Item12 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
			Item10 = tup.Item10;
			Item11 = tup.Item11;
			Item12 = tup.Item12;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 , out T10 Item10 , out T11 Item11 , out T12 Item12 , out T13 Item13 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
			Item10 = tup.Item10;
			Item11 = tup.Item11;
			Item12 = tup.Item12;
			Item13 = tup.Item13;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 , out T10 Item10 , out T11 Item11 , out T12 Item12 , out T13 Item13 , out T14 Item14 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
			Item10 = tup.Item10;
			Item11 = tup.Item11;
			Item12 = tup.Item12;
			Item13 = tup.Item13;
			Item14 = tup.Item14;
		}

		public static void _DECOMPOSE_QS<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 , out T10 Item10 , out T11 Item11 , out T12 Item12 , out T13 Item13 , out T14 Item14 , out T15 Item15 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
			Item10 = tup.Item10;
			Item11 = tup.Item11;
			Item12 = tup.Item12;
			Item13 = tup.Item13;
			Item14 = tup.Item14;
			Item15 = tup.Item15;
		}

		public static void _DECOMPOSE_QS_NNV<T1>( QStruct<T1> tup , out T1 Item1 ) => Item1 = tup.Item1;

		public static void _DECOMPOSE_QS_NNV<T1, T2>( QStruct<T1 , T2> tup , out T1 Item1 , out T2 Item2 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3>( QStruct<T1 , T2 , T3> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3, T4>( QStruct<T1 , T2 , T3 , T4> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3, T4, T5>( QStruct<T1 , T2 , T3 , T4 , T5> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3, T4, T5, T6>( QStruct<T1 , T2 , T3 , T4 , T5 , T6> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3, T4, T5, T6, T7>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3, T4, T5, T6, T7, T8>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3, T4, T5, T6, T7, T8, T9>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 , out T10 Item10 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
			Item10 = tup.Item10;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 , out T10 Item10 , out T11 Item11 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
			Item10 = tup.Item10;
			Item11 = tup.Item11;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 , out T10 Item10 , out T11 Item11 , out T12 Item12 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
			Item10 = tup.Item10;
			Item11 = tup.Item11;
			Item12 = tup.Item12;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 , out T10 Item10 , out T11 Item11 , out T12 Item12 , out T13 Item13 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
			Item10 = tup.Item10;
			Item11 = tup.Item11;
			Item12 = tup.Item12;
			Item13 = tup.Item13;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 , out T10 Item10 , out T11 Item11 , out T12 Item12 , out T13 Item13 , out T14 Item14 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
			Item10 = tup.Item10;
			Item11 = tup.Item11;
			Item12 = tup.Item12;
			Item13 = tup.Item13;
			Item14 = tup.Item14;
		}

		public static void _DECOMPOSE_QS_NNV<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> tup , out T1 Item1 , out T2 Item2 , out T3 Item3 , out T4 Item4 , out T5 Item5 , out T6 Item6 , out T7 Item7 , out T8 Item8 , out T9 Item9 , out T10 Item10 , out T11 Item11 , out T12 Item12 , out T13 Item13 , out T14 Item14 , out T15 Item15 )
		{
			Item1 = tup.Item1;
			Item2 = tup.Item2;
			Item3 = tup.Item3;
			Item4 = tup.Item4;
			Item5 = tup.Item5;
			Item6 = tup.Item6;
			Item7 = tup.Item7;
			Item8 = tup.Item8;
			Item9 = tup.Item9;
			Item10 = tup.Item10;
			Item11 = tup.Item11;
			Item12 = tup.Item12;
			Item13 = tup.Item13;
			Item14 = tup.Item14;
			Item15 = tup.Item15;
		}


		#endregion
	}
}
