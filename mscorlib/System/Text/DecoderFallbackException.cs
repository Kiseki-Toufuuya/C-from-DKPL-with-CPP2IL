namespace System.Text;

public sealed class DecoderFallbackException : ArgumentException
{
	private Byte[] _bytesUnknown; //Field offset: 0x4C
	private int _index; //Field offset: 0x50

	public DecoderFallbackException() { }

	public DecoderFallbackException(string message, Byte[] bytesUnknown, int index) { }

	private DecoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

