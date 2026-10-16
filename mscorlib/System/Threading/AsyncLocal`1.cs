namespace System.Threading;

public sealed class AsyncLocal : IAsyncLocal
{
	private readonly Action<AsyncLocalValueChangedArgs`1<T>> m_valueChangedHandler; //Field offset: 0x0

	public T Value
	{
		 set { } //Length: 87
	}

	public AsyncLocal`1(Action<AsyncLocalValueChangedArgs`1<T>> valueChangedHandler) { }

	public void set_Value(T value) { }

	private override void System.Threading.IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged) { }

}

