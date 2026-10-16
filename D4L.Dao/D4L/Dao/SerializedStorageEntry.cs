namespace D4L.Dao;

public struct SerializedStorageEntry
{
	private Table __p; //Field offset: 0x0

	public string Key
	{
		 get { } //Length: 48
	}

	public SerializedStorageEntry __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public static void AddKey(FlatBufferBuilder builder, StringOffset KeyOffset) { }

	public static void AddValue(FlatBufferBuilder builder, VectorOffset ValueOffset) { }

	public static Offset<SerializedStorageEntry> CreateSerializedStorageEntry(FlatBufferBuilder builder, StringOffset KeyOffset = null, VectorOffset ValueOffset = null) { }

	public static VectorOffset CreateValueVector(FlatBufferBuilder builder, Byte[] data) { }

	public static Offset<SerializedStorageEntry> EndSerializedStorageEntry(FlatBufferBuilder builder) { }

	public string get_Key() { }

	public Nullable<ArraySegment`1<Byte>> GetValueBytes() { }

}

