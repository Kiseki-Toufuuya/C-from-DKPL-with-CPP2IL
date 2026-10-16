namespace D4L.TakashoFes.Master;

public struct ComboMaxRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public ComboMaxRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<ComboMaxRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static ComboMaxRaw GetRootAsComboMaxRaw(ByteBuffer _bb) { }

	public static ComboMaxRaw GetRootAsComboMaxRaw(ByteBuffer _bb, ComboMaxRaw obj) { }

}

