#pragma once
#include "predef_and_include.hpp"
#include <boost\algorithm\string.hpp>
#include "Array.hpp"

namespace QCCore
{
	template<typename T> class BasicStringRef;

	template<typename T>
	class BasicString final : public std::basic_string<T>
	{
	public:
		using base_t = std::basic_string<T>;
		forceinline base_t& base( ) { return *this; }
		forceinline constexpr const base_t& base( )const { return *this; }

		using self = BasicString<T>;
		using value_type = T;
		using reference = T & ;
		using const_reference = const T&;
		using iterator = typename base_t::iterator;
		using const_iterator = typename base_t::const_iterator;
		using reverse_iterator = typename base_t::reverse_iterator;
		using const_reverse_iterator = typename base_t::const_reverse_iterator;

		forceinline iterator begin( ) { return std::begin( base( ) ); }
		forceinline constexpr const_iterator begin( ) const { return std::begin( base( ) ); }
		forceinline iterator end( ) { return std::end( base( ) ); }
		forceinline constexpr const_iterator end( ) const { return std::end( base( ) ); }
		forceinline constexpr const_iterator cbegin( ) const { return std::cbegin( base( ) ); }
		forceinline constexpr const_iterator cend( ) const { return std::cend( base( ) ); }

		forceinline reverse_iterator rbegin( ) { return std::rbegin( base( ) ); }
		forceinline constexpr const_reverse_iterator rbegin( ) const { return std::rbegin( base( ) ); }
		forceinline reverse_iterator rend( ) { return std::rend( base( ) ); }
		forceinline constexpr const_reverse_iterator rend( ) const { return std::rend( base( ) ); }
		forceinline constexpr const_reverse_iterator crbegin( ) const { return std::crbegin( base( ) ); }
		forceinline constexpr const_reverse_iterator crend( ) const { return std::crend( base( ) ); }

		forceinline BasicString( const std::basic_string_view<T>& v ) :base_t( v ) { }
		forceinline BasicString( const BasicStringRef<T>& v );
		forceinline BasicString( const base_t& v ) :base_t( v ) { }
		forceinline BasicString( base_t&& v ) : base_t( std::move( v ) ) { }
		forceinline BasicString( ) : base_t( ) { }

		template<typename Iter> BasicString( Iter beg , Iter end ) : base_t( beg , end ) { }
		forceinline BasicString( const T* value ) : base_t( value ) { }
		forceinline BasicString( const T* value , int startIndex , int length ) : base_t( value , startIndex , length ) { }

		forceinline const T& operator[]( int idx ) const { return base( )[ ( size_t ) idx ]; }

		forceinline int Length( ) const { return ( int ) base( ).length( ); }

		forceinline bool Contains( const self& s )const { return ( s.Length( ) == 0 ) || boost::contains( base( ) , s ); }
		forceinline bool EndsWith( const self& s )const { return ( s.Length( ) == 0 ) || boost::ends_with( base( ) , s ); }
		forceinline bool StartsWith( const self& s )const { return ( s.Length( ) == 0 ) || boost::starts_with( base( ) , s ); }
		forceinline bool Equals( const self& s )const { return base( ) == s.base( ); }
		forceinline size_t GetHashCode( ) const { return QCCore::Hash( base( ) ); }
		forceinline self Substring( int startIndex , int length ) { return self( base( ).substr( startIndex , length ) ); }
		forceinline self Substring( int startIndex ) { return self( base( ).substr( startIndex ) ); }

		forceinline self& operator+=( const self& s ) { base( ) += s.base( ); return *this; }
		forceinline self& operator+=( self&& s ) { base( ) += std::move( s.base( ) ); return *this; }
		forceinline self operator+( const self& s )const { return self( base( ) + s.base( ) ); }
		forceinline self operator+( self&& s ) const { return self( base( ) + std::move( s.base( ) ) ); }
		forceinline bool operator==( const self& s ) const { return base( ) == s.base( ); }
		forceinline bool operator!=( const self& s ) const { return base( ) != s.base( ); }

		forceinline void swap( self& rhs ) { base( ).swap( rhs.base( ) ); }

