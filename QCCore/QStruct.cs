
using System;
using System.Collections.Generic;
using static QCCore.MainCls;

namespace QCCore
{
	public static partial class MainCls
	{
		#region MakeQStruct
		public static QStruct<T1> MakeQStruct<T1>( T1 Item1 ) => new QStruct<T1>( Item1 );

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

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );
		public QStruct<_T1 , _T2 , _T3 , _T4 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11> PushFront<_T1, _T2, _T3, _T4>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 , _T4 NItem4 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , NItem4 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 );

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

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );
		public QStruct<_T1 , _T2 , _T3 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12> PushFront<_T1, _T2, _T3>( _T1 NItem1 , _T2 NItem2 , _T3 NItem3 ) =>
		MakeQStruct( NItem1 , NItem2 , NItem3 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 );

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

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );
		public QStruct<_T1 , _T2 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13> PushFront<_T1, _T2>( _T1 NItem1 , _T2 NItem2 ) =>
		MakeQStruct( NItem1 , NItem2 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 );

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

		public QStruct<_T1 , T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14> PushFront<_T1>( _T1 NItem1 ) =>
		MakeQStruct( NItem1 , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 );

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

	#endregion
}
