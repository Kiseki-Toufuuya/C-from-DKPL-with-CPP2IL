namespace System;

public class ObjectDisposedException : InvalidOperationException
{
	private string _objectName; //Field offset: 0x48

	public virtual string Message
	{
		 get { } //Length: 132
	}

	public string ObjectName
	{
		 get { } //Length: 29
	}

	private ObjectDisposedException() { }

	public ObjectDisposedException(string objectName) { }

	public ObjectDisposedException(string objectName, string message) { }

	protected ObjectDisposedException(SerializationInfo info, StreamingContext context) { }

	public virtual string get_Message() { }

	public string get_ObjectName() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

