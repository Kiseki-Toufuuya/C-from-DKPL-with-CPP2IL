namespace System.Xml;

internal class MimeHeaderReader
{
	private enum ReadState
	{
		ReadName = 0,
		SkipWS = 1,
		ReadValue = 2,
		ReadLF = 3,
		ReadWS = 4,
		EOF = 5,
	}

	private string value; //Field offset: 0x8
	private Byte[] buffer; //Field offset: 0xC
	private int maxOffset; //Field offset: 0x10
	private string name; //Field offset: 0x14
	private int offset; //Field offset: 0x18
	private ReadState readState; //Field offset: 0x1C
	private Stream stream; //Field offset: 0x20

	public string Name
	{
		 get { } //Length: 11
	}

	public string Value
	{
		 get { } //Length: 11
	}

	public MimeHeaderReader(Stream stream) { }

	private void AppendName(string value, int maxBuffer, ref int remaining) { }

	private void AppendValue(string value, int maxBuffer, ref int remaining) { }

	private bool BufferEnd() { }

	public void Close() { }

	public string get_Name() { }

	public string get_Value() { }

	private bool ProcessBuffer(int maxBuffer, ref int remaining) { }

	public bool Read(int maxBuffer, ref int remaining) { }

	public void Reset(Stream stream) { }

}

