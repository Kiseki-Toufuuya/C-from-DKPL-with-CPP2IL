namespace D4L.TakashoFes.Master;

public sealed class ImageHelpEntry : IFlatbuffersDaoEntry<Int64>
{
	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <DataVersion>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Enable>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <GroupID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <ImageID>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <AppearanceID>k__BackingField; //Field offset: 0x20

	public int AppearanceID
	{
		[CompilerGenerated]
		 set { } //Length: 14
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

	public int GroupID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public long ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int ImageID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public ImageHelpEntry() { }

	public static ImageHelpEntry Create(ImageHelpRawEntry source) { }

	[CompilerGenerated]
	public void set_AppearanceID(int value) { }

	[CompilerGenerated]
	public void set_DataVersion(int value) { }

	[CompilerGenerated]
	public void set_Enable(int value) { }

	[CompilerGenerated]
	public void set_GroupID(int value) { }

	[CompilerGenerated]
	public void set_ID(long value) { }

	[CompilerGenerated]
	public void set_ImageID(int value) { }

}

