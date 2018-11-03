#pragma once
#include "predef_and_include.h"
#include "QStruct.h"
#include <boost\multi_array.hpp>
#include <algorithm>

namespace QCCore
{
	struct Extents
	{
		using value_type = ULong;
		using reference = ULong & ;
		using const_reference = const ULong&;
		using iterator = ULong * ;
		using const_iterator = const ULong*;
		using reverse_iterator = std::reverse_iterator<ULong *>;
		using const_reverse_iterator = std::reverse_iterator<const ULong *>;

		ULong arr[ 4 ];

		constexpr Extents( std::initializer_list<ULong> initList ) noexcept :Extents( )
		{
			ULong idx = 0;
			for ( auto& val : initList ) arr[ idx++ ] = val;
		}
		constexpr inline Extents( const ULong& a = 0 , const ULong& b = 0 , const ULong& c = 0 , const ULong& d = 0 ) noexcept : arr { a,b,c,d } { }
		constexpr inline Extents( const QStruct<ULong>& a ) noexcept : Extents( a.Item1 ) { }
		constexpr inline Extents( const QStruct<ULong , ULong>& a ) noexcept : Extents( a.Item1 , a.Item2 ) { }
		constexpr inline Extents( const QStruct<ULong , ULong , ULong>& a ) noexcept : Extents( a.Item1 , a.Item2 , a.Item3 ) { }
		constexpr inline Extents( const QStruct<ULong , ULong , ULong , ULong>& a ) noexcept : Extents( a.Item1 , a.Item2 , a.Item3 , a.Item4 ) { }

		constexpr inline ULong& operator[]( const ULong& idx ) noexcept { return arr[ idx ]; }

		constexpr inline const ULong& operator[]( const ULong& idx ) const noexcept { return arr[ idx ]; }

		constexpr inline operator QStruct<ULong , ULong , ULong , ULong>( ) noexcept
		{ return QStruct<ULong , ULong , ULong , ULong>( arr[ 0 ] , arr[ 1 ] , arr[ 2 ] , arr[ 3 ] ); }

		constexpr inline ULong Length( ) const noexcept { return 4; }
		constexpr inline ULong Size( ) const noexcept { return 4; }
		constexpr inline ULong Count( ) const noexcept { return 4; }
		constexpr inline ULong size( ) const noexcept { return 4; }
		constexpr inline ULong length( ) const noexcept { return 4; }
		constexpr inline ULong count( ) const noexcept { return 4; }

		constexpr inline iterator begin( ) { return std::begin( arr ); }
		constexpr inline const_iterator begin( ) const { return std::begin( arr ); }
		constexpr inline iterator end( ) { return std::end( arr ); }
		constexpr inline const_iterator end( ) const { return std::end( arr ); }
		constexpr inline const_iterator cbegin( ) const { return std::cbegin( arr ); }
		constexpr inline const_iterator cend( ) const { return std::cend( arr ); }

		constexpr inline reverse_iterator rbegin( ) { return std::rbegin( arr ); }
		constexpr inline const_reverse_iterator rbegin( ) const { return std::rbegin( arr ); }
		constexpr inline reverse_iterator rend( ) { return std::rend( arr ); }
		constexpr inline const_reverse_iterator rend( ) const { return std::rend( arr ); }
		constexpr inline const_reverse_iterator crbegin( ) const { return std::crbegin( arr ); }
		constexpr inline const_reverse_iterator crend( ) const { return std::crend( arr ); }
	};

	static Extents Ext( ULong a = 0 , ULong b = 0 , ULong c = 0 , ULong d = 0 ) { return Extents( a , b , c , d ); }

	template<typename T>
	class Array1
	{
		using array_t = std::vector<T>;
		array_t array_;
	public:
		typedef typename array_t::value_type value_type;
		typedef typename array_t::reference reference;
		typedef typename array_t::const_reference const_reference;
		typedef typename array_t::iterator iterator;
		typedef typename array_t::const_iterator const_iterator;
		typedef typename array_t::reverse_iterator reverse_iterator;
		typedef typename array_t::const_reverse_iterator const_reverse_iterator;
		typedef typename array_t::size_type size_type;
		typedef typename array_t::difference_type difference_type;

	#pragma region GetEnumerator
		inline iterator begin( ) { return		array_.begin( ); }
		inline const_iterator begin( ) const { return  array_.begin( ); }
		inline iterator end( ) { return		 array_.end( ); }
		inline const_iterator end( ) const { return array_.end( ); }
		inline const_iterator cbegin( ) const { return  array_.begin( ); }
		inline const_iterator cend( ) const { return array_.end( ); }

