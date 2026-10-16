namespace D4L.TakashoFes.Master;

public struct CardR4ExpRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public CardR4ExpRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<CardR4ExpRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static CardR4ExpRaw GetRootAsCardR4ExpRaw(ByteBuffer _bb) { }

	public static CardR4ExpRaw GetRootAsCardR4ExpRaw(ByteBuffer _bb, CardR4ExpRaw obj) { }

}

