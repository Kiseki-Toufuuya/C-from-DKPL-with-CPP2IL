namespace System.Xml;

internal class MimeWriter
{
	private Stream stream; //Field offset: 0x8
	private Byte[] boundaryBytes; //Field offset: 0xC
	private MimeWriterState state; //Field offset: 0x10
	private BufferedWrite bufferedWrite; //Field offset: 0x14
	private Stream contentStream; //Field offset: 0x18

	internal MimeWriterState WriteState
	{
		internal get { } //Length: 11
	}

	internal MimeWriter(Stream stream, string boundary) { }

	internal void Close() { }

	private void Flush() { }

	internal MimeWriterState get_WriteState() { }

	internal static Byte[] GetBoundaryBytes(string boundary) { }

	internal int GetBoundarySize() { }

	internal Stream GetContentStream() { }

	internal static int GetHeaderSize(string name, string value, int maxSizeInBytes) { }

	internal void StartPart() { }

	internal void StartPreface() { }

	internal void WriteHeader(string name, string value) { }

}