		inline reverse_iterator rbegin( ) { return array_.rbegin( ); }
		inline const_reverse_iterator rbegin( ) const { return array_.rbegin( ); }
		inline reverse_iterator rend( ) { return array_.rend( ); }
		inline const_reverse_iterator rend( ) const { return array_.rend( ); }
		inline const_reverse_iterator crbegin( ) const { return array_.rbegin( ); }
		inline const_reverse_iterator crend( ) const { return array_.rend( ); }
	#pragma endregion

		inline Array1( ) :array_ {} { }
		inline Array1( Extents extents ) : array_( extents[ 0 ] ) { }

		inline T& operator[]( const Extents& extents ) noexcept { return array_[ extents[ 0 ] ]; }
		inline const T& operator[]( const Extents& extents ) const noexcept { return array_[ extents[ 0 ] ]; }
		inline T& At( const Extents& extents ) { return array_.at( extents[ 0 ] ); }
		inline const T& At( const Extents& extents ) const { return array_.at( extents[ 0 ] ); }
		inline T& at( const Extents& extents ) { return array_.at( extents[ 0 ] ); }
		inline const T& at( const Extents& extents ) const { return array_.at( extents[ 0 ] ); }

		template<typename... Args> inline Array1 Set( Args&&... args )
		{
			array_ = std::vector<T> { std::forward<Args>( args )... };
			return *this;
		}

		inline ULong Length( ) const noexcept { return array_.size( ); }
		inline Extents Size( ) const noexcept { return array_.size( ); }
		inline ULong Count( ) const noexcept { return array_.size( ); }
		inline ULong size( ) const noexcept { return array_.size( ); }
		inline Extents length( ) const noexcept { return array_.size( ); }
		inline ULong count( ) const noexcept { return array_.size( ); }

		inline array_t& __NATIVE( ) noexcept { return array_; }
		inline const array_t& __NATIVE( ) const noexcept { return array_; }
	};

	template<typename T>
	class Array2
	{
		using array_t = std::vector<T>;
		array_t array_;
		Extents sz;

		inline ULong cnvtExtntTIdx( const Extents& ext ) const noexcept
		{
			return
				ext[ 1 ] +
				ext[ 0 ] * ext[ 1 ];
		}
	public:
		typedef typename array_t::value_type value_type;
		typedef typename array_t::reference reference;
		typedef typename array_t::const_reference const_reference;
		typedef typename array_t::iterator iterator;
		typedef typename array_t::const_iterator const_iterator;
		typedef typename array_t::reverse_iterator reverse_iterator;
		typedef typename array_t::const_reverse_iterator const_reverse_iterator;
		typedef typename array_t::size_type size_type;
		typedef typename array_t::difference_type difference_type;

	#pragma region GetEnumerator
		inline iterator begin( ) { return		array_.begin( ); }
		inline const_iterator begin( ) const { return  array_.begin( ); }
		inline iterator end( ) { return		 array_.end( ); }
		inline const_iterator end( ) const { return array_.end( ); }
		inline const_iterator cbegin( ) const { return  array_.begin( ); }
		inline const_iterator cend( ) const { return array_.end( ); }

		inline reverse_iterator rbegin( ) { return array_.rbegin( ); }
		inline const_reverse_iterator rbegin( ) const { return array_.rbegin( ); }
		inline reverse_iterator rend( ) { return array_.rend( ); }
		inline const_reverse_iterator rend( ) const { return array_.rend( ); }
		inline const_reverse_iterator crbegin( ) const { return array_.rbegin( ); }
		inline const_reverse_iterator crend( ) const { return array_.rend( ); }
	#pragma endregion

		inline Array2( ) :array_ {} , sz { 0,0,0,0 } { }
		inline Array2( Extents extents ) : array_( extents[ 0 ] * extents[ 1 ] ) , sz { extents } { }

		inline T& operator[]( const Extents& extents ) noexcept { return array_[ cnvtExtntTIdx( extents ) ]; }
		inline const T& operator[]( const Extents& extents ) const noexcept { return array_[ cnvtExtntTIdx( extents ) ]; }
		inline T& At( const Extents& extents ) { return array_.at( cnvtExtntTIdx( extents ) ); }
		inline const T& At( const Extents& extents ) const { return array_.at( cnvtExtntTIdx( extents ) ); }
		inline T& at( const Extents& extents ) { return array_.at( cnvtExtntTIdx( extents ) ); }
		inline const T& at( const Extents& extents ) const { return array_.at( cnvtExtntTIdx( extents ) ); }

		inline Extents Size( ) const noexcept { return sz; }
		inline Extents size( ) const noexcept { return sz; }

