#pragma once
#include "predef_and_include.hpp"
#include "QStruct.hpp"
#include <boost\multi_array.hpp>
#include <algorithm>

namespace QCCore
{
	struct ValueNotFoundException :std::exception
	{
		virtual char const* what( ) const noexcept override
		{
			return "ValueNotFound";
		}
	};

	struct Extent
	{
		using value_type = ULong;
		using reference = ULong & ;
		using const_reference = const ULong&;
		using iterator = ULong * ;
		using const_iterator = const ULong*;
		using reverse_iterator = std::reverse_iterator<ULong *>;
		using const_reverse_iterator = std::reverse_iterator<const ULong *>;

		ULong arr[ 4 ];

		constexpr Extent( std::initializer_list<ULong> initList ) noexcept :Extent( )
		{
			ULong idx = 0;
			for ( auto& val : initList ) arr[ idx++ ] = val;
		}
		constexpr forceinline Extent( const ULong& a = 0 , const ULong& b = 0 , const ULong& c = 0 , const ULong& d = 0 ) noexcept : arr { a,b,c,d } { }
		constexpr forceinline Extent( const QStruct<ULong>& a ) noexcept : Extent( a.Item1 ) { }
		constexpr forceinline Extent( const QStruct<ULong , ULong>& a ) noexcept : Extent( a.Item1 , a.Item2 ) { }
		constexpr forceinline Extent( const QStruct<ULong , ULong , ULong>& a ) noexcept : Extent( a.Item1 , a.Item2 , a.Item3 ) { }
		constexpr forceinline Extent( const QStruct<ULong , ULong , ULong , ULong>& a ) noexcept : Extent( a.Item1 , a.Item2 , a.Item3 , a.Item4 ) { }

		constexpr forceinline ULong& operator[]( const ULong& idx ) noexcept { return arr[ idx ]; }

		constexpr forceinline const ULong& operator[]( const ULong& idx ) const noexcept { return arr[ idx ]; }

		constexpr forceinline operator QStruct<ULong , ULong , ULong , ULong>( ) noexcept
		{ return QStruct<ULong , ULong , ULong , ULong>( arr[ 0 ] , arr[ 1 ] , arr[ 2 ] , arr[ 3 ] ); }

		constexpr forceinline ULong Length( ) const noexcept { return 4; }
		constexpr forceinline ULong Size( ) const noexcept { return 4; }
		constexpr forceinline ULong Count( ) const noexcept { return 4; }
		constexpr forceinline ULong size( ) const noexcept { return 4; }
		constexpr forceinline ULong length( ) const noexcept { return 4; }
		constexpr forceinline ULong count( ) const noexcept { return 4; }

		constexpr forceinline iterator begin( ) { return std::begin( arr ); }
		constexpr forceinline const_iterator begin( ) const { return std::begin( arr ); }
		constexpr forceinline iterator end( ) { return std::end( arr ); }
		constexpr forceinline const_iterator end( ) const { return std::end( arr ); }
		constexpr forceinline const_iterator cbegin( ) const { return std::cbegin( arr ); }
		constexpr forceinline const_iterator cend( ) const { return std::cend( arr ); }

		constexpr forceinline reverse_iterator rbegin( ) { return std::rbegin( arr ); }
		constexpr forceinline const_reverse_iterator rbegin( ) const { return std::rbegin( arr ); }
		constexpr forceinline reverse_iterator rend( ) { return std::rend( arr ); }
		constexpr forceinline const_reverse_iterator rend( ) const { return std::rend( arr ); }
		constexpr forceinline const_reverse_iterator crbegin( ) const { return std::crbegin( arr ); }
		constexpr forceinline const_reverse_iterator crend( ) const { return std::crend( arr ); }
	};

	static forceinline Extent Ext( ULong a = 0 , ULong b = 0 , ULong c = 0 , ULong d = 0 ) { return Extent( a , b , c , d ); }

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
		forceinline iterator begin( ) { return		array_.begin( ); }
		forceinline const_iterator begin( ) const { return  array_.begin( ); }
		forceinline iterator end( ) { return		 array_.end( ); }
		forceinline const_iterator end( ) const { return array_.end( ); }
		forceinline const_iterator cbegin( ) const { return  array_.begin( ); }
		forceinline const_iterator cend( ) const { return array_.end( ); }

