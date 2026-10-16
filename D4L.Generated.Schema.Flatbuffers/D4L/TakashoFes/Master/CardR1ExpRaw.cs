namespace D4L.TakashoFes.Master;

public struct CardR1ExpRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public CardR1ExpRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<CardR1ExpRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static CardR1ExpRaw GetRootAsCardR1ExpRaw(ByteBuffer _bb) { }

	public static CardR1ExpRaw GetRootAsCardR1ExpRaw(ByteBuffer _bb, CardR1ExpRaw obj) { }

}

