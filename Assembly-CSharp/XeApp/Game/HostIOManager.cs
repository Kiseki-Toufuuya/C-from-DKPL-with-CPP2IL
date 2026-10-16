namespace XeApp.Game;

public class HostIOManager
{
	public const int PORT = 50101; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private bool <IsLogEnabled>k__BackingField; //Field offset: 0x9
	[CompilerGenerated]
	private string <HostAddr>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private bool <IsMasterEnable>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsFumenEnable>k__BackingField; //Field offset: 0x11

	public string HostAddr
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool IsEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsFumenEnable
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsLogEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsMasterEnable
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public HostIOManager() { }

	[CompilerGenerated]
	public string get_HostAddr() { }

	[CompilerGenerated]
	public bool get_IsEnabled() { }

	[CompilerGenerated]
	public bool get_IsFumenEnable() { }

	[CompilerGenerated]
	public bool get_IsLogEnabled() { }

	[CompilerGenerated]
	public bool get_IsMasterEnable() { }

	public void Load() { }

	public void Save() { }

	[CompilerGenerated]
	public void set_HostAddr(string value) { }

	[CompilerGenerated]
	public void set_IsEnabled(bool value) { }

	[CompilerGenerated]
	public void set_IsFumenEnable(bool value) { }

	[CompilerGenerated]
	public void set_IsLogEnabled(bool value) { }

	[CompilerGenerated]
	public void set_IsMasterEnable(bool value) { }

	public String[] SimpleDirGetFiles(string path, string searchOption) { }

	public void SimpleFileAppend(string path, Byte[] dataBytes) { }

	public Byte[] SimpleFileRead(string path) { }

	public void SimpleFileWrite(string path, Byte[] dataBytes) { }

	public void SimpleFolderExtract(string hostPath, string deviceDir, string searchOption) { }

	public void SimpleLog(string dir, string log) { }

}

