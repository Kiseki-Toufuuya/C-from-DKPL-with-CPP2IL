namespace System.Runtime;

internal class FatalException : SystemException
{

	public FatalException() { }

	public FatalException(string message, Exception innerException) { }

	protected FatalException(SerializationInfo info, StreamingContext context) { }

}

