namespace D4L.TakashoFes.Master;

public struct ErrorMessageRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public ErrorMessageRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<ErrorMessageRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static ErrorMessageRaw GetRootAsErrorMessageRaw(ByteBuffer _bb) { }

	public static ErrorMessageRaw GetRootAsErrorMessageRaw(ByteBuffer _bb, ErrorMessageRaw obj) { }

}