		inline array_t& __NATIVE( ) noexcept { return array_; }
		inline const array_t& __NATIVE( ) const noexcept { return array_; }
	};

	template<typename T>
	class Array3
	{
		using array_t = std::vector<T>;
		array_t array_;
		Extents sz;

		inline ULong cnvtExtntTIdx( const Extents& ext ) const noexcept
		{
			return
				ext[ 2 ] +
				ext[ 1 ] * ext[ 2 ] * +
				ext[ 0 ] * ext[ 1 ] * ext[ 2 ];
		}
	public:
		typedef typename array_t::value_type value_type;
		typedef typename array_t::reference reference;
		typedef typename array_t::const_reference const_reference;
		typedef typename array_t::iterator iterator;
		typedef typename array_t::const_iterator const_iterator;
		typedef typename array_t::reverse_iterator reverse_iterator;
		typedef typename array_t::const_reverse_iterator const_reverse_iterator;
		typedef typename array_t::size_type size_type;
		typedef typename array_t::difference_type difference_type;

	#pragma region GetEnumerator
		inline iterator begin( ) { return		array_.begin( ); }
		inline const_iterator begin( ) const { return  array_.begin( ); }
		inline iterator end( ) { return		 array_.end( ); }
		inline const_iterator end( ) const { return array_.end( ); }
		inline const_iterator cbegin( ) const { return  array_.begin( ); }
		inline const_iterator cend( ) const { return array_.end( ); }

		inline reverse_iterator rbegin( ) { return array_.rbegin( ); }
		inline const_reverse_iterator rbegin( ) const { return array_.rbegin( ); }
		inline reverse_iterator rend( ) { return array_.rend( ); }
		inline const_reverse_iterator rend( ) const { return array_.rend( ); }
		inline const_reverse_iterator crbegin( ) const { return array_.rbegin( ); }
		inline const_reverse_iterator crend( ) const { return array_.rend( ); }
	#pragma endregion

		inline Array3( ) :array_ {} , sz { 0,0,0,0 } { }
		inline Array3( Extents extents ) : array_( extents[ 0 ] * extents[ 1 ] * extents[ 2 ] ) , sz { extents } { }

		inline T& operator[]( const Extents& extents ) noexcept { return array_[ cnvtExtntTIdx( extents ) ]; }
		inline const T& operator[]( const Extents& extents ) const noexcept { return array_[ cnvtExtntTIdx( extents ) ]; }
		inline T& At( const Extents& extents ) { return array_.at( cnvtExtntTIdx( extents ) ); }
		inline const T& At( const Extents& extents ) const { return array_.at( cnvtExtntTIdx( extents ) ); }
		inline T& at( const Extents& extents ) { return array_.at( cnvtExtntTIdx( extents ) ); }
		inline const T& at( const Extents& extents ) const { return array_.at( cnvtExtntTIdx( extents ) ); }

		inline Extents Size( ) const noexcept { return sz; }
		inline Extents size( ) const noexcept { return sz; }

		inline array_t& __NATIVE( ) noexcept { return array_; }
		inline const array_t& __NATIVE( ) const noexcept { return array_; }
	};

	template<typename T>
	class Array4
	{
		using array_t = std::vector<T>;
		array_t array_;
		Extents sz;

		inline ULong cnvtExtntTIdx( const Extents& ext ) const noexcept
		{
			return
				ext[ 3 ] +
				ext[ 2 ] * sz[ 3 ] +
				ext[ 1 ] * sz[ 2 ] * sz[ 3 ] +
				ext[ 0 ] * sz[ 1 ] * sz[ 2 ] * sz[ 3 ];
		}
	public:
		typedef typename array_t::value_type value_type;
		typedef typename array_t::reference reference;
		typedef typename array_t::const_reference const_reference;
		typedef typename array_t::iterator iterator;
		typedef typename array_t::const_iterator const_iterator;
		typedef typename array_t::reverse_iterator reverse_iterator;
		typedef typename array_t::const_reverse_iterator const_reverse_iterator;
		typedef typename array_t::size_type size_type;
		typedef typename array_t::difference_type difference_type;

	#pragma region GetEnumerator
		inline iterator begin( ) { return		array_.begin( ); }
		inline const_iterator begin( ) const { return  array_.begin( ); }
		inline iterator end( ) { return		 array_.end( ); }
		inline const_iterator end( ) const { return array_.end( ); }
		inline const_iterator cbegin( ) const { return  array_.begin( ); }
		inline const_iterator cend( ) const { return array_.end( ); }

