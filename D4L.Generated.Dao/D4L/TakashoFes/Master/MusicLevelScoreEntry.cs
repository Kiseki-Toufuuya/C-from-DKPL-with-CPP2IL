namespace D4L.TakashoFes.Master;

public sealed class MusicLevelScoreEntry : IFlatbuffersDaoEntry<Int32>
{
	[CompilerGenerated]
	private int <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <BaseValue>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private GuardFloat <ScoreRankFactor>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private GuardFloat <MoneyFactor>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private GuardFloat <ExpFactor>k__BackingField; //Field offset: 0x24

	public GuardInt BaseValue
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardFloat ExpFactor
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int ID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardFloat MoneyFactor
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardFloat ScoreRankFactor
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public MusicLevelScoreEntry() { }

	public static MusicLevelScoreEntry Create(MusicLevelScoreRawEntry source) { }

	[CompilerGenerated]
	public void set_BaseValue(GuardInt value) { }

	[CompilerGenerated]
	public void set_ExpFactor(GuardFloat value) { }

	[CompilerGenerated]
	public void set_ID(int value) { }

	[CompilerGenerated]
	public void set_MoneyFactor(GuardFloat value) { }

	[CompilerGenerated]
	public void set_ScoreRankFactor(GuardFloat value) { }

}

