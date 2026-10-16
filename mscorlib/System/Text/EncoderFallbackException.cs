namespace System.Text;

public sealed class EncoderFallbackException : ArgumentException
{
	private char _charUnknown; //Field offset: 0x4C
	private char _charUnknownHigh; //Field offset: 0x4E
	private char _charUnknownLow; //Field offset: 0x50
	private int _index; //Field offset: 0x54

	public EncoderFallbackException() { }

	internal EncoderFallbackException(string message, char charUnknown, int index) { }

	internal EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index) { }

	private EncoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

