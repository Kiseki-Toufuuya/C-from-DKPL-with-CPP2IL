namespace D4L.TakashoFes.Master;

public struct HeroineGrowthRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public HeroineGrowthRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<HeroineGrowthRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static HeroineGrowthRaw GetRootAsHeroineGrowthRaw(ByteBuffer _bb) { }

	public static HeroineGrowthRaw GetRootAsHeroineGrowthRaw(ByteBuffer _bb, HeroineGrowthRaw obj) { }

}

