namespace D4L.TakashoFes.Master;

public struct MusicProductRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public MusicProductRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<MusicProductRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static MusicProductRaw GetRootAsMusicProductRaw(ByteBuffer _bb) { }

	public static MusicProductRaw GetRootAsMusicProductRaw(ByteBuffer _bb, MusicProductRaw obj) { }

}