		forceinline reverse_iterator rbegin( ) { return array_.rbegin( ); }
		forceinline const_reverse_iterator rbegin( ) const { return array_.rbegin( ); }
		forceinline reverse_iterator rend( ) { return array_.rend( ); }
		forceinline const_reverse_iterator rend( ) const { return array_.rend( ); }
		forceinline const_reverse_iterator crbegin( ) const { return array_.rbegin( ); }
		forceinline const_reverse_iterator crend( ) const { return array_.rend( ); }
	#pragma endregion

		forceinline Array1( ) :array_ {} { }
		forceinline Array1( Extent extents ) : array_( extents[ 0 ] ) { }

		forceinline T& operator[]( const Extent& extents ) { return array_[ extents[ 0 ] ]; }
		forceinline const T& operator[]( const Extent& extents ) const { return array_[ extents[ 0 ] ]; }
		forceinline T& At( const Extent& extents ) { return array_.at( extents[ 0 ] ); }
		forceinline const T& At( const Extent& extents ) const { return array_.at( extents[ 0 ] ); }
		forceinline T& at( const Extent& extents ) { return array_.at( extents[ 0 ] ); }
		forceinline const T& at( const Extent& extents ) const { return array_.at( extents[ 0 ] ); }

		template<typename... Args> inline Array1 Set( Args&&... args )
		{
			array_ = std::vector<T> { std::forward<Args>( args )... };
			return *this;
		}

		forceinline ULong Length( ) const noexcept { return array_.size( ); }
		forceinline Extent Size( ) const noexcept { return array_.size( ); }
		forceinline ULong Count( ) const noexcept { return array_.size( ); }
		forceinline ULong size( ) const noexcept { return array_.size( ); }
		forceinline Extent length( ) const noexcept { return array_.size( ); }
		forceinline ULong count( ) const noexcept { return array_.size( ); }

