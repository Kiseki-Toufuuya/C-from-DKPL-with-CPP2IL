namespace System;

public sealed class InsufficientMemoryException : OutOfMemoryException
{

	public InsufficientMemoryException() { }

	private InsufficientMemoryException(SerializationInfo info, StreamingContext context) { }

}

