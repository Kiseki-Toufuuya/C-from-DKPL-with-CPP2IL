namespace D4L.TakashoFes.Master;

public sealed class DataVersionEntry : IFlatbuffersDaoEntry<Int64>
{
	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <DataVersion>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <OpenAt>k__BackingField; //Field offset: 0x18

	public int DataVersion
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public long ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long OpenAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public DataVersionEntry() { }

	public static DataVersionEntry Create(DataVersionRawEntry source) { }

	[CompilerGenerated]
	public int get_DataVersion() { }

	[CompilerGenerated]
	public long get_OpenAt() { }

	[CompilerGenerated]
	public void set_DataVersion(int value) { }

	[CompilerGenerated]
	public void set_ID(long value) { }

	[CompilerGenerated]
	public void set_OpenAt(long value) { }

}

