namespace D4L.TakashoFes.Master;

public struct MusicScoreRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public MusicScoreRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<MusicScoreRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static MusicScoreRaw GetRootAsMusicScoreRaw(ByteBuffer _bb) { }

	public static MusicScoreRaw GetRootAsMusicScoreRaw(ByteBuffer _bb, MusicScoreRaw obj) { }

}

