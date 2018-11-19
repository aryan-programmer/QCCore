namespace QCCore
{
	#region Function
	public delegate TReturn Function<out TReturn>( );
	public delegate TReturn Function<out TReturn, in TArg1>( TArg1 arg1 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2>( TArg1 arg1 , TArg2 arg2 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 );
	#endregion

	#region VoidFunction
	public delegate void VoidFunction( );
	public delegate void VoidFunction<in TArg1>( TArg1 arg1 );
	public delegate void VoidFunction<in TArg1, in TArg2>( TArg1 arg1 , TArg2 arg2 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 );
	#endregion

	#region Automatic type deduction
	public static partial class MainCls
	{
		public static Function<TReturn , T1> Lambda<TReturn, T1>( Function<TReturn , T1> value ) => value;
		public static Function<TReturn , T1 , T2> Lambda<TReturn, T1, T2>( Function<TReturn , T1 , T2> value ) => value;
		public static Function<TReturn , T1 , T2 , T3> Lambda<TReturn, T1, T2, T3>( Function<TReturn , T1 , T2 , T3> value ) => value;
		public static Function<TReturn , T1 , T2 , T3 , T4> Lambda<TReturn, T1, T2, T3, T4>( Function<TReturn , T1 , T2 , T3 , T4> value ) => value;
		public static Function<TReturn , T1 , T2 , T3 , T4 , T5> Lambda<TReturn, T1, T2, T3, T4, T5>( Function<TReturn , T1 , T2 , T3 , T4 , T5> value ) => value;
		public static Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6> Lambda<TReturn, T1, T2, T3, T4, T5, T6>( Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6> value ) => value;
		public static Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7> Lambda<TReturn, T1, T2, T3, T4, T5, T6, T7>( Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7> value ) => value;
		public static Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> Lambda<TReturn, T1, T2, T3, T4, T5, T6, T7, T8>( Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> value ) => value;
		public static Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> Lambda<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9>( Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> value ) => value;
		public static Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> Lambda<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>( Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> value ) => value;
		public static Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> Lambda<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>( Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> value ) => value;
		public static Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> Lambda<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>( Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> value ) => value;
		public static Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> Lambda<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>( Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> value ) => value;
		public static Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> Lambda<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>( Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> value ) => value;
		public static Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> Lambda<TReturn, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( Function<TReturn , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> value ) => value;
		public static VoidFunction<T1> Lambda<T1>( VoidFunction<T1> value ) => value;
		public static VoidFunction<T1 , T2> Lambda<T1, T2>( VoidFunction<T1 , T2> value ) => value;
		public static VoidFunction<T1 , T2 , T3> Lambda<T1, T2, T3>( VoidFunction<T1 , T2 , T3> value ) => value;
		public static VoidFunction<T1 , T2 , T3 , T4> Lambda<T1, T2, T3, T4>( VoidFunction<T1 , T2 , T3 , T4> value ) => value;
		public static VoidFunction<T1 , T2 , T3 , T4 , T5> Lambda<T1, T2, T3, T4, T5>( VoidFunction<T1 , T2 , T3 , T4 , T5> value ) => value;
		public static VoidFunction<T1 , T2 , T3 , T4 , T5 , T6> Lambda<T1, T2, T3, T4, T5, T6>( VoidFunction<T1 , T2 , T3 , T4 , T5 , T6> value ) => value;
		public static VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7> Lambda<T1, T2, T3, T4, T5, T6, T7>( VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7> value ) => value;
		public static VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> Lambda<T1, T2, T3, T4, T5, T6, T7, T8>( VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> value ) => value;
		public static VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9>( VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> value ) => value;
		public static VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>( VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> value ) => value;
		public static VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>( VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> value ) => value;
		public static VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>( VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> value ) => value;
		public static VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>( VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> value ) => value;
		public static VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>( VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> value ) => value;
		public static VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> Lambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( VoidFunction<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> value ) => value;

	}
	#endregion
}