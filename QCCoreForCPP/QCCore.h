#pragma once

#include "predef_and_include.h"

namespace QCCore
{	template<typename... Args>
	size_t CombineHashCodes( Args&&... hashCodes )
	{
		size_t hash1 = ( 0x1505UL << 0x10UL ) + 0x1505UL;
		size_t hash2 = hash1;

		size_t i = 0UL;
		auto f = [ &hash1 , &hash2 , &i ] ( auto&& hashCode )
		{
			if ( i % 0x2 == 0x0 )
				hash1 = ( ( hash1 << 0x5 ) + hash1 + ( hash1 >> 0x1b ) ) ^ hashCode;
			else
				hash2 = ( ( hash2 << 0x5 ) + hash2 + ( hash2 >> 0x1b ) ) ^ hashCode;

			++i;
		};
		( f( hashCodes ) , ... );

		return hash1 + ( hash2 * 0x5d588b65 );
	}

	class InvalidCastException : public std::bad_cast
	{
	public:
		virtual inline const char * what( ) const BOOST_NOEXCEPT_OR_NOTHROW
		{ return "InvalidCastException: failed conversion using As<T>"; }
	};

	template<typename T> inline const T& As( const Object& obj )
	{
		try { return *boost::any_cast< T >( &obj ); }
		catch ( ... ) { throw InvalidCastException( ); }
	}
	template<typename T> inline T& As( Object& obj )
	{
		try { return *boost::any_cast< T >( &obj ); }
		catch ( ... ) { throw InvalidCastException( ); }
	}
	template<typename T> inline T As( Object&& obj )
	{
		try { return boost::any_cast< T >( obj ); }
		catch ( ... ) { throw InvalidCastException( ); }
	}
	template<typename T> inline T* As( Object* obj )
	{
		return boost::any_cast< T >( obj );
	}
	template<typename T> inline const T* As( const Object* obj )
	{
		return boost::any_cast< T >( obj );
	}
	template<typename T> inline String TypeName( T& v )
	{
		return boost::typeindex::type_id_with_cvr<decltype( v )>( ).pretty_name( );
	}
	template<typename T> inline String TypeNameNoCVR( T& v )
	{ return boost::typeindex::type_id_with_cvr<boost::remove_cv_ref_t<decltype( v )>>( ).pretty_name( ); }

	template<typename T> inline String RTTITypeName( T&& v ) { return typeid( v ).name( ); }
	template<typename T> inline size_t Hash( T&& val ) { return std::hash<T>( )( val ); }

	template<typename T> inline auto Pipable( T&& v )
	{ return boost::hof::pipable( v ); }

	template<class _Ty>
	boost::add_reference_t<boost::add_const<_Ty>> cdeclref( ) noexcept;

	template<typename T1 , typename T2>
	using AreComparable = decltype( cdeclref<T1>( ) == cdeclref<T2>( ) );

	template<typename T1 , typename T2>
	constexpr inline bool AreEqualDTrue( const T1& v1 , const T2& v2 )
	{
		if constexpr ( boost::is_detected_v<AreComparable , T1 , T2> )
			return v1 == v2;
		else return true;
	}

	template<typename T> using HasGHC = decltype( cdeclref<T>( ).GetHashCode( ) );

	struct Hasher
	{
		template<typename T>
		inline size_t operator()( const T& val ) const noexcept( noexcept( ( *this )( val , std::bool_constant<boost::is_detected_v<HasGHC , boost::remove_cv_ref_t<T>>>( ) ) ) )
		{ return ( *this )( val , std::bool_constant<boost::is_detected_v<HasGHC , boost::remove_cv_ref_t<T>>>( ) ); }

	private:
		template<typename T>
		inline size_t operator()( const T& val , std::true_type ) const noexcept( noexcept( val.GetHashCode( ) ) )
		{ return val.GetHashCode( ); }
		template<typename T>
		inline size_t operator()( const T& val , std::false_type ) const noexcept( noexcept( std::hash<T>( )( val ) ) )
		{ return std::hash<boost::remove_cv_ref_t<T>>( )( val ); }
	};
}

#include "ConstN.h"
#include "QStruct.h"
#include "Array.h"
