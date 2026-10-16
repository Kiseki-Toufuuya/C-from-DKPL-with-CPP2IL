namespace XeApp.Game.Net;

public class GenericItemModel : EntityBase<GenericItemModel, Int64>
{
	[CompilerGenerated]
	private readonly long <ID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <ItemPrefix>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly int <ItemValue>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private readonly GuardInt <Value>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly int <SortOrder>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly int <Rarity>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private readonly GuardInt <HaveMax>k__BackingField; //Field offset: 0x38

	public string Description
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public GuardInt HaveMax
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public int ItemPrefix
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int ItemValue
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int Rarity
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int SortOrder
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public GuardInt Value
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public GenericItemModel(long id, int itemPrefix, int itemValue, string name, string description, int val, int sortOrder, int rarity, int haveMax) { }

	[CompilerGenerated]
	public string get_Description() { }

	[CompilerGenerated]
	public GuardInt get_HaveMax() { }

	[CompilerGenerated]
	public long get_ID() { }

	[CompilerGenerated]
	public int get_ItemPrefix() { }

	[CompilerGenerated]
	public int get_ItemValue() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public int get_Rarity() { }

	[CompilerGenerated]
	public int get_SortOrder() { }

	[CompilerGenerated]
	public GuardInt get_Value() { }

}

