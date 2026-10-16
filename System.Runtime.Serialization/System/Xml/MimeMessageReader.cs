namespace System.Xml;

internal class MimeMessageReader
{
	private static Byte[] CRLFCRLF; //Field offset: 0x0
	private bool getContentStreamCalled; //Field offset: 0x8
	private MimeHeaderReader mimeHeaderReader; //Field offset: 0xC
	private DelimittedStreamReader reader; //Field offset: 0x10

	private static MimeMessageReader() { }

	public MimeMessageReader(Stream stream) { }

	public Stream GetContentStream() { }

	public MimeHeaders ReadHeaders(int maxBuffer, ref int remaining) { }

}

