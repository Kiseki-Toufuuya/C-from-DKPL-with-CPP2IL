namespace D4L.TakashoFes.Master;

public struct HeroineRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public HeroineRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<HeroineRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static HeroineRaw GetRootAsHeroineRaw(ByteBuffer _bb) { }

	public static HeroineRaw GetRootAsHeroineRaw(ByteBuffer _bb, HeroineRaw obj) { }

}

