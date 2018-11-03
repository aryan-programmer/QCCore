using System;
using System.Collections.Generic;
using static QCCore.QCCoreCls;

namespace QCCore
{
	public static partial class QCCoreCls
	{
		#region MakeQStruct
		public static QStruct<T1> MakeQStruct<T1>( T1 Item1) => new QStruct<T1>( Item1 );

		public static QStruct<T1 , T2> MakeQStruct<T1, T2>( T1 Item1 , T2 Item2 ) => new QStruct<T1 , T2>( Item1 , Item2 );

		public static QStruct<T1 , T2 , T3> MakeQStruct<T1, T2, T3>( T1 Item1 , T2 Item2 , T3 Item3 ) => new QStruct<T1 , T2 , T3>( Item1 , Item2 , Item3 );

		public static QStruct<T1 , T2 , T3 , T4> MakeQStruct<T1, T2, T3, T4>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 ) => new QStruct<T1 , T2 , T3 , T4>( Item1 , Item2 , Item3 , Item4 );

		public static QStruct<T1 , T2 , T3 , T4 , T5> MakeQStruct<T1, T2, T3, T4, T5>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 ) => new QStruct<T1 , T2 , T3 , T4 , T5>( Item1 , Item2 , Item3 , Item4 , Item5 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6> MakeQStruct<T1, T2, T3, T4, T5, T6>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> MakeQStruct<T1, T2, T3, T4, T5, T6, T7>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 , T14 Item14 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 , T14 Item14 , T15 Item15 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 , T14 Item14 , T15 Item15 , T16 Item16 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 , T14 Item14 , T15 Item15 , T16 Item16 , T17 Item17 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 , T14 Item14 , T15 Item15 , T16 Item16 , T17 Item17 , T18 Item18 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 , T14 Item14 , T15 Item15 , T16 Item16 , T17 Item17 , T18 Item18 , T19 Item19 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 , T14 Item14 , T15 Item15 , T16 Item16 , T17 Item17 , T18 Item18 , T19 Item19 , T20 Item20 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 , T14 Item14 , T15 Item15 , T16 Item16 , T17 Item17 , T18 Item18 , T19 Item19 , T20 Item20 , T21 Item21 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 , T14 Item14 , T15 Item15 , T16 Item16 , T17 Item17 , T18 Item18 , T19 Item19 , T20 Item20 , T21 Item21 , T22 Item22 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 , T14 Item14 , T15 Item15 , T16 Item16 , T17 Item17 , T18 Item18 , T19 Item19 , T20 Item20 , T21 Item21 , T22 Item22 , T23 Item23 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 , T14 Item14 , T15 Item15 , T16 Item16 , T17 Item17 , T18 Item18 , T19 Item19 , T20 Item20 , T21 Item21 , T22 Item22 , T23 Item23 , T24 Item24 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );

		public static QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> MakeQStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>( T1 Item1 , T2 Item2 , T3 Item3 , T4 Item4 , T5 Item5 , T6 Item6 , T7 Item7 , T8 Item8 , T9 Item9 , T10 Item10 , T11 Item11 , T12 Item12 , T13 Item13 , T14 Item14 , T15 Item15 , T16 Item16 , T17 Item17 , T18 Item18 , T19 Item19 , T20 Item20 , T21 Item21 , T22 Item22 , T23 Item23 , T24 Item24 , T25 Item25 ) => new QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		#endregion
	}
	#region QStruct

	public struct QStruct<T1> : IEquatable<QStruct<T1>>
	{
		public T1 Item1;

		public QStruct( T1 v1 = default( T1 ) ) => Item1 = v1;

		public override int GetHashCode( ) => Item1.GetHashCode();

		public override bool Equals( object obj ) => obj is QStruct<T1> && Equals( ( QStruct<T1> ) obj );

		public bool Equals( QStruct<T1> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 );

		public static bool operator ==( QStruct<T1> struct1 , QStruct<T1> struct2 ) => struct1.Equals( struct2 );

		public static bool operator !=( QStruct<T1> struct1 , QStruct<T1> struct2 ) => !( struct1 == struct2 );

		public T1 this[ Const1 _ ]
		{
			get => Item1;
			set => Item1 = value;
		}


		public QStruct<T1 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , NItem1 );
		public QStruct<T1 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 );
		public QStruct<T1 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , _T22> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21, _T22>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 , _T22 NItem22 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , NItem22 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , _T22 , _T23> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21, _T22, _T23>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 , _T22 NItem22 , _T23 NItem23 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , NItem22 , NItem23 );
		public QStruct<T1 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , _T22 , _T23 , _T24> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21, _T22, _T23, _T24>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 , _T22 NItem22 , _T23 NItem23 , _T24 NItem24 ) =>
		MakeQStruct( Item1 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , NItem22 , NItem23 , NItem24 );

		public QStruct<_T1 , T1> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 );
		public QStruct<_T1 , _T2 , T1> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , T1> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , _T22 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21, _T22>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 , _T22 NItem22 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , NItem22 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , _T22 , _T23 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21, _T22, _T23>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 , _T22 NItem22 , _T23 NItem23 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , NItem22 , NItem23 , Item1 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , _T22 , _T23 , _T24 , T1> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21, _T22, _T23, _T24>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 , _T22 NItem22 , _T23 NItem23 , _T24 NItem24 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , NItem22 , NItem23 , NItem24 , Item1 );

	}

	public struct QStruct<T1, T2> : IEquatable<QStruct<T1 , T2>>
	{

		public T1 Item1;
		public T2 Item2;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) )
		{ Item1 = v1; Item2 = v2; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2> && Equals( ( QStruct<T1 , T2> ) obj );
		public bool Equals( QStruct<T1 , T2> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 );

		public static bool operator ==( QStruct<T1 , T2> lhs , QStruct<T1 , T2> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2> lhs , QStruct<T1 , T2> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public QStruct<T1 , T2 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 );
		public QStruct<T1 , T2 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , _T22> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21, _T22>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 , _T22 NItem22 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , NItem22 );
		public QStruct<T1 , T2 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , _T22 , _T23> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21, _T22, _T23>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 , _T22 NItem22 , _T23 NItem23 ) =>
		MakeQStruct( Item1 , Item2 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , NItem22 , NItem23 );

		public QStruct<_T1 , T1 , T2> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , T1 , T2> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , _T22 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21, _T22>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 , _T22 NItem22 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , NItem22 , Item1 , Item2 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , _T22 , _T23 , T1 , T2> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21, _T22, _T23>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 , _T22 NItem22 , _T23 NItem23 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , NItem22 , NItem23 , Item1 , Item2 );

		public QStruct<T1> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 );

		public QStruct<T2> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 );

		public QStruct<QStruct<T1> , QStruct<T2>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C1 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); }

		public QStruct<dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) );

	}


	public struct QStruct<T1, T2, T3> : IEquatable<QStruct<T1 , T2 , T3>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3> && Equals( ( QStruct<T1 , T2 , T3> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 );

		public static bool operator ==( QStruct<T1 , T2 , T3> lhs , QStruct<T1 , T2 , T3> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3> lhs , QStruct<T1 , T2 , T3> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public QStruct<T1 , T2 , T3 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 );
		public QStruct<T1 , T2 , T3 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , _T22> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21, _T22>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 , _T22 NItem22 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , NItem22 );

		public QStruct<_T1 , T1 , T2 , T3> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , Item1 , Item2 , Item3 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , _T22 , T1 , T2 , T3> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21, _T22>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 , _T22 NItem22 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , NItem22 , Item1 , Item2 , Item3 );

		public QStruct<T1> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 );

		public QStruct<T2 , T3> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 );
		public QStruct<T3> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C2 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); }

		public QStruct<dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) );

	}


	public struct QStruct<T1, T2, T3, T4> : IEquatable<QStruct<T1 , T2 , T3 , T4>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4> && Equals( ( QStruct<T1 , T2 , T3 , T4> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4> lhs , QStruct<T1 , T2 , T3 , T4> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4> lhs , QStruct<T1 , T2 , T3 , T4> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public QStruct<T1 , T2 , T3 , T4 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 );
		public QStruct<T1 , T2 , T3 , T4 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 );

		public QStruct<_T1 , T1 , T2 , T3 , T4> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , Item1 , Item2 , Item3 , Item4 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , _T21 , T1 , T2 , T3 , T4> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20, _T21>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 , _T21 NItem21 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , NItem21 , Item1 , Item2 , Item3 , Item4 );

		public QStruct<T1> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );

		public QStruct<T2 , T3 , T4> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 );
		public QStruct<T3 , T4> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 );
		public QStruct<T4> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C3 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5> lhs , QStruct<T1 , T2 , T3 , T4 , T5> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5> lhs , QStruct<T1 , T2 , T3 , T4 , T5> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , _T20 , T1 , T2 , T3 , T4 , T5> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19, _T20>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 , _T20 NItem20 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , NItem20 , Item1 , Item2 , Item3 , Item4 , Item5 );

		public QStruct<T1> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );

		public QStruct<T2 , T3 , T4 , T5> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 );
		public QStruct<T3 , T4 , T5> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 );
		public QStruct<T4 , T5> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 );
		public QStruct<T5> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C4 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , _T19 , T1 , T2 , T3 , T4 , T5 , T6> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18, _T19>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 , _T19 NItem19 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , NItem19 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );

		public QStruct<T1> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );

		public QStruct<T2 , T3 , T4 , T5 , T6> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T3 , T4 , T5 , T6> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 );
		public QStruct<T4 , T5 , T6> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 );
		public QStruct<T5 , T6> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 );
		public QStruct<T6> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C5 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , _T18 , T1 , T2 , T3 , T4 , T5 , T6 , T7> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17, _T18>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 , _T18 NItem18 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , NItem18 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );

		public QStruct<T1> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T3 , T4 , T5 , T6 , T7> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T4 , T5 , T6 , T7> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 );
		public QStruct<T5 , T6 , T7> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 );
		public QStruct<T6 , T7> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 );
		public QStruct<T7> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C6 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , _T17 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16, _T17>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 , _T17 NItem17 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , NItem17 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );

		public QStruct<T1> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T4 , T5 , T6 , T7 , T8> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T5 , T6 , T7 , T8> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 );
		public QStruct<T6 , T7 , T8> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 );
		public QStruct<T7 , T8> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 );
		public QStruct<T8> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C7 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
				MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , _T16 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15, _T16>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 , _T16 NItem16 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , NItem16 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );

		public QStruct<T1> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T5 , T6 , T7 , T8 , T9> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T6 , T7 , T8 , T9> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 );
		public QStruct<T7 , T8 , T9> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 );
		public QStruct<T8 , T9> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 );
		public QStruct<T9> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C8 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , _T15 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14, _T15>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 , _T15 NItem15 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , NItem15 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );

		public QStruct<T1> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T6 , T7 , T8 , T9 , T10> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T7 , T8 , T9 , T10> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 );
		public QStruct<T8 , T9 , T10> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 );
		public QStruct<T9 , T10> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 );
		public QStruct<T10> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C9 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , _T14 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13, _T14>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 , _T14 NItem14 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , NItem14 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );

		public QStruct<T1> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T7 , T8 , T9 , T10 , T11> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T8 , T9 , T10 , T11> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 );
		public QStruct<T9 , T10 , T11> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 );
		public QStruct<T10 , T11> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 );
		public QStruct<T11> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C10 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , _T13 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12, _T13>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 , _T13 NItem13 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , NItem13 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );

		public QStruct<T1> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T8 , T9 , T10 , T11 , T12> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T9 , T10 , T11 , T12> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 );
		public QStruct<T10 , T11 , T12> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 );
		public QStruct<T11 , T12> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 );
		public QStruct<T12> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C11 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , _T12 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11, _T12>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 , _T12 NItem12 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , NItem12 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );

		public QStruct<T1> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T9 , T10 , T11 , T12 , T13> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T10 , T11 , T12 , T13> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 );
		public QStruct<T11 , T12 , T13> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 );
		public QStruct<T12 , T13> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 );
		public QStruct<T13> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C12 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;
		public T14 Item14;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) , T14 v14 = default( T14 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; Item14 = v14; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() , Item14.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 ) && EqualityComparer<T14>.Default.Equals( Item14 , rhs.Item14 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public T14 this[ Const14 _ ] { get => Item14; set => Item14 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , _T11 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10, _T11>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 , _T11 NItem11 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , NItem11 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );

		public QStruct<T1> PopBack( Const13 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T9 , T10 , T11 , T12 , T13 , T14> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T10 , T11 , T12 , T13 , T14> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T11 , T12 , T13 , T14> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 , Item14 );
		public QStruct<T12 , T13 , T14> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 , Item14 );
		public QStruct<T13 , T14> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 , Item14 );
		public QStruct<T14> PopFront( Const13 _ ) =>
		MakeQStruct( Item14 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C13 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13 , T14>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13 , T14>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13 , T14>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13 , T14>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13 , T14>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C12 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> , QStruct<T14>> SplitAt( Const13 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C13 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;
		public T14 Item14;
		public T15 Item15;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) , T14 v14 = default( T14 ) , T15 v15 = default( T15 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; Item14 = v14; Item15 = v15; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() , Item14.GetHashCode() , Item15.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 ) && EqualityComparer<T14>.Default.Equals( Item14 , rhs.Item14 ) && EqualityComparer<T15>.Default.Equals( Item15 , rhs.Item15 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public T14 this[ Const14 _ ] { get => Item14; set => Item14 = value; }
		public T15 this[ Const15 _ ] { get => Item15; set => Item15 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , _T10 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9, _T10>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 , _T10 NItem10 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , NItem10 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );

		public QStruct<T1> PopBack( Const14 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const13 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T10 , T11 , T12 , T13 , T14 , T15> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T11 , T12 , T13 , T14 , T15> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T12 , T13 , T14 , T15> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 , Item14 , Item15 );
		public QStruct<T13 , T14 , T15> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 , Item14 , Item15 );
		public QStruct<T14 , T15> PopFront( Const13 _ ) =>
		MakeQStruct( Item14 , Item15 );
		public QStruct<T15> PopFront( Const14 _ ) =>
		MakeQStruct( Item15 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C14 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C13 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13 , T14 , T15>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13 , T14 , T15>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13 , T14 , T15>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13 , T14 , T15>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C12 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> , QStruct<T14 , T15>> SplitAt( Const13 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C13 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> , QStruct<T15>> SplitAt( Const14 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C14 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;
		public T14 Item14;
		public T15 Item15;
		public T16 Item16;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) , T14 v14 = default( T14 ) , T15 v15 = default( T15 ) , T16 v16 = default( T16 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; Item14 = v14; Item15 = v15; Item16 = v16; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() , Item14.GetHashCode() , Item15.GetHashCode() , Item16.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 ) && EqualityComparer<T14>.Default.Equals( Item14 , rhs.Item14 ) && EqualityComparer<T15>.Default.Equals( Item15 , rhs.Item15 ) && EqualityComparer<T16>.Default.Equals( Item16 , rhs.Item16 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public T14 this[ Const14 _ ] { get => Item14; set => Item14 = value; }
		public T15 this[ Const15 _ ] { get => Item15; set => Item15 = value; }
		public T16 this[ Const16 _ ] { get => Item16; set => Item16 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , _T9 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8, _T9>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 , _T9 NItem9 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , NItem9 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );

		public QStruct<T1> PopBack( Const15 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const14 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const13 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T11 , T12 , T13 , T14 , T15 , T16> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T12 , T13 , T14 , T15 , T16> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T13 , T14 , T15 , T16> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 , Item14 , Item15 , Item16 );
		public QStruct<T14 , T15 , T16> PopFront( Const13 _ ) =>
		MakeQStruct( Item14 , Item15 , Item16 );
		public QStruct<T15 , T16> PopFront( Const14 _ ) =>
		MakeQStruct( Item15 , Item16 );
		public QStruct<T16> PopFront( Const15 _ ) =>
		MakeQStruct( Item16 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C15 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C14 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C13 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13 , T14 , T15 , T16>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13 , T14 , T15 , T16>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13 , T14 , T15 , T16>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C12 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> , QStruct<T14 , T15 , T16>> SplitAt( Const13 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C13 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> , QStruct<T15 , T16>> SplitAt( Const14 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C14 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> , QStruct<T16>> SplitAt( Const15 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C15 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); func( Item16 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) , func( Item16 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;
		public T14 Item14;
		public T15 Item15;
		public T16 Item16;
		public T17 Item17;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) , T14 v14 = default( T14 ) , T15 v15 = default( T15 ) , T16 v16 = default( T16 ) , T17 v17 = default( T17 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; Item14 = v14; Item15 = v15; Item16 = v16; Item17 = v17; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() , Item14.GetHashCode() , Item15.GetHashCode() , Item16.GetHashCode() , Item17.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 ) && EqualityComparer<T14>.Default.Equals( Item14 , rhs.Item14 ) && EqualityComparer<T15>.Default.Equals( Item15 , rhs.Item15 ) && EqualityComparer<T16>.Default.Equals( Item16 , rhs.Item16 ) && EqualityComparer<T17>.Default.Equals( Item17 , rhs.Item17 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public T14 this[ Const14 _ ] { get => Item14; set => Item14 = value; }
		public T15 this[ Const15 _ ] { get => Item15; set => Item15 = value; }
		public T16 this[ Const16 _ ] { get => Item16; set => Item16 = value; }
		public T17 this[ Const17 _ ] { get => Item17; set => Item17 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , _T8 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7, _T8>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 , _T8 NItem8 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , NItem8 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );

		public QStruct<T1> PopBack( Const16 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const15 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const14 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const13 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T12 , T13 , T14 , T15 , T16 , T17> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T13 , T14 , T15 , T16 , T17> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T14 , T15 , T16 , T17> PopFront( Const13 _ ) =>
		MakeQStruct( Item14 , Item15 , Item16 , Item17 );
		public QStruct<T15 , T16 , T17> PopFront( Const14 _ ) =>
		MakeQStruct( Item15 , Item16 , Item17 );
		public QStruct<T16 , T17> PopFront( Const15 _ ) =>
		MakeQStruct( Item16 , Item17 );
		public QStruct<T17> PopFront( Const16 _ ) =>
		MakeQStruct( Item17 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C16 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C15 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C14 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C13 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13 , T14 , T15 , T16 , T17>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13 , T14 , T15 , T16 , T17>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C12 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> , QStruct<T14 , T15 , T16 , T17>> SplitAt( Const13 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C13 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> , QStruct<T15 , T16 , T17>> SplitAt( Const14 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C14 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> , QStruct<T16 , T17>> SplitAt( Const15 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C15 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> , QStruct<T17>> SplitAt( Const16 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C16 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); func( Item16 ); func( Item17 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) , func( Item16 ) , func( Item17 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;
		public T14 Item14;
		public T15 Item15;
		public T16 Item16;
		public T17 Item17;
		public T18 Item18;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) , T14 v14 = default( T14 ) , T15 v15 = default( T15 ) , T16 v16 = default( T16 ) , T17 v17 = default( T17 ) , T18 v18 = default( T18 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; Item14 = v14; Item15 = v15; Item16 = v16; Item17 = v17; Item18 = v18; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() , Item14.GetHashCode() , Item15.GetHashCode() , Item16.GetHashCode() , Item17.GetHashCode() , Item18.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 ) && EqualityComparer<T14>.Default.Equals( Item14 , rhs.Item14 ) && EqualityComparer<T15>.Default.Equals( Item15 , rhs.Item15 ) && EqualityComparer<T16>.Default.Equals( Item16 , rhs.Item16 ) && EqualityComparer<T17>.Default.Equals( Item17 , rhs.Item17 ) && EqualityComparer<T18>.Default.Equals( Item18 , rhs.Item18 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public T14 this[ Const14 _ ] { get => Item14; set => Item14 = value; }
		public T15 this[ Const15 _ ] { get => Item15; set => Item15 = value; }
		public T16 this[ Const16 _ ] { get => Item16; set => Item16 = value; }
		public T17 this[ Const17 _ ] { get => Item17; set => Item17 = value; }
		public T18 this[ Const18 _ ] { get => Item18; set => Item18 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7> PushBack<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , _T7 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PushFront<_T1, _T2, _T3, _T4, _T5, _T6, _T7>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 , _T7 NItem7 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , NItem7 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );

		public QStruct<T1> PopBack( Const17 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const16 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const15 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const14 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const13 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T13 , T14 , T15 , T16 , T17 , T18> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T14 , T15 , T16 , T17 , T18> PopFront( Const13 _ ) =>
		MakeQStruct( Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T15 , T16 , T17 , T18> PopFront( Const14 _ ) =>
		MakeQStruct( Item15 , Item16 , Item17 , Item18 );
		public QStruct<T16 , T17 , T18> PopFront( Const15 _ ) =>
		MakeQStruct( Item16 , Item17 , Item18 );
		public QStruct<T17 , T18> PopFront( Const16 _ ) =>
		MakeQStruct( Item17 , Item18 );
		public QStruct<T18> PopFront( Const17 _ ) =>
		MakeQStruct( Item18 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C17 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C16 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C15 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C14 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C13 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13 , T14 , T15 , T16 , T17 , T18>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C12 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> , QStruct<T14 , T15 , T16 , T17 , T18>> SplitAt( Const13 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C13 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> , QStruct<T15 , T16 , T17 , T18>> SplitAt( Const14 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C14 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> , QStruct<T16 , T17 , T18>> SplitAt( Const15 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C15 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> , QStruct<T17 , T18>> SplitAt( Const16 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C16 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> , QStruct<T18>> SplitAt( Const17 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C17 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); func( Item16 ); func( Item17 ); func( Item18 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) , func( Item16 ) , func( Item17 ) , func( Item18 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;
		public T14 Item14;
		public T15 Item15;
		public T16 Item16;
		public T17 Item17;
		public T18 Item18;
		public T19 Item19;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) , T14 v14 = default( T14 ) , T15 v15 = default( T15 ) , T16 v16 = default( T16 ) , T17 v17 = default( T17 ) , T18 v18 = default( T18 ) , T19 v19 = default( T19 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; Item14 = v14; Item15 = v15; Item16 = v16; Item17 = v17; Item18 = v18; Item19 = v19; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() , Item14.GetHashCode() , Item15.GetHashCode() , Item16.GetHashCode() , Item17.GetHashCode() , Item18.GetHashCode() , Item19.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 ) && EqualityComparer<T14>.Default.Equals( Item14 , rhs.Item14 ) && EqualityComparer<T15>.Default.Equals( Item15 , rhs.Item15 ) && EqualityComparer<T16>.Default.Equals( Item16 , rhs.Item16 ) && EqualityComparer<T17>.Default.Equals( Item17 , rhs.Item17 ) && EqualityComparer<T18>.Default.Equals( Item18 , rhs.Item18 ) && EqualityComparer<T19>.Default.Equals( Item19 , rhs.Item19 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public T14 this[ Const14 _ ] { get => Item14; set => Item14 = value; }
		public T15 this[ Const15 _ ] { get => Item15; set => Item15 = value; }
		public T16 this[ Const16 _ ] { get => Item16; set => Item16 = value; }
		public T17 this[ Const17 _ ] { get => Item17; set => Item17 = value; }
		public T18 this[ Const18 _ ] { get => Item18; set => Item18 = value; }
		public T19 this[ Const19 _ ] { get => Item19; set => Item19 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , _T1 , _T2 , _T3 , _T4 , _T5 , _T6> PushBack<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , _T6 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PushFront<_T1, _T2, _T3, _T4, _T5, _T6>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 , _T6 NItem6 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , NItem6 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );

		public QStruct<T1> PopBack( Const18 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const17 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const16 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const15 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const14 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const13 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T14 , T15 , T16 , T17 , T18 , T19> PopFront( Const13 _ ) =>
		MakeQStruct( Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T15 , T16 , T17 , T18 , T19> PopFront( Const14 _ ) =>
		MakeQStruct( Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T16 , T17 , T18 , T19> PopFront( Const15 _ ) =>
		MakeQStruct( Item16 , Item17 , Item18 , Item19 );
		public QStruct<T17 , T18 , T19> PopFront( Const16 _ ) =>
		MakeQStruct( Item17 , Item18 , Item19 );
		public QStruct<T18 , T19> PopFront( Const17 _ ) =>
		MakeQStruct( Item18 , Item19 );
		public QStruct<T19> PopFront( Const18 _ ) =>
		MakeQStruct( Item19 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C18 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C17 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C16 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C15 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C14 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C13 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C12 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> , QStruct<T14 , T15 , T16 , T17 , T18 , T19>> SplitAt( Const13 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C13 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> , QStruct<T15 , T16 , T17 , T18 , T19>> SplitAt( Const14 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C14 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> , QStruct<T16 , T17 , T18 , T19>> SplitAt( Const15 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C15 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> , QStruct<T17 , T18 , T19>> SplitAt( Const16 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C16 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> , QStruct<T18 , T19>> SplitAt( Const17 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C17 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> , QStruct<T19>> SplitAt( Const18 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C18 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); func( Item16 ); func( Item17 ); func( Item18 ); func( Item19 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) , func( Item16 ) , func( Item17 ) , func( Item18 ) , func( Item19 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;
		public T14 Item14;
		public T15 Item15;
		public T16 Item16;
		public T17 Item17;
		public T18 Item18;
		public T19 Item19;
		public T20 Item20;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) , T14 v14 = default( T14 ) , T15 v15 = default( T15 ) , T16 v16 = default( T16 ) , T17 v17 = default( T17 ) , T18 v18 = default( T18 ) , T19 v19 = default( T19 ) , T20 v20 = default( T20 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; Item14 = v14; Item15 = v15; Item16 = v16; Item17 = v17; Item18 = v18; Item19 = v19; Item20 = v20; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() , Item14.GetHashCode() , Item15.GetHashCode() , Item16.GetHashCode() , Item17.GetHashCode() , Item18.GetHashCode() , Item19.GetHashCode() , Item20.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 ) && EqualityComparer<T14>.Default.Equals( Item14 , rhs.Item14 ) && EqualityComparer<T15>.Default.Equals( Item15 , rhs.Item15 ) && EqualityComparer<T16>.Default.Equals( Item16 , rhs.Item16 ) && EqualityComparer<T17>.Default.Equals( Item17 , rhs.Item17 ) && EqualityComparer<T18>.Default.Equals( Item18 , rhs.Item18 ) && EqualityComparer<T19>.Default.Equals( Item19 , rhs.Item19 ) && EqualityComparer<T20>.Default.Equals( Item20 , rhs.Item20 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public T14 this[ Const14 _ ] { get => Item14; set => Item14 = value; }
		public T15 this[ Const15 _ ] { get => Item15; set => Item15 = value; }
		public T16 this[ Const16 _ ] { get => Item16; set => Item16 = value; }
		public T17 this[ Const17 _ ] { get => Item17; set => Item17 = value; }
		public T18 this[ Const18 _ ] { get => Item18; set => Item18 = value; }
		public T19 this[ Const19 _ ] { get => Item19; set => Item19 = value; }
		public T20 this[ Const20 _ ] { get => Item20; set => Item20 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , NItem1 , NItem2 , NItem3 , NItem4 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , _T1 , _T2 , _T3 , _T4 , _T5> PushBack<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , NItem1 , NItem2 , NItem3 , NItem4 , NItem5 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , _T5 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PushFront<_T1, _T2, _T3, _T4, _T5>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 , _T5 NItem5 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , NItem5 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );

		public QStruct<T1> PopBack( Const19 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const18 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const17 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const16 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const15 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const14 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const13 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T14 , T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const13 _ ) =>
		MakeQStruct( Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T15 , T16 , T17 , T18 , T19 , T20> PopFront( Const14 _ ) =>
		MakeQStruct( Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T16 , T17 , T18 , T19 , T20> PopFront( Const15 _ ) =>
		MakeQStruct( Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T17 , T18 , T19 , T20> PopFront( Const16 _ ) =>
		MakeQStruct( Item17 , Item18 , Item19 , Item20 );
		public QStruct<T18 , T19 , T20> PopFront( Const17 _ ) =>
		MakeQStruct( Item18 , Item19 , Item20 );
		public QStruct<T19 , T20> PopFront( Const18 _ ) =>
		MakeQStruct( Item19 , Item20 );
		public QStruct<T20> PopFront( Const19 _ ) =>
		MakeQStruct( Item20 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C19 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C18 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C17 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C16 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C15 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C14 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C13 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C12 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> , QStruct<T14 , T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const13 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C13 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> , QStruct<T15 , T16 , T17 , T18 , T19 , T20>> SplitAt( Const14 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C14 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> , QStruct<T16 , T17 , T18 , T19 , T20>> SplitAt( Const15 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C15 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> , QStruct<T17 , T18 , T19 , T20>> SplitAt( Const16 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C16 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> , QStruct<T18 , T19 , T20>> SplitAt( Const17 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C17 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> , QStruct<T19 , T20>> SplitAt( Const18 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C18 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> , QStruct<T20>> SplitAt( Const19 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C19 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); func( Item16 ); func( Item17 ); func( Item18 ); func( Item19 ); func( Item20 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) , func( Item16 ) , func( Item17 ) , func( Item18 ) , func( Item19 ) , func( Item20 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;
		public T14 Item14;
		public T15 Item15;
		public T16 Item16;
		public T17 Item17;
		public T18 Item18;
		public T19 Item19;
		public T20 Item20;
		public T21 Item21;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) , T14 v14 = default( T14 ) , T15 v15 = default( T15 ) , T16 v16 = default( T16 ) , T17 v17 = default( T17 ) , T18 v18 = default( T18 ) , T19 v19 = default( T19 ) , T20 v20 = default( T20 ) , T21 v21 = default( T21 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; Item14 = v14; Item15 = v15; Item16 = v16; Item17 = v17; Item18 = v18; Item19 = v19; Item20 = v20; Item21 = v21; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() , Item14.GetHashCode() , Item15.GetHashCode() , Item16.GetHashCode() , Item17.GetHashCode() , Item18.GetHashCode() , Item19.GetHashCode() , Item20.GetHashCode() , Item21.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 ) && EqualityComparer<T14>.Default.Equals( Item14 , rhs.Item14 ) && EqualityComparer<T15>.Default.Equals( Item15 , rhs.Item15 ) && EqualityComparer<T16>.Default.Equals( Item16 , rhs.Item16 ) && EqualityComparer<T17>.Default.Equals( Item17 , rhs.Item17 ) && EqualityComparer<T18>.Default.Equals( Item18 , rhs.Item18 ) && EqualityComparer<T19>.Default.Equals( Item19 , rhs.Item19 ) && EqualityComparer<T20>.Default.Equals( Item20 , rhs.Item20 ) && EqualityComparer<T21>.Default.Equals( Item21 , rhs.Item21 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public T14 this[ Const14 _ ] { get => Item14; set => Item14 = value; }
		public T15 this[ Const15 _ ] { get => Item15; set => Item15 = value; }
		public T16 this[ Const16 _ ] { get => Item16; set => Item16 = value; }
		public T17 this[ Const17 _ ] { get => Item17; set => Item17 = value; }
		public T18 this[ Const18 _ ] { get => Item18; set => Item18 = value; }
		public T19 this[ Const19 _ ] { get => Item19; set => Item19 = value; }
		public T20 this[ Const20 _ ] { get => Item20; set => Item20 = value; }
		public T21 this[ Const21 _ ] { get => Item21; set => Item21 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , NItem1 , NItem2 , NItem3 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , _T1 , _T2 , _T3 , _T4> PushBack<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , NItem1 , NItem2 , NItem3 , NItem4 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );

		public QStruct<T1> PopBack( Const20 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const19 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const18 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const17 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const16 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const15 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const14 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const13 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const13 _ ) =>
		MakeQStruct( Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T15 , T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const14 _ ) =>
		MakeQStruct( Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T16 , T17 , T18 , T19 , T20 , T21> PopFront( Const15 _ ) =>
		MakeQStruct( Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T17 , T18 , T19 , T20 , T21> PopFront( Const16 _ ) =>
		MakeQStruct( Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T18 , T19 , T20 , T21> PopFront( Const17 _ ) =>
		MakeQStruct( Item18 , Item19 , Item20 , Item21 );
		public QStruct<T19 , T20 , T21> PopFront( Const18 _ ) =>
		MakeQStruct( Item19 , Item20 , Item21 );
		public QStruct<T20 , T21> PopFront( Const19 _ ) =>
		MakeQStruct( Item20 , Item21 );
		public QStruct<T21> PopFront( Const20 _ ) =>
		MakeQStruct( Item21 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C20 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C19 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C18 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C17 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C16 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C15 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C14 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C13 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C12 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> , QStruct<T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const13 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C13 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> , QStruct<T15 , T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const14 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C14 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> , QStruct<T16 , T17 , T18 , T19 , T20 , T21>> SplitAt( Const15 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C15 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> , QStruct<T17 , T18 , T19 , T20 , T21>> SplitAt( Const16 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C16 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> , QStruct<T18 , T19 , T20 , T21>> SplitAt( Const17 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C17 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> , QStruct<T19 , T20 , T21>> SplitAt( Const18 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C18 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> , QStruct<T20 , T21>> SplitAt( Const19 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C19 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> , QStruct<T21>> SplitAt( Const20 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C20 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); func( Item16 ); func( Item17 ); func( Item18 ); func( Item19 ); func( Item20 ); func( Item21 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) , func( Item16 ) , func( Item17 ) , func( Item18 ) , func( Item19 ) , func( Item20 ) , func( Item21 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;
		public T14 Item14;
		public T15 Item15;
		public T16 Item16;
		public T17 Item17;
		public T18 Item18;
		public T19 Item19;
		public T20 Item20;
		public T21 Item21;
		public T22 Item22;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) , T14 v14 = default( T14 ) , T15 v15 = default( T15 ) , T16 v16 = default( T16 ) , T17 v17 = default( T17 ) , T18 v18 = default( T18 ) , T19 v19 = default( T19 ) , T20 v20 = default( T20 ) , T21 v21 = default( T21 ) , T22 v22 = default( T22 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; Item14 = v14; Item15 = v15; Item16 = v16; Item17 = v17; Item18 = v18; Item19 = v19; Item20 = v20; Item21 = v21; Item22 = v22; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() , Item14.GetHashCode() , Item15.GetHashCode() , Item16.GetHashCode() , Item17.GetHashCode() , Item18.GetHashCode() , Item19.GetHashCode() , Item20.GetHashCode() , Item21.GetHashCode() , Item22.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 ) && EqualityComparer<T14>.Default.Equals( Item14 , rhs.Item14 ) && EqualityComparer<T15>.Default.Equals( Item15 , rhs.Item15 ) && EqualityComparer<T16>.Default.Equals( Item16 , rhs.Item16 ) && EqualityComparer<T17>.Default.Equals( Item17 , rhs.Item17 ) && EqualityComparer<T18>.Default.Equals( Item18 , rhs.Item18 ) && EqualityComparer<T19>.Default.Equals( Item19 , rhs.Item19 ) && EqualityComparer<T20>.Default.Equals( Item20 , rhs.Item20 ) && EqualityComparer<T21>.Default.Equals( Item21 , rhs.Item21 ) && EqualityComparer<T22>.Default.Equals( Item22 , rhs.Item22 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public T14 this[ Const14 _ ] { get => Item14; set => Item14 = value; }
		public T15 this[ Const15 _ ] { get => Item15; set => Item15 = value; }
		public T16 this[ Const16 _ ] { get => Item16; set => Item16 = value; }
		public T17 this[ Const17 _ ] { get => Item17; set => Item17 = value; }
		public T18 this[ Const18 _ ] { get => Item18; set => Item18 = value; }
		public T19 this[ Const19 _ ] { get => Item19; set => Item19 = value; }
		public T20 this[ Const20 _ ] { get => Item20; set => Item20 = value; }
		public T21 this[ Const21 _ ] { get => Item21; set => Item21 = value; }
		public T22 this[ Const22 _ ] { get => Item22; set => Item22 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , NItem1 , NItem2 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , _T1 , _T2 , _T3> PushBack<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , NItem1 , NItem2 , NItem3 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );

		public QStruct<T1> PopBack( Const21 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const20 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const19 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const18 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const17 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const16 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const15 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const14 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const13 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const13 _ ) =>
		MakeQStruct( Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const14 _ ) =>
		MakeQStruct( Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T16 , T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const15 _ ) =>
		MakeQStruct( Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T17 , T18 , T19 , T20 , T21 , T22> PopFront( Const16 _ ) =>
		MakeQStruct( Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T18 , T19 , T20 , T21 , T22> PopFront( Const17 _ ) =>
		MakeQStruct( Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T19 , T20 , T21 , T22> PopFront( Const18 _ ) =>
		MakeQStruct( Item19 , Item20 , Item21 , Item22 );
		public QStruct<T20 , T21 , T22> PopFront( Const19 _ ) =>
		MakeQStruct( Item20 , Item21 , Item22 );
		public QStruct<T21 , T22> PopFront( Const20 _ ) =>
		MakeQStruct( Item21 , Item22 );
		public QStruct<T22> PopFront( Const21 _ ) =>
		MakeQStruct( Item22 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C21 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C20 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C19 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C18 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C17 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C16 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C15 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C14 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C13 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C12 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> , QStruct<T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const13 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C13 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> , QStruct<T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const14 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C14 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> , QStruct<T16 , T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const15 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C15 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> , QStruct<T17 , T18 , T19 , T20 , T21 , T22>> SplitAt( Const16 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C16 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> , QStruct<T18 , T19 , T20 , T21 , T22>> SplitAt( Const17 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C17 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> , QStruct<T19 , T20 , T21 , T22>> SplitAt( Const18 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C18 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> , QStruct<T20 , T21 , T22>> SplitAt( Const19 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C19 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> , QStruct<T21 , T22>> SplitAt( Const20 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C20 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> , QStruct<T22>> SplitAt( Const21 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C21 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); func( Item16 ); func( Item17 ); func( Item18 ); func( Item19 ); func( Item20 ); func( Item21 ); func( Item22 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) , func( Item16 ) , func( Item17 ) , func( Item18 ) , func( Item19 ) , func( Item20 ) , func( Item21 ) , func( Item22 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;
		public T14 Item14;
		public T15 Item15;
		public T16 Item16;
		public T17 Item17;
		public T18 Item18;
		public T19 Item19;
		public T20 Item20;
		public T21 Item21;
		public T22 Item22;
		public T23 Item23;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) , T14 v14 = default( T14 ) , T15 v15 = default( T15 ) , T16 v16 = default( T16 ) , T17 v17 = default( T17 ) , T18 v18 = default( T18 ) , T19 v19 = default( T19 ) , T20 v20 = default( T20 ) , T21 v21 = default( T21 ) , T22 v22 = default( T22 ) , T23 v23 = default( T23 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; Item14 = v14; Item15 = v15; Item16 = v16; Item17 = v17; Item18 = v18; Item19 = v19; Item20 = v20; Item21 = v21; Item22 = v22; Item23 = v23; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() , Item14.GetHashCode() , Item15.GetHashCode() , Item16.GetHashCode() , Item17.GetHashCode() , Item18.GetHashCode() , Item19.GetHashCode() , Item20.GetHashCode() , Item21.GetHashCode() , Item22.GetHashCode() , Item23.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 ) && EqualityComparer<T14>.Default.Equals( Item14 , rhs.Item14 ) && EqualityComparer<T15>.Default.Equals( Item15 , rhs.Item15 ) && EqualityComparer<T16>.Default.Equals( Item16 , rhs.Item16 ) && EqualityComparer<T17>.Default.Equals( Item17 , rhs.Item17 ) && EqualityComparer<T18>.Default.Equals( Item18 , rhs.Item18 ) && EqualityComparer<T19>.Default.Equals( Item19 , rhs.Item19 ) && EqualityComparer<T20>.Default.Equals( Item20 , rhs.Item20 ) && EqualityComparer<T21>.Default.Equals( Item21 , rhs.Item21 ) && EqualityComparer<T22>.Default.Equals( Item22 , rhs.Item22 ) && EqualityComparer<T23>.Default.Equals( Item23 , rhs.Item23 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public T14 this[ Const14 _ ] { get => Item14; set => Item14 = value; }
		public T15 this[ Const15 _ ] { get => Item15; set => Item15 = value; }
		public T16 this[ Const16 _ ] { get => Item16; set => Item16 = value; }
		public T17 this[ Const17 _ ] { get => Item17; set => Item17 = value; }
		public T18 this[ Const18 _ ] { get => Item18; set => Item18 = value; }
		public T19 this[ Const19 _ ] { get => Item19; set => Item19 = value; }
		public T20 this[ Const20 _ ] { get => Item20; set => Item20 = value; }
		public T21 this[ Const21 _ ] { get => Item21; set => Item21 = value; }
		public T22 this[ Const22 _ ] { get => Item22; set => Item22 = value; }
		public T23 this[ Const23 _ ] { get => Item23; set => Item23 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , NItem1 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , _T1 , _T2> PushBack<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , NItem1 , NItem2 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );

		public QStruct<T1> PopBack( Const22 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const21 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const20 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const19 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const18 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const17 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const16 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const15 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const14 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const13 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const13 _ ) =>
		MakeQStruct( Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const14 _ ) =>
		MakeQStruct( Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const15 _ ) =>
		MakeQStruct( Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T17 , T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const16 _ ) =>
		MakeQStruct( Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T18 , T19 , T20 , T21 , T22 , T23> PopFront( Const17 _ ) =>
		MakeQStruct( Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T19 , T20 , T21 , T22 , T23> PopFront( Const18 _ ) =>
		MakeQStruct( Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T20 , T21 , T22 , T23> PopFront( Const19 _ ) =>
		MakeQStruct( Item20 , Item21 , Item22 , Item23 );
		public QStruct<T21 , T22 , T23> PopFront( Const20 _ ) =>
		MakeQStruct( Item21 , Item22 , Item23 );
		public QStruct<T22 , T23> PopFront( Const21 _ ) =>
		MakeQStruct( Item22 , Item23 );
		public QStruct<T23> PopFront( Const22 _ ) =>
		MakeQStruct( Item23 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C22 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C21 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C20 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C19 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C18 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C17 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C16 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C15 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C14 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C13 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C12 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> , QStruct<T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const13 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C13 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> , QStruct<T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const14 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C14 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> , QStruct<T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const15 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C15 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> , QStruct<T17 , T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const16 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C16 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> , QStruct<T18 , T19 , T20 , T21 , T22 , T23>> SplitAt( Const17 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C17 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> , QStruct<T19 , T20 , T21 , T22 , T23>> SplitAt( Const18 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C18 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> , QStruct<T20 , T21 , T22 , T23>> SplitAt( Const19 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C19 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> , QStruct<T21 , T22 , T23>> SplitAt( Const20 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C20 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> , QStruct<T22 , T23>> SplitAt( Const21 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C21 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> , QStruct<T23>> SplitAt( Const22 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C22 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); func( Item16 ); func( Item17 ); func( Item18 ); func( Item19 ); func( Item20 ); func( Item21 ); func( Item22 ); func( Item23 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) , func( Item16 ) , func( Item17 ) , func( Item18 ) , func( Item19 ) , func( Item20 ) , func( Item21 ) , func( Item22 ) , func( Item23 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;
		public T14 Item14;
		public T15 Item15;
		public T16 Item16;
		public T17 Item17;
		public T18 Item18;
		public T19 Item19;
		public T20 Item20;
		public T21 Item21;
		public T22 Item22;
		public T23 Item23;
		public T24 Item24;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) , T14 v14 = default( T14 ) , T15 v15 = default( T15 ) , T16 v16 = default( T16 ) , T17 v17 = default( T17 ) , T18 v18 = default( T18 ) , T19 v19 = default( T19 ) , T20 v20 = default( T20 ) , T21 v21 = default( T21 ) , T22 v22 = default( T22 ) , T23 v23 = default( T23 ) , T24 v24 = default( T24 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; Item14 = v14; Item15 = v15; Item16 = v16; Item17 = v17; Item18 = v18; Item19 = v19; Item20 = v20; Item21 = v21; Item22 = v22; Item23 = v23; Item24 = v24; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() , Item14.GetHashCode() , Item15.GetHashCode() , Item16.GetHashCode() , Item17.GetHashCode() , Item18.GetHashCode() , Item19.GetHashCode() , Item20.GetHashCode() , Item21.GetHashCode() , Item22.GetHashCode() , Item23.GetHashCode() , Item24.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 ) && EqualityComparer<T14>.Default.Equals( Item14 , rhs.Item14 ) && EqualityComparer<T15>.Default.Equals( Item15 , rhs.Item15 ) && EqualityComparer<T16>.Default.Equals( Item16 , rhs.Item16 ) && EqualityComparer<T17>.Default.Equals( Item17 , rhs.Item17 ) && EqualityComparer<T18>.Default.Equals( Item18 , rhs.Item18 ) && EqualityComparer<T19>.Default.Equals( Item19 , rhs.Item19 ) && EqualityComparer<T20>.Default.Equals( Item20 , rhs.Item20 ) && EqualityComparer<T21>.Default.Equals( Item21 , rhs.Item21 ) && EqualityComparer<T22>.Default.Equals( Item22 , rhs.Item22 ) && EqualityComparer<T23>.Default.Equals( Item23 , rhs.Item23 ) && EqualityComparer<T24>.Default.Equals( Item24 , rhs.Item24 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public T14 this[ Const14 _ ] { get => Item14; set => Item14 = value; }
		public T15 this[ Const15 _ ] { get => Item15; set => Item15 = value; }
		public T16 this[ Const16 _ ] { get => Item16; set => Item16 = value; }
		public T17 this[ Const17 _ ] { get => Item17; set => Item17 = value; }
		public T18 this[ Const18 _ ] { get => Item18; set => Item18 = value; }
		public T19 this[ Const19 _ ] { get => Item19; set => Item19 = value; }
		public T20 this[ Const20 _ ] { get => Item20; set => Item20 = value; }
		public T21 this[ Const21 _ ] { get => Item21; set => Item21 = value; }
		public T22 this[ Const22 _ ] { get => Item22; set => Item22 = value; }
		public T23 this[ Const23 _ ] { get => Item23; set => Item23 = value; }
		public T24 this[ Const24 _ ] { get => Item24; set => Item24 = value; }
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , _T1> PushBack<_T1>( _T1 NItem1 ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , NItem1 );

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );

		public QStruct<T1> PopBack( Const23 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const22 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const21 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const20 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const19 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const18 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const17 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const16 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const15 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const14 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const13 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const13 _ ) =>
		MakeQStruct( Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const14 _ ) =>
		MakeQStruct( Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const15 _ ) =>
		MakeQStruct( Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const16 _ ) =>
		MakeQStruct( Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T18 , T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const17 _ ) =>
		MakeQStruct( Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T19 , T20 , T21 , T22 , T23 , T24> PopFront( Const18 _ ) =>
		MakeQStruct( Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T20 , T21 , T22 , T23 , T24> PopFront( Const19 _ ) =>
		MakeQStruct( Item20 , Item21 , Item22 , Item23 , Item24 );
		public QStruct<T21 , T22 , T23 , T24> PopFront( Const20 _ ) =>
		MakeQStruct( Item21 , Item22 , Item23 , Item24 );
		public QStruct<T22 , T23 , T24> PopFront( Const21 _ ) =>
		MakeQStruct( Item22 , Item23 , Item24 );
		public QStruct<T23 , T24> PopFront( Const22 _ ) =>
		MakeQStruct( Item23 , Item24 );
		public QStruct<T24> PopFront( Const23 _ ) =>
		MakeQStruct( Item24 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C23 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C22 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C21 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C20 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C19 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C18 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C17 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C16 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C15 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C14 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C13 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C12 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> , QStruct<T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const13 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C13 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> , QStruct<T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const14 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C14 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> , QStruct<T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const15 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C15 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> , QStruct<T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const16 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C16 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> , QStruct<T18 , T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const17 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C17 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> , QStruct<T19 , T20 , T21 , T22 , T23 , T24>> SplitAt( Const18 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C18 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> , QStruct<T20 , T21 , T22 , T23 , T24>> SplitAt( Const19 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C19 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> , QStruct<T21 , T22 , T23 , T24>> SplitAt( Const20 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C20 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> , QStruct<T22 , T23 , T24>> SplitAt( Const21 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C21 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> , QStruct<T23 , T24>> SplitAt( Const22 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C22 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> , QStruct<T24>> SplitAt( Const23 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C23 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); func( Item16 ); func( Item17 ); func( Item18 ); func( Item19 ); func( Item20 ); func( Item21 ); func( Item22 ); func( Item23 ); func( Item24 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) , func( Item16 ) , func( Item17 ) , func( Item18 ) , func( Item19 ) , func( Item20 ) , func( Item21 ) , func( Item22 ) , func( Item23 ) , func( Item24 ) );

	}


	public struct QStruct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> : IEquatable<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>>
	{

		public T1 Item1;
		public T2 Item2;
		public T3 Item3;
		public T4 Item4;
		public T5 Item5;
		public T6 Item6;
		public T7 Item7;
		public T8 Item8;
		public T9 Item9;
		public T10 Item10;
		public T11 Item11;
		public T12 Item12;
		public T13 Item13;
		public T14 Item14;
		public T15 Item15;
		public T16 Item16;
		public T17 Item17;
		public T18 Item18;
		public T19 Item19;
		public T20 Item20;
		public T21 Item21;
		public T22 Item22;
		public T23 Item23;
		public T24 Item24;
		public T25 Item25;

		public QStruct( T1 v1 = default( T1 ) , T2 v2 = default( T2 ) , T3 v3 = default( T3 ) , T4 v4 = default( T4 ) , T5 v5 = default( T5 ) , T6 v6 = default( T6 ) , T7 v7 = default( T7 ) , T8 v8 = default( T8 ) , T9 v9 = default( T9 ) , T10 v10 = default( T10 ) , T11 v11 = default( T11 ) , T12 v12 = default( T12 ) , T13 v13 = default( T13 ) , T14 v14 = default( T14 ) , T15 v15 = default( T15 ) , T16 v16 = default( T16 ) , T17 v17 = default( T17 ) , T18 v18 = default( T18 ) , T19 v19 = default( T19 ) , T20 v20 = default( T20 ) , T21 v21 = default( T21 ) , T22 v22 = default( T22 ) , T23 v23 = default( T23 ) , T24 v24 = default( T24 ) , T25 v25 = default( T25 ) )
		{ Item1 = v1; Item2 = v2; Item3 = v3; Item4 = v4; Item5 = v5; Item6 = v6; Item7 = v7; Item8 = v8; Item9 = v9; Item10 = v10; Item11 = v11; Item12 = v12; Item13 = v13; Item14 = v14; Item15 = v15; Item16 = v16; Item17 = v17; Item18 = v18; Item19 = v19; Item20 = v20; Item21 = v21; Item22 = v22; Item23 = v23; Item24 = v24; Item25 = v25; }

		public override int GetHashCode( ) => CombineHashCodes( Item1.GetHashCode() , Item2.GetHashCode() , Item3.GetHashCode() , Item4.GetHashCode() , Item5.GetHashCode() , Item6.GetHashCode() , Item7.GetHashCode() , Item8.GetHashCode() , Item9.GetHashCode() , Item10.GetHashCode() , Item11.GetHashCode() , Item12.GetHashCode() , Item13.GetHashCode() , Item14.GetHashCode() , Item15.GetHashCode() , Item16.GetHashCode() , Item17.GetHashCode() , Item18.GetHashCode() , Item19.GetHashCode() , Item20.GetHashCode() , Item21.GetHashCode() , Item22.GetHashCode() , Item23.GetHashCode() , Item24.GetHashCode() , Item25.GetHashCode() );

		public override bool Equals( object obj ) => obj is QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> && Equals( ( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> ) obj );
		public bool Equals( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 ) && EqualityComparer<T2>.Default.Equals( Item2 , rhs.Item2 ) && EqualityComparer<T3>.Default.Equals( Item3 , rhs.Item3 ) && EqualityComparer<T4>.Default.Equals( Item4 , rhs.Item4 ) && EqualityComparer<T5>.Default.Equals( Item5 , rhs.Item5 ) && EqualityComparer<T6>.Default.Equals( Item6 , rhs.Item6 ) && EqualityComparer<T7>.Default.Equals( Item7 , rhs.Item7 ) && EqualityComparer<T8>.Default.Equals( Item8 , rhs.Item8 ) && EqualityComparer<T9>.Default.Equals( Item9 , rhs.Item9 ) && EqualityComparer<T10>.Default.Equals( Item10 , rhs.Item10 ) && EqualityComparer<T11>.Default.Equals( Item11 , rhs.Item11 ) && EqualityComparer<T12>.Default.Equals( Item12 , rhs.Item12 ) && EqualityComparer<T13>.Default.Equals( Item13 , rhs.Item13 ) && EqualityComparer<T14>.Default.Equals( Item14 , rhs.Item14 ) && EqualityComparer<T15>.Default.Equals( Item15 , rhs.Item15 ) && EqualityComparer<T16>.Default.Equals( Item16 , rhs.Item16 ) && EqualityComparer<T17>.Default.Equals( Item17 , rhs.Item17 ) && EqualityComparer<T18>.Default.Equals( Item18 , rhs.Item18 ) && EqualityComparer<T19>.Default.Equals( Item19 , rhs.Item19 ) && EqualityComparer<T20>.Default.Equals( Item20 , rhs.Item20 ) && EqualityComparer<T21>.Default.Equals( Item21 , rhs.Item21 ) && EqualityComparer<T22>.Default.Equals( Item22 , rhs.Item22 ) && EqualityComparer<T23>.Default.Equals( Item23 , rhs.Item23 ) && EqualityComparer<T24>.Default.Equals( Item24 , rhs.Item24 ) && EqualityComparer<T25>.Default.Equals( Item25 , rhs.Item25 );

		public static bool operator ==( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> rhs ) => lhs.Equals( rhs );
		public static bool operator !=( QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> lhs , QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> rhs ) => !( lhs == rhs );


		public T1 this[ Const1 _ ] { get => Item1; set => Item1 = value; }
		public T2 this[ Const2 _ ] { get => Item2; set => Item2 = value; }
		public T3 this[ Const3 _ ] { get => Item3; set => Item3 = value; }
		public T4 this[ Const4 _ ] { get => Item4; set => Item4 = value; }
		public T5 this[ Const5 _ ] { get => Item5; set => Item5 = value; }
		public T6 this[ Const6 _ ] { get => Item6; set => Item6 = value; }
		public T7 this[ Const7 _ ] { get => Item7; set => Item7 = value; }
		public T8 this[ Const8 _ ] { get => Item8; set => Item8 = value; }
		public T9 this[ Const9 _ ] { get => Item9; set => Item9 = value; }
		public T10 this[ Const10 _ ] { get => Item10; set => Item10 = value; }
		public T11 this[ Const11 _ ] { get => Item11; set => Item11 = value; }
		public T12 this[ Const12 _ ] { get => Item12; set => Item12 = value; }
		public T13 this[ Const13 _ ] { get => Item13; set => Item13 = value; }
		public T14 this[ Const14 _ ] { get => Item14; set => Item14 = value; }
		public T15 this[ Const15 _ ] { get => Item15; set => Item15 = value; }
		public T16 this[ Const16 _ ] { get => Item16; set => Item16 = value; }
		public T17 this[ Const17 _ ] { get => Item17; set => Item17 = value; }
		public T18 this[ Const18 _ ] { get => Item18; set => Item18 = value; }
		public T19 this[ Const19 _ ] { get => Item19; set => Item19 = value; }
		public T20 this[ Const20 _ ] { get => Item20; set => Item20 = value; }
		public T21 this[ Const21 _ ] { get => Item21; set => Item21 = value; }
		public T22 this[ Const22 _ ] { get => Item22; set => Item22 = value; }
		public T23 this[ Const23 _ ] { get => Item23; set => Item23 = value; }
		public T24 this[ Const24 _ ] { get => Item24; set => Item24 = value; }
		public T25 this[ Const25 _ ] { get => Item25; set => Item25 = value; }


		public QStruct<T1> PopBack( Const24 _ ) =>
		MakeQStruct( Item1 );
		public QStruct<T1 , T2> PopBack( Const23 _ ) =>
		MakeQStruct( Item1 , Item2 );
		public QStruct<T1 , T2 , T3> PopBack( Const22 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 );
		public QStruct<T1 , T2 , T3 , T4> PopBack( Const21 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 );
		public QStruct<T1 , T2 , T3 , T4 , T5> PopBack( Const20 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6> PopBack( Const19 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> PopBack( Const18 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> PopBack( Const17 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> PopBack( Const16 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> PopBack( Const15 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PopBack( Const14 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PopBack( Const13 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PopBack( Const12 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PopBack( Const11 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> PopBack( Const10 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> PopBack( Const9 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> PopBack( Const8 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> PopBack( Const7 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> PopBack( Const6 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> PopBack( Const5 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> PopBack( Const4 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> PopBack( Const3 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> PopBack( Const2 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 );
		public QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> PopBack( Const1 _ ) =>
		MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 );

		public QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const1 _ ) =>
		MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const2 _ ) =>
		MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const3 _ ) =>
		MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const4 _ ) =>
		MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const5 _ ) =>
		MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const6 _ ) =>
		MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const7 _ ) =>
		MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const8 _ ) =>
		MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const9 _ ) =>
		MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const10 _ ) =>
		MakeQStruct( Item11 , Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const11 _ ) =>
		MakeQStruct( Item12 , Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const12 _ ) =>
		MakeQStruct( Item13 , Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const13 _ ) =>
		MakeQStruct( Item14 , Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const14 _ ) =>
		MakeQStruct( Item15 , Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const15 _ ) =>
		MakeQStruct( Item16 , Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const16 _ ) =>
		MakeQStruct( Item17 , Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const17 _ ) =>
		MakeQStruct( Item18 , Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T19 , T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const18 _ ) =>
		MakeQStruct( Item19 , Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T20 , T21 , T22 , T23 , T24 , T25> PopFront( Const19 _ ) =>
		MakeQStruct( Item20 , Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T21 , T22 , T23 , T24 , T25> PopFront( Const20 _ ) =>
		MakeQStruct( Item21 , Item22 , Item23 , Item24 , Item25 );
		public QStruct<T22 , T23 , T24 , T25> PopFront( Const21 _ ) =>
		MakeQStruct( Item22 , Item23 , Item24 , Item25 );
		public QStruct<T23 , T24 , T25> PopFront( Const22 _ ) =>
		MakeQStruct( Item23 , Item24 , Item25 );
		public QStruct<T24 , T25> PopFront( Const23 _ ) =>
		MakeQStruct( Item24 , Item25 );
		public QStruct<T25> PopFront( Const24 _ ) =>
		MakeQStruct( Item25 );

		public QStruct<QStruct<T1> , QStruct<T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const1 _ ) => MakeQStruct( PopBack( C24 ) , PopFront( C1 ) );
		public QStruct<QStruct<T1 , T2> , QStruct<T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const2 _ ) => MakeQStruct( PopBack( C23 ) , PopFront( C2 ) );
		public QStruct<QStruct<T1 , T2 , T3> , QStruct<T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const3 _ ) => MakeQStruct( PopBack( C22 ) , PopFront( C3 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4> , QStruct<T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const4 _ ) => MakeQStruct( PopBack( C21 ) , PopFront( C4 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5> , QStruct<T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const5 _ ) => MakeQStruct( PopBack( C20 ) , PopFront( C5 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6> , QStruct<T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const6 _ ) => MakeQStruct( PopBack( C19 ) , PopFront( C6 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7> , QStruct<T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const7 _ ) => MakeQStruct( PopBack( C18 ) , PopFront( C7 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8> , QStruct<T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const8 _ ) => MakeQStruct( PopBack( C17 ) , PopFront( C8 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9> , QStruct<T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const9 _ ) => MakeQStruct( PopBack( C16 ) , PopFront( C9 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10> , QStruct<T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const10 _ ) => MakeQStruct( PopBack( C15 ) , PopFront( C10 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> , QStruct<T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const11 _ ) => MakeQStruct( PopBack( C14 ) , PopFront( C11 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> , QStruct<T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const12 _ ) => MakeQStruct( PopBack( C13 ) , PopFront( C12 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> , QStruct<T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const13 _ ) => MakeQStruct( PopBack( C12 ) , PopFront( C13 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> , QStruct<T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const14 _ ) => MakeQStruct( PopBack( C11 ) , PopFront( C14 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15> , QStruct<T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const15 _ ) => MakeQStruct( PopBack( C10 ) , PopFront( C15 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16> , QStruct<T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const16 _ ) => MakeQStruct( PopBack( C9 ) , PopFront( C16 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17> , QStruct<T18 , T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const17 _ ) => MakeQStruct( PopBack( C8 ) , PopFront( C17 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18> , QStruct<T19 , T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const18 _ ) => MakeQStruct( PopBack( C7 ) , PopFront( C18 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19> , QStruct<T20 , T21 , T22 , T23 , T24 , T25>> SplitAt( Const19 _ ) => MakeQStruct( PopBack( C6 ) , PopFront( C19 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20> , QStruct<T21 , T22 , T23 , T24 , T25>> SplitAt( Const20 _ ) => MakeQStruct( PopBack( C5 ) , PopFront( C20 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21> , QStruct<T22 , T23 , T24 , T25>> SplitAt( Const21 _ ) => MakeQStruct( PopBack( C4 ) , PopFront( C21 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22> , QStruct<T23 , T24 , T25>> SplitAt( Const22 _ ) => MakeQStruct( PopBack( C3 ) , PopFront( C22 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23> , QStruct<T24 , T25>> SplitAt( Const23 _ ) => MakeQStruct( PopBack( C2 ) , PopFront( C23 ) );
		public QStruct<QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15 , T16 , T17 , T18 , T19 , T20 , T21 , T22 , T23 , T24> , QStruct<T25>> SplitAt( Const24 _ ) => MakeQStruct( PopBack( C1 ) , PopFront( C24 ) );

		public void ForEach( VoidFunction<dynamic> func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); func( Item16 ); func( Item17 ); func( Item18 ); func( Item19 ); func( Item20 ); func( Item21 ); func( Item22 ); func( Item23 ); func( Item24 ); func( Item25 ); }

		public QStruct<dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic , dynamic> ForEachGetResult( Function<dynamic , dynamic> func ) => MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) , func( Item16 ) , func( Item17 ) , func( Item18 ) , func( Item19 ) , func( Item20 ) , func( Item21 ) , func( Item22 ) , func( Item23 ) , func( Item24 ) , func( Item25 ) );

	}


	#endregion
}