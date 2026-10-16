namespace System.Runtime;

internal interface IAsyncEventArgs
{

	public object AsyncState
	{
		 get { } //Length: 0
	}

	public Exception Exception
	{
		 get { } //Length: 0
	}

	public object get_AsyncState() { }

	public Exception get_Exception() { }

}

