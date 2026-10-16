namespace Mono.Net.Security;

internal class BufferOffsetSize
{
	public Byte[] Buffer; //Field offset: 0x8
	public int Offset; //Field offset: 0xC
	public int Size; //Field offset: 0x10
	public int TotalBytes; //Field offset: 0x14
	public bool Complete; //Field offset: 0x18

	public int EndOffset
	{
		 get { } //Length: 14
	}

	public int Remaining
	{
		 get { } //Length: 29
	}

	public BufferOffsetSize(Byte[] buffer, int offset, int size) { }

	public int get_EndOffset() { }

	public int get_Remaining() { }

	public virtual string ToString() { }

}