		inline reverse_iterator rbegin( ) { return array_.rbegin( ); }
		inline const_reverse_iterator rbegin( ) const { return array_.rbegin( ); }
		inline reverse_iterator rend( ) { return array_.rend( ); }
		inline const_reverse_iterator rend( ) const { return array_.rend( ); }
		inline const_reverse_iterator crbegin( ) const { return array_.rbegin( ); }
		inline const_reverse_iterator crend( ) const { return array_.rend( ); }
	#pragma endregion

		inline Array4( ) :array_ {} , sz { 0,0,0,0 } { }
		inline Array4( Extents extents ) : array_( extents[ 0 ] * extents[ 1 ] * extents[ 2 ] * extents[ 3 ] ) , sz { extents } { }

		inline T& operator[]( const Extents& extents ) noexcept { return array_[ cnvtExtntTIdx( extents ) ]; }
		inline const T& operator[]( const Extents& extents ) const noexcept { return array_[ cnvtExtntTIdx( extents ) ]; }
		inline T& At( const Extents& extents ) { return array_.at( cnvtExtntTIdx( extents ) ); }
		inline const T& At( const Extents& extents ) const { return array_.at( cnvtExtntTIdx( extents ) ); }
		inline T& at( const Extents& extents ) { return array_.at( cnvtExtntTIdx( extents ) ); }
		inline const T& at( const Extents& extents ) const { return array_.at( cnvtExtntTIdx( extents ) ); }

		inline Extents Size( ) const noexcept { return sz; }
		inline Extents size( ) const noexcept { return sz; }

		inline array_t& __NATIVE( ) noexcept { return array_; }
		inline const array_t& __NATIVE( ) const noexcept { return array_; }
	};

	template<typename T>
	class DynArray : public std::vector<T>
	{
		using base_t = std::vector<T>;
		base_t& base( ) { return *this; }
		const base_t& base( ) const { return *this; }
	public:
		typedef typename base_t::value_type value_type;
		typedef typename base_t::reference reference;
		typedef typename base_t::const_reference const_reference;
		typedef typename base_t::iterator iterator;
		typedef typename base_t::const_iterator const_iterator;
		typedef typename base_t::reverse_iterator reverse_iterator;
		typedef typename base_t::const_reverse_iterator const_reverse_iterator;
		typedef typename base_t::size_type size_type;
		typedef typename base_t::difference_type difference_type;

	#pragma region GetEnumerator
		inline iterator begin( ) { return		base( ).begin( ); }
		inline const_iterator begin( ) const { return  base( ).begin( ); }
		inline iterator end( ) { return		 base( ).end( ); }
		inline const_iterator end( ) const { return base( ).end( ); }
		inline const_iterator cbegin( ) const { return  base( ).begin( ); }
		inline const_iterator cend( ) const { return base( ).end( ); }

		inline reverse_iterator rbegin( ) { return base( ).rbegin( ); }
		inline const_reverse_iterator rbegin( ) const { return base( ).rbegin( ); }
		inline reverse_iterator rend( ) { return base( ).rend( ); }
		inline const_reverse_iterator rend( ) const { return base( ).rend( ); }
		inline const_reverse_iterator crbegin( ) const { return base( ).rbegin( ); }
		inline const_reverse_iterator crend( ) const { return base( ).rend( ); }
	#pragma endregion

		inline DynArray( ) : base_t( ) { }
		inline DynArray( int len ) : base_t( len ) { }
		template<typename TIter>
		inline DynArray( const TIter& beg , const TIter& end ) : base_t( beg , end ) { }
		inline DynArray( std::initializer_list<T> init ) : base_t( init ) { }

		inline T& operator[]( const int& idx ) { return base( )[ idx ]; }
		inline const T& operator[]( const int& idx ) const { return base( )[ idx ]; }

