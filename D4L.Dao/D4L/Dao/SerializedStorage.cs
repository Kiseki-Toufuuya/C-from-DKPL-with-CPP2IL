namespace D4L.Dao;

public struct SerializedStorage
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public SerializedStorage __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public static void AddEntries(FlatBufferBuilder builder, VectorOffset EntriesOffset) { }

	public static VectorOffset CreateEntriesVector(FlatBufferBuilder builder, Offset<SerializedStorageEntry>[] data) { }

	public static Offset<SerializedStorage> CreateSerializedStorage(FlatBufferBuilder builder, VectorOffset EntriesOffset = null) { }

	public static Offset<SerializedStorage> EndSerializedStorage(FlatBufferBuilder builder) { }

	public Nullable<SerializedStorageEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static SerializedStorage GetRootAsSerializedStorage(ByteBuffer _bb) { }

	public static SerializedStorage GetRootAsSerializedStorage(ByteBuffer _bb, SerializedStorage obj) { }

}

