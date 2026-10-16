namespace D4L.TakashoFes.Master;

public sealed class MusicProductEntry : IFlatbuffersDaoEntry<Int32>
{
	[CompilerGenerated]
	private int <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <PurchaseType>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private GuardInt <ConsumeItemPrefix>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private GuardInt <ConsumeItemValue>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private GuardInt <Price>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private GuardLong <OpenAt>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GuardLong <CloseAt>k__BackingField; //Field offset: 0x40

	public GuardLong CloseAt
	{
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardInt ConsumeItemPrefix
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ConsumeItemValue
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int ID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardLong OpenAt
	{
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardInt Price
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt PurchaseType
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public MusicProductEntry() { }

	public static MusicProductEntry Create(MusicProductRawEntry source) { }

	[CompilerGenerated]
	public void set_CloseAt(GuardLong value) { }

	[CompilerGenerated]
	public void set_ConsumeItemPrefix(GuardInt value) { }

	[CompilerGenerated]
	public void set_ConsumeItemValue(GuardInt value) { }

	[CompilerGenerated]
	public void set_ID(int value) { }

	[CompilerGenerated]
	public void set_OpenAt(GuardLong value) { }

	[CompilerGenerated]
	public void set_Price(GuardInt value) { }

	[CompilerGenerated]
	public void set_PurchaseType(GuardInt value) { }

}

