namespace D4L.TakashoFes.Master;

public struct EpisodeRewardRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public EpisodeRewardRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<EpisodeRewardRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static EpisodeRewardRaw GetRootAsEpisodeRewardRaw(ByteBuffer _bb) { }

	public static EpisodeRewardRaw GetRootAsEpisodeRewardRaw(ByteBuffer _bb, EpisodeRewardRaw obj) { }

}

