namespace D4L.TakashoFes.Master;

public struct MusicSelectionRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public MusicSelectionRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<MusicSelectionRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static MusicSelectionRaw GetRootAsMusicSelectionRaw(ByteBuffer _bb) { }

	public static MusicSelectionRaw GetRootAsMusicSelectionRaw(ByteBuffer _bb, MusicSelectionRaw obj) { }

}

