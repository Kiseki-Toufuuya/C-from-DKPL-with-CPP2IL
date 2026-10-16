namespace D4L.TakashoFes.Master;

public struct EpisodeRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public EpisodeRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<EpisodeRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static EpisodeRaw GetRootAsEpisodeRaw(ByteBuffer _bb) { }

	public static EpisodeRaw GetRootAsEpisodeRaw(ByteBuffer _bb, EpisodeRaw obj) { }

}

