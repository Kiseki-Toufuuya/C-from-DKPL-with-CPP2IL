namespace System.Security.Cryptography;

[ComVisible(True)]
public class CryptographicUnexpectedOperationException : CryptographicException
{

	public CryptographicUnexpectedOperationException() { }

	public CryptographicUnexpectedOperationException(string message) { }

	public CryptographicUnexpectedOperationException(string format, string insert) { }

	public CryptographicUnexpectedOperationException(string message, Exception inner) { }

	protected CryptographicUnexpectedOperationException(SerializationInfo info, StreamingContext context) { }

}

