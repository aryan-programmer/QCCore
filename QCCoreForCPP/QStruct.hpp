#pragma once

namespace QCCore
{

	template<typename... TS> struct QStruct;

	template<typename... Ts>
	constexpr auto MakeQStruct( Ts&&... Items )
	{ return QStruct<boost::remove_cv_ref_t<Ts>...>( std::forward<Ts>( Items )... ); }

	template<typename T1>
	struct QStruct<T1>
	{
		using self = QStruct<T1>;

		T1 Item1;

		constexpr QStruct( ) :Item1( ) { }

		template<typename _T1>
		constexpr QStruct( _T1&& v1 ) : Item1( std::forward<_T1>( v1 ) ) { }

		size_t GetHashCode( ) const { return Hasher( )( Item1 ); }

		constexpr bool Equals( const self& rhs ) const { return AreEqualDTrue( Item1 , rhs.Item1 ); }

		constexpr bool operator ==( const self& rhs ) const { return Equals( rhs ); }

		constexpr bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr T1& operator[]( Const1 ) { return Item1; }

		constexpr const T1& operator[]( Const1 ) const { return Item1; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) { func( Item1 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const { func( Item1 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) ); }
	};
	template<typename T1 , typename T2>
	struct QStruct<T1 , T2>
	{
		using self = QStruct<T1 , T2>;

		T1 Item1;
		T2 Item2;

		constexpr QStruct( ) : Item1 {} , Item2 {}
		{}

