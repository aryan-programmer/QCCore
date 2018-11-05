namespace QCCore
{
	internal interface IWeakPtr<T> where T : class
	{
		bool Expired( );
		GCPtr<T> Lock( );
		GCPtr<T> LockIfNotThrow( );
		WeakPtr<T> Reset( );
	}
}