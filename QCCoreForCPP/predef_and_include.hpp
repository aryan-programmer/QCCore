#pragma once

#define _SILENCE_CXX17_ITERATOR_BASE_CLASS_DEPRECATION_WARNING
#define _SILENCE_CXX17_OLD_ALLOCATOR_MEMBERS_DEPRECATION_WARNING

#include <climits>
#include <cmath>
#include <string>
#include <cstddef>
#include <functional>
#include <boost\any.hpp>
#include <boost\type_index.hpp>
#include <boost\hof\pipable.hpp>
#include <boost\hof\flow.hpp>
#include <boost\hof\function.hpp>
#include <boost\type_traits\is_detected.hpp>
#include <boost\type_traits\add_const.hpp>
#include <boost\type_traits\add_reference.hpp>
#include <boost\type_traits\remove_cv_ref.hpp>
#include <boost\preprocessor\variadic\size.hpp>
#include <boost\preprocessor\variadic\to_seq.hpp>
#include <boost\preprocessor\seq\for_each_i.hpp>
#include <boost\preprocessor\arithmetic\inc.hpp>

#define _DECOMPOSE_QS_NNV_helper(r, data, i, elem) elem = data.BOOST_PP_CAT(Item,BOOST_PP_INC(i));
#define _DECOMPOSE_QS_NNV(qstruct, ...) BOOST_PP_SEQ_FOR_EACH_I(_DECOMPOSE_QS_NNV_helper,qstruct,BOOST_PP_VARIADIC_TO_SEQ(__VA_ARGS__)); static_assert(::QCCore::__dimentionality<boost::remove_cv_ref_t<decltype(qstruct)>>::value == BOOST_PP_VARIADIC_SIZE(__VA_ARGS__), "The number of elements of the QStruct and the number of variables being decomposed to must match.")
#define _DECOMPOSE_QS(qstruct, ...) auto [__VA_ARGS__] = qstruct
#define forceinline BOOST_FORCEINLINE

#if _HAS_CXX17
#define ___NODISCARD___ [[nodiscard]]
#else
#define ___NODISCARD___
#endif /* _HAS_NODISCARD */

namespace std
{
	// ENUM CLASS sbyte
	enum class sbyte : char { };

