namespace D4L.TakashoFes.Master;

public struct WavRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public WavRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<WavRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static WavRaw GetRootAsWavRaw(ByteBuffer _bb) { }

	public static WavRaw GetRootAsWavRaw(ByteBuffer _bb, WavRaw obj) { }

}

