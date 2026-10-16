namespace D4L.TakashoFes.Master;

public struct CardR3ExpRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public CardR3ExpRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<CardR3ExpRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static CardR3ExpRaw GetRootAsCardR3ExpRaw(ByteBuffer _bb) { }

	public static CardR3ExpRaw GetRootAsCardR3ExpRaw(ByteBuffer _bb, CardR3ExpRaw obj) { }

}

