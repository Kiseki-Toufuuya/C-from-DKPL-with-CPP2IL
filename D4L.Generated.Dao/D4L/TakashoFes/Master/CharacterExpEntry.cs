namespace D4L.TakashoFes.Master;

public sealed class CharacterExpEntry : IFlatbuffersDaoEntry<GuardInt>
{
	[CompilerGenerated]
	private GuardInt <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <Exp>k__BackingField; //Field offset: 0x10

	public GuardInt Exp
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public CharacterExpEntry() { }

	public static CharacterExpEntry Create(CharacterExpRawEntry source) { }

	[CompilerGenerated]
	public void set_Exp(GuardInt value) { }

	[CompilerGenerated]
	public void set_ID(GuardInt value) { }

}