			template<typename _T1 , typename _T2> constexpr QStruct( _T1 v1 , _T2 v2 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 ); }

		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C1 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) ); }
	};
	template<typename T1 , typename T2 , typename T3>
	struct QStruct<T1 , T2 , T3>
	{
		using self = QStruct<T1 , T2 , T3>;

		T1 Item1;
		T2 Item2;
		T3 Item3;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 ); }

		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C2 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) ); }
	};
	template<typename T1 , typename T2 , typename T3 , typename T4>
	struct QStruct<T1 , T2 , T3 , T4>
	{
		using self = QStruct<T1 , T2 , T3 , T4>;

		T1 Item1;
		T2 Item2;
		T3 Item3;
		T4 Item4;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {} , Item4 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3 , typename _T4> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 , _T4 v4 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) ) , Item4( std::forward<_T4>( v4 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) , Hasher( )( Item4 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 ) && AreEqualDTrue( Item4 , rhs.Item4 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }
		constexpr forceinline T4& operator[]( Const4 ) { return Item4; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }
		constexpr forceinline const T4& operator[]( Const4 ) const { return Item4; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 , Item4 ); }

		constexpr auto PopBack( Const3 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 , Item2 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 , Item4 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 , Item4 ); }
		constexpr auto PopFront( Const3 ) const
		{ return MakeQStruct( Item4 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C3 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C2 ) ); }
		constexpr auto SplitAt( Const3 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C3 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) ); }
	};
	template<typename T1 , typename T2 , typename T3 , typename T4 , typename T5>
	struct QStruct<T1 , T2 , T3 , T4 , T5>
	{
		using self = QStruct<T1 , T2 , T3 , T4 , T5>;

		T1 Item1;
		T2 Item2;
		T3 Item3;
		T4 Item4;
		T5 Item5;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {} , Item4 {} , Item5 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3 , typename _T4 , typename _T5> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 , _T4 v4 , _T5 v5 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) ) , Item4( std::forward<_T4>( v4 ) ) , Item5( std::forward<_T5>( v5 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) , Hasher( )( Item4 ) , Hasher( )( Item5 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 ) && AreEqualDTrue( Item4 , rhs.Item4 ) && AreEqualDTrue( Item5 , rhs.Item5 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }
		constexpr forceinline T4& operator[]( Const4 ) { return Item4; }
		constexpr forceinline T5& operator[]( Const5 ) { return Item5; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }
		constexpr forceinline const T4& operator[]( Const4 ) const { return Item4; }
		constexpr forceinline const T5& operator[]( Const5 ) const { return Item5; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 , Item4 , Item5 ); }

		constexpr auto PopBack( Const4 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const3 ) const
		{ return MakeQStruct( Item1 , Item2 ); }
		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 , Item4 , Item5 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 , Item4 , Item5 ); }
		constexpr auto PopFront( Const3 ) const
		{ return MakeQStruct( Item4 , Item5 ); }
		constexpr auto PopFront( Const4 ) const
		{ return MakeQStruct( Item5 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C4 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C3 ) , PopFront( C2 ) ); }
		constexpr auto SplitAt( Const3 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C3 ) ); }
		constexpr auto SplitAt( Const4 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C4 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) ); }
	};
	template<typename T1 , typename T2 , typename T3 , typename T4 , typename T5 , typename T6>
	struct QStruct<T1 , T2 , T3 , T4 , T5 , T6>
	{
		using self = QStruct<T1 , T2 , T3 , T4 , T5 , T6>;

		T1 Item1;
		T2 Item2;
		T3 Item3;
		T4 Item4;
		T5 Item5;
		T6 Item6;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {} , Item4 {} , Item5 {} , Item6 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3 , typename _T4 , typename _T5 , typename _T6> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 , _T4 v4 , _T5 v5 , _T6 v6 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) ) , Item4( std::forward<_T4>( v4 ) ) , Item5( std::forward<_T5>( v5 ) ) , Item6( std::forward<_T6>( v6 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) , Hasher( )( Item4 ) , Hasher( )( Item5 ) , Hasher( )( Item6 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 ) && AreEqualDTrue( Item4 , rhs.Item4 ) && AreEqualDTrue( Item5 , rhs.Item5 ) && AreEqualDTrue( Item6 , rhs.Item6 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }
		constexpr forceinline T4& operator[]( Const4 ) { return Item4; }
		constexpr forceinline T5& operator[]( Const5 ) { return Item5; }
		constexpr forceinline T6& operator[]( Const6 ) { return Item6; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }
		constexpr forceinline const T4& operator[]( Const4 ) const { return Item4; }
		constexpr forceinline const T5& operator[]( Const5 ) const { return Item5; }
		constexpr forceinline const T6& operator[]( Const6 ) const { return Item6; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 ); }

		constexpr auto PopBack( Const5 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const4 ) const
		{ return MakeQStruct( Item1 , Item2 ); }
		constexpr auto PopBack( Const3 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 ); }
		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 , Item4 , Item5 , Item6 ); }
		constexpr auto PopFront( Const3 ) const
		{ return MakeQStruct( Item4 , Item5 , Item6 ); }
		constexpr auto PopFront( Const4 ) const
		{ return MakeQStruct( Item5 , Item6 ); }
		constexpr auto PopFront( Const5 ) const
		{ return MakeQStruct( Item6 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C5 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C4 ) , PopFront( C2 ) ); }
		constexpr auto SplitAt( Const3 ) const { return MakeQStruct( PopBack( C3 ) , PopFront( C3 ) ); }
		constexpr auto SplitAt( Const4 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C4 ) ); }
		constexpr auto SplitAt( Const5 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C5 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) ); }
	};
	template<typename T1 , typename T2 , typename T3 , typename T4 , typename T5 , typename T6 , typename T7>
	struct QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7>
	{
		using self = QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7>;

		T1 Item1;
		T2 Item2;
		T3 Item3;
		T4 Item4;
		T5 Item5;
		T6 Item6;
		T7 Item7;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {} , Item4 {} , Item5 {} , Item6 {} , Item7 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3 , typename _T4 , typename _T5 , typename _T6 , typename _T7> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 , _T4 v4 , _T5 v5 , _T6 v6 , _T7 v7 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) ) , Item4( std::forward<_T4>( v4 ) ) , Item5( std::forward<_T5>( v5 ) ) , Item6( std::forward<_T6>( v6 ) ) , Item7( std::forward<_T7>( v7 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) , Hasher( )( Item4 ) , Hasher( )( Item5 ) , Hasher( )( Item6 ) , Hasher( )( Item7 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 ) && AreEqualDTrue( Item4 , rhs.Item4 ) && AreEqualDTrue( Item5 , rhs.Item5 ) && AreEqualDTrue( Item6 , rhs.Item6 ) && AreEqualDTrue( Item7 , rhs.Item7 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }
		constexpr forceinline T4& operator[]( Const4 ) { return Item4; }
		constexpr forceinline T5& operator[]( Const5 ) { return Item5; }
		constexpr forceinline T6& operator[]( Const6 ) { return Item6; }
		constexpr forceinline T7& operator[]( Const7 ) { return Item7; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }
		constexpr forceinline const T4& operator[]( Const4 ) const { return Item4; }
		constexpr forceinline const T5& operator[]( Const5 ) const { return Item5; }
		constexpr forceinline const T6& operator[]( Const6 ) const { return Item6; }
		constexpr forceinline const T7& operator[]( Const7 ) const { return Item7; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 ); }

		constexpr auto PopBack( Const6 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const5 ) const
		{ return MakeQStruct( Item1 , Item2 ); }
		constexpr auto PopBack( Const4 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 ); }
		constexpr auto PopBack( Const3 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 ); }
		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 ); }
		constexpr auto PopFront( Const3 ) const
		{ return MakeQStruct( Item4 , Item5 , Item6 , Item7 ); }
		constexpr auto PopFront( Const4 ) const
		{ return MakeQStruct( Item5 , Item6 , Item7 ); }
		constexpr auto PopFront( Const5 ) const
		{ return MakeQStruct( Item6 , Item7 ); }
		constexpr auto PopFront( Const6 ) const
		{ return MakeQStruct( Item7 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C6 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C5 ) , PopFront( C2 ) ); }
		constexpr auto SplitAt( Const3 ) const { return MakeQStruct( PopBack( C4 ) , PopFront( C3 ) ); }
		constexpr auto SplitAt( Const4 ) const { return MakeQStruct( PopBack( C3 ) , PopFront( C4 ) ); }
		constexpr auto SplitAt( Const5 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C5 ) ); }
		constexpr auto SplitAt( Const6 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C6 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) ); }
	};
	template<typename T1 , typename T2 , typename T3 , typename T4 , typename T5 , typename T6 , typename T7 , typename T8>
	struct QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8>
	{
		using self = QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8>;

		T1 Item1;
		T2 Item2;
		T3 Item3;
		T4 Item4;
		T5 Item5;
		T6 Item6;
		T7 Item7;
		T8 Item8;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {} , Item4 {} , Item5 {} , Item6 {} , Item7 {} , Item8 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3 , typename _T4 , typename _T5 , typename _T6 , typename _T7 , typename _T8> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 , _T4 v4 , _T5 v5 , _T6 v6 , _T7 v7 , _T8 v8 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) ) , Item4( std::forward<_T4>( v4 ) ) , Item5( std::forward<_T5>( v5 ) ) , Item6( std::forward<_T6>( v6 ) ) , Item7( std::forward<_T7>( v7 ) ) , Item8( std::forward<_T8>( v8 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) , Hasher( )( Item4 ) , Hasher( )( Item5 ) , Hasher( )( Item6 ) , Hasher( )( Item7 ) , Hasher( )( Item8 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 ) && AreEqualDTrue( Item4 , rhs.Item4 ) && AreEqualDTrue( Item5 , rhs.Item5 ) && AreEqualDTrue( Item6 , rhs.Item6 ) && AreEqualDTrue( Item7 , rhs.Item7 ) && AreEqualDTrue( Item8 , rhs.Item8 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }
		constexpr forceinline T4& operator[]( Const4 ) { return Item4; }
		constexpr forceinline T5& operator[]( Const5 ) { return Item5; }
		constexpr forceinline T6& operator[]( Const6 ) { return Item6; }
		constexpr forceinline T7& operator[]( Const7 ) { return Item7; }
		constexpr forceinline T8& operator[]( Const8 ) { return Item8; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }
		constexpr forceinline const T4& operator[]( Const4 ) const { return Item4; }
		constexpr forceinline const T5& operator[]( Const5 ) const { return Item5; }
		constexpr forceinline const T6& operator[]( Const6 ) const { return Item6; }
		constexpr forceinline const T7& operator[]( Const7 ) const { return Item7; }
		constexpr forceinline const T8& operator[]( Const8 ) const { return Item8; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 ); }

		constexpr auto PopBack( Const7 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const6 ) const
		{ return MakeQStruct( Item1 , Item2 ); }
		constexpr auto PopBack( Const5 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 ); }
		constexpr auto PopBack( Const4 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 ); }
		constexpr auto PopBack( Const3 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 ); }
		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 ); }
		constexpr auto PopFront( Const3 ) const
		{ return MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 ); }
		constexpr auto PopFront( Const4 ) const
		{ return MakeQStruct( Item5 , Item6 , Item7 , Item8 ); }
		constexpr auto PopFront( Const5 ) const
		{ return MakeQStruct( Item6 , Item7 , Item8 ); }
		constexpr auto PopFront( Const6 ) const
		{ return MakeQStruct( Item7 , Item8 ); }
		constexpr auto PopFront( Const7 ) const
		{ return MakeQStruct( Item8 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C7 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C6 ) , PopFront( C2 ) ); }
		constexpr auto SplitAt( Const3 ) const { return MakeQStruct( PopBack( C5 ) , PopFront( C3 ) ); }
		constexpr auto SplitAt( Const4 ) const { return MakeQStruct( PopBack( C4 ) , PopFront( C4 ) ); }
		constexpr auto SplitAt( Const5 ) const { return MakeQStruct( PopBack( C3 ) , PopFront( C5 ) ); }
		constexpr auto SplitAt( Const6 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C6 ) ); }
		constexpr auto SplitAt( Const7 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C7 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) ); }
	};
	template<typename T1 , typename T2 , typename T3 , typename T4 , typename T5 , typename T6 , typename T7 , typename T8 , typename T9>
	struct QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9>
	{
		using self = QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9>;

		T1 Item1;
		T2 Item2;
		T3 Item3;
		T4 Item4;
		T5 Item5;
		T6 Item6;
		T7 Item7;
		T8 Item8;
		T9 Item9;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {} , Item4 {} , Item5 {} , Item6 {} , Item7 {} , Item8 {} , Item9 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3 , typename _T4 , typename _T5 , typename _T6 , typename _T7 , typename _T8 , typename _T9> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 , _T4 v4 , _T5 v5 , _T6 v6 , _T7 v7 , _T8 v8 , _T9 v9 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) ) , Item4( std::forward<_T4>( v4 ) ) , Item5( std::forward<_T5>( v5 ) ) , Item6( std::forward<_T6>( v6 ) ) , Item7( std::forward<_T7>( v7 ) ) , Item8( std::forward<_T8>( v8 ) ) , Item9( std::forward<_T9>( v9 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) , Hasher( )( Item4 ) , Hasher( )( Item5 ) , Hasher( )( Item6 ) , Hasher( )( Item7 ) , Hasher( )( Item8 ) , Hasher( )( Item9 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 ) && AreEqualDTrue( Item4 , rhs.Item4 ) && AreEqualDTrue( Item5 , rhs.Item5 ) && AreEqualDTrue( Item6 , rhs.Item6 ) && AreEqualDTrue( Item7 , rhs.Item7 ) && AreEqualDTrue( Item8 , rhs.Item8 ) && AreEqualDTrue( Item9 , rhs.Item9 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }
		constexpr forceinline T4& operator[]( Const4 ) { return Item4; }
		constexpr forceinline T5& operator[]( Const5 ) { return Item5; }
		constexpr forceinline T6& operator[]( Const6 ) { return Item6; }
		constexpr forceinline T7& operator[]( Const7 ) { return Item7; }
		constexpr forceinline T8& operator[]( Const8 ) { return Item8; }
		constexpr forceinline T9& operator[]( Const9 ) { return Item9; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }
		constexpr forceinline const T4& operator[]( Const4 ) const { return Item4; }
		constexpr forceinline const T5& operator[]( Const5 ) const { return Item5; }
		constexpr forceinline const T6& operator[]( Const6 ) const { return Item6; }
		constexpr forceinline const T7& operator[]( Const7 ) const { return Item7; }
		constexpr forceinline const T8& operator[]( Const8 ) const { return Item8; }
		constexpr forceinline const T9& operator[]( Const9 ) const { return Item9; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 ); }

		constexpr auto PopBack( Const8 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const7 ) const
		{ return MakeQStruct( Item1 , Item2 ); }
		constexpr auto PopBack( Const6 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 ); }
		constexpr auto PopBack( Const5 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 ); }
		constexpr auto PopBack( Const4 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 ); }
		constexpr auto PopBack( Const3 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 ); }
		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 ); }
		constexpr auto PopFront( Const3 ) const
		{ return MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 ); }
		constexpr auto PopFront( Const4 ) const
		{ return MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 ); }
		constexpr auto PopFront( Const5 ) const
		{ return MakeQStruct( Item6 , Item7 , Item8 , Item9 ); }
		constexpr auto PopFront( Const6 ) const
		{ return MakeQStruct( Item7 , Item8 , Item9 ); }
		constexpr auto PopFront( Const7 ) const
		{ return MakeQStruct( Item8 , Item9 ); }
		constexpr auto PopFront( Const8 ) const
		{ return MakeQStruct( Item9 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C8 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C7 ) , PopFront( C2 ) ); }
		constexpr auto SplitAt( Const3 ) const { return MakeQStruct( PopBack( C6 ) , PopFront( C3 ) ); }
		constexpr auto SplitAt( Const4 ) const { return MakeQStruct( PopBack( C5 ) , PopFront( C4 ) ); }
		constexpr auto SplitAt( Const5 ) const { return MakeQStruct( PopBack( C4 ) , PopFront( C5 ) ); }
		constexpr auto SplitAt( Const6 ) const { return MakeQStruct( PopBack( C3 ) , PopFront( C6 ) ); }
		constexpr auto SplitAt( Const7 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C7 ) ); }
		constexpr auto SplitAt( Const8 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C8 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) ); }
	};
	template<typename T1 , typename T2 , typename T3 , typename T4 , typename T5 , typename T6 , typename T7 , typename T8 , typename T9 , typename T10>
	struct QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10>
	{
		using self = QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10>;

		T1 Item1;
		T2 Item2;
		T3 Item3;
		T4 Item4;
		T5 Item5;
		T6 Item6;
		T7 Item7;
		T8 Item8;
		T9 Item9;
		T10 Item10;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {} , Item4 {} , Item5 {} , Item6 {} , Item7 {} , Item8 {} , Item9 {} , Item10 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3 , typename _T4 , typename _T5 , typename _T6 , typename _T7 , typename _T8 , typename _T9 , typename _T10> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 , _T4 v4 , _T5 v5 , _T6 v6 , _T7 v7 , _T8 v8 , _T9 v9 , _T10 v10 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) ) , Item4( std::forward<_T4>( v4 ) ) , Item5( std::forward<_T5>( v5 ) ) , Item6( std::forward<_T6>( v6 ) ) , Item7( std::forward<_T7>( v7 ) ) , Item8( std::forward<_T8>( v8 ) ) , Item9( std::forward<_T9>( v9 ) ) , Item10( std::forward<_T10>( v10 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) , Hasher( )( Item4 ) , Hasher( )( Item5 ) , Hasher( )( Item6 ) , Hasher( )( Item7 ) , Hasher( )( Item8 ) , Hasher( )( Item9 ) , Hasher( )( Item10 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 ) && AreEqualDTrue( Item4 , rhs.Item4 ) && AreEqualDTrue( Item5 , rhs.Item5 ) && AreEqualDTrue( Item6 , rhs.Item6 ) && AreEqualDTrue( Item7 , rhs.Item7 ) && AreEqualDTrue( Item8 , rhs.Item8 ) && AreEqualDTrue( Item9 , rhs.Item9 ) && AreEqualDTrue( Item10 , rhs.Item10 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }
		constexpr forceinline T4& operator[]( Const4 ) { return Item4; }
		constexpr forceinline T5& operator[]( Const5 ) { return Item5; }
		constexpr forceinline T6& operator[]( Const6 ) { return Item6; }
		constexpr forceinline T7& operator[]( Const7 ) { return Item7; }
		constexpr forceinline T8& operator[]( Const8 ) { return Item8; }
		constexpr forceinline T9& operator[]( Const9 ) { return Item9; }
		constexpr forceinline T10& operator[]( Const10 ) { return Item10; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }
		constexpr forceinline const T4& operator[]( Const4 ) const { return Item4; }
		constexpr forceinline const T5& operator[]( Const5 ) const { return Item5; }
		constexpr forceinline const T6& operator[]( Const6 ) const { return Item6; }
		constexpr forceinline const T7& operator[]( Const7 ) const { return Item7; }
		constexpr forceinline const T8& operator[]( Const8 ) const { return Item8; }
		constexpr forceinline const T9& operator[]( Const9 ) const { return Item9; }
		constexpr forceinline const T10& operator[]( Const10 ) const { return Item10; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 ); }

		constexpr auto PopBack( Const9 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const8 ) const
		{ return MakeQStruct( Item1 , Item2 ); }
		constexpr auto PopBack( Const7 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 ); }
		constexpr auto PopBack( Const6 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 ); }
		constexpr auto PopBack( Const5 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 ); }
		constexpr auto PopBack( Const4 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 ); }
		constexpr auto PopBack( Const3 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 ); }
		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 ); }
		constexpr auto PopFront( Const3 ) const
		{ return MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 ); }
		constexpr auto PopFront( Const4 ) const
		{ return MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 ); }
		constexpr auto PopFront( Const5 ) const
		{ return MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 ); }
		constexpr auto PopFront( Const6 ) const
		{ return MakeQStruct( Item7 , Item8 , Item9 , Item10 ); }
		constexpr auto PopFront( Const7 ) const
		{ return MakeQStruct( Item8 , Item9 , Item10 ); }
		constexpr auto PopFront( Const8 ) const
		{ return MakeQStruct( Item9 , Item10 ); }
		constexpr auto PopFront( Const9 ) const
		{ return MakeQStruct( Item10 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C9 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C8 ) , PopFront( C2 ) ); }
		constexpr auto SplitAt( Const3 ) const { return MakeQStruct( PopBack( C7 ) , PopFront( C3 ) ); }
		constexpr auto SplitAt( Const4 ) const { return MakeQStruct( PopBack( C6 ) , PopFront( C4 ) ); }
		constexpr auto SplitAt( Const5 ) const { return MakeQStruct( PopBack( C5 ) , PopFront( C5 ) ); }
		constexpr auto SplitAt( Const6 ) const { return MakeQStruct( PopBack( C4 ) , PopFront( C6 ) ); }
		constexpr auto SplitAt( Const7 ) const { return MakeQStruct( PopBack( C3 ) , PopFront( C7 ) ); }
		constexpr auto SplitAt( Const8 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C8 ) ); }
		constexpr auto SplitAt( Const9 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C9 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) ); }
	};
	template<typename T1 , typename T2 , typename T3 , typename T4 , typename T5 , typename T6 , typename T7 , typename T8 , typename T9 , typename T10 , typename T11>
	struct QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11>
	{
		using self = QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11>;

		T1 Item1;
		T2 Item2;
		T3 Item3;
		T4 Item4;
		T5 Item5;
		T6 Item6;
		T7 Item7;
		T8 Item8;
		T9 Item9;
		T10 Item10;
		T11 Item11;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {} , Item4 {} , Item5 {} , Item6 {} , Item7 {} , Item8 {} , Item9 {} , Item10 {} , Item11 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3 , typename _T4 , typename _T5 , typename _T6 , typename _T7 , typename _T8 , typename _T9 , typename _T10 , typename _T11> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 , _T4 v4 , _T5 v5 , _T6 v6 , _T7 v7 , _T8 v8 , _T9 v9 , _T10 v10 , _T11 v11 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) ) , Item4( std::forward<_T4>( v4 ) ) , Item5( std::forward<_T5>( v5 ) ) , Item6( std::forward<_T6>( v6 ) ) , Item7( std::forward<_T7>( v7 ) ) , Item8( std::forward<_T8>( v8 ) ) , Item9( std::forward<_T9>( v9 ) ) , Item10( std::forward<_T10>( v10 ) ) , Item11( std::forward<_T11>( v11 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) , Hasher( )( Item4 ) , Hasher( )( Item5 ) , Hasher( )( Item6 ) , Hasher( )( Item7 ) , Hasher( )( Item8 ) , Hasher( )( Item9 ) , Hasher( )( Item10 ) , Hasher( )( Item11 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 ) && AreEqualDTrue( Item4 , rhs.Item4 ) && AreEqualDTrue( Item5 , rhs.Item5 ) && AreEqualDTrue( Item6 , rhs.Item6 ) && AreEqualDTrue( Item7 , rhs.Item7 ) && AreEqualDTrue( Item8 , rhs.Item8 ) && AreEqualDTrue( Item9 , rhs.Item9 ) && AreEqualDTrue( Item10 , rhs.Item10 ) && AreEqualDTrue( Item11 , rhs.Item11 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }
		constexpr forceinline T4& operator[]( Const4 ) { return Item4; }
		constexpr forceinline T5& operator[]( Const5 ) { return Item5; }
		constexpr forceinline T6& operator[]( Const6 ) { return Item6; }
		constexpr forceinline T7& operator[]( Const7 ) { return Item7; }
		constexpr forceinline T8& operator[]( Const8 ) { return Item8; }
		constexpr forceinline T9& operator[]( Const9 ) { return Item9; }
		constexpr forceinline T10& operator[]( Const10 ) { return Item10; }
		constexpr forceinline T11& operator[]( Const11 ) { return Item11; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }
		constexpr forceinline const T4& operator[]( Const4 ) const { return Item4; }
		constexpr forceinline const T5& operator[]( Const5 ) const { return Item5; }
		constexpr forceinline const T6& operator[]( Const6 ) const { return Item6; }
		constexpr forceinline const T7& operator[]( Const7 ) const { return Item7; }
		constexpr forceinline const T8& operator[]( Const8 ) const { return Item8; }
		constexpr forceinline const T9& operator[]( Const9 ) const { return Item9; }
		constexpr forceinline const T10& operator[]( Const10 ) const { return Item10; }
		constexpr forceinline const T11& operator[]( Const11 ) const { return Item11; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 ); }

		constexpr auto PopBack( Const10 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const9 ) const
		{ return MakeQStruct( Item1 , Item2 ); }
		constexpr auto PopBack( Const8 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 ); }
		constexpr auto PopBack( Const7 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 ); }
		constexpr auto PopBack( Const6 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 ); }
		constexpr auto PopBack( Const5 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 ); }
		constexpr auto PopBack( Const4 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 ); }
		constexpr auto PopBack( Const3 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 ); }
		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 ); }
		constexpr auto PopFront( Const3 ) const
		{ return MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 ); }
		constexpr auto PopFront( Const4 ) const
		{ return MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 ); }
		constexpr auto PopFront( Const5 ) const
		{ return MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 ); }
		constexpr auto PopFront( Const6 ) const
		{ return MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 ); }
		constexpr auto PopFront( Const7 ) const
		{ return MakeQStruct( Item8 , Item9 , Item10 , Item11 ); }
		constexpr auto PopFront( Const8 ) const
		{ return MakeQStruct( Item9 , Item10 , Item11 ); }
		constexpr auto PopFront( Const9 ) const
		{ return MakeQStruct( Item10 , Item11 ); }
		constexpr auto PopFront( Const10 ) const
		{ return MakeQStruct( Item11 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C10 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C9 ) , PopFront( C2 ) ); }
		constexpr auto SplitAt( Const3 ) const { return MakeQStruct( PopBack( C8 ) , PopFront( C3 ) ); }
		constexpr auto SplitAt( Const4 ) const { return MakeQStruct( PopBack( C7 ) , PopFront( C4 ) ); }
		constexpr auto SplitAt( Const5 ) const { return MakeQStruct( PopBack( C6 ) , PopFront( C5 ) ); }
		constexpr auto SplitAt( Const6 ) const { return MakeQStruct( PopBack( C5 ) , PopFront( C6 ) ); }
		constexpr auto SplitAt( Const7 ) const { return MakeQStruct( PopBack( C4 ) , PopFront( C7 ) ); }
		constexpr auto SplitAt( Const8 ) const { return MakeQStruct( PopBack( C3 ) , PopFront( C8 ) ); }
		constexpr auto SplitAt( Const9 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C9 ) ); }
		constexpr auto SplitAt( Const10 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C10 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) ); }
	};
	template<typename T1 , typename T2 , typename T3 , typename T4 , typename T5 , typename T6 , typename T7 , typename T8 , typename T9 , typename T10 , typename T11 , typename T12>
	struct QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12>
	{
		using self = QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12>;

		T1 Item1;
		T2 Item2;
		T3 Item3;
		T4 Item4;
		T5 Item5;
		T6 Item6;
		T7 Item7;
		T8 Item8;
		T9 Item9;
		T10 Item10;
		T11 Item11;
		T12 Item12;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {} , Item4 {} , Item5 {} , Item6 {} , Item7 {} , Item8 {} , Item9 {} , Item10 {} , Item11 {} , Item12 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3 , typename _T4 , typename _T5 , typename _T6 , typename _T7 , typename _T8 , typename _T9 , typename _T10 , typename _T11 , typename _T12> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 , _T4 v4 , _T5 v5 , _T6 v6 , _T7 v7 , _T8 v8 , _T9 v9 , _T10 v10 , _T11 v11 , _T12 v12 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) ) , Item4( std::forward<_T4>( v4 ) ) , Item5( std::forward<_T5>( v5 ) ) , Item6( std::forward<_T6>( v6 ) ) , Item7( std::forward<_T7>( v7 ) ) , Item8( std::forward<_T8>( v8 ) ) , Item9( std::forward<_T9>( v9 ) ) , Item10( std::forward<_T10>( v10 ) ) , Item11( std::forward<_T11>( v11 ) ) , Item12( std::forward<_T12>( v12 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) , Hasher( )( Item4 ) , Hasher( )( Item5 ) , Hasher( )( Item6 ) , Hasher( )( Item7 ) , Hasher( )( Item8 ) , Hasher( )( Item9 ) , Hasher( )( Item10 ) , Hasher( )( Item11 ) , Hasher( )( Item12 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 ) && AreEqualDTrue( Item4 , rhs.Item4 ) && AreEqualDTrue( Item5 , rhs.Item5 ) && AreEqualDTrue( Item6 , rhs.Item6 ) && AreEqualDTrue( Item7 , rhs.Item7 ) && AreEqualDTrue( Item8 , rhs.Item8 ) && AreEqualDTrue( Item9 , rhs.Item9 ) && AreEqualDTrue( Item10 , rhs.Item10 ) && AreEqualDTrue( Item11 , rhs.Item11 ) && AreEqualDTrue( Item12 , rhs.Item12 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }
		constexpr forceinline T4& operator[]( Const4 ) { return Item4; }
		constexpr forceinline T5& operator[]( Const5 ) { return Item5; }
		constexpr forceinline T6& operator[]( Const6 ) { return Item6; }
		constexpr forceinline T7& operator[]( Const7 ) { return Item7; }
		constexpr forceinline T8& operator[]( Const8 ) { return Item8; }
		constexpr forceinline T9& operator[]( Const9 ) { return Item9; }
		constexpr forceinline T10& operator[]( Const10 ) { return Item10; }
		constexpr forceinline T11& operator[]( Const11 ) { return Item11; }
		constexpr forceinline T12& operator[]( Const12 ) { return Item12; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }
		constexpr forceinline const T4& operator[]( Const4 ) const { return Item4; }
		constexpr forceinline const T5& operator[]( Const5 ) const { return Item5; }
		constexpr forceinline const T6& operator[]( Const6 ) const { return Item6; }
		constexpr forceinline const T7& operator[]( Const7 ) const { return Item7; }
		constexpr forceinline const T8& operator[]( Const8 ) const { return Item8; }
		constexpr forceinline const T9& operator[]( Const9 ) const { return Item9; }
		constexpr forceinline const T10& operator[]( Const10 ) const { return Item10; }
		constexpr forceinline const T11& operator[]( Const11 ) const { return Item11; }
		constexpr forceinline const T12& operator[]( Const12 ) const { return Item12; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 ); }

		constexpr auto PopBack( Const11 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const10 ) const
		{ return MakeQStruct( Item1 , Item2 ); }
		constexpr auto PopBack( Const9 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 ); }
		constexpr auto PopBack( Const8 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 ); }
		constexpr auto PopBack( Const7 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 ); }
		constexpr auto PopBack( Const6 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 ); }
		constexpr auto PopBack( Const5 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 ); }
		constexpr auto PopBack( Const4 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 ); }
		constexpr auto PopBack( Const3 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 ); }
		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 ); }
		constexpr auto PopFront( Const3 ) const
		{ return MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 ); }
		constexpr auto PopFront( Const4 ) const
		{ return MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 ); }
		constexpr auto PopFront( Const5 ) const
		{ return MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 ); }
		constexpr auto PopFront( Const6 ) const
		{ return MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 ); }
		constexpr auto PopFront( Const7 ) const
		{ return MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 ); }
		constexpr auto PopFront( Const8 ) const
		{ return MakeQStruct( Item9 , Item10 , Item11 , Item12 ); }
		constexpr auto PopFront( Const9 ) const
		{ return MakeQStruct( Item10 , Item11 , Item12 ); }
		constexpr auto PopFront( Const10 ) const
		{ return MakeQStruct( Item11 , Item12 ); }
		constexpr auto PopFront( Const11 ) const
		{ return MakeQStruct( Item12 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C11 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C10 ) , PopFront( C2 ) ); }
		constexpr auto SplitAt( Const3 ) const { return MakeQStruct( PopBack( C9 ) , PopFront( C3 ) ); }
		constexpr auto SplitAt( Const4 ) const { return MakeQStruct( PopBack( C8 ) , PopFront( C4 ) ); }
		constexpr auto SplitAt( Const5 ) const { return MakeQStruct( PopBack( C7 ) , PopFront( C5 ) ); }
		constexpr auto SplitAt( Const6 ) const { return MakeQStruct( PopBack( C6 ) , PopFront( C6 ) ); }
		constexpr auto SplitAt( Const7 ) const { return MakeQStruct( PopBack( C5 ) , PopFront( C7 ) ); }
		constexpr auto SplitAt( Const8 ) const { return MakeQStruct( PopBack( C4 ) , PopFront( C8 ) ); }
		constexpr auto SplitAt( Const9 ) const { return MakeQStruct( PopBack( C3 ) , PopFront( C9 ) ); }
		constexpr auto SplitAt( Const10 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C10 ) ); }
		constexpr auto SplitAt( Const11 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C11 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) ); }
	};
	template<typename T1 , typename T2 , typename T3 , typename T4 , typename T5 , typename T6 , typename T7 , typename T8 , typename T9 , typename T10 , typename T11 , typename T12 , typename T13>
	struct QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13>
	{
		using self = QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13>;

		T1 Item1;
		T2 Item2;
		T3 Item3;
		T4 Item4;
		T5 Item5;
		T6 Item6;
		T7 Item7;
		T8 Item8;
		T9 Item9;
		T10 Item10;
		T11 Item11;
		T12 Item12;
		T13 Item13;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {} , Item4 {} , Item5 {} , Item6 {} , Item7 {} , Item8 {} , Item9 {} , Item10 {} , Item11 {} , Item12 {} , Item13 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3 , typename _T4 , typename _T5 , typename _T6 , typename _T7 , typename _T8 , typename _T9 , typename _T10 , typename _T11 , typename _T12 , typename _T13> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 , _T4 v4 , _T5 v5 , _T6 v6 , _T7 v7 , _T8 v8 , _T9 v9 , _T10 v10 , _T11 v11 , _T12 v12 , _T13 v13 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) ) , Item4( std::forward<_T4>( v4 ) ) , Item5( std::forward<_T5>( v5 ) ) , Item6( std::forward<_T6>( v6 ) ) , Item7( std::forward<_T7>( v7 ) ) , Item8( std::forward<_T8>( v8 ) ) , Item9( std::forward<_T9>( v9 ) ) , Item10( std::forward<_T10>( v10 ) ) , Item11( std::forward<_T11>( v11 ) ) , Item12( std::forward<_T12>( v12 ) ) , Item13( std::forward<_T13>( v13 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) , Hasher( )( Item4 ) , Hasher( )( Item5 ) , Hasher( )( Item6 ) , Hasher( )( Item7 ) , Hasher( )( Item8 ) , Hasher( )( Item9 ) , Hasher( )( Item10 ) , Hasher( )( Item11 ) , Hasher( )( Item12 ) , Hasher( )( Item13 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 ) && AreEqualDTrue( Item4 , rhs.Item4 ) && AreEqualDTrue( Item5 , rhs.Item5 ) && AreEqualDTrue( Item6 , rhs.Item6 ) && AreEqualDTrue( Item7 , rhs.Item7 ) && AreEqualDTrue( Item8 , rhs.Item8 ) && AreEqualDTrue( Item9 , rhs.Item9 ) && AreEqualDTrue( Item10 , rhs.Item10 ) && AreEqualDTrue( Item11 , rhs.Item11 ) && AreEqualDTrue( Item12 , rhs.Item12 ) && AreEqualDTrue( Item13 , rhs.Item13 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }
		constexpr forceinline T4& operator[]( Const4 ) { return Item4; }
		constexpr forceinline T5& operator[]( Const5 ) { return Item5; }
		constexpr forceinline T6& operator[]( Const6 ) { return Item6; }
		constexpr forceinline T7& operator[]( Const7 ) { return Item7; }
		constexpr forceinline T8& operator[]( Const8 ) { return Item8; }
		constexpr forceinline T9& operator[]( Const9 ) { return Item9; }
		constexpr forceinline T10& operator[]( Const10 ) { return Item10; }
		constexpr forceinline T11& operator[]( Const11 ) { return Item11; }
		constexpr forceinline T12& operator[]( Const12 ) { return Item12; }
		constexpr forceinline T13& operator[]( Const13 ) { return Item13; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }
		constexpr forceinline const T4& operator[]( Const4 ) const { return Item4; }
		constexpr forceinline const T5& operator[]( Const5 ) const { return Item5; }
		constexpr forceinline const T6& operator[]( Const6 ) const { return Item6; }
		constexpr forceinline const T7& operator[]( Const7 ) const { return Item7; }
		constexpr forceinline const T8& operator[]( Const8 ) const { return Item8; }
		constexpr forceinline const T9& operator[]( Const9 ) const { return Item9; }
		constexpr forceinline const T10& operator[]( Const10 ) const { return Item10; }
		constexpr forceinline const T11& operator[]( Const11 ) const { return Item11; }
		constexpr forceinline const T12& operator[]( Const12 ) const { return Item12; }
		constexpr forceinline const T13& operator[]( Const13 ) const { return Item13; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 ); }

		constexpr auto PopBack( Const12 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const11 ) const
		{ return MakeQStruct( Item1 , Item2 ); }
		constexpr auto PopBack( Const10 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 ); }
		constexpr auto PopBack( Const9 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 ); }
		constexpr auto PopBack( Const8 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 ); }
		constexpr auto PopBack( Const7 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 ); }
		constexpr auto PopBack( Const6 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 ); }
		constexpr auto PopBack( Const5 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 ); }
		constexpr auto PopBack( Const4 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 ); }
		constexpr auto PopBack( Const3 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 ); }
		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 ); }
		constexpr auto PopFront( Const3 ) const
		{ return MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 ); }
		constexpr auto PopFront( Const4 ) const
		{ return MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 ); }
		constexpr auto PopFront( Const5 ) const
		{ return MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 ); }
		constexpr auto PopFront( Const6 ) const
		{ return MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 ); }
		constexpr auto PopFront( Const7 ) const
		{ return MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 ); }
		constexpr auto PopFront( Const8 ) const
		{ return MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 ); }
		constexpr auto PopFront( Const9 ) const
		{ return MakeQStruct( Item10 , Item11 , Item12 , Item13 ); }
		constexpr auto PopFront( Const10 ) const
		{ return MakeQStruct( Item11 , Item12 , Item13 ); }
		constexpr auto PopFront( Const11 ) const
		{ return MakeQStruct( Item12 , Item13 ); }
		constexpr auto PopFront( Const12 ) const
		{ return MakeQStruct( Item13 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C12 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C11 ) , PopFront( C2 ) ); }
		constexpr auto SplitAt( Const3 ) const { return MakeQStruct( PopBack( C10 ) , PopFront( C3 ) ); }
		constexpr auto SplitAt( Const4 ) const { return MakeQStruct( PopBack( C9 ) , PopFront( C4 ) ); }
		constexpr auto SplitAt( Const5 ) const { return MakeQStruct( PopBack( C8 ) , PopFront( C5 ) ); }
		constexpr auto SplitAt( Const6 ) const { return MakeQStruct( PopBack( C7 ) , PopFront( C6 ) ); }
		constexpr auto SplitAt( Const7 ) const { return MakeQStruct( PopBack( C6 ) , PopFront( C7 ) ); }
		constexpr auto SplitAt( Const8 ) const { return MakeQStruct( PopBack( C5 ) , PopFront( C8 ) ); }
		constexpr auto SplitAt( Const9 ) const { return MakeQStruct( PopBack( C4 ) , PopFront( C9 ) ); }
		constexpr auto SplitAt( Const10 ) const { return MakeQStruct( PopBack( C3 ) , PopFront( C10 ) ); }
		constexpr auto SplitAt( Const11 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C11 ) ); }
		constexpr auto SplitAt( Const12 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C12 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) ); }
	};
	template<typename T1 , typename T2 , typename T3 , typename T4 , typename T5 , typename T6 , typename T7 , typename T8 , typename T9 , typename T10 , typename T11 , typename T12 , typename T13 , typename T14>
	struct QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14>
	{
		using self = QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14>;

		T1 Item1;
		T2 Item2;
		T3 Item3;
		T4 Item4;
		T5 Item5;
		T6 Item6;
		T7 Item7;
		T8 Item8;
		T9 Item9;
		T10 Item10;
		T11 Item11;
		T12 Item12;
		T13 Item13;
		T14 Item14;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {} , Item4 {} , Item5 {} , Item6 {} , Item7 {} , Item8 {} , Item9 {} , Item10 {} , Item11 {} , Item12 {} , Item13 {} , Item14 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3 , typename _T4 , typename _T5 , typename _T6 , typename _T7 , typename _T8 , typename _T9 , typename _T10 , typename _T11 , typename _T12 , typename _T13 , typename _T14> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 , _T4 v4 , _T5 v5 , _T6 v6 , _T7 v7 , _T8 v8 , _T9 v9 , _T10 v10 , _T11 v11 , _T12 v12 , _T13 v13 , _T14 v14 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) ) , Item4( std::forward<_T4>( v4 ) ) , Item5( std::forward<_T5>( v5 ) ) , Item6( std::forward<_T6>( v6 ) ) , Item7( std::forward<_T7>( v7 ) ) , Item8( std::forward<_T8>( v8 ) ) , Item9( std::forward<_T9>( v9 ) ) , Item10( std::forward<_T10>( v10 ) ) , Item11( std::forward<_T11>( v11 ) ) , Item12( std::forward<_T12>( v12 ) ) , Item13( std::forward<_T13>( v13 ) ) , Item14( std::forward<_T14>( v14 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) , Hasher( )( Item4 ) , Hasher( )( Item5 ) , Hasher( )( Item6 ) , Hasher( )( Item7 ) , Hasher( )( Item8 ) , Hasher( )( Item9 ) , Hasher( )( Item10 ) , Hasher( )( Item11 ) , Hasher( )( Item12 ) , Hasher( )( Item13 ) , Hasher( )( Item14 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 ) && AreEqualDTrue( Item4 , rhs.Item4 ) && AreEqualDTrue( Item5 , rhs.Item5 ) && AreEqualDTrue( Item6 , rhs.Item6 ) && AreEqualDTrue( Item7 , rhs.Item7 ) && AreEqualDTrue( Item8 , rhs.Item8 ) && AreEqualDTrue( Item9 , rhs.Item9 ) && AreEqualDTrue( Item10 , rhs.Item10 ) && AreEqualDTrue( Item11 , rhs.Item11 ) && AreEqualDTrue( Item12 , rhs.Item12 ) && AreEqualDTrue( Item13 , rhs.Item13 ) && AreEqualDTrue( Item14 , rhs.Item14 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }
		constexpr forceinline T4& operator[]( Const4 ) { return Item4; }
		constexpr forceinline T5& operator[]( Const5 ) { return Item5; }
		constexpr forceinline T6& operator[]( Const6 ) { return Item6; }
		constexpr forceinline T7& operator[]( Const7 ) { return Item7; }
		constexpr forceinline T8& operator[]( Const8 ) { return Item8; }
		constexpr forceinline T9& operator[]( Const9 ) { return Item9; }
		constexpr forceinline T10& operator[]( Const10 ) { return Item10; }
		constexpr forceinline T11& operator[]( Const11 ) { return Item11; }
		constexpr forceinline T12& operator[]( Const12 ) { return Item12; }
		constexpr forceinline T13& operator[]( Const13 ) { return Item13; }
		constexpr forceinline T14& operator[]( Const14 ) { return Item14; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }
		constexpr forceinline const T4& operator[]( Const4 ) const { return Item4; }
		constexpr forceinline const T5& operator[]( Const5 ) const { return Item5; }
		constexpr forceinline const T6& operator[]( Const6 ) const { return Item6; }
		constexpr forceinline const T7& operator[]( Const7 ) const { return Item7; }
		constexpr forceinline const T8& operator[]( Const8 ) const { return Item8; }
		constexpr forceinline const T9& operator[]( Const9 ) const { return Item9; }
		constexpr forceinline const T10& operator[]( Const10 ) const { return Item10; }
		constexpr forceinline const T11& operator[]( Const11 ) const { return Item11; }
		constexpr forceinline const T12& operator[]( Const12 ) const { return Item12; }
		constexpr forceinline const T13& operator[]( Const13 ) const { return Item13; }
		constexpr forceinline const T14& operator[]( Const14 ) const { return Item14; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 ); }

		constexpr auto PopBack( Const13 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const12 ) const
		{ return MakeQStruct( Item1 , Item2 ); }
		constexpr auto PopBack( Const11 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 ); }
		constexpr auto PopBack( Const10 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 ); }
		constexpr auto PopBack( Const9 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 ); }
		constexpr auto PopBack( Const8 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 ); }
		constexpr auto PopBack( Const7 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 ); }
		constexpr auto PopBack( Const6 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 ); }
		constexpr auto PopBack( Const5 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 ); }
		constexpr auto PopBack( Const4 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 ); }
		constexpr auto PopBack( Const3 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 ); }
		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 ); }
		constexpr auto PopFront( Const3 ) const
		{ return MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 ); }
		constexpr auto PopFront( Const4 ) const
		{ return MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 ); }
		constexpr auto PopFront( Const5 ) const
		{ return MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 ); }
		constexpr auto PopFront( Const6 ) const
		{ return MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 ); }
		constexpr auto PopFront( Const7 ) const
		{ return MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 ); }
		constexpr auto PopFront( Const8 ) const
		{ return MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 ); }
		constexpr auto PopFront( Const9 ) const
		{ return MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 ); }
		constexpr auto PopFront( Const10 ) const
		{ return MakeQStruct( Item11 , Item12 , Item13 , Item14 ); }
		constexpr auto PopFront( Const11 ) const
		{ return MakeQStruct( Item12 , Item13 , Item14 ); }
		constexpr auto PopFront( Const12 ) const
		{ return MakeQStruct( Item13 , Item14 ); }
		constexpr auto PopFront( Const13 ) const
		{ return MakeQStruct( Item14 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C13 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C12 ) , PopFront( C2 ) ); }
		constexpr auto SplitAt( Const3 ) const { return MakeQStruct( PopBack( C11 ) , PopFront( C3 ) ); }
		constexpr auto SplitAt( Const4 ) const { return MakeQStruct( PopBack( C10 ) , PopFront( C4 ) ); }
		constexpr auto SplitAt( Const5 ) const { return MakeQStruct( PopBack( C9 ) , PopFront( C5 ) ); }
		constexpr auto SplitAt( Const6 ) const { return MakeQStruct( PopBack( C8 ) , PopFront( C6 ) ); }
		constexpr auto SplitAt( Const7 ) const { return MakeQStruct( PopBack( C7 ) , PopFront( C7 ) ); }
		constexpr auto SplitAt( Const8 ) const { return MakeQStruct( PopBack( C6 ) , PopFront( C8 ) ); }
		constexpr auto SplitAt( Const9 ) const { return MakeQStruct( PopBack( C5 ) , PopFront( C9 ) ); }
		constexpr auto SplitAt( Const10 ) const { return MakeQStruct( PopBack( C4 ) , PopFront( C10 ) ); }
		constexpr auto SplitAt( Const11 ) const { return MakeQStruct( PopBack( C3 ) , PopFront( C11 ) ); }
		constexpr auto SplitAt( Const12 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C12 ) ); }
		constexpr auto SplitAt( Const13 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C13 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) ); }
	};
	template<typename T1 , typename T2 , typename T3 , typename T4 , typename T5 , typename T6 , typename T7 , typename T8 , typename T9 , typename T10 , typename T11 , typename T12 , typename T13 , typename T14 , typename T15>
	struct QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15>
	{
		using self = QStruct<T1 , T2 , T3 , T4 , T5 , T6 , T7 , T8 , T9 , T10 , T11 , T12 , T13 , T14 , T15>;

		T1 Item1;
		T2 Item2;
		T3 Item3;
		T4 Item4;
		T5 Item5;
		T6 Item6;
		T7 Item7;
		T8 Item8;
		T9 Item9;
		T10 Item10;
		T11 Item11;
		T12 Item12;
		T13 Item13;
		T14 Item14;
		T15 Item15;

		constexpr QStruct( ) : Item1 {} , Item2 {} , Item3 {} , Item4 {} , Item5 {} , Item6 {} , Item7 {} , Item8 {} , Item9 {} , Item10 {} , Item11 {} , Item12 {} , Item13 {} , Item14 {} , Item15 {}
		{}

			template<typename _T1 , typename _T2 , typename _T3 , typename _T4 , typename _T5 , typename _T6 , typename _T7 , typename _T8 , typename _T9 , typename _T10 , typename _T11 , typename _T12 , typename _T13 , typename _T14 , typename _T15> constexpr QStruct( _T1 v1 , _T2 v2 , _T3 v3 , _T4 v4 , _T5 v5 , _T6 v6 , _T7 v7 , _T8 v8 , _T9 v9 , _T10 v10 , _T11 v11 , _T12 v12 , _T13 v13 , _T14 v14 , _T15 v15 ) : Item1( std::forward<_T1>( v1 ) ) , Item2( std::forward<_T2>( v2 ) ) , Item3( std::forward<_T3>( v3 ) ) , Item4( std::forward<_T4>( v4 ) ) , Item5( std::forward<_T5>( v5 ) ) , Item6( std::forward<_T6>( v6 ) ) , Item7( std::forward<_T7>( v7 ) ) , Item8( std::forward<_T8>( v8 ) ) , Item9( std::forward<_T9>( v9 ) ) , Item10( std::forward<_T10>( v10 ) ) , Item11( std::forward<_T11>( v11 ) ) , Item12( std::forward<_T12>( v12 ) ) , Item13( std::forward<_T13>( v13 ) ) , Item14( std::forward<_T14>( v14 ) ) , Item15( std::forward<_T15>( v15 ) )
		{ }

		size_t GetHashCode( ) const
		{
			return CombineHashCodes( Hasher( )( Item1 ) , Hasher( )( Item2 ) , Hasher( )( Item3 ) , Hasher( )( Item4 ) , Hasher( )( Item5 ) , Hasher( )( Item6 ) , Hasher( )( Item7 ) , Hasher( )( Item8 ) , Hasher( )( Item9 ) , Hasher( )( Item10 ) , Hasher( )( Item11 ) , Hasher( )( Item12 ) , Hasher( )( Item13 ) , Hasher( )( Item14 ) , Hasher( )( Item15 ) );
		}

		constexpr bool Equals( const self& rhs ) const
		{
			return AreEqualDTrue( Item1 , rhs.Item1 ) && AreEqualDTrue( Item2 , rhs.Item2 ) && AreEqualDTrue( Item3 , rhs.Item3 ) && AreEqualDTrue( Item4 , rhs.Item4 ) && AreEqualDTrue( Item5 , rhs.Item5 ) && AreEqualDTrue( Item6 , rhs.Item6 ) && AreEqualDTrue( Item7 , rhs.Item7 ) && AreEqualDTrue( Item8 , rhs.Item8 ) && AreEqualDTrue( Item9 , rhs.Item9 ) && AreEqualDTrue( Item10 , rhs.Item10 ) && AreEqualDTrue( Item11 , rhs.Item11 ) && AreEqualDTrue( Item12 , rhs.Item12 ) && AreEqualDTrue( Item13 , rhs.Item13 ) && AreEqualDTrue( Item14 , rhs.Item14 ) && AreEqualDTrue( Item15 , rhs.Item15 );
		}

		constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs ); }
		constexpr forceinline bool operator !=( const self& rhs ) const { return !Equals( rhs ); }

		constexpr forceinline T1& operator[]( Const1 ) { return Item1; }
		constexpr forceinline T2& operator[]( Const2 ) { return Item2; }
		constexpr forceinline T3& operator[]( Const3 ) { return Item3; }
		constexpr forceinline T4& operator[]( Const4 ) { return Item4; }
		constexpr forceinline T5& operator[]( Const5 ) { return Item5; }
		constexpr forceinline T6& operator[]( Const6 ) { return Item6; }
		constexpr forceinline T7& operator[]( Const7 ) { return Item7; }
		constexpr forceinline T8& operator[]( Const8 ) { return Item8; }
		constexpr forceinline T9& operator[]( Const9 ) { return Item9; }
		constexpr forceinline T10& operator[]( Const10 ) { return Item10; }
		constexpr forceinline T11& operator[]( Const11 ) { return Item11; }
		constexpr forceinline T12& operator[]( Const12 ) { return Item12; }
		constexpr forceinline T13& operator[]( Const13 ) { return Item13; }
		constexpr forceinline T14& operator[]( Const14 ) { return Item14; }
		constexpr forceinline T15& operator[]( Const15 ) { return Item15; }

		constexpr forceinline const T1& operator[]( Const1 ) const { return Item1; }
		constexpr forceinline const T2& operator[]( Const2 ) const { return Item2; }
		constexpr forceinline const T3& operator[]( Const3 ) const { return Item3; }
		constexpr forceinline const T4& operator[]( Const4 ) const { return Item4; }
		constexpr forceinline const T5& operator[]( Const5 ) const { return Item5; }
		constexpr forceinline const T6& operator[]( Const6 ) const { return Item6; }
		constexpr forceinline const T7& operator[]( Const7 ) const { return Item7; }
		constexpr forceinline const T8& operator[]( Const8 ) const { return Item8; }
		constexpr forceinline const T9& operator[]( Const9 ) const { return Item9; }
		constexpr forceinline const T10& operator[]( Const10 ) const { return Item10; }
		constexpr forceinline const T11& operator[]( Const11 ) const { return Item11; }
		constexpr forceinline const T12& operator[]( Const12 ) const { return Item12; }
		constexpr forceinline const T13& operator[]( Const13 ) const { return Item13; }
		constexpr forceinline const T14& operator[]( Const14 ) const { return Item14; }
		constexpr forceinline const T15& operator[]( Const15 ) const { return Item15; }

		template<typename... _Ts>
		constexpr auto PushBack( _Ts&&... Items ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 , std::forward<_Ts>( Items )... ); }

		template<typename... _Ts>
		constexpr auto PushFront( _Ts&&... Items ) const
		{ return MakeQStruct( std::forward<_Ts>( Items )... , Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 ); }

		constexpr auto PopBack( Const14 ) const
		{ return MakeQStruct( Item1 ); }
		constexpr auto PopBack( Const13 ) const
		{ return MakeQStruct( Item1 , Item2 ); }
		constexpr auto PopBack( Const12 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 ); }
		constexpr auto PopBack( Const11 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 ); }
		constexpr auto PopBack( Const10 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 ); }
		constexpr auto PopBack( Const9 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 ); }
		constexpr auto PopBack( Const8 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 ); }
		constexpr auto PopBack( Const7 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 ); }
		constexpr auto PopBack( Const6 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 ); }
		constexpr auto PopBack( Const5 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 ); }
		constexpr auto PopBack( Const4 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 ); }
		constexpr auto PopBack( Const3 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 ); }
		constexpr auto PopBack( Const2 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 ); }
		constexpr auto PopBack( Const1 ) const
		{ return MakeQStruct( Item1 , Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 ); }

		constexpr auto PopFront( Const1 ) const
		{ return MakeQStruct( Item2 , Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 ); }
		constexpr auto PopFront( Const2 ) const
		{ return MakeQStruct( Item3 , Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 ); }
		constexpr auto PopFront( Const3 ) const
		{ return MakeQStruct( Item4 , Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 ); }
		constexpr auto PopFront( Const4 ) const
		{ return MakeQStruct( Item5 , Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 ); }
		constexpr auto PopFront( Const5 ) const
		{ return MakeQStruct( Item6 , Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 ); }
		constexpr auto PopFront( Const6 ) const
		{ return MakeQStruct( Item7 , Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 ); }
		constexpr auto PopFront( Const7 ) const
		{ return MakeQStruct( Item8 , Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 ); }
		constexpr auto PopFront( Const8 ) const
		{ return MakeQStruct( Item9 , Item10 , Item11 , Item12 , Item13 , Item14 , Item15 ); }
		constexpr auto PopFront( Const9 ) const
		{ return MakeQStruct( Item10 , Item11 , Item12 , Item13 , Item14 , Item15 ); }
		constexpr auto PopFront( Const10 ) const
		{ return MakeQStruct( Item11 , Item12 , Item13 , Item14 , Item15 ); }
		constexpr auto PopFront( Const11 ) const
		{ return MakeQStruct( Item12 , Item13 , Item14 , Item15 ); }
		constexpr auto PopFront( Const12 ) const
		{ return MakeQStruct( Item13 , Item14 , Item15 ); }
		constexpr auto PopFront( Const13 ) const
		{ return MakeQStruct( Item14 , Item15 ); }
		constexpr auto PopFront( Const14 ) const
		{ return MakeQStruct( Item15 ); }

		constexpr auto SplitAt( Const1 ) const { return MakeQStruct( PopBack( C14 ) , PopFront( C1 ) ); }
		constexpr auto SplitAt( Const2 ) const { return MakeQStruct( PopBack( C13 ) , PopFront( C2 ) ); }
		constexpr auto SplitAt( Const3 ) const { return MakeQStruct( PopBack( C12 ) , PopFront( C3 ) ); }
		constexpr auto SplitAt( Const4 ) const { return MakeQStruct( PopBack( C11 ) , PopFront( C4 ) ); }
		constexpr auto SplitAt( Const5 ) const { return MakeQStruct( PopBack( C10 ) , PopFront( C5 ) ); }
		constexpr auto SplitAt( Const6 ) const { return MakeQStruct( PopBack( C9 ) , PopFront( C6 ) ); }
		constexpr auto SplitAt( Const7 ) const { return MakeQStruct( PopBack( C8 ) , PopFront( C7 ) ); }
		constexpr auto SplitAt( Const8 ) const { return MakeQStruct( PopBack( C7 ) , PopFront( C8 ) ); }
		constexpr auto SplitAt( Const9 ) const { return MakeQStruct( PopBack( C6 ) , PopFront( C9 ) ); }
		constexpr auto SplitAt( Const10 ) const { return MakeQStruct( PopBack( C5 ) , PopFront( C10 ) ); }
		constexpr auto SplitAt( Const11 ) const { return MakeQStruct( PopBack( C4 ) , PopFront( C11 ) ); }
		constexpr auto SplitAt( Const12 ) const { return MakeQStruct( PopBack( C3 ) , PopFront( C12 ) ); }
		constexpr auto SplitAt( Const13 ) const { return MakeQStruct( PopBack( C2 ) , PopFront( C13 ) ); }
		constexpr auto SplitAt( Const14 ) const { return MakeQStruct( PopBack( C1 ) , PopFront( C14 ) ); }

		template<typename TFunc>
		constexpr void ForEach( TFunc func )
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); }

		template<typename TFunc>
		constexpr auto ForEach( TFunc func ) const
		{ func( Item1 ); func( Item2 ); func( Item3 ); func( Item4 ); func( Item5 ); func( Item6 ); func( Item7 ); func( Item8 ); func( Item9 ); func( Item10 ); func( Item11 ); func( Item12 ); func( Item13 ); func( Item14 ); func( Item15 ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func )
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) ); }

		template<typename TFunc>
		constexpr auto ForEachGetResult( TFunc func ) const
		{ return MakeQStruct( func( Item1 ) , func( Item2 ) , func( Item3 ) , func( Item4 ) , func( Item5 ) , func( Item6 ) , func( Item7 ) , func( Item8 ) , func( Item9 ) , func( Item10 ) , func( Item11 ) , func( Item12 ) , func( Item13 ) , func( Item14 ) , func( Item15 ) ); }
	};

}