namespace System;

public class UnhandledExceptionEventArgs : EventArgs
{
	private object _exception; //Field offset: 0x8
	private bool _isTerminating; //Field offset: 0xC

	public object ExceptionObject
	{
		 get { } //Length: 11
	}

	public bool IsTerminating
	{
		 get { } //Length: 11
	}

	public UnhandledExceptionEventArgs(object exception, bool isTerminating) { }

	public object get_ExceptionObject() { }

	public bool get_IsTerminating() { }

}

