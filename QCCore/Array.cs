﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace QCCore
{
	public interface IHasNative<out TNative>
	{
		TNative __NATIVE( );
	}

	public struct Extent : IEnumerable<ulong>
	{
		public ulong[ ] arr;

		public ulong this[ ulong idx ]
		{
			get => arr[ idx ];
			set => arr[ idx ] = value;
		}

		public ulong Count => 4;

		public ulong Size( ) => 4;
		public ulong Length( ) => 4;

		public Extent( ulong a = 0 , ulong b = 0 , ulong c = 0 , ulong d = 0 ) => arr = new ulong[ ] { a , b , c , d };
		public Extent( Extent tup ) => arr = new ulong[ ] { tup[ 0 ] , tup[ 1 ] , tup[ 2 ] , tup[ 3 ] };

		public static implicit operator Extent( ulong tup ) => new Extent( tup , 0 , 0 , 0 );
		public static implicit operator Extent( QStruct<ulong> tup ) => new Extent( tup.Item1 , 0 , 0 , 0 );
		public static implicit operator Extent( QStruct<ulong , ulong> tup ) => new Extent( tup.Item1 , tup.Item2 , 0 , 0 );
		public static implicit operator Extent( QStruct<ulong , ulong , ulong> tup ) => new Extent( tup.Item1 , tup.Item2 , tup.Item3 , 0 );
		public static implicit operator Extent( QStruct<ulong , ulong , ulong , ulong> tup ) => new Extent( tup.Item1 , tup.Item2 , tup.Item3 , tup.Item4 );
		public static implicit operator QStruct<ulong , ulong , ulong , ulong>( Extent tup ) => new QStruct<ulong , ulong , ulong , ulong>( tup[ 0 ] , tup[ 1 ] , tup[ 2 ] , tup[ 3 ] );

		public IEnumerator<ulong> GetEnumerator( ) => ( ( IEnumerable<ulong> ) arr ).GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator( ) => arr.GetEnumerator();
	}

	public static partial class QCCoreCls
	{
		public static Extent Ext( ulong a = 0 , ulong b = 0 , ulong c = 0 , ulong d = 0 ) => new Extent( a , b , c , d );
	}

	public class Array1<T> : IEnumerable<T>, IHasNative<T[ ]>
	{
		private T[ ] array_;

		public IEnumerator<T> GetEnumerator( ) => ( ( IEnumerable<T> ) array_ ).GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator( ) => array_.GetEnumerator();

		private Array1( T[ ] array_ ) =>
			this.array_ = array_;

		public Array1( Extent extents ) =>
			array_ = new T[ extents[ 0 ] ];

		public Array1( ) => array_ = null;

		public T this[ Extent extents ]
		{
			get => array_[ extents[ 0 ] ];
			set => array_[ extents[ 0 ] ] = value;
		}
		public T At( Extent extents ) => array_[ extents[ 0 ] ];
		public T at( Extent extents ) => array_[ extents[ 0 ] ];

		public Array1<T> Set( params T[ ] ts )
		{
			array_ = ( T[ ] ) ts.Clone();
			return this;
		}

		public ulong Length( ) => ( ulong ) array_.Length;
		public Extent Size( ) => ( ulong ) array_.Length;
		public ulong Count( ) => ( ulong ) array_.Length;
		public ulong length( ) => ( ulong ) array_.Length;
		public Extent size( ) => ( ulong ) array_.Length;
		public ulong count( ) => ( ulong ) array_.Length;

		public T[ ] __NATIVE( ) => array_;
	}

	public class Array2<T> : IEnumerable<T>, IHasNative<T[ ]>
	{
		private T[ ] array_;
		private readonly Extent sz;

		private ulong CnvtExtntTIdx( Extent ext ) =>
			ext[ 1 ] +
			ext[ 0 ] * sz[ 1 ];

		public IEnumerator<T> GetEnumerator( ) => ( ( IEnumerable<T> ) array_ ).GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator( ) => array_.GetEnumerator();

		public Array2( Extent extents )
		{
			array_ = new T[ extents[ 0 ] * extents[ 1 ] ];
			sz = new Extent( extents );
		}

		public Array2( ) => array_ = null;

		public T this[ Extent ext ]
		{
			get => array_[ CnvtExtntTIdx( ext ) ];
			set => array_[ CnvtExtntTIdx( ext ) ] = value;
		}

		public T At( Extent ext ) => array_[ CnvtExtntTIdx( ext ) ];
		public T at( Extent ext ) => array_[ CnvtExtntTIdx( ext ) ];

		public Extent Size( ) => new Extent( sz );
		public Extent size( ) => new Extent( sz );

		public T[ ] __NATIVE( ) => array_;
	}

	public class Array3<T> : IEnumerable<T>, IHasNative<T[ ]>
	{
		private T[ ] array_;
		private readonly Extent sz;

		private ulong CnvtExtntTIdx( Extent ext ) =>
			ext[ 2 ] +
			ext[ 1 ] * ext[ 2 ] * +
			ext[ 0 ] * ext[ 1 ] * ext[ 2 ];

		public IEnumerator<T> GetEnumerator( ) => ( ( IEnumerable<T> ) array_ ).GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator( ) => array_.GetEnumerator();

		public Array3( Extent extents )
		{
			array_ = new T[ extents[ 0 ] * extents[ 1 ] * extents[ 2 ] ];
			sz = new Extent( extents );
		}

		public Array3( ) => array_ = null;

		public T this[ Extent ext ]
		{
			get => array_[ CnvtExtntTIdx( ext ) ];
			set => array_[ CnvtExtntTIdx( ext ) ] = value;
		}

		public T At( Extent ext ) => array_[ CnvtExtntTIdx( ext ) ];
		public T at( Extent ext ) => array_[ CnvtExtntTIdx( ext ) ];

		public Extent Size( ) => new Extent( sz );
		public Extent size( ) => new Extent( sz );

		public T[ ] __NATIVE( ) => array_;
	}

	public class Array4<T> : IEnumerable<T>, IHasNative<T[ ]>
	{
		private T[ ] array_;
		private readonly Extent sz;

		private ulong CnvtExtntTIdx( Extent ext ) =>
			ext[ 3 ] +
			ext[ 2 ] * sz[ 3 ] +
			ext[ 1 ] * sz[ 2 ] * sz[ 3 ] +
			ext[ 0 ] * sz[ 1 ] * sz[ 2 ] * sz[ 3 ];

		public IEnumerator<T> GetEnumerator( ) => ( ( IEnumerable<T> ) array_ ).GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator( ) => array_.GetEnumerator();

		public Array4( Extent extents )
		{
			array_ = new T[ extents[ 0 ] * extents[ 1 ] * extents[ 2 ] * extents[ 3 ] ];
			sz = new Extent( extents );
		}

		public Array4( ) => array_ = null;

		public T this[ Extent ext ]
		{
			get => array_[ CnvtExtntTIdx( ext ) ];
			set => array_[ CnvtExtntTIdx( ext ) ] = value;
		}

		public T At( Extent ext ) => array_[ CnvtExtntTIdx( ext ) ];
		public T at( Extent ext ) => array_[ CnvtExtntTIdx( ext ) ];

		public Extent Size( ) => new Extent( sz );
		public Extent size( ) => new Extent( sz );

		public T[ ] __NATIVE( ) => array_;
	}

	public class DynArray<T> : List<T>, IDynArray<T>
	{
		public DynArray( IEnumerable<T> coll ) : base( coll ) { }
		public DynArray( int len ) : base(len) { }
		public DynArray( ) : base() { }

		public T this[ ulong index ] { get => this[ ( int ) index ]; set => this[ ( int ) index ] = value; }

		public int Size( ) => Count;
		public int Length( ) => Count;
		public new DynArray<TOutput> ConvertAll<TOutput>( Converter<T , TOutput> converter ) => new DynArray<TOutput>( ( ( List<T> ) this ).ConvertAll( converter ) );
		public new DynArray<T> FindAll( Predicate<T> match ) => new DynArray<T>( ( ( List<T> ) this ).FindAll( match ) );
		public new DynArray<T> GetRange( int index , int count ) => new DynArray<T>( ( ( List<T> ) this ).GetRange( index , count ) );
		public void RevForEach( Action<T> action )
		{ for ( int i = Size() - 1; i >= 0; i-- ) action( this[ i ] ); }
		public new int Capacity( ) => base.Capacity;
		public new void Capacity( int size ) => base.Capacity = size;

		public List<T> __NATIVE( ) => this;
	}
}