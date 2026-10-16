namespace FlatBuffers;

public sealed class ByteArrayAllocator : ByteBufferAllocator
{
	private Byte[] _buffer; //Field offset: 0x10

	public ByteArrayAllocator(Byte[] buffer) { }

	public virtual void GrowFront(int newSize) { }

	private void InitBuffer() { }

}

