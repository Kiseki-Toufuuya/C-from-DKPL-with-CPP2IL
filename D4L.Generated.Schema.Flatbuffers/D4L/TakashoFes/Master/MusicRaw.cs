namespace D4L.TakashoFes.Master;

public struct MusicRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public MusicRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<MusicRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static MusicRaw GetRootAsMusicRaw(ByteBuffer _bb) { }

	public static MusicRaw GetRootAsMusicRaw(ByteBuffer _bb, MusicRaw obj) { }

}

