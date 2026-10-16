namespace D4L.TakashoFes.Master;

public sealed class EpisodeLivePresetEntry : IFlatbuffersDaoEntry<GuardInt>
{
	[CompilerGenerated]
	private GuardInt <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <MusicID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardInt <Difficulty>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Int32[] <HeroineIDs>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Int32[] <CharacterLvs>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private Int32[] <CardIDs>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Int32[] <CardLvs>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private GuardInt <ReturnEpisodeID>k__BackingField; //Field offset: 0x30

	public Int32[] CardIDs
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Int32[] CardLvs
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Int32[] CharacterLvs
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public GuardInt Difficulty
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Int32[] HeroineIDs
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public GuardInt ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt MusicID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ReturnEpisodeID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public EpisodeLivePresetEntry() { }

	public static EpisodeLivePresetEntry Create(EpisodeLivePresetRawEntry source) { }

	[CompilerGenerated]
	public Int32[] get_CardIDs() { }

	[CompilerGenerated]
	public Int32[] get_CardLvs() { }

	[CompilerGenerated]
	public Int32[] get_CharacterLvs() { }

	[CompilerGenerated]
	public Int32[] get_HeroineIDs() { }

	[CompilerGenerated]
	public void set_CardIDs(Int32[] value) { }

	[CompilerGenerated]
	public void set_CardLvs(Int32[] value) { }

	[CompilerGenerated]
	public void set_CharacterLvs(Int32[] value) { }

	[CompilerGenerated]
	public void set_Difficulty(GuardInt value) { }

	[CompilerGenerated]
	public void set_HeroineIDs(Int32[] value) { }

	[CompilerGenerated]
	public void set_ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_MusicID(GuardInt value) { }

	[CompilerGenerated]
	public void set_ReturnEpisodeID(GuardInt value) { }

}

