namespace D4L.TakashoFes.Master;

public sealed class CharacterEntry : IFlatbuffersDaoEntry<GuardInt>
{
	[CompilerGenerated]
	private GuardInt <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <SortNo>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Enable>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <DataVersion>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private GuardInt <ImageID>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <NameYomi>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private string <ShortName>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <NameDispText>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private string <ActorName>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private GuardInt <ShotDamageInterval>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private bool <IsSpot>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private bool <IsEpisode>k__BackingField; //Field offset: 0x45
	[CompilerGenerated]
	private string <GachaMessage1>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private string <GachaMessage2>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private string <GachaMessage3>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private GuardInt <GrowthEmblem1ID>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private GuardInt <GrowthEmblem2ID>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private string <DefaultSkinName>k__BackingField; //Field offset: 0x64

	public string ActorName
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int DataVersion
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string DefaultSkinName
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int Enable
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string GachaMessage1
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string GachaMessage2
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string GachaMessage3
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public GuardInt GrowthEmblem1ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt GrowthEmblem2ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt ImageID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public bool IsEpisode
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsSpot
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string Name
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string NameDispText
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string NameYomi
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string ShortName
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public GuardInt ShotDamageInterval
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt SortNo
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public CharacterEntry() { }

	public static CharacterEntry Create(CharacterRawEntry source) { }

	[CompilerGenerated]
	public void set_ActorName(string value) { }

	[CompilerGenerated]
	public void set_DataVersion(int value) { }

	[CompilerGenerated]
	public void set_DefaultSkinName(string value) { }

	[CompilerGenerated]
	public void set_Enable(int value) { }

	[CompilerGenerated]
	public void set_GachaMessage1(string value) { }

	[CompilerGenerated]
	public void set_GachaMessage2(string value) { }

	[CompilerGenerated]
	public void set_GachaMessage3(string value) { }

	[CompilerGenerated]
	public void set_GrowthEmblem1ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_GrowthEmblem2ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_ID(GuardInt value) { }

	[CompilerGenerated]
	public void set_ImageID(GuardInt value) { }

	[CompilerGenerated]
	public void set_IsEpisode(bool value) { }

	[CompilerGenerated]
	public void set_IsSpot(bool value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_NameDispText(string value) { }

	[CompilerGenerated]
	public void set_NameYomi(string value) { }

	[CompilerGenerated]
	public void set_ShortName(string value) { }

	[CompilerGenerated]
	public void set_ShotDamageInterval(GuardInt value) { }

	[CompilerGenerated]
	public void set_SortNo(GuardInt value) { }

}

