using System.Text;
using static System.Console;

namespace MainNamespace
{
	public static partial class Program
	{
		private const ulong insts = 15;

		private static string GetLoopedString( string fmt , ulong start , ulong end )
		{
			StringBuilder @string = new StringBuilder();
			for ( ulong i = start; i <= end; i++ )
				@string.Append( string.Format( fmt , i ) );
			return @string.ToString();
		}

		private static void CSPrint_Function_DelegateTemplates( )
		{
			WriteLine( "public delegate TReturn Function<out TReturn>( );" );
			for ( ulong nInst = 1; nInst <= insts; nInst++ )
			{
				Write( "public delegate TReturn Function<out TReturn" );
				Write( GetLoopedString( ", in TArg{0}" , 1 , nInst ) );
				Write( ">( TArg1 arg1" );
				Write( GetLoopedString( ", TArg{0} arg{0}" , 2 , nInst ) );
				WriteLine( ");" );
			}
		}

		private static void CSPrint_VoidFunction_DelegateTemplates( )
		{
			WriteLine( "public delegate void VoidFunction( );" );
			for ( ulong nInst = 1; nInst <= insts; nInst++ )
			{
				Write( "public delegate void VoidFunction<in TArg1" );
				Write( GetLoopedString( ", in TArg{0}" , 2 , nInst ) );
				Write( ">( TArg1 arg1" );
				Write( GetLoopedString( ", TArg{0} arg{0}" , 2 , nInst ) );
				WriteLine( ");" );
			}
		}

		private static void CSPrint_Pipable_FunctionTemplates( )
		{
			WriteLine( "public static Function<FPipable<TReturn , TArg1>> Pipable<TReturn , TArg1>( Function<TReturn , TArg1> function ) => ( ) => MFPipable( function ); " );
			for ( ulong nInst = 2; nInst <= insts; nInst++ )
			{
				Write( "public static Function<FPipable<TReturn , TArg1> " );
				Write( GetLoopedString( ", TArg{0}" , 2 , nInst ) );
				Write( ">Pipable<TReturn" );
				Write( GetLoopedString( ", TArg{0}" , 1 , nInst ) );
				Write( ">( Function<TReturn" );
				Write( GetLoopedString( ", TArg{0}" , 1 , nInst ) );
				Write( "> function ) => ( arg2" );
				Write( GetLoopedString( ", arg{0}" , 3 , nInst ) );
				Write( ")=>MFPipable<TReturn , TArg1>( arg1 => function( arg1" );
				Write( GetLoopedString( ", arg{0}" , 2 , nInst ) );
				WriteLine( " ) );" );
			}
		}

		private static void CSPrint_Cn_ConstantClasses( )
		{
			for ( ulong nInst = 1; nInst <= insts; nInst++ )
			{
				Write( "public struct Const" );
				Write( nInst );
				Write( "{public const ulong value = " );
				Write( nInst );
				Write( "UL;}\n" );
			}
		}

		private static void CPPPrint_Cn_ConstantClasses( )
		{
			for ( ulong nInst = 1; nInst <= insts; nInst++ )
			{
				Write( "struct Const" );
				Write( nInst );
				Write( "{static constexpr ULong value = " );
				Write( nInst );
				Write( "UL;};\n" );
			}
		}

		private static void CSPrint_Cn_ConstantInstantiations( )
		{
			for ( ulong nInst = 1; nInst <= insts; nInst++ )
			{
				Write( "public static readonly Const" );
				Write( nInst );
				Write( " C" );
				Write( nInst );
				Write( " = new Const" );
				Write( nInst );
				Write( "();\n" );
			}
		}

		private static void CPPPrint_Cn_ConstantInstantiations( )
		{
			for ( ulong nInst = 1; nInst <= insts; nInst++ )
			{
				Write( "static constexpr const Const" );
				Write( nInst );
				Write( " C" );
				Write( nInst );
				Write( "{};\n" );
			}
		}

