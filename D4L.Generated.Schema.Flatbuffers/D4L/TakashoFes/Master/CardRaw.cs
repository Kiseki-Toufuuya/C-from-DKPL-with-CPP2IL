namespace D4L.TakashoFes.Master;

public struct CardRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public CardRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<CardRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static CardRaw GetRootAsCardRaw(ByteBuffer _bb) { }

	public static CardRaw GetRootAsCardRaw(ByteBuffer _bb, CardRaw obj) { }

}

