namespace D4L.TakashoFes.Master;

public struct PKVSRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public PKVSRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<PKVSRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static PKVSRaw GetRootAsPKVSRaw(ByteBuffer _bb) { }

	public static PKVSRaw GetRootAsPKVSRaw(ByteBuffer _bb, PKVSRaw obj) { }

}

