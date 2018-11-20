namespace QCCore
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.CodeAnalysis;

	public struct NullPtrType { };
	public static partial class MainCls
	{ public static readonly NullPtrType NullPtr = new NullPtrType(); }

	[Serializable]
	public class BadWeakPtrException : Exception
	{
		public BadWeakPtrException( ) { }
		public BadWeakPtrException( string message ) : base( message ) { }
		public BadWeakPtrException( string message , Exception inner ) : base( message , inner ) { }
		protected BadWeakPtrException(
		  System.Runtime.Serialization.SerializationInfo info ,
		  System.Runtime.Serialization.StreamingContext context ) : base( info , context ) { }
	}

	[Serializable]
	public class NullPointerException : Exception
	{
		public NullPointerException( ) { }
		public NullPointerException( string message ) : base( message ) { }
		public NullPointerException( string message , Exception inner ) : base( message , inner ) { }
		protected NullPointerException(
		  System.Runtime.Serialization.SerializationInfo info ,
		  System.Runtime.Serialization.StreamingContext context ) : base( info , context ) { }
	}

#pragma warning disable CS0660 // No Equals(object o)
#pragma warning disable CS0661 // No GetHashCode()
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
	public struct GCPtr<T> :
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
		IEquatable<GCPtr<T>> where T : class
#pragma warning restore CS0661 // No GetHashCode()
#pragma warning restore CS0660 // No Equals(object o)
	{
		private T value;

		public GCPtr( NullPtrType null_ = default ) => value = null;
		public GCPtr( T value ) => this.value = value;

		public GCPtr<T> Reset( ) { value = null; return this; }
		public GCPtr<T> Reset( T val )
		{ value = val; return this; }

		public T Get( ) => value ?? throw new NullPointerException( "read access violation, value was nullptr" );

		public bool HasValue( ) => value != null;

		public static bool operator !=( GCPtr<T> ptr , NullPtrType obj ) => ptr.value != null;
		public static bool operator ==( GCPtr<T> ptr , NullPtrType obj ) => ptr.value != null;
		public static bool operator !=( NullPtrType obj , GCPtr<T> ptr ) => ptr.value != null;
		public static bool operator ==( NullPtrType obj , GCPtr<T> ptr ) => ptr.value != null;
		public static implicit operator GCPtr<T>( NullPtrType nullptr ) => new GCPtr<T>();

		public static bool operator ==( GCPtr<T> ptr1 , GCPtr<T> ptr2 ) => ptr1.Equals( ptr2 );
		public static bool operator !=( GCPtr<T> ptr1 , GCPtr<T> ptr2 ) => !( ptr1 == ptr2 );

		public T __NATIVE( ) => value;
		public override bool Equals( object obj ) => obj is GCPtr<T> && Equals( ( GCPtr<T> ) obj );
		public bool Equals( GCPtr<T> other ) => EqualityComparer<T>.Default.Equals( value , other.value );
	}

	[SuppressMessage( "NDepend" , "ND1805:FieldsShouldBeDeclaredAsPrivate" , Justification = "Meant to wrap values as a reference." )]
	public class RefWrap<T> { public T value; }

#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
#pragma warning disable CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
	public struct WeakPtr<T> :
#pragma warning restore CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
		IEquatable<WeakPtr<T>> where T : class
	{
		private WeakReference wptr;

		public WeakPtr( NullPtrType _T = default ) => wptr = null;
		public WeakPtr( GCPtr<T> ptr ) => wptr = new WeakReference( ptr.__NATIVE() );

		public WeakPtr<T> Reset( ) { wptr = null; return this; }

		public bool Expired( ) => !( wptr?.IsAlive ?? true );

		public GCPtr<T> Lock( ) => wptr != null ? new GCPtr<T>( ( T ) wptr.Target ) : new GCPtr<T>( MainCls.NullPtr );

		public GCPtr<T> LockIfNotThrow( )
		{
			GCPtr<T> lockedVal = Lock();
			if ( lockedVal == MainCls.NullPtr ) throw new BadWeakPtrException( "BadWeakPtrException" );
			return lockedVal;
		}

		public static implicit operator WeakPtr<T>( GCPtr<T> gCPtr ) => new WeakPtr<T>( gCPtr );

		public static implicit operator WeakPtr<T>( NullPtrType nullptr ) => new WeakPtr<T>();

		public static bool operator ==( WeakPtr<T> ptr1 , WeakPtr<T> ptr2 ) => ptr1.Equals( ptr2 );
		public static bool operator !=( WeakPtr<T> ptr1 , WeakPtr<T> ptr2 ) => !( ptr1 == ptr2 );

		public WeakReference __NATIVE( ) => wptr;
		public override bool Equals( object obj ) => obj is WeakPtr<T> && Equals( ( WeakPtr<T> ) obj );
		public bool Equals( WeakPtr<T> other ) => EqualityComparer<WeakReference>.Default.Equals( wptr , other.wptr );
	}

	public static partial class MainCls
	{
		public static GCPtr<T> GCFromMe<T>( this T me ) where T : class, IEnableGCPtrFromMe<T> => new GCPtr<T>( me );
		public static WeakPtr<T> WeakFromMe<T>( this T me ) where T : class, IEnableGCPtrFromMe<T> => new WeakPtr<T>( me.GCFromMe() );
	}

#pragma warning disable IDE1006 // Naming Styles
	public interface IEnableGCPtrFromMe<T> where T : IEnableGCPtrFromMe<T> { }
#pragma warning restore IDE1006 // Naming Styles
}