		private static void CSPrint_MakeQStruct_FunctionTemplates( )
		{
			Write( @"
		public static QStruct<T1> MakeQStruct<T1>( T1 Item1 ) => new QStruct<T1>( Item1 );

" );
			for ( ulong nIter = 2; nIter <= insts; nIter++ )
			{
				string template = "<T1" +
					GetLoopedString( ", T{0}" , 2 , nIter ) +
					">";
				string thisType = "QStruct" + template;
				Write( $"public static {thisType} MakeQStruct{template}(T1 Item1" );
				Write( GetLoopedString( ",T{0} Item{0}" , 2 , nIter ) );
				Write( $") => new {thisType}(Item1" );
				Write( GetLoopedString( ",Item{0}" , 2 , nIter ) );
				Write( ");\n" );
				WriteNewLine();
			}
		}

		private static void CSPrint_Tuple_ClassTemplates( )
		{
			ulong nIter = 1, pI, rem;
			string _template, retTypeTemplate, retType;
			WriteLine( @"
public struct QStruct<T1>: IEquatable<QStruct<T1>>
{
	public T1 Item1;
	
	public QStruct(T1 v1 = default(T1))=>Item1=v1;

	public override int GetHashCode( ) => Item1.GetHashCode();

	public override bool Equals( object obj ) => obj is QStruct<T1> && Equals( ( QStruct<T1> ) obj );

	public bool Equals( QStruct<T1> rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 );

	public static bool operator ==( QStruct<T1> struct1 , QStruct<T1> struct2 ) => struct1.Equals( struct2 );

	public static bool operator !=( QStruct<T1> struct1 , QStruct<T1> struct2 ) => !( struct1 == struct2 );

	public T1 this[Const1 _]
	{
		get=>Item1;
		set=>Item1=value;
	}
" );
			WriteNewLine();
			#region PushBack
			for ( pI = 1; pI <= insts - nIter; pI++ )
			{
				_template =
					"<_T1" +
					GetLoopedString( ",_T{0}" , 2 , pI ) +
					">";
				retTypeTemplate =
					"<T1" +
					// GetLoopedString( ",T{0}" , 2 , nIter ) +
					GetLoopedString( ",_T{0}" , 1 , pI ) +
					">";
				retType = "QStruct" + retTypeTemplate;
				Write( "\t" );
				Write( $"public {retType} PushBack{_template}(_T1 NItem1" );
				Write( GetLoopedString( ", _T{0} NItem{0}" , 2 , pI ) );
				Write( @") =>
	MakeQStruct(" );
				Write( "Item1" );
				// Write( GetLoopedString( ",Item{0}" , 2 , nIter ) );
				Write( GetLoopedString( ",NItem{0}" , 1 , pI ) );
				Write( @");
" );
			}
			#endregion
			WriteNewLine();
			#region PushFront
			for ( pI = 1; pI <= insts - nIter; pI++ )
			{
				_template =
					"<_T1" +
					GetLoopedString( ",_T{0}" , 2 , pI ) +
					">";
				retTypeTemplate =
					"<_T1" +
					GetLoopedString( ",_T{0}" , 2 , pI ) +
					GetLoopedString( ", T{0}" , 1 , nIter ) +
					">";
				retType = "QStruct" + retTypeTemplate;
				Write( "\t" );
				Write( $"public {retType} PushFront{_template} (_T1 NItem1" );
				Write( GetLoopedString( ", _T{0} NItem{0}" , 2 , pI ) );
				Write( @") =>
	MakeQStruct(" );
				Write( "NItem1" );
				Write( GetLoopedString( ",NItem{0}" , 2 , pI ) );
				Write( GetLoopedString( ",Item{0}" , 1 , nIter ) );
				Write( @");
" );
			}
			#endregion
			Write( @"
}
" );
			for ( nIter = 2; nIter <= insts; nIter++ )
			{
				string template = "<T1" +
					GetLoopedString( ", T{0}" , 2 , nIter ) +
					">";
				string thisType = "QStruct" + template;
				WriteNewLine();
				#region Struct
				Write( "public struct " );
				Write( thisType );
				Write( ": IEquatable<" );
				Write( thisType );
				WriteLine( ">" );
				Write( "{" );
				#endregion
				WriteNewLine();
				#region Fields
				Write( GetLoopedString( @"
	public T{0} Item{0};" , 1 , nIter ) );
				#endregion
				WriteNewLine();
				#region Constructor!(s)
				Write( @"
	public QStruct(T1 v1 = default(T1)" );
				Write( GetLoopedString( ", T{0} v{0} = default(T{0})" , 2 , nIter ) );
				Write( @")
	{" );
				Write( GetLoopedString( @"Item{0} = v{0}; " , 1 , nIter ) );
				Write( "}" );
				#endregion
				WriteNewLine();
				#region GetHashCode
				Write( @"
	public override int GetHashCode( )=>CombineHashCodes(Item1.GetHashCode()" );
				Write( GetLoopedString( ",Item{0}.GetHashCode()" , 2 , nIter ) );
				Write( ");" );
				#endregion
				WriteNewLine();
				#region "Equals"
				Write( @"
	public override bool Equals( object obj ) => obj is " );
				Write( thisType );
				Write( " && Equals( ( " );
				Write( thisType );
				Write( " ) obj );" );
				Write( @"
	public bool Equals( " );
				Write( thisType );
				Write( @" rhs ) => EqualityComparer<T1>.Default.Equals( Item1 , rhs.Item1 )" );
				Write( GetLoopedString( " && EqualityComparer<T{0}>.Default.Equals( Item{0} , rhs.Item{0} )" , 2 , nIter ) );
				Write( ";" );
				#endregion
				WriteNewLine();
				#region Operators "==" && "!="
				Write( @"
	public static bool operator ==( " );
				Write( thisType );
				Write( " lhs , " );
				Write( thisType );
				Write( @" rhs ) => lhs.Equals( rhs );
	public static bool operator !=( " );
				Write( thisType );
				Write( " lhs , " );
				Write( thisType );
				Write( @" rhs ) => !(lhs==rhs);
" );
				#endregion
				WriteNewLine();
				#region Operator "[]"
				Write( GetLoopedString( @"
	public T{0} this[Const{0} _] __OPEN_BRACE__ get => Item{0}; set => Item{0} = value; __CLOSE_BRACE__" , 1 , nIter ) );
				#endregion
				WriteNewLine();
				#region PushBack
				for ( pI = 1; pI <= insts - nIter; pI++ )
				{
					_template =
						"<_T1" +
						GetLoopedString( ",_T{0}" , 2 , pI ) +
						">";
					retTypeTemplate =
						"<T1" +
						GetLoopedString( ",T{0}" , 2 , nIter ) +
						GetLoopedString( ",_T{0}" , 1 , pI ) +
						">";
					retType = "QStruct" + retTypeTemplate;
					Write( "\t" );
					Write( $"public {retType} PushBack{_template}(_T1 NItem1" );
					Write( GetLoopedString( ", _T{0} NItem{0}" , 2 , pI ) );
					Write( @") =>
	MakeQStruct(" );
					Write( "Item1" );
					Write( GetLoopedString( ",Item{0}" , 2 , nIter ) );
					Write( GetLoopedString( ",NItem{0}" , 1 , pI ) );
					Write( @");
" );
				}
				#endregion
				WriteNewLine();
				#region PushFront
				for ( pI = 1; pI <= insts - nIter; pI++ )
				{
					_template =
						"<_T1" +
						GetLoopedString( ",_T{0}" , 2 , pI ) +
						">";
					retTypeTemplate =
						"<_T1" +
						GetLoopedString( ",_T{0}" , 2 , pI ) +
						GetLoopedString( ",T{0}" , 1 , nIter ) +
						">";
					retType = "QStruct" + retTypeTemplate;
					Write( "\t" );
					Write( $"public {retType} PushFront{_template} (_T1 NItem1" );
					Write( GetLoopedString( ", _T{0} NItem{0}" , 2 , pI ) );
					Write( @") =>
	MakeQStruct(" );
					Write( "NItem1" );
					Write( GetLoopedString( ",NItem{0}" , 2 , pI ) );
					Write( GetLoopedString( ",Item{0}" , 1 , nIter ) );
					Write( @");
" );
				}
				#endregion
				WriteNewLine();
				#region PopBack
				for ( rem = 1; rem <= nIter - 1; rem++ )
				{
					retType =
						"QStruct<T1" +
						GetLoopedString( ",T{0}" , 2 , rem ) +
						">";
					Write( "\t" );
					Write( $@"public {retType} PopBack(Const{nIter - rem} _) =>
	MakeQStruct(Item1" );
					Write( GetLoopedString( @",Item{0}" , 2 , rem ) );
					Write( @");
" );
				}
				#endregion
				WriteNewLine();
				#region PopFront
				for ( rem = 1; rem <= nIter - 1; rem++ )
				{
					retType =
						$"QStruct<T{rem + 1}" +
						GetLoopedString( ",T{0}" , rem + 2 , nIter ) +
						">";
					Write( "\t" );
					Write( $@"public {retType} PopFront(Const{rem} _) =>
	MakeQStruct(Item{rem + 1}" );
					Write( GetLoopedString( @",Item{0}" , rem + 2 , nIter ) );
					Write( @");
" );
				}
				#endregion
				WriteNewLine();
				#region SplitAt
				for ( rem = 1; rem <= nIter - 1; rem++ )
				{
					retType =
						"QStruct<QStruct<T1" +
						GetLoopedString( ",T{0}" , 2 , rem ) +
						$">,QStruct<T{rem + 1}" +
						GetLoopedString( ",T{0}" , rem + 2 , nIter ) +
						">>";
					Write( "\t" );
					Write( $@"public {retType} SplitAt(Const{rem} _)=> MakeQStruct(" );
					Write( $"PopBack(C{nIter - rem}), PopFront(C{rem})" );
					Write( @");
" );
				}
				#endregion
				WriteNewLine();
				#region ForEach
				Write( "\t" );
				Write( @"public void ForEach(VoidFunction<dynamic> func)
	{" );
				Write( GetLoopedString( "func(Item{0});" , 1 , nIter ) );
				Write( "}\n" );
				#endregion
				WriteNewLine();
				#region ForEachGetResult
				{
					retType =
					  "QStruct<dynamic" +
					  GetLoopedString( ",dynamic" , 2 , nIter ) +
					  ">";
					Write( "\t" );
					Write( $@"public {retType} ForEachGetResult(Function<dynamic,dynamic> func) => MakeQStruct(func(Item1)" );
					Write( GetLoopedString( ", func(Item{0})" , 2 , nIter ) );
					Write( ");\n" );
				}
				#endregion
				WriteNewLine();
				Write( @"}

" );
			}
		}

		private static void CPPPrint_Tuple_ClassTemplates( )
		{
			#region First Instantiation
			WriteLine( @"
template<typename... TS> struct QStruct;

template<typename... Ts>
constexpr auto MakeQStruct(Ts&&... Items)
{return QStruct<boost::remove_cv_ref_t<Ts>...>(std::forward<Ts>(Items)...);}

template<typename T1>
struct QStruct<T1>
{
	using self = QStruct<T1>;

	T1 Item1;

	constexpr QStruct():Item1(){}

	template<typename _T1>
	constexpr QStruct(_T1&& v1):Item1(std::forward<_T1>(v1)){}

	size_t GetHashCode( ) const {return Hasher()(Item1);}

	constexpr bool Equals( const self& rhs ) const {return AreEqualDTrue( Item1 , rhs.Item1 );}

	constexpr bool operator ==( const self& rhs ) const{return Equals( rhs );}

	constexpr bool operator !=( const self& rhs ) const{return !Equals( rhs );}

	constexpr T1& operator[](Const1){return Item1;}

	constexpr const T1& operator[](Const1) const {return Item1;}

	template<typename... _Ts>
	constexpr auto PushBack(_Ts&&... Items) const 
	{return MakeQStruct(Item1,std::forward<_Ts>(Items)...);}

	template<typename... _Ts>
	constexpr auto PushFront(_Ts&&... Items) const 
	{return MakeQStruct(std::forward<_Ts>(Items)...,Item1);}

	template<typename TFunc>
	constexpr auto ForEach(TFunc func) { func(Item1); }

	template<typename TFunc>
	constexpr auto ForEachGetResult(TFunc func)
	{return MakeQStruct( func(Item1) );}

	template<typename TFunc>
	constexpr auto ForEach(TFunc func) const { func(Item1); }

	template<typename TFunc>
	constexpr auto ForEachGetResult(TFunc func) const
	{return MakeQStruct( func(Item1) );}
};" );
			#endregion
			for ( ulong nIter = 2; nIter <= insts; nIter++ )
			{
				string thisType = "QStruct<T1" +
					GetLoopedString( ", T{0}" , 2 , nIter ) +
					">";
				#region Struct
				#region Start Template
				Write( "template<typename T1" );
				Write( GetLoopedString( ", typename T{0}" , 2 , nIter ) );
				Write( ">" );
				#endregion
				#region Struct & Self
				Write( @"
struct " );
				Write( thisType );
				Write( @"
{
	using self = " );
				Write( thisType );
				Write( ";" );
				#endregion
				#endregion
				WriteNewLine();
				#region Fields
				Write( GetLoopedString( @"
	T{0} Item{0};" , 1 , nIter ) );
				#endregion
				WriteNewLine();
				#region Constructor(s)
				#region Default Constructor
				Write( @"
	constexpr QStruct(): Item1{}" );
				Write( GetLoopedString( @", Item{0} __DEFAULT_UNIFORM_INITIALIZER__" , 2 , nIter ) );
				Write( @"
	{}" );
				#endregion
				WriteNewLine();
				#region Forwarding Constructor
				#region Template
				Write( @"
	template<typename _T1" );
				Write( GetLoopedString( ", typename _T{0}" , 2 , nIter ) );
				Write( @"> " );
				#endregion
				#region Implementation
				Write( @"constexpr QStruct(_T1 v1" );
				Write( GetLoopedString( ", _T{0} v{0}" , 2 , nIter ) );
				Write( @") : Item1(std::forward<_T1>(v1))" );
				Write( GetLoopedString( @", Item{0}( std::forward<_T{0}>(v{0}) )" , 2 , nIter ) );
				Write( @"
	{}" );
				#endregion
				#endregion
				#endregion
				WriteNewLine();
				#region GetHashCode
				Write( @"
	size_t GetHashCode( ) const 
	{
		return CombineHashCodes(Hasher()( Item1 )" );
				Write( GetLoopedString( @", Hasher()(Item{0})" , 2 , nIter ) );
				Write( @");
	}" );
				#endregion
				WriteNewLine();
				#region "Equals"
				Write( @"
	constexpr bool Equals( const self& rhs ) const 
	{ 
		return AreEqualDTrue( Item1 , rhs.Item1 )" );
				Write( GetLoopedString( @" && AreEqualDTrue( Item{0} , rhs.Item{0} )" ,
					2 , nIter ) );
				Write( @";
	}" );
				#endregion
				WriteNewLine();
				#region Operators "==" && "!="
				Write( @"
	constexpr forceinline bool operator ==( const self& rhs ) const { return Equals( rhs );}
	constexpr forceinline bool operator !=( const self& rhs ) const {return !Equals(rhs);}" );
				#endregion
				WriteNewLine();
				#region Operator "[]"
				Write( GetLoopedString( @"
	constexpr forceinline T{0}& operator[](Const{0}) __OPEN_BRACE__ return Item{0}; __CLOSE_BRACE__" , 1 , nIter ) );
				WriteNewLine();
				#region Const Operator "[]"
				Write( GetLoopedString( @"
	constexpr forceinline const T{0}& operator[](Const{0}) const __OPEN_BRACE__ return Item{0}; __CLOSE_BRACE__" , 1 , nIter ) );
				#endregion
				#endregion
				WriteNewLine();
				#region PushBack
				Write( @"
	template<typename... _Ts>
	constexpr auto PushBack(_Ts&&... Items) const
	{return MakeQStruct(Item1" );
				Write( GetLoopedString( @", Item{0}" , 2 , nIter ) );
				Write( @", std::forward<_Ts>(Items)...);}" );
				#endregion
				WriteNewLine();
				#region PushFront
				Write( @"
	template<typename... _Ts>
	constexpr auto PushFront(_Ts&&... Items) const
	{return MakeQStruct(std::forward<_Ts>(Items)..." );
				Write( GetLoopedString( @", Item{0}" , 1 , nIter ) );
				Write( @");}" );
				#endregion
				WriteNewLine();
				#region PopBack
				for ( ulong rem = 1; rem <= nIter - 1; rem++ )
				{
					Write( $@"
	constexpr auto PopBack(Const{nIter - rem}) const" );
					Write( @"
	{return MakeQStruct(Item1" );
					Write( GetLoopedString( @",Item{0}" , 2 , rem ) );
					Write( ");}" );
				}
				#endregion
				WriteNewLine();
				#region PopFront
				for ( ulong rem = 1; rem <= nIter - 1; rem++ )
				{
					Write( $@"
	constexpr auto PopFront(Const{rem}) const" );
					Write( @"
	{return MakeQStruct(Item" );
					Write( $"{rem + 1}" );
					Write( GetLoopedString( @",Item{0}" , rem + 2 , nIter ) );
					Write( ");}" );
				}
				#endregion
				WriteNewLine();
				#region SplitAt
				for ( ulong rem = 1; rem <= nIter - 1; rem++ )
				{
					Write( $@"
	constexpr auto SplitAt(Const{rem}) const" );
					Write( @"{return MakeQStruct(" );
					Write( $"PopBack(C{nIter - rem}), PopFront(C{rem})" );
					Write( ");}" );
				}
				#endregion
				WriteNewLine();
				#region ForEach
				Write( @"
	template<typename TFunc>
	constexpr void ForEach(TFunc func)
	{" );
				Write( GetLoopedString( "func(Item{0});" , 1 , nIter ) );
				Write( "}" );
				WriteNewLine();
				#region Const ForEach
				Write( @"
	template<typename TFunc>
	constexpr auto ForEach(TFunc func) const
	{" );
				Write( GetLoopedString( "func(Item{0});" , 1 , nIter ) );
				Write( "}" );
				#endregion
				#endregion
				WriteNewLine();
				#region ForEachGetResult
				Write( @"
	template<typename TFunc>
	constexpr auto ForEachGetResult(TFunc func)
	{return MakeQStruct(func(Item1)" );
				Write( GetLoopedString( ", func(Item{0})" , 2 , nIter ) );
				Write( ");}" );
				WriteNewLine();
				#region Const ForEachGetResult
				Write( @"
	template<typename TFunc>
	constexpr auto ForEachGetResult(TFunc func) const
	{return MakeQStruct(func(Item1)" );
				Write( GetLoopedString( ", func(Item{0})" , 2 , nIter ) );
				Write( @");}" );
				#endregion
				#endregion
				WriteNewLine();
				Write( "};" );
				WriteNewLine();
			}
		}

		private static void CSPrint__DECOMPOSE_QS_FunctionTemplate( )
		{
			for ( ulong nIter = 1; nIter <= insts; nIter++ )
			{
				string template =
					"<T1" +
					GetLoopedString( ",T{0}" , 2 , nIter ) +
					">";
				Write( $@"public static void _DECOMPOSE_QS{template}(QStruct{template} tup" );
				Write( GetLoopedString( ", out T{0} Item{0}" , 1 , nIter ) );
				Write( @")
{" );
				Write( GetLoopedString( @"
	Item{0} = tup.Item{0};" , 1 , nIter ) );
				Write( @"
}

" );
			}
			for ( ulong nIter = 1; nIter <= insts; nIter++ )
			{
				string template =
					"<T1" +
					GetLoopedString( ",T{0}" , 2 , nIter ) +
					">";
				Write( $@"public static void _DECOMPOSE_QS_NNV{template}(QStruct{template} tup" );
				Write( GetLoopedString( ", out T{0} Item{0}" , 1 , nIter ) );
				Write( @")
{" );
				Write( GetLoopedString( @"
	Item{0} = tup.Item{0};" , 1 , nIter ) );
				Write( @"
}

" );
			}
		}

		private static void CSPrint_Lambda_FunctionTemplate( )
		{
			for ( ulong nIter = 1; nIter <= insts; nIter++ )
			{
				string template =
					"<TReturn" +
					GetLoopedString( ",T{0}" , 1 , nIter ) +
					">";
				Write( $"public static Function{template} Lambda{template}(Function{template} value) => value;\n" );
			}
			for ( ulong nIter = 1; nIter <= insts; nIter++ )
			{
				string template =
					"<T1" +
					GetLoopedString( ",T{0}" , 2 , nIter ) +
					">";
				Write( $"public static VoidFunction{template} Lambda{template}(VoidFunction{template} value) => value;\n" );
			}
		}

		private static void WriteNewLine( ) => WriteLine( "" );
	}
}