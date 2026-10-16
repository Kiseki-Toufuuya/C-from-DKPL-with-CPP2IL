namespace FlatBuffers;

public class FlatBufferBuilder
{
	private int _space; //Field offset: 0x8
	private ByteBuffer _bb; //Field offset: 0xC
	private int _minAlign; //Field offset: 0x10
	private Int32[] _vtable; //Field offset: 0x14
	private int _vtableSize; //Field offset: 0x18
	private int _objectStart; //Field offset: 0x1C
	private Int32[] _vtables; //Field offset: 0x20
	private int _numVtables; //Field offset: 0x24
	private int _vectorNumElems; //Field offset: 0x28
	[CompilerGenerated]
	private bool <ForceDefaults>k__BackingField; //Field offset: 0x2C

	public bool ForceDefaults
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int Offset
	{
		 get { } //Length: 33
	}

	public FlatBufferBuilder(int initialSize) { }

	public void AddByte(byte x) { }

	public void AddInt(int x) { }

	public void AddOffset(int o, int x, int d) { }

	public void AddOffset(int off) { }

	public void AddShort(short x) { }

	public StringOffset CreateString(string s) { }

	public int EndObject() { }

	public VectorOffset EndVector() { }

	protected void Finish(int rootTable, bool sizePrefix) { }

	protected void Finish(int rootTable, string fileIdentifier, bool sizePrefix) { }

	public void Finish(int rootTable, string fileIdentifier) { }

	[CompilerGenerated]
	public bool get_ForceDefaults() { }

	public int get_Offset() { }

	private void GrowBuffer() { }

	public void NotNested() { }

	public void Pad(int size) { }

	public void Prep(int size, int additionalBytes) { }

	public void PutByte(byte x) { }

	public void PutInt(int x) { }

	public void PutShort(short x) { }

	public Byte[] SizedByteArray() { }

	public void Slot(int voffset) { }

	public void StartObject(int numfields) { }

	public void StartVector(int elemSize, int count, int alignment) { }

}

