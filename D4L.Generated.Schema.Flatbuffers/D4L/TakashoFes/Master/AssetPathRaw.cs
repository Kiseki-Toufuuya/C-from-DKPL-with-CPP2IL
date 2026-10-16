namespace D4L.TakashoFes.Master;

public struct AssetPathRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public AssetPathRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<AssetPathRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static AssetPathRaw GetRootAsAssetPathRaw(ByteBuffer _bb) { }

	public static AssetPathRaw GetRootAsAssetPathRaw(ByteBuffer _bb, AssetPathRaw obj) { }

}

