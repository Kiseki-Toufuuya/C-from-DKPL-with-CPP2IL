namespace Mono.Net.Security;

internal class BufferOffsetSize2 : BufferOffsetSize
{
	public readonly int InitialSize; //Field offset: 0x1C

	public BufferOffsetSize2(int size) { }

	public void AppendData(Byte[] buffer, int offset, int size) { }

	public void MakeRoom(int size) { }

	public void Reset() { }

}

