namespace UnityEngine;

public sealed class AndroidJavaException : Exception
{
	private string mJavaStackTrace; //Field offset: 0x48

	public virtual string StackTrace
	{
		 get { } //Length: 33
	}

	internal AndroidJavaException(string message, string javaStackTrace) { }

	public virtual string get_StackTrace() { }

}