	template<class _IntType ,
		enable_if_t<is_integral_v<_IntType> , int> = 0>
		___NODISCARD___ forceinline constexpr sbyte operator<<( const sbyte _Arg , const _IntType _Shift ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >( static_cast< int >( _Arg ) << _Shift ) ) );
	}

	template<class _IntType ,
		enable_if_t<is_integral_v<_IntType> , int> = 0>
		___NODISCARD___ forceinline constexpr sbyte operator>>( const sbyte _Arg , const _IntType _Shift ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >( static_cast< int >( _Arg ) >> _Shift ) ) );
	}

	___NODISCARD___ forceinline constexpr sbyte operator|( const sbyte _Left , const sbyte _Right ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >(
			static_cast< int >( _Left ) | static_cast< int >( _Right ) ) ) );
	}

	___NODISCARD___ forceinline constexpr sbyte operator&( const sbyte _Left , const sbyte _Right ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >(
			static_cast< int >( _Left ) & static_cast< int >( _Right ) ) ) );
	}

	___NODISCARD___ forceinline constexpr sbyte operator^( const sbyte _Left , const sbyte _Right ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >(
			static_cast< int >( _Left ) ^ static_cast< int >( _Right ) ) ) );
	}

	___NODISCARD___ forceinline constexpr sbyte operator~( const sbyte _Arg ) noexcept
	{	// bitwise NOT, every static_cast is intentional
		return ( static_cast< sbyte >( static_cast< char >( ~static_cast< int >( _Arg ) ) ) );
	}

	template<class _IntType , enable_if_t<is_integral_v<_IntType> , int> = 0>
	constexpr sbyte& operator<<=( sbyte& _Arg , const _IntType _Shift ) noexcept { return ( _Arg = _Arg << _Shift ); }

	template<class _IntType , enable_if_t<is_integral_v<_IntType> , int> = 0>
	constexpr sbyte& operator>>=( sbyte& _Arg , const _IntType _Shift ) noexcept { return ( _Arg = _Arg >> _Shift ); }

	constexpr sbyte& operator|=( sbyte& _Left , const sbyte _Right ) noexcept { return ( _Left = _Left | _Right ); }

	constexpr sbyte& operator&=( sbyte& _Left , const sbyte _Right ) noexcept { return ( _Left = _Left & _Right ); }

	constexpr sbyte& operator^=( sbyte& _Left , const sbyte _Right ) noexcept { return ( _Left = _Left ^ _Right ); }

	template<class _IntType ,
		enable_if_t<is_integral_v<_IntType> , int> = 0>
		___NODISCARD___ forceinline constexpr sbyte operator+( const sbyte _Arg , const _IntType _Shift ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >( static_cast< int >( _Arg ) + _Shift ) ) );
	}

	template<class _IntType ,
		enable_if_t<is_integral_v<_IntType> , int> = 0>
		___NODISCARD___ forceinline constexpr sbyte operator-( const sbyte _Arg , const _IntType _Shift ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >( static_cast< int >( _Arg ) - _Shift ) ) );
	}

	___NODISCARD___ forceinline constexpr sbyte operator/( const sbyte _Left , const sbyte _Right ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >(
			static_cast< int >( _Left ) / static_cast< int >( _Right ) ) ) );
	}

	___NODISCARD___ forceinline constexpr sbyte operator*( const sbyte _Left , const sbyte _Right ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >(
			static_cast< int >( _Left ) * static_cast< int >( _Right ) ) ) );
	}

	___NODISCARD___ forceinline constexpr sbyte operator%( const sbyte _Left , const sbyte _Right ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >(
			static_cast< int >( _Left ) % static_cast< int >( _Right ) ) ) );
	}

	___NODISCARD___ forceinline constexpr sbyte operator-( const sbyte _Arg ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >( -static_cast< int >( _Arg ) ) ) );
	}

	___NODISCARD___ forceinline constexpr sbyte operator+( const sbyte _Arg ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >( +static_cast< int >( _Arg ) ) ) );
	}

	template<class _IntType , enable_if_t<is_integral_v<_IntType> , int> = 0>
	constexpr sbyte& operator+=( sbyte& _Arg , const _IntType _Shift ) noexcept { return ( _Arg = _Arg + _Shift ); }

	template<class _IntType , enable_if_t<is_integral_v<_IntType> , int> = 0>
	constexpr sbyte& operator-=( sbyte& _Arg , const _IntType _Shift ) noexcept { return ( _Arg = _Arg - _Shift ); }

	constexpr sbyte& operator/=( sbyte& _Left , const sbyte _Right ) noexcept { return ( _Left = _Left / _Right ); }

	constexpr sbyte& operator*=( sbyte& _Left , const sbyte _Right ) noexcept { return ( _Left = _Left * _Right ); }

	constexpr sbyte& operator%=( sbyte& _Left , const sbyte _Right ) noexcept { return ( _Left = _Left % _Right ); }

	template<class _IntType ,
		enable_if_t<is_integral_v<_IntType> , int> = 0>
		___NODISCARD___ forceinline constexpr byte operator+( const byte _Arg , const _IntType _Shift ) noexcept
	{
		return ( static_cast< byte >( static_cast< char >( static_cast< int >( _Arg ) + _Shift ) ) );
	}

	template<class _IntType ,
		enable_if_t<is_integral_v<_IntType> , int> = 0>
		___NODISCARD___ forceinline constexpr byte operator-( const byte _Arg , const _IntType _Shift ) noexcept
	{
		return ( static_cast< byte >( static_cast< char >( static_cast< int >( _Arg ) - _Shift ) ) );
	}

	___NODISCARD___ forceinline constexpr byte operator/( const byte _Left , const byte _Right ) noexcept
	{
		return ( static_cast< byte >( static_cast< char >(
			static_cast< int >( _Left ) / static_cast< int >( _Right ) ) ) );
	}

	___NODISCARD___ forceinline constexpr byte operator*( const byte _Left , const byte _Right ) noexcept
	{
		return ( static_cast< byte >( static_cast< char >(
			static_cast< int >( _Left ) * static_cast< int >( _Right ) ) ) );
	}

	___NODISCARD___ forceinline constexpr byte operator%( const byte _Left , const byte _Right ) noexcept
	{
		return ( static_cast< byte >( static_cast< char >(
			static_cast< int >( _Left ) % static_cast< int >( _Right ) ) ) );
	}

	___NODISCARD___ forceinline constexpr byte operator-( const byte _Arg ) noexcept
	{
		return ( static_cast< byte >( static_cast< char >( -static_cast< int >( _Arg ) ) ) );
	}

	___NODISCARD___ forceinline constexpr byte operator+( const byte _Arg ) noexcept
	{
		return ( static_cast< byte >( static_cast< char >( +static_cast< int >( _Arg ) ) ) );
	}

	template<class _IntType , enable_if_t<is_integral_v<_IntType> , int> = 0>
	constexpr byte& operator+=( byte& _Arg , const _IntType _Shift ) noexcept { return ( _Arg = _Arg + _Shift ); }

	template<class _IntType , enable_if_t<is_integral_v<_IntType> , int> = 0>
	constexpr byte& operator-=( byte& _Arg , const _IntType _Shift ) noexcept { return ( _Arg = _Arg - _Shift ); }

	constexpr byte& operator/=( byte& _Left , const byte _Right ) noexcept { return ( _Left = _Left / _Right ); }

	constexpr byte& operator*=( byte& _Left , const byte _Right ) noexcept { return ( _Left = _Left * _Right ); }

	constexpr byte& operator%=( byte& _Left , const byte _Right ) noexcept { return ( _Left = _Left % _Right ); }

	template<class _IntType , enable_if_t<is_integral_v<_IntType> , int> = 0>
	___NODISCARD___ forceinline constexpr _IntType to_integer( const sbyte _Arg ) noexcept { return ( static_cast< _IntType >( _Arg ) ); }
}

namespace QCCore
{
	using Int16 = int16_t;
	using Int32 = int32_t;
	using Int64 = int64_t;
	using UInt16 = uint16_t;
	using UInt32 = uint32_t;
	using UInt64 = uint64_t;
	using Short = int16_t;
	using Int = int32_t;
	using Long = int64_t;
	using UShort = uint16_t;
	using UInt = uint32_t;
	using ULong = uint64_t;
	using Char = char;
	using WChar = wchar_t;
	using Bool = bool;
	using Byte = std::byte;
	using SByte = std::sbyte;
	using Object = boost::any;
	using HashCode = size_t;
	using Float = float;
	using Single = float;
	using Double = double;
	template<typename TReturn , typename... TArgs>
	using Function = std::function<TReturn( TArgs... )>;
	template<typename... TArgs> using VoidFunction = std::function<void( TArgs... )>;

	template<typename... Args>
	size_t CombineHashCodes( Args&&... hashCodes );

	template<typename T1 , typename T2>
	constexpr forceinline bool AreEqualDTrue( const T1& v1 , const T2& v2 );

#pragma region Limits
	inline constexpr const Int16	Int16Min = INT16_MIN;
	inline constexpr const Int16	Int16Max = INT16_MAX;
	inline constexpr const Int32	Int32Min = INT32_MIN;
	inline constexpr const Int32	Int32Max = INT32_MAX;
	inline constexpr const Int64	Int64Min = INT64_MIN;
	inline constexpr const Int64	Int64Max = INT64_MAX;
	inline constexpr const UInt16	UInt16Min = 0;
	inline constexpr const UInt16	UInt16Max = UINT16_MAX;
	inline constexpr const UInt32	UInt32Min = 0;
	inline constexpr const UInt32	UInt32Max = UINT32_MAX;
	inline constexpr const UInt64	UInt64Min = 0;
	inline constexpr const UInt64	UInt64Max = UINT64_MAX;
	inline constexpr const Short	ShortMin = INT16_MIN;
	inline constexpr const Short	ShortMax = INT16_MAX;
	inline constexpr const Int		IntMin = INT32_MIN;
	inline constexpr const Int		IntMax = INT32_MAX;
	inline constexpr const Long		LongMin = INT64_MIN;
	inline constexpr const Long		LongMax = INT64_MAX;
	inline constexpr const UShort	UShortMin = 0;
	inline constexpr const UShort	UShortMax = UINT16_MAX;
	inline constexpr const UInt		UIntMin = 0;
	inline constexpr const UInt		UIntMax = UINT32_MAX;
	inline constexpr const ULong	ULongMin = 0;
	inline constexpr const ULong	ULongMax = UINT64_MAX;
	inline constexpr const Char		CharMin = CHAR_MIN;
	inline constexpr const Char		CharMax = CHAR_MAX;
	inline constexpr const WChar	WCharMin = WCHAR_MIN;
	inline constexpr const WChar	WCharMax = WCHAR_MAX;
	inline constexpr const Byte		ByteMin = ( Byte ) 0;
	inline constexpr const Byte		ByteMax = ( Byte ) UCHAR_MAX;
	inline constexpr const SByte	SByteMin = ( SByte ) CHAR_MIN;
	inline constexpr const SByte	SByteMax = ( SByte ) CHAR_MAX;
#pragma endregion

	template<typename T> forceinline size_t Hash( const T& val );

	template<typename TFunc> forceinline decltype(auto) Lambda( TFunc&& value )
	{ return std::forward<TFunc>( value ); }
}
