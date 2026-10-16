namespace System.Xml;

internal class MimeReader
{
	private static Byte[] CRLFCRLF; //Field offset: 0x0
	private Byte[] boundaryBytes; //Field offset: 0x8
	private string content; //Field offset: 0xC
	private Stream currentStream; //Field offset: 0x10
	private MimeHeaderReader mimeHeaderReader; //Field offset: 0x14
	private DelimittedStreamReader reader; //Field offset: 0x18
	private Byte[] scratch; //Field offset: 0x1C

	public string Preface
	{
		 get { } //Length: 223
	}

	private static MimeReader() { }

	public MimeReader(Stream stream, string boundary) { }

	private int BlockRead(Stream stream, Byte[] buffer, int offset, int count) { }

	public void Close() { }

	public string get_Preface() { }

	public Stream GetContentStream() { }

	public MimeHeaders ReadHeaders(int maxBuffer, ref int remaining) { }

	public bool ReadNextPart() { }

}

