namespace System.IO;

public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
{
	private WIN32_FILE_ATTRIBUTE_DATA _data; //Field offset: 0xC
	private int _dataInitialized; //Field offset: 0x30
	protected string FullPath; //Field offset: 0x34
	protected string OriginalPath; //Field offset: 0x38
	internal string _name; //Field offset: 0x3C

	public FileAttributes Attributes
	{
		 get { } //Length: 24
	}

	public override bool Exists
	{
		 get { } //Length: 233
	}

	internal bool ExistsCore
	{
		internal get { } //Length: 119
	}

	public override string FullName
	{
		 get { } //Length: 11
	}

	public DateTime LastWriteTime
	{
		 get { } //Length: 187
	}

	internal DateTimeOffset LastWriteTimeCore
	{
		internal get { } //Length: 50
	}

	public DateTime LastWriteTimeUtc
	{
		 get { } //Length: 118
	}

	internal long LengthCore
	{
		internal get { } //Length: 29
	}

	public override string Name
	{
		 get { } //Length: 11
	}

	protected FileSystemInfo() { }

	protected FileSystemInfo(SerializationInfo info, StreamingContext context) { }

	internal static FileSystemInfo Create(string fullPath, ref FileSystemEntry findData) { }

	private void EnsureDataInitialized() { }

	public FileAttributes get_Attributes() { }

	public override bool get_Exists() { }

	internal bool get_ExistsCore() { }

	public override string get_FullName() { }

	public DateTime get_LastWriteTime() { }

	internal DateTimeOffset get_LastWriteTimeCore() { }

	public DateTime get_LastWriteTimeUtc() { }

	internal long get_LengthCore() { }

	public override string get_Name() { }

	[ComVisible(False)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal void Init(FILE_FULL_DIR_INFORMATION* info) { }

	public void Refresh() { }

	public virtual string ToString() { }

}

