namespace FlatBuffers;

public class ByteBuffer
{
	private static Dictionary<Type, Int32> genericSizes; //Field offset: 0x0
	private ByteBufferAllocator _buffer; //Field offset: 0x8
	private int _pos; //Field offset: 0xC
	private Single[] floathelper; //Field offset: 0x10
	private Int32[] inthelper; //Field offset: 0x14
	private Double[] doublehelper; //Field offset: 0x18
	private UInt64[] ulonghelper; //Field offset: 0x1C

	public int Length
	{
		 get { } //Length: 23
	}

	public int Position
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static ByteBuffer() { }

	public ByteBuffer(Byte[] buffer, int pos) { }

	public ByteBuffer(int size) { }

	public ByteBuffer(Byte[] buffer) { }

	public static int ArraySize(T[] x) { }

	private void AssertOffsetAndLength(int offset, int length) { }

	public byte Get(int index) { }

	public int get_Length() { }

	public int get_Position() { }

	public float GetFloat(int index) { }

	public int GetInt(int index) { }

	public long GetLong(int index) { }

	public sbyte GetSbyte(int index) { }

	public short GetShort(int index) { }

	public string GetStringUTF8(int startPos, int len) { }

	public void GrowFront(int newSize) { }

	public void PutByte(int offset, byte value) { }

	public void PutByte(int offset, byte value, int count) { }

	public void PutInt(int offset, int value) { }

	public void PutShort(int offset, short value) { }

	public void PutStringUTF8(int offset, string value) { }

	protected ulong ReadLittleEndian(int offset, int count) { }

	public void set_Position(int value) { }

	public static int SizeOf() { }

	public T[] ToArray(int pos, int len) { }

	public ArraySegment<Byte> ToArraySegment(int pos, int len) { }

	public Byte[] ToSizedArray() { }

	protected void WriteLittleEndian(int offset, int count, ulong data) { }

}

