namespace D4L.TakashoFes.Master;

public struct MusicLevelScoreRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public MusicLevelScoreRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<MusicLevelScoreRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static MusicLevelScoreRaw GetRootAsMusicLevelScoreRaw(ByteBuffer _bb) { }

	public static MusicLevelScoreRaw GetRootAsMusicLevelScoreRaw(ByteBuffer _bb, MusicLevelScoreRaw obj) { }

}

