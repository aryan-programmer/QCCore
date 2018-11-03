﻿namespace QCCore
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
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 , TArg20 arg20 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 , TArg20 arg20 , TArg21 arg21 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 , TArg20 arg20 , TArg21 arg21 , TArg22 arg22 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 , TArg20 arg20 , TArg21 arg21 , TArg22 arg22 , TArg23 arg23 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 , TArg20 arg20 , TArg21 arg21 , TArg22 arg22 , TArg23 arg23 , TArg24 arg24 );
	public delegate TReturn Function<out TReturn, in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 , TArg20 arg20 , TArg21 arg21 , TArg22 arg22 , TArg23 arg23 , TArg24 arg24 , TArg25 arg25 );

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
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 , TArg20 arg20 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 , TArg20 arg20 , TArg21 arg21 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 , TArg20 arg20 , TArg21 arg21 , TArg22 arg22 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 , TArg20 arg20 , TArg21 arg21 , TArg22 arg22 , TArg23 arg23 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 , TArg20 arg20 , TArg21 arg21 , TArg22 arg22 , TArg23 arg23 , TArg24 arg24 );
	public delegate void VoidFunction<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25>( TArg1 arg1 , TArg2 arg2 , TArg3 arg3 , TArg4 arg4 , TArg5 arg5 , TArg6 arg6 , TArg7 arg7 , TArg8 arg8 , TArg9 arg9 , TArg10 arg10 , TArg11 arg11 , TArg12 arg12 , TArg13 arg13 , TArg14 arg14 , TArg15 arg15 , TArg16 arg16 , TArg17 arg17 , TArg18 arg18 , TArg19 arg19 , TArg20 arg20 , TArg21 arg21 , TArg22 arg22 , TArg23 arg23 , TArg24 arg24 , TArg25 arg25 );
	#endregion
}