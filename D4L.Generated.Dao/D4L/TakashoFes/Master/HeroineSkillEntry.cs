namespace D4L.TakashoFes.Master;

public sealed class HeroineSkillEntry : IFlatbuffersDaoEntry<GuardInt>
{
	[CompilerGenerated]
	private GuardInt <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <Description>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardInt <Value>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private GuardInt <Weight>k__BackingField; //Field offset: 0x1C

	public string Description
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public GuardInt ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt Value
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt Weight
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public HeroineSkillEntry() { }

	public static HeroineSkillEntry Create(HeroineSkillRawEntry source) { }

	[CompilerGenerated]
	public void set_Description(string value) { }

	[CompilerGenerated]
	public void set_ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_Value(GuardInt value) { }

	[CompilerGenerated]
	public void set_Weight(GuardInt value) { }

}

