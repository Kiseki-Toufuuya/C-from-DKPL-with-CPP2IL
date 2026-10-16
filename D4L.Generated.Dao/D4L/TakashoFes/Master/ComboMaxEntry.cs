namespace D4L.TakashoFes.Master;

public sealed class ComboMaxEntry : IFlatbuffersDaoEntry<Int32>
{
	[CompilerGenerated]
	private int <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <Count>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private GuardInt <TotalAttack>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private GuardInt <DapSec>k__BackingField; //Field offset: 0x1C

	public GuardInt Count
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt DapSec
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int ID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardInt TotalAttack
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public ComboMaxEntry() { }

	public static ComboMaxEntry Create(ComboMaxRawEntry source) { }

	[CompilerGenerated]
	public void set_Count(GuardInt value) { }

	[CompilerGenerated]
	public void set_DapSec(GuardInt value) { }

	[CompilerGenerated]
	public void set_ID(int value) { }

	[CompilerGenerated]
	public void set_TotalAttack(GuardInt value) { }

}

