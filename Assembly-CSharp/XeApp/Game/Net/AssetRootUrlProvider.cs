namespace XeApp.Game.Net;

public class AssetRootUrlProvider
{
	[CompilerGenerated]
	private struct <InitializeLoad>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public AssetRootUrlProvider <>4__this; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class AssetRoot
	{
		public string Client; //Field offset: 0x8
		public string Key; //Field offset: 0xC
		public long OpenAt; //Field offset: 0x10

		public AssetRoot() { }

	}

	internal class AssetRootList
	{
		public AssetRoot[] Roots; //Field offset: 0x8

		public AssetRootList() { }

	}

	internal class AssetUpload
	{
		public string Path; //Field offset: 0x8
		public long Date; //Field offset: 0x10
		public FileListInfo[] FileList; //Field offset: 0x18

		public AssetUpload() { }

	}

	internal class AssetUploadList
	{
		public AssetUpload[] Uploads; //Field offset: 0x8

		public AssetUploadList() { }

	}

	internal class FileListInfo
	{
		public string Platform; //Field offset: 0x8
		public int DataVersion; //Field offset: 0xC
		public int Enable; //Field offset: 0x10
		public string DB; //Field offset: 0x14
		public int Salt; //Field offset: 0x18
		public string HashPath; //Field offset: 0x1C
		public long OpenAt; //Field offset: 0x20

		public FileListInfo() { }

	}

	[CompilerGenerated]
	private static AssetRootUrlProvider <Instance>k__BackingField; //Field offset: 0x0
	private string RootKey; //Field offset: 0x8
	[CompilerGenerated]
	private FileListInfo[] <FileList>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private GuardString <CurrentUploadPath>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardString <AssetBaseUrl>k__BackingField; //Field offset: 0x18
	public List<Int64> DataVersionChangeDate; //Field offset: 0x20
	[CompilerGenerated]
	private GuardString <ArgDB>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private GuardString <ArgCommon>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private GuardString <ArgPlatform>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private GuardString <ArgTitleCommon>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private GuardString <ArgTitlePlatform>k__BackingField; //Field offset: 0x44
	private GuardInt m_version; //Field offset: 0x4C
	[CompilerGenerated]
	private GuardLong <NextDataVersionTime>k__BackingField; //Field offset: 0x58
	public bool IsInitRootKey; //Field offset: 0x68
	[CompilerGenerated]
	private bool <IsNeedUpdate>k__BackingField; //Field offset: 0x69
	public bool IsInitialized; //Field offset: 0x6A

	public GuardString ArgCommon
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 34
	}

	public GuardString ArgDB
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 34
	}

	public GuardString ArgPlatform
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 34
	}

	public GuardString ArgTitleCommon
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 34
	}

	public GuardString ArgTitlePlatform
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 34
	}

	public GuardString AssetBaseUrl
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 34
	}

	public int CurrentDataVersion
	{
		 get { } //Length: 6
		 set { } //Length: 76
	}

	public int CurrentEnable
	{
		 get { } //Length: 6
	}

	public private GuardString CurrentUploadPath
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 34
	}

	public private FileListInfo[] FileList
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private static AssetRootUrlProvider Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public private bool IsNeedUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public GuardLong NextDataVersionTime
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public AssetRootUrlProvider() { }

	public void ForceNeedUpdate() { }

	[CompilerGenerated]
	public GuardString get_ArgCommon() { }

	[CompilerGenerated]
	public GuardString get_ArgDB() { }

	[CompilerGenerated]
	public GuardString get_ArgPlatform() { }

	[CompilerGenerated]
	public GuardString get_ArgTitleCommon() { }

	[CompilerGenerated]
	public GuardString get_ArgTitlePlatform() { }

	[CompilerGenerated]
	public GuardString get_AssetBaseUrl() { }

	public int get_CurrentDataVersion() { }

	public int get_CurrentEnable() { }

	[CompilerGenerated]
	public GuardString get_CurrentUploadPath() { }

	[CompilerGenerated]
	public FileListInfo[] get_FileList() { }

	[CompilerGenerated]
	public static AssetRootUrlProvider get_Instance() { }

	[CompilerGenerated]
	public bool get_IsNeedUpdate() { }

	[CompilerGenerated]
	public GuardLong get_NextDataVersionTime() { }

	public void Initialize() { }

	[AsyncStateMachine(typeof(<InitializeLoad>d__63))]
	public Task InitializeLoad() { }

	public static bool IsAvaliableVersion(int contentDataVersion, int contentDataEnable) { }

	[CompilerGenerated]
	public void set_ArgCommon(GuardString value) { }

	[CompilerGenerated]
	public void set_ArgDB(GuardString value) { }

	[CompilerGenerated]
	public void set_ArgPlatform(GuardString value) { }

	[CompilerGenerated]
	public void set_ArgTitleCommon(GuardString value) { }

	[CompilerGenerated]
	public void set_ArgTitlePlatform(GuardString value) { }

	[CompilerGenerated]
	public void set_AssetBaseUrl(GuardString value) { }

	public void set_CurrentDataVersion(int value) { }

	[CompilerGenerated]
	private void set_CurrentUploadPath(GuardString value) { }

	[CompilerGenerated]
	private void set_FileList(FileListInfo[] value) { }

	[CompilerGenerated]
	private static void set_Instance(AssetRootUrlProvider value) { }

	[CompilerGenerated]
	private void set_IsNeedUpdate(bool value) { }

	[CompilerGenerated]
	public void set_NextDataVersionTime(GuardLong value) { }

}

