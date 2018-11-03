using System;

namespace QCCore
{
	public class FPipable<TReturn, TArg>
	{
		public readonly Function<TReturn , TArg> function;

		public FPipable( Function<TReturn , TArg> function ) => this.function = function ?? throw new ArgumentNullException( nameof( function ) );

		public static explicit operator FPipable<TReturn , TArg>( Function<TReturn , TArg> function ) => new FPipable<TReturn , TArg>( function );

		public static TReturn operator |( TArg arg1 , FPipable<TReturn , TArg> pipable ) => pipable.function( arg1 );
	}
}
