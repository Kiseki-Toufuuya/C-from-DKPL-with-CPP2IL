namespace D4L.TakashoFes.Master;

public struct CardR2ExpRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public CardR2ExpRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<CardR2ExpRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static CardR2ExpRaw GetRootAsCardR2ExpRaw(ByteBuffer _bb) { }

	public static CardR2ExpRaw GetRootAsCardR2ExpRaw(ByteBuffer _bb, CardR2ExpRaw obj) { }

}

