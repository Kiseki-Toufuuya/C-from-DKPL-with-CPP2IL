namespace System.Net;

internal class BufferOffsetSize
{
	internal Byte[] Buffer; //Field offset: 0x8
	internal int Offset; //Field offset: 0xC
	internal int Size; //Field offset: 0x10

	internal BufferOffsetSize(Byte[] buffer, int offset, int size, bool copyBuffer) { }

	internal BufferOffsetSize(Byte[] buffer, bool copyBuffer) { }

}

