namespace System.Runtime.CompilerServices;

public sealed class RuntimeWrappedException : Exception
{
	private object _wrappedException; //Field offset: 0x48

	public object WrappedException
	{
		 get { } //Length: 11
	}

	public RuntimeWrappedException(object thrownObject) { }

	private RuntimeWrappedException(SerializationInfo info, StreamingContext context) { }

	internal RuntimeWrappedException() { }

	public object get_WrappedException() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

