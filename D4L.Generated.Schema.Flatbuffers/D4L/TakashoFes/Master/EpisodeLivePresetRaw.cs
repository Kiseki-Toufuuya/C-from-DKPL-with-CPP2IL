namespace D4L.TakashoFes.Master;

public struct EpisodeLivePresetRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public EpisodeLivePresetRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<EpisodeLivePresetRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static EpisodeLivePresetRaw GetRootAsEpisodeLivePresetRaw(ByteBuffer _bb) { }

	public static EpisodeLivePresetRaw GetRootAsEpisodeLivePresetRaw(ByteBuffer _bb, EpisodeLivePresetRaw obj) { }

}