		inline int Size( ) const { return base( ).size( ); }
		inline int Length( ) const { return base( ).size( ); }
		template<typename T>
		inline void Add( T&& item )
		{ base( ).emplace_back( std::forward<T>( item ) ); }
		inline void Clear( ) { base( ).clear( ); }
		inline bool Contains( const T& item )
		{ return std::find( begin( ) , end( ) , item ) != end( ); }
		template<typename TF>
		inline bool Exists( TF&& func ) const { return std::any_of( begin( ) , end( ) , std::forward<TF>( func ) ); }
		template<typename TF>
		inline T& Find( TF&& func ) { return *std::find_if( begin( ) , end( ) , std::forward<TF>( func ) ); }
		template<typename TF>
		inline const T& Find( TF&& func ) const { return *std::find_if( begin( ) , end( ) , std::forward<TF>( func ) ); }
		template<typename TF>
		inline int FindIndex( int startIndex , int count , TF&& match ) const
		{ return std::find_if( begin( ) + startIndex , begin( ) + startIndex + count + 1 , std::forward<TF>( match ) ) - begin( ); }
		template<typename TF>
		inline int FindIndex( int startIndex , TF&& match ) const
		{ return std::find_if( begin( ) + startIndex , end( ) , std::forward<TF>( match ) ) - begin( ); }
		template<typename TF>
		inline int FindIndex( TF&& match ) const
		{ return std::find_if( begin( ) , end( ) , std::forward<TF>( match ) ) - begin( ); }
		template<typename TF>
		inline T& FindLast( TF&& func )
		{ return *std::find_if( rbegin( ) , rend( ) , std::forward<TF>( func ) ); }
		template<typename TF>
		inline const T& FindLast( TF&& func ) const
		{ return *std::find_if( rbegin( ) , rend( ) , std::forward<TF>( func ) ); }
		template<typename TF>
		inline int FindLastIndex( TF&& match ) const
		{ return std::find_if( rbegin( ) , rend( ) , std::forward<TF>( match ) ) - rbegin( ); }
		template<typename TF>
		inline void ForEach( TF&& f )
		{ std::for_each( begin( ) , end( ) , std::forward<TF>( f ) ); }
		template<typename TF>
		inline void ForEach( TF&& f ) const
		{ std::for_each( begin( ) , end( ) , std::forward<TF>( f ) ); }
		template<typename TF>
		inline void RevForEach( TF&& f )
		{ std::for_each( rbegin( ) , rend( ) , std::forward<TF>( f ) ); }
		template<typename TF>
		inline void RevForEach( TF&& f ) const
		{ std::for_each( rbegin( ) , rend( ) , std::forward<TF>( f ) ); }
		inline DynArray<T> GetRange( int index , int count )
		{ return DynArray<T>( begin( ) + index , begin( ) + index + count + 1 ); }
		int IndexOf( const T& item , int index , int count )
		{
			auto idx = std::find( begin( ) + index , begin( ) + index + count + 1 , item );
			if ( idx == end( ) )return -1;
			return idx - begin( );
		}
		int IndexOf( const T& item , int index )
		{
			auto idx = std::find( begin( ) + index , end( ) , item );
			if ( idx == end( ) )return -1;
			return idx - begin( );
		}
		int IndexOf( const T& item )
		{
			auto idx = std::find( begin( ) , end( ) , item );
			if ( idx == end( ) )return -1;
			return idx - begin( );
		}
		template<typename T>
		inline void Insert( int index , T&& item )
		{ base( ).emplace( begin( ) + index , std::forward<T>( item ) ); }
		int LastIndexOf( const T& item )
		{
			auto idx = std::find( rbegin( ) , rend( ) , item );
			if ( idx == rend( ) )return -1;
			return idx - rbegin( );
		}
		bool Remove( T const& item )
		{
			auto iter = std::find( begin( ) , end( ) , item );
			if ( iter == end( ) )return false;
			base( ).erase( iter );
			return true;
		}
		template<typename TF>
		int RemoveAll( TF match )
		{
			int no = 0;
			for ( size_t i = 0; i < base( ).size( ); i++ )
				if ( match( ( *this )[ i ] ) )
				{
					++no;
					RemoveAt( begin( ) + i );
					--i;
				}
			return no;
		}
		inline void Reverse( int index , int count ) { std::reverse( begin( ) + index , begin( ) + index + count + 1 ); }
		inline void Reverse( ) { std::reverse( begin( ) , end( ) ); }
		inline int GetCapacity( ) { return base( ).capacity( ); }
		inline void SetCapacity(int size ) { base( ).reserve( size ); }

		template<typename TF>
		inline void Sort( int index , int count , TF&& comparer )
		{ std::stable_sort( begin( ) + index , begin( ) + index + count + 1 , std::forward<TF>( comparer ) ); }
		inline void Sort( ) { std::stable_sort( begin( ) , end( ) ); }
		template<typename TF>
		inline void Sort( TF&& comparer ){ std::stable_sort( begin( ) , end( ),std::forward<TF>( comparer ) ); }
		inline void TrimExcess( ) { base( ).shrink_to_fit( ); }
		template<typename TF>
		inline bool TrueForAll( TF&& match ) { return std::all_of( begin( ) , end( ) , std::forward<TF>( match ) ); }

		inline void RemoveAt( int index ) { base( ).erase( begin( ) + index ); }

		inline base_t& __NATIVE( ) { return base( ); }
		inline const base_t& __NATIVE( ) const { return base( ); }
	};
}
