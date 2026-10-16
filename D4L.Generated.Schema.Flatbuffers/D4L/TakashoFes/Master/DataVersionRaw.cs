namespace D4L.TakashoFes.Master;

public struct DataVersionRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public DataVersionRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<DataVersionRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static DataVersionRaw GetRootAsDataVersionRaw(ByteBuffer _bb) { }

	public static DataVersionRaw GetRootAsDataVersionRaw(ByteBuffer _bb, DataVersionRaw obj) { }

}