		forceinline array_t& __NATIVE( ) noexcept { return array_; }
		forceinline const array_t& __NATIVE( ) const noexcept { return array_; }
	};

	template<typename T>
	class Array2
	{
		using array_t = std::vector<T>;
		array_t array_;
		Extent sz;

		inline ULong cnvtExtntTIdx( const Extent& ext ) const noexcept
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
		forceinline iterator begin( ) { return		array_.begin( ); }
		forceinline const_iterator begin( ) const { return  array_.begin( ); }
		forceinline iterator end( ) { return		 array_.end( ); }
		forceinline const_iterator end( ) const { return array_.end( ); }
		forceinline const_iterator cbegin( ) const { return  array_.begin( ); }
		forceinline const_iterator cend( ) const { return array_.end( ); }

		forceinline reverse_iterator rbegin( ) { return array_.rbegin( ); }
		forceinline const_reverse_iterator rbegin( ) const { return array_.rbegin( ); }
		forceinline reverse_iterator rend( ) { return array_.rend( ); }
		forceinline const_reverse_iterator rend( ) const { return array_.rend( ); }
		forceinline const_reverse_iterator crbegin( ) const { return array_.rbegin( ); }
		forceinline const_reverse_iterator crend( ) const { return array_.rend( ); }
	#pragma endregion

		forceinline Array2( ) :array_ {} , sz { 0,0,0,0 } { }
		forceinline Array2( Extent extents ) : array_( extents[ 0 ] * extents[ 1 ] ) , sz { extents } { }

		forceinline T& operator[]( const Extent& extents ) { return array_[ cnvtExtntTIdx( extents ) ]; }
		forceinline const T& operator[]( const Extent& extents ) const { return array_[ cnvtExtntTIdx( extents ) ]; }
		forceinline T& At( const Extent& extents ) { return array_.at( cnvtExtntTIdx( extents ) ); }
		forceinline const T& At( const Extent& extents ) const { return array_.at( cnvtExtntTIdx( extents ) ); }
		forceinline T& at( const Extent& extents ) { return array_.at( cnvtExtntTIdx( extents ) ); }
		forceinline const T& at( const Extent& extents ) const { return array_.at( cnvtExtntTIdx( extents ) ); }

		forceinline Extent Size( ) const noexcept { return sz; }
		forceinline Extent size( ) const noexcept { return sz; }

		forceinline array_t& __NATIVE( ) noexcept { return array_; }
		forceinline const array_t& __NATIVE( ) const noexcept { return array_; }
	};

	template<typename T>
	class Array3
	{
		using array_t = std::vector<T>;
		array_t array_;
		Extent sz;

		inline ULong cnvtExtntTIdx( const Extent& ext ) const noexcept
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
		forceinline iterator begin( ) { return		array_.begin( ); }
		forceinline const_iterator begin( ) const { return  array_.begin( ); }
		forceinline iterator end( ) { return		 array_.end( ); }
		forceinline const_iterator end( ) const { return array_.end( ); }
		forceinline const_iterator cbegin( ) const { return  array_.begin( ); }
		forceinline const_iterator cend( ) const { return array_.end( ); }

		forceinline reverse_iterator rbegin( ) { return array_.rbegin( ); }
		forceinline const_reverse_iterator rbegin( ) const { return array_.rbegin( ); }
		forceinline reverse_iterator rend( ) { return array_.rend( ); }
		forceinline const_reverse_iterator rend( ) const { return array_.rend( ); }
		forceinline const_reverse_iterator crbegin( ) const { return array_.rbegin( ); }
		forceinline const_reverse_iterator crend( ) const { return array_.rend( ); }
	#pragma endregion

		forceinline Array3( ) :array_ {} , sz { 0,0,0,0 } { }
		forceinline Array3( Extent extents ) : array_( extents[ 0 ] * extents[ 1 ] * extents[ 2 ] ) , sz { extents } { }

		forceinline T& operator[]( const Extent& extents ) { return array_[ cnvtExtntTIdx( extents ) ]; }
		forceinline const T& operator[]( const Extent& extents ) const { return array_[ cnvtExtntTIdx( extents ) ]; }
		forceinline T& At( const Extent& extents ) { return array_.at( cnvtExtntTIdx( extents ) ); }
		forceinline const T& At( const Extent& extents ) const { return array_.at( cnvtExtntTIdx( extents ) ); }
		forceinline T& at( const Extent& extents ) { return array_.at( cnvtExtntTIdx( extents ) ); }
		forceinline const T& at( const Extent& extents ) const { return array_.at( cnvtExtntTIdx( extents ) ); }

		forceinline Extent Size( ) const noexcept { return sz; }
		forceinline Extent size( ) const noexcept { return sz; }

		forceinline array_t& __NATIVE( ) noexcept { return array_; }
		forceinline const array_t& __NATIVE( ) const noexcept { return array_; }
	};

	template<typename T>
	class Array4
	{
		using array_t = std::vector<T>;
		array_t array_;
		Extent sz;

		inline ULong cnvtExtntTIdx( const Extent& ext ) const noexcept
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
		forceinline iterator begin( ) { return		array_.begin( ); }
		forceinline const_iterator begin( ) const { return  array_.begin( ); }
		forceinline iterator end( ) { return		 array_.end( ); }
		forceinline const_iterator end( ) const { return array_.end( ); }
		forceinline const_iterator cbegin( ) const { return  array_.begin( ); }
		forceinline const_iterator cend( ) const { return array_.end( ); }

		forceinline reverse_iterator rbegin( ) { return array_.rbegin( ); }
		forceinline const_reverse_iterator rbegin( ) const { return array_.rbegin( ); }
		forceinline reverse_iterator rend( ) { return array_.rend( ); }
		forceinline const_reverse_iterator rend( ) const { return array_.rend( ); }
		forceinline const_reverse_iterator crbegin( ) const { return array_.rbegin( ); }
		forceinline const_reverse_iterator crend( ) const { return array_.rend( ); }
	#pragma endregion

		forceinline Array4( ) :array_ {} , sz { 0,0,0,0 } { }
		forceinline Array4( Extent extents ) : array_( extents[ 0 ] * extents[ 1 ] * extents[ 2 ] * extents[ 3 ] ) , sz { extents } { }

		forceinline T& operator[]( const Extent& extents ) { return array_[ cnvtExtntTIdx( extents ) ]; }
		forceinline const T& operator[]( const Extent& extents ) const { return array_[ cnvtExtntTIdx( extents ) ]; }
		forceinline T& At( const Extent& extents ) { return array_.at( cnvtExtntTIdx( extents ) ); }
		forceinline const T& At( const Extent& extents ) const { return array_.at( cnvtExtntTIdx( extents ) ); }
		forceinline T& at( const Extent& extents ) { return array_.at( cnvtExtntTIdx( extents ) ); }
		forceinline const T& at( const Extent& extents ) const { return array_.at( cnvtExtntTIdx( extents ) ); }

		forceinline Extent Size( ) const noexcept { return sz; }
		forceinline Extent size( ) const noexcept { return sz; }

		forceinline array_t& __NATIVE( ) noexcept { return array_; }
		forceinline const array_t& __NATIVE( ) const noexcept { return array_; }
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
		forceinline iterator begin( ) { return		base( ).begin( ); }
		forceinline const_iterator begin( ) const { return  base( ).begin( ); }
		forceinline iterator end( ) { return		 base( ).end( ); }
		forceinline const_iterator end( ) const { return base( ).end( ); }
		forceinline const_iterator cbegin( ) const { return  base( ).begin( ); }
		forceinline const_iterator cend( ) const { return base( ).end( ); }

		forceinline reverse_iterator rbegin( ) { return base( ).rbegin( ); }
		forceinline const_reverse_iterator rbegin( ) const { return base( ).rbegin( ); }
		forceinline reverse_iterator rend( ) { return base( ).rend( ); }
		forceinline const_reverse_iterator rend( ) const { return base( ).rend( ); }
		forceinline const_reverse_iterator crbegin( ) const { return base( ).rbegin( ); }
		forceinline const_reverse_iterator crend( ) const { return base( ).rend( ); }
	#pragma endregion


		forceinline DynArray( ) : base_t( ) { }
		inline DynArray( int len ) : base_t( ) { base( ).reserve( ( ULong ) len ); }
		template<typename TIter>
		forceinline DynArray( const TIter& beg , const TIter& end ) : base_t( beg , end ) { }
		forceinline DynArray( std::initializer_list<T> init ) : base_t( init ) { }

		forceinline T& operator[]( const int& idx ) { return base( )[ ( ULong ) idx ]; }
		forceinline const T& operator[]( const int& idx ) const { return base( )[ ( ULong ) idx ]; }
		forceinline T& At( const int& idx ) { return base( ).at( ( ULong ) idx ); }
		forceinline const T& At( const int& idx ) const { return base( ).at( ( ULong ) idx ); }
		forceinline T& at( const int& idx ) { return base( ).at( ( ULong ) idx ); }
		forceinline const T& at( const int& idx ) const { return base( ).at( ( ULong ) idx ); }

		forceinline int Size( ) const { return ( int ) base( ).size( ); }
		forceinline int Length( ) const { return ( int ) base( ).size( ); }
		template<typename _T>
		forceinline void Add( _T&& item )
		{ base( ).emplace_back( std::forward<_T>( item ) ); }
		forceinline void Clear( ) { base( ).clear( ); }
		forceinline bool Contains( const T& item )
		{ return std::find( begin( ) , end( ) , item ) != end( ); }
		template<typename TF>
		forceinline bool Exists( TF&& func ) const { return std::any_of( begin( ) , end( ) , std::forward<TF>( func ) ); }
		template<typename TF>
		T& Find( TF&& func )
		{
			auto iter = std::find_if( begin( ) , end( ) , std::forward<TF>( func ) );
			if ( iter == end( ) )throw ValueNotFoundException( );
			return *iter;
		}
		template<typename TF>
		const T& Find( TF&& func ) const
		{
			auto iter = std::find_if( begin( ) , end( ) , std::forward<TF>( func ) );
			if ( iter == end( ) )throw ValueNotFoundException( );
			return *iter;
		}
		template<typename TF>
		DynArray<T> FindAll( TF&& func )
		{
			DynArray<T> retVal;
			std::copy_if( begin( ) , end( ) , std::back_inserter( retVal ) , std::forward<TF>( func ) );
			return retVal;
		}
		template<typename TF>
		DynArray<T> FindAll( TF&& func ) const
		{
			DynArray<T> retVal;
			std::copy_if( begin( ) , end( ) , std::back_inserter( retVal ) , std::forward<TF>( func ) );
			return retVal;
		}
		template<typename TF>
		int FindIndex( int startIndex , int count , TF&& match )
		{
			auto iter = std::find_if( begin( ) + startIndex , begin( ) + startIndex + count , std::forward<TF>( match ) );
			if ( iter == ( begin( ) + startIndex + count ) )return -1;
			return ( int ) ( iter - begin( ) );
		}
		template<typename TF>
		int FindIndex( int startIndex , TF&& match )
		{
			auto iter = std::find_if( begin( ) + startIndex , end( ) , std::forward<TF>( match ) );
			if ( iter == end( ) )return -1;
			return ( int ) ( iter - begin( ) );
		}
		template<typename TF>
		int FindIndex( TF&& match )
		{
			auto iter = std::find_if( begin( ) , end( ) , std::forward<TF>( match ) );
			if ( iter == end( ) )return -1;
			return ( int ) ( iter - begin( ) );
		}
		template<typename TF>
		int FindIndex( int startIndex , int count , TF&& match ) const
		{
			auto iter = std::find_if( begin( ) + startIndex , begin( ) + startIndex + count , std::forward<TF>( match ) );
			if ( iter == ( begin( ) + startIndex + count ) )return -1;
			return ( int ) ( iter - begin( ) );
		}
		template<typename TF>
		int FindIndex( int startIndex , TF&& match ) const
		{
			auto iter = std::find_if( begin( ) + startIndex , end( ) , std::forward<TF>( match ) );
			if ( iter == end( ) )return -1;
			return ( int ) ( iter - begin( ) );
		}
		template<typename TF>
		int FindIndex( TF&& match ) const
		{
			auto iter = std::find_if( begin( ) , end( ) , std::forward<TF>( match ) );
			if ( iter == end( ) )return -1;
			return ( int ) ( iter - begin( ) );
		}
		template<typename TF>
		int FindLastIndex( TF&& match )
		{
			auto iter = std::find_if( rbegin( ) , rend( ) , std::forward<TF>( match ) );
			if ( iter == rend( ) )return -1;
			return ( int ) ( base( ).size( ) - 1 - ( iter - rbegin( ) ) );
		}
		template<typename TF>
		forceinline void ForEach( TF&& f )
		{ std::for_each( begin( ) , end( ) , std::forward<TF>( f ) ); }
		template<typename TF>
		forceinline void ForEach( TF&& f ) const
		{ std::for_each( begin( ) , end( ) , std::forward<TF>( f ) ); }
		template<typename TF>
		forceinline void RevForEach( TF&& f )
		{ std::for_each( rbegin( ) , rend( ) , std::forward<TF>( f ) ); }
		template<typename TF>
		forceinline void RevForEach( TF&& f ) const
		{ std::for_each( rbegin( ) , rend( ) , std::forward<TF>( f ) ); }
		forceinline DynArray<T> GetRange( int index , int count )
		{ return DynArray<T>( begin( ) + index , begin( ) + index + count ); }
		int IndexOf( const T& item , int index , int count )
		{
			auto idx = std::find( begin( ) + index , begin( ) + index + count + 1 , item );
			if ( idx == end( ) )return -1;
			return ( int ) ( idx - begin( ) );
		}
		int IndexOf( const T& item , int index )
		{
			auto idx = std::find( begin( ) + index , end( ) , item );
			if ( idx == end( ) )return -1;
			return ( int ) ( idx - begin( ) );
		}
		int IndexOf( const T& item )
		{
			auto idx = std::find( begin( ) , end( ) , item );
			if ( idx == end( ) )return -1;
			return ( int ) ( idx - begin( ) );
		}
		template<typename _T>
		forceinline void Insert( int index , _T&& item )
		{ base( ).emplace( begin( ) + index , std::forward<_T>( item ) ); }
		int LastIndexOf( const T& item )
		{
			auto iter = std::find( rbegin( ) , rend( ) , item );
			if ( iter == rend( ) )return -1;
			return ( int ) ( base( ).size( ) - 1 - ( iter - rbegin( ) ) );
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
		forceinline void Reverse( int index , int count ) { std::reverse( begin( ) + index , begin( ) + index + count ); }
		forceinline void Reverse( ) { std::reverse( begin( ) , end( ) ); }
		forceinline int Capacity( ) { return ( int ) base( ).capacity( ); }
		forceinline void Capacity( int size ) { base( ).reserve( ( ULong ) size ); }

		forceinline void Sort( ) { std::sort( begin( ) , end( ) ); }
		template<typename TF>
		forceinline void Sort( TF&& comparer ) { std::sort( begin( ) , end( ) , std::forward<TF>( comparer ) ); }
		forceinline void TrimExcess( ) { base( ).shrink_to_fit( ); }
		template<typename TF>
		forceinline bool TrueForAll( TF&& match ) { return std::all_of( begin( ) , end( ) , std::forward<TF>( match ) ); }

		forceinline void RemoveAt( int index ) { base( ).erase( begin( ) + index ); }

		forceinline base_t& __NATIVE( ) { return base( ); }
		forceinline const base_t& __NATIVE( ) const { return base( ); }
	};
}
