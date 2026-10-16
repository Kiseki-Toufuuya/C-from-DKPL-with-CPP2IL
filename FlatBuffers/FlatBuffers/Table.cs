namespace FlatBuffers;

public struct Table
{
	public int bb_pos; //Field offset: 0x0
	public ByteBuffer bb; //Field offset: 0x4

	public int __indirect(int offset) { }

	public int __offset(int vtableOffset) { }

	public string __string(int offset) { }

	public int __vector(int offset) { }

	public Nullable<ArraySegment`1<Byte>> __vector_as_arraysegment(int offset) { }

	public int __vector_len(int offset) { }

}

