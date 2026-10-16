namespace D4L.TakashoFes.Master;

public sealed class EpisodeRewardEntry : IFlatbuffersDaoEntry<GuardInt>
{
	[CompilerGenerated]
	private GuardInt <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <ItemID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardInt <ItemPrefix>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GuardInt <ItemCount>k__BackingField; //Field offset: 0x20

	public GuardInt ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ItemCount
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ItemID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ItemPrefix
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public EpisodeRewardEntry() { }

	public static EpisodeRewardEntry Create(EpisodeRewardRawEntry source) { }

	[CompilerGenerated]
	public void set_ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_ItemCount(GuardInt value) { }

	[CompilerGenerated]
	public void set_ItemID(GuardInt value) { }

	[CompilerGenerated]
	public void set_ItemPrefix(GuardInt value) { }

}

