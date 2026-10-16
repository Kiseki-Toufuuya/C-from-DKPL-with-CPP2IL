namespace D4L.TakashoFes.Master;

public struct HeroineSkillRaw
{
	private Table __p; //Field offset: 0x0

	public int EntriesLength
	{
		 get { } //Length: 42
	}

	public HeroineSkillRaw __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public Nullable<HeroineSkillRawEntry> Entries(int j) { }

	public int get_EntriesLength() { }

	public static HeroineSkillRaw GetRootAsHeroineSkillRaw(ByteBuffer _bb) { }

	public static HeroineSkillRaw GetRootAsHeroineSkillRaw(ByteBuffer _bb, HeroineSkillRaw obj) { }

}

