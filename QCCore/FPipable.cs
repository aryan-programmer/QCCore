using System;
using System.Collections.Generic;

namespace QCCore
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
#pragma warning disable CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
	public struct FPipable<TReturn, TArg> : IEquatable<FPipable<TReturn , TArg>>
#pragma warning restore CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
	{
		public readonly Function<TReturn , TArg> function;

		public FPipable( Function<TReturn , TArg> function ) => this.function = function ?? throw new ArgumentNullException( nameof( function ) );

		public static explicit operator FPipable<TReturn , TArg>( Function<TReturn , TArg> function ) => new FPipable<TReturn , TArg>( function );

		public static TReturn operator |( TArg arg1 , FPipable<TReturn , TArg> pipable ) => pipable.function( arg1 );
		public static bool operator ==( FPipable<TReturn , TArg> pipable1 , FPipable<TReturn , TArg> pipable2 ) => pipable1.Equals( pipable2 );
		public static bool operator !=( FPipable<TReturn , TArg> pipable1 , FPipable<TReturn , TArg> pipable2 ) => !( pipable1 == pipable2 );

		public override bool Equals( object obj ) => obj is FPipable<TReturn , TArg> && Equals( ( FPipable<TReturn , TArg> ) obj );
		public bool Equals( FPipable<TReturn , TArg> other ) => EqualityComparer<Function<TReturn , TArg>>.Default.Equals( function , other.function );
	}

	public static partial class MainCls
	{
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
	}
}
