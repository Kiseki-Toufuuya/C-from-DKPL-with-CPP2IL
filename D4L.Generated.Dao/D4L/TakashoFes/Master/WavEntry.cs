namespace D4L.TakashoFes.Master;

public sealed class WavEntry : IFlatbuffersDaoEntry<GuardInt>
{
	[CompilerGenerated]
	private GuardInt <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <Enable>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <DataVersion>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private GuardLong <CuesheetID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private GuardLong <DecKey>k__BackingField; //Field offset: 0x28

	public GuardLong CuesheetID
	{
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public int DataVersion
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardLong DecKey
	{
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public int Enable
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardInt ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public WavEntry() { }

	public static WavEntry Create(WavRawEntry source) { }

	[CompilerGenerated]
	public void set_CuesheetID(GuardLong value) { }

	[CompilerGenerated]
	public void set_DataVersion(int value) { }

	[CompilerGenerated]
	public void set_DecKey(GuardLong value) { }

	[CompilerGenerated]
	public void set_Enable(int value) { }

	[CompilerGenerated]
	public void set_ID(GuardInt value) { }

}

