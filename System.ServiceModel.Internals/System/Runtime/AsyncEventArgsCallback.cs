namespace System.Runtime;

internal sealed class AsyncEventArgsCallback : MulticastDelegate
{

	public AsyncEventArgsCallback(object object, IntPtr method) { }

	public override void Invoke(IAsyncEventArgs eventArgs) { }

}

