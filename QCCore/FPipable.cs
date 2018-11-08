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
}
