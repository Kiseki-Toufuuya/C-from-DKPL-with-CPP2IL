namespace D4L.TakashoFes.Master;

public struct MessageMapRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public MessageMapRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<MessageMapRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static MessageMapRaw GetRootAsMessageMapRaw(ByteBuffer _bb) { }

	public static MessageMapRaw GetRootAsMessageMapRaw(ByteBuffer _bb, MessageMapRaw obj) { }

}

