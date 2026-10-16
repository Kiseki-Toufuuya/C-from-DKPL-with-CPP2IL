namespace D4L.TakashoFes.Master;

public sealed class PKVSEntry : IFlatbuffersDaoEntry<Int32>
{
	[CompilerGenerated]
	private int <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <DataVersion>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private int <Enable>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Label>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <ImageId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <OpenAt>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private long <CloseAt>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <PKVSType>k__BackingField; //Field offset: 0x30

	public long CloseAt
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int DataVersion
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int Enable
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int ID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int ImageId
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string Label
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public long OpenAt
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int PKVSType
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public PKVSEntry() { }

	public static PKVSEntry Create(PKVSRawEntry source) { }

	[CompilerGenerated]
	public void set_CloseAt(long value) { }

	[CompilerGenerated]
	public void set_DataVersion(int value) { }

	[CompilerGenerated]
	public void set_Enable(int value) { }

	[CompilerGenerated]
	public void set_ID(int value) { }

	[CompilerGenerated]
	public void set_ImageId(int value) { }

	[CompilerGenerated]
	public void set_Label(string value) { }

	[CompilerGenerated]
	public void set_OpenAt(long value) { }

	[CompilerGenerated]
	public void set_PKVSType(int value) { }

}

