using System;
using System.Collections.Generic;

namespace QCCore
{
	public interface IDynArray<T>
	{
		T this[ int index ] { get; set; }
		T this[ ulong index ] { get; set; }

		int Capacity { get; set; }
		int Count { get; }

		void Add( T item );
		void AddRange( IEnumerable<T> collection );
		void Clear( );
		bool Contains( T item );
		void CopyTo( int index , T[ ] array , int arrayIndex , int count );
		void CopyTo( T[ ] array );
		void CopyTo( T[ ] array , int arrayIndex );
		bool Exists( Predicate<T> match );
		T Find( Predicate<T> match );
		int FindIndex( int startIndex , int count , Predicate<T> match );
		int FindIndex( int startIndex , Predicate<T> match );
		int FindIndex( Predicate<T> match );
		T FindLast( Predicate<T> match );
		int FindLastIndex( int startIndex , int count , Predicate<T> match );
		int FindLastIndex( int startIndex , Predicate<T> match );
		int FindLastIndex( Predicate<T> match );
		void ForEach( Action<T> action );
		void RevForEach( Action<T> action );
		int IndexOf( T item );
		int IndexOf( T item , int index );
		int IndexOf( T item , int index , int count );
		void Insert( int index , T item );
		void InsertRange( int index , IEnumerable<T> collection );
		int LastIndexOf( T item );
		int LastIndexOf( T item , int index );
		int LastIndexOf( T item , int index , int count );
		int Length( );
		bool Remove( T item );
		int RemoveAll( Predicate<T> match );
		void RemoveAt( int index );
		void RemoveRange( int index , int count );
		void Reverse( );
		void Reverse( int index , int count );
		int Size( );
		void Sort( );
		void Sort( Comparison<T> comparison );
		void Sort( IComparer<T> comparer );
		void Sort( int index , int count , IComparer<T> comparer );
		T[ ] ToArray( );
		void TrimExcess( );
		bool TrueForAll( Predicate<T> match );
	}
}