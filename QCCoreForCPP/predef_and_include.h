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

namespace std
{
#if _HAS_CXX17
#define ___NODISCARD___ [[nodiscard]]
#else
#define ___NODISCARD___
#endif /* _HAS_NODISCARD */
	// ENUM CLASS sbyte
	enum class sbyte : char { };

	template<class _IntType ,
		enable_if_t<is_integral_v<_IntType> , int> = 0>
		___NODISCARD___ constexpr sbyte operator<<( const sbyte _Arg , const _IntType _Shift ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >( static_cast< int >( _Arg ) << _Shift ) ) );
	}

	template<class _IntType ,
		enable_if_t<is_integral_v<_IntType> , int> = 0>
		___NODISCARD___ constexpr sbyte operator>>( const sbyte _Arg , const _IntType _Shift ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >( static_cast< int >( _Arg ) >> _Shift ) ) );
	}

	___NODISCARD___ constexpr sbyte operator|( const sbyte _Left , const sbyte _Right ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >(
			static_cast< int >( _Left ) | static_cast< int >( _Right ) ) ) );
	}

	___NODISCARD___ constexpr sbyte operator&( const sbyte _Left , const sbyte _Right ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >(
			static_cast< int >( _Left ) & static_cast< int >( _Right ) ) ) );
	}

	___NODISCARD___ constexpr sbyte operator^( const sbyte _Left , const sbyte _Right ) noexcept
	{
		return ( static_cast< sbyte >( static_cast< char >(
			static_cast< int >( _Left ) ^ static_cast< int >( _Right ) ) ) );
	}

	___NODISCARD___ constexpr sbyte operator~( const sbyte _Arg ) noexcept
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

	template<class _IntType , enable_if_t<is_integral_v<_IntType> , int> = 0>
	___NODISCARD___ constexpr _IntType to_integer( const sbyte _Arg ) noexcept { return ( static_cast< _IntType >( _Arg ) ); }
#undef ___NODISCARD___
}

#define _DECOMPOSE_QS(qstruct, ...) auto [__VA_ARGS__] = qstruct

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
	using String = std::string;
	using WString = std::wstring;
	using StringRef = std::string_view;
	using WStringRef = std::wstring_view;
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
	template<typename... TArgs>
	using VoidFunction = std::function<void( TArgs... )>;

	template<typename... Args>
	size_t CombineHashCodes( Args&&... hashCodes );

	template<typename T1 , typename T2>
	constexpr inline bool AreEqualDTrue( const T1& v1 , const T2& v2 );

#pragma region Limits
	inline constexpr const Int16 Int16Min = INT16_MIN;
	inline constexpr const Int16 Int16Max = INT16_MAX;
	inline constexpr const Int32 Int32Min = INT32_MIN;
	inline constexpr const Int32 Int32Max = INT32_MAX;
	inline constexpr const Int64 Int64Min = INT64_MIN;
	inline constexpr const Int64 Int64Max = INT64_MAX;
	inline constexpr const UInt16 UInt16Min = 0;
	inline constexpr const UInt16 UInt16Max = UINT16_MAX;
	inline constexpr const UInt32 UInt32Min = 0;
	inline constexpr const UInt32 UInt32Max = UINT32_MAX;
	inline constexpr const UInt64 UInt64Min = 0;
	inline constexpr const UInt64 UInt64Max = UINT64_MAX;
	inline constexpr const Short ShortMin = INT16_MIN;
	inline constexpr const Short ShortMax = INT16_MAX;
	inline constexpr const Int IntMin = INT32_MIN;
	inline constexpr const Int IntMax = INT32_MAX;
	inline constexpr const Long LongMin = INT64_MIN;
	inline constexpr const Long LongMax = INT64_MAX;
	inline constexpr const UShort UShortMin = 0;
	inline constexpr const UShort UShortMax = UINT16_MAX;
	inline constexpr const UInt UIntMin = 0;
	inline constexpr const UInt UIntMax = UINT32_MAX;
	inline constexpr const ULong ULongMin = 0;
	inline constexpr const ULong ULongMax = UINT64_MAX;
	inline constexpr const Char CharMin = CHAR_MIN;
	inline constexpr const Char CharMax = CHAR_MAX;
	inline constexpr const WChar WCharMin = WCHAR_MIN;
	inline constexpr const WChar WCharMax = WCHAR_MAX;
	inline constexpr const Byte ByteMin = ( Byte ) 0;
	inline constexpr const Byte ByteMax = ( Byte ) UCHAR_MAX;
	inline constexpr const SByte SByteMin = ( SByte ) CHAR_MIN;
	inline constexpr const SByte SByteMax = ( SByte ) CHAR_MAX;
#pragma endregion

}
