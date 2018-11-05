namespace QCCore
{
	public interface IGCPtr<T> where T : class
	{
		T Get( );
		bool HasValue( );
		GCPtr<T> Reset( );
		GCPtr<T> Reset( T val );
	}
}