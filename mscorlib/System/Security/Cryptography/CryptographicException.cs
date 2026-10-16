namespace System.Security.Cryptography;

[ComVisible(True)]
public class CryptographicException : SystemException
{
	private const int FORMAT_MESSAGE_IGNORE_INSERTS = 512; //Field offset: 0x0
	private const int FORMAT_MESSAGE_FROM_SYSTEM = 4096; //Field offset: 0x0
	private const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192; //Field offset: 0x0

	public CryptographicException() { }

	public CryptographicException(string message) { }

	public CryptographicException(string format, string insert) { }

	public CryptographicException(string message, Exception inner) { }

	public CryptographicException(int hr) { }

	protected CryptographicException(SerializationInfo info, StreamingContext context) { }

	private static void ThrowCryptographicException(int hr) { }

}

