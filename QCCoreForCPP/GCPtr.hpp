#pragma once
#include "predef_and_include.hpp"
#include <memory>
#include <exception>

namespace QCCore
{
	using nullptr_t = std::nullptr_t;
	using NullPtrType = std::nullptr_t;
	struct NullPointerException : public std::exception
	{
		NullPointerException( ) noexcept { }
		virtual const char * what( ) const noexcept override { return "read access violation, value was nullptr"; }
	};

	struct BadWeakPtrException : public std::exception
	{
		BadWeakPtrException( ) noexcept { }
		virtual const char * what( ) const noexcept override { return "BadWeakPtr"; }
	};

	template<typename T>struct RefWrap { T value; };

	template<typename T>
	class GCPtr
	{
		std::shared_ptr<T> ptr;

		void NoValueThenThrow( ) const { if ( !HasValue( ) )throw NullPointerException( ); }

		forceinline GCPtr( std::shared_ptr<T>&& p ) :ptr { p } { }
		forceinline GCPtr( const std::shared_ptr<T>& p ) : ptr { p } { }
	public:
		using element_type = T;

		forceinline GCPtr( ) noexcept :ptr {  } { }
		forceinline GCPtr( nullptr_t ) noexcept :ptr { } { }
		forceinline explicit GCPtr( T* value ) : ptr { value } { }
		forceinline explicit GCPtr( const T& value ) : ptr { new T( value ) } { }

		forceinline explicit operator bool( ) const noexcept { return ptr != nullptr; }
		forceinline GCPtr<T>& Reset( ) noexcept { ptr.reset( ); return *this; }
		forceinline GCPtr<T>& Reset( T* value ) { ptr.reset( value ); return *this; }
		forceinline GCPtr<T>& Reset( const T& value )
		{
			ptr.reset( new T( value ) );
			return *this;
		}

		forceinline T& Get( ) { NoValueThenThrow( ); return *ptr; }
		forceinline const T& Get( ) const { NoValueThenThrow( ); return *ptr; }

		forceinline bool HasValue( ) const noexcept { return ptr != nullptr; }

		forceinline bool operator!=( nullptr_t )const noexcept { return ptr != nullptr; }
		forceinline bool operator==( nullptr_t )const noexcept { return ptr == nullptr; }

		forceinline std::shared_ptr<T>& __NATIVE( ) noexcept { return ptr; }
		forceinline const std::shared_ptr<T>& __NATIVE( ) const noexcept { return ptr; }
		forceinline bool operator ==( GCPtr<T> ptr2 ) { return Equals( ptr2 ); }
		forceinline bool operator !=( GCPtr<T> ptr2 ) { return !Equals( ptr2 ); }

		forceinline bool Equals( GCPtr<T> other ) { return ptr == other.ptr; }
		template<typename T>
		friend class WeakPtr;
		template<typename T>
		friend class IEnableGCPtrFromMe;
	};

	template<typename T>
	forceinline bool operator!=( nullptr_t , const GCPtr<T>& val )
	{ return val != nullptr; }

	template<typename T>
	forceinline bool operator==( nullptr_t , const GCPtr<T>& val )
	{ return val == nullptr; }

	template<typename T>
	class WeakPtr
	{
		std::weak_ptr<T> wptr;

		forceinline WeakPtr( std::weak_ptr<T>&& p ) :wptr( std::move( p ) ) { }
		forceinline WeakPtr( const std::weak_ptr<T>& p ) : wptr( p ){}
	public:
		forceinline WeakPtr( ) noexcept :wptr( ) { }
		forceinline WeakPtr( nullptr_t ) noexcept :wptr( ) { }
		forceinline WeakPtr( const GCPtr<T>& ptr ) noexcept :wptr( ptr.ptr ) { }

		forceinline WeakPtr<T>& Reset( ) noexcept { wptr.reset( ); return *this; }
		forceinline bool Expired( ) { return wptr.expired( ); }

		forceinline GCPtr<T> Lock( ) { return GCPtr<T>( wptr.lock( ) ); }
		GCPtr<T> LockIfNotThrow( )
		{
			auto lockedVal = wptr.lock( );
			if ( lockedVal == nullptr ) throw BadWeakPtrException( );
			return GCPtr<T>( std::move( lockedVal ) );
		}

		forceinline WeakPtr<T>& operator=( const GCPtr<T>& ptr ) { wptr = ptr.ptr; return *this; }
		forceinline WeakPtr<T>& operator=( GCPtr<T>&& ptr ) { wptr = ptr.ptr; return *this; }

		forceinline bool operator!=( nullptr_t )const noexcept { return wptr != nullptr; }
		forceinline bool operator==( nullptr_t )const noexcept { return wptr == nullptr; }

		template<typename T>
		friend class IEnableGCPtrFromMe;
	};

	template<typename T>
	forceinline bool operator!=( nullptr_t , const WeakPtr<T>& val )
	{ return val != nullptr; }

	template<typename T>
	forceinline bool operator==( nullptr_t , const WeakPtr<T>& val )
	{ return val == nullptr; }

	template<typename T>
	class IEnableGCPtrFromMe : public std::enable_shared_from_this<T>
	{
		using base_t = std::enable_shared_from_this<T>;
		base_t& base( ) { return *this; }
		const base_t& base( ) const { return *this; }
	public:
		GCPtr<T> GCFromMe( )
		{ return GCPtr<T>( base( ).shared_from_this( ) ); }

		GCPtr<const T> GCFromMe( ) const
		{ return GCPtr<const T>( base( ).shared_from_this( ) ); }

		WeakPtr<T> WeakFromMe( ) noexcept
		{ return WeakPtr<T>( base( ).weak_from_this( ) ); }

		WeakPtr<const T> WeakFromMe( ) const noexcept
		{ return WeakPtr<const T>( base( ).weak_from_this( ) ); }
	};
}