namespace D4L.TakashoFes.Master;

public struct AssetPathRawEntry
{
	private Table __p; //Field offset: 0x0

	public string AssetPath
	{
		 get { } //Length: 48
	}

	public int DownloadOption
	{
		 get { } //Length: 60
	}

	public string FileHash
	{
		 get { } //Length: 48
	}

	public int FileRev
	{
		 get { } //Length: 60
	}

	public int FileSize
	{
		 get { } //Length: 60
	}

	public int FileType
	{
		 get { } //Length: 60
	}

	public string HashedPath
	{
		 get { } //Length: 48
	}

	public long ID
	{
		 get { } //Length: 62
	}

	public AssetPathRawEntry __assign(int _i, ByteBuffer _bb) { }

	public override void __init(int _i, ByteBuffer _bb) { }

	public string get_AssetPath() { }

	public int get_DownloadOption() { }

	public string get_FileHash() { }

	public int get_FileRev() { }

	public int get_FileSize() { }

	public int get_FileType() { }

	public string get_HashedPath() { }

	public long get_ID() { }

}

