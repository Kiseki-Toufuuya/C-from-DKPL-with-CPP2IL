namespace System.Xml;

internal class BufferedWrite
{
	private Byte[] buffer; //Field offset: 0x8
	private int offset; //Field offset: 0xC

	internal int Length
	{
		internal get { } //Length: 11
	}

	internal BufferedWrite() { }

	internal BufferedWrite(int initialSize) { }

	private void EnsureBuffer(int count) { }

	internal int get_Length() { }

	internal Byte[] GetBuffer() { }

	internal void Reset() { }

	internal void Write(Byte[] value) { }

	internal void Write(Byte[] value, int index, int count) { }

	internal void Write(string value) { }

	internal void Write(string value, int index, int count) { }

}