		template<typename T> friend class BasicStringRef;
	};

	template<typename T>
	class BasicStringRef final : public std::basic_string_view<T>
	{
	public:
		using base_t = std::basic_string_view<T>;
		forceinline constexpr base_t& base( ) { return *this; }
		forceinline constexpr const base_t& base( )const { return *this; }

		using self = BasicStringRef<T>;
		using value_type = T;
		using reference = T & ;
		using const_reference = const T&;
		using iterator = typename base_t::iterator;
		using const_iterator = typename base_t::const_iterator;
		using reverse_iterator = typename base_t::reverse_iterator;
		using const_reverse_iterator = typename base_t::const_reverse_iterator;

		forceinline constexpr BasicStringRef( const base_t& v ) :base_t( v ) { }
		forceinline constexpr BasicStringRef( base_t&& v ) : base_t( std::move( v ) ) { }

		forceinline iterator begin( ) { return std::begin( base( ) ); }
		forceinline constexpr const_iterator begin( ) const { return std::begin( base( ) ); }
		forceinline iterator end( ) { return std::end( base( ) ); }
		forceinline constexpr const_iterator end( ) const { return std::end( base( ) ); }
		forceinline constexpr const_iterator cbegin( ) const { return std::cbegin( base( ) ); }
		forceinline constexpr const_iterator cend( ) const { return std::cend( base( ) ); }

		forceinline reverse_iterator rbegin( ) { return std::rbegin( base( ) ); }
		forceinline constexpr const_reverse_iterator rbegin( ) const { return std::rbegin( base( ) ); }
		forceinline reverse_iterator rend( ) { return std::rend( base( ) ); }
		forceinline constexpr const_reverse_iterator rend( ) const { return std::rend( base( ) ); }
		forceinline constexpr const_reverse_iterator crbegin( ) const { return std::crbegin( base( ) ); }
		forceinline constexpr const_reverse_iterator crend( ) const { return std::crend( base( ) ); }

		forceinline constexpr BasicStringRef(  ) : base_t(  ) { }
		forceinline constexpr BasicStringRef( const T* value ) : base_t( value ) { }
		forceinline constexpr BasicStringRef( const T* value , int startIndex , int length ) : base_t( value , startIndex , length ) { }

		forceinline constexpr const T& operator[]( int idx ) const { return base( )[ ( size_t ) idx ]; }

		forceinline constexpr int Length( ) const { return ( int ) base( ).length( ); }
		forceinline constexpr int Count( ) const { return ( int ) base( ).length( ); }
		forceinline constexpr int Size( ) const { return ( int ) base( ).length( ); }

		forceinline bool Contains( const self& s )const { return ( s.Length( ) == 0 ) || boost::contains( base( ) , s ); }
		forceinline bool EndsWith( const self& s )const { return ( s.Length( ) == 0 ) || boost::ends_with( base( ) , s ); }
		forceinline bool StartsWith( const self& s )const { return ( s.Length( ) == 0 ) || boost::starts_with( base( ) , s ); }
		forceinline constexpr bool Equals( const self& s )const { return base( ) == s.base( ); }
		forceinline size_t GetHashCode( ) const { return QCCore::Hash( base( ) ); }
		forceinline constexpr self Substring( int startIndex , int length ) { return self( base( ).substr( startIndex , length ) ); }
		forceinline constexpr self Substring( int startIndex ) { return self( base( ).substr( startIndex ) ); }

		forceinline operator BasicString<T>( ) { return BasicString<T>( base( ) ); }
		forceinline constexpr bool operator==( const self& s ) const { return base( ) == s.base( ); }
		forceinline constexpr bool operator!=( const self& s ) const { return base( ) != s.base( ); }

		forceinline void swap( self& rhs ) { base( ).swap( rhs.base( ) ); }

		template<typename T> friend class BasicString;
	};

	using String = BasicString<char>;
	using WString = BasicString<wchar_t>;
	using StringRef = BasicStringRef<char>;
	using WStringRef = BasicStringRef<wchar_t>;
	template<typename T> forceinline BasicString<T>::BasicString( const BasicStringRef<T>& v ) :base_t( v.base( ) ) { }
}