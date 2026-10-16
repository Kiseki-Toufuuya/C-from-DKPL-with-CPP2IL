namespace D4L.TakashoFes.Master;

public sealed class AssetPathEntry : IFlatbuffersDaoEntry<Int64>
{
	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <AssetPath>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <HashedPath>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private string <FileHash>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <FileSize>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <FileRev>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <FileType>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <DownloadOption>k__BackingField; //Field offset: 0x28

	public string AssetPath
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int DownloadOption
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string FileHash
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int FileRev
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int FileSize
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int FileType
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string HashedPath
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public long ID
	{
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public AssetPathEntry() { }

	public static AssetPathEntry Create(AssetPathRawEntry source) { }

	[CompilerGenerated]
	public string get_AssetPath() { }

	[CompilerGenerated]
	public int get_DownloadOption() { }

	[CompilerGenerated]
	public string get_FileHash() { }

	[CompilerGenerated]
	public int get_FileSize() { }

	[CompilerGenerated]
	public int get_FileType() { }

	[CompilerGenerated]
	public string get_HashedPath() { }

	[CompilerGenerated]
	public void set_AssetPath(string value) { }

	[CompilerGenerated]
	public void set_DownloadOption(int value) { }

	[CompilerGenerated]
	public void set_FileHash(string value) { }

	[CompilerGenerated]
	public void set_FileRev(int value) { }

	[CompilerGenerated]
	public void set_FileSize(int value) { }

	[CompilerGenerated]
	public void set_FileType(int value) { }

	[CompilerGenerated]
	public void set_HashedPath(string value) { }

	[CompilerGenerated]
	public void set_ID(long value) { }

}

