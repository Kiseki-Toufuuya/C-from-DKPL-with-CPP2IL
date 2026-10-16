namespace XeApp.Game.Net;

public class AssetPathProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<UIResult> <>9__66_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <DownloadTarFileV2>b__66_0(UIResult r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public Action onFinish; //Field offset: 0x8

		public <>c__DisplayClass55_0() { }

		internal void <InitializeBoot>b__0(object x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public AssetPathProvider <>4__this; //Field offset: 0x8
		public string url; //Field offset: 0xC

		public <>c__DisplayClass65_0() { }

		internal Task<Byte[]> <DownloadTarFile>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_0
	{
		public AssetPathProvider <>4__this; //Field offset: 0x8
		public string url; //Field offset: 0xC

		public <>c__DisplayClass66_0() { }

		internal Task<Byte[]> <DownloadTarFileV2>b__1() { }

	}

	[CompilerGenerated]
	private struct <DownloadTarFile>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TarFile> <>t__builder; //Field offset: 0x4
		public AssetPathProvider <>4__this; //Field offset: 0x10
		public CategoryID categoryID; //Field offset: 0x14
		private FileListInfo <fileList>5__2; //Field offset: 0x18
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadTarFileV2>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TarFile> <>t__builder; //Field offset: 0x4
		public AssetPathProvider <>4__this; //Field offset: 0x10
		public string arg; //Field offset: 0x14
		public CategoryID categoryID; //Field offset: 0x18
		private FileListInfo <file>5__2; //Field offset: 0x1C
		private AppCustomErrorInfo <err>5__3; //Field offset: 0x20
		private TaskAwaiter<UIResult> <>u__1; //Field offset: 0x24
		private TaskAwaiter <>u__2; //Field offset: 0x28
		private TaskAwaiter<Byte[]> <>u__3; //Field offset: 0x2C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFile>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x4
		public string url; //Field offset: 0x10
		private UnityWebRequest <req>5__2; //Field offset: 0x14
		private object <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeBoot>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Action onFinish; //Field offset: 0x10
		public AssetPathProvider <>4__this; //Field offset: 0x14
		private <>c__DisplayClass55_0 <>8__1; //Field offset: 0x18
		private TaskAwaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeLoad>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public AssetPathProvider <>4__this; //Field offset: 0x10
		public CategoryID categoryId; //Field offset: 0x14
		private TaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeLoadV2>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public AssetPathProvider <>4__this; //Field offset: 0x10
		public CategoryID categoryId; //Field offset: 0x14
		private TaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Load>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public AssetPathProvider <>4__this; //Field offset: 0x10
		public CategoryID categoryId; //Field offset: 0x14
		private TaskAwaiter<TarFile> <>u__1; //Field offset: 0x18
		private TaskAwaiter <>u__2; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadFromLocalStorage>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public CategoryID categoryId; //Field offset: 0x10
		public AssetPathProvider <>4__this; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadV2>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public AssetPathProvider <>4__this; //Field offset: 0x10
		public CategoryID categoryId; //Field offset: 0x14
		public string arg; //Field offset: 0x18
		private TaskAwaiter<TarFile> <>u__1; //Field offset: 0x1C
		private TaskAwaiter <>u__2; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum AssetDownloadTimingID
	{
		AssetDownloadTimingID_Tutorial = 1,
		AssetDownloadTimingID_Main = 2,
		AssetDownloadTimingID_Delay = 3,
		AssetDownloadTimingID_DelayBootDelete = 4,
		AssetDownloadTimingID_DelayMonthDelete = 5,
		AssetDownloadTimingID_MainAndroidOnly = 6,
		AssetDownloadTimingID_MainiOSOnly = 7,
	}

	internal enum CategoryID
	{
		None = 0,
		DB = 1,
		Common = 2,
		Platform = 3,
		TitleCommon = 4,
		TitlePlatform = 5,
	}

	internal static class DownloadOption
	{
		public const int XAB_SALT_MASK = 4095; //Field offset: 0x0
		public const int DOWNLOAD_TIMINGM_MASK = 2130706432; //Field offset: 0x0
		public const int TITLE_ASSET = 1048576; //Field offset: 0x0

	}

	internal class TitleBGInfo
	{
		public string BgID; //Field offset: 0x8
		public string LogoMovieID; //Field offset: 0xC
		public int SysBgmID; //Field offset: 0x10
		public long CloseAt; //Field offset: 0x18

		public TitleBGInfo() { }

	}

	[CompilerGenerated]
	private static AssetPathProvider <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static string <CDNServerHostBase>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static string <AssetRootHash>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static string <GameID>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private static string <UpdloadID>k__BackingField; //Field offset: 0x10
	private static readonly String[] CategoryLabel; //Field offset: 0x14
	private static readonly string DataRoot; //Field offset: 0x18
	private static readonly String[] CategoryRoot; //Field offset: 0x1C
	[CompilerGenerated]
	private static string <ClientInstallTargetPath>k__BackingField; //Field offset: 0x20
	private static readonly String[] TitleAssetPath; //Field offset: 0x24
	private static readonly String[] TitleBgmPath; //Field offset: 0x28
	[CompilerGenerated]
	private AssetPathContext <DBAssetPathContext>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private AssetPathContext <CommonAssetPathContext>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private AssetPathContext <PlatformAssetPathContext>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private AssetPathContext <TitleCommonAssetPathContext>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private AssetPathContext <TitlePlatformAssetPathContext>k__BackingField; //Field offset: 0x18
	private StringBuilder bulder; //Field offset: 0x1C
	private LocalSaveData<AssetPathSaveData> LocalSave; //Field offset: 0x20
	private Dictionary<String, Boolean> KeepFile; //Field offset: 0x24

	public static string AssetRootHash
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		 set { } //Length: 89
	}

	public static string CDNServerHostBase
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		 set { } //Length: 89
	}

	public private static string ClientInstallTargetPath
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		private set { } //Length: 89
	}

	public private AssetPathContext CommonAssetPathContext
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private AssetPathContext DBAssetPathContext
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public static string GameID
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		 set { } //Length: 89
	}

	public private static AssetPathProvider Instance
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public private AssetPathContext PlatformAssetPathContext
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private AssetPathContext TitleCommonAssetPathContext
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private AssetPathContext TitlePlatformAssetPathContext
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public static string UpdloadID
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		 set { } //Length: 89
	}

	private static AssetPathProvider() { }

	public AssetPathProvider() { }

	private string BuildFileListDownloadUrl(FileListInfo info) { }

	public string BuildFileListStoragePath(FileListInfo info) { }

	public long CalcDownloadSize(string assetPathWithoutPlatformName, CategoryID categoryID) { }

	private string Digest(Byte[] b) { }

	[AsyncStateMachine(typeof(<DownloadTarFile>d__65))]
	private Task<TarFile> DownloadTarFile(CategoryID categoryID) { }

	[AsyncStateMachine(typeof(<DownloadTarFileV2>d__66))]
	private Task<TarFile> DownloadTarFileV2(CategoryID categoryID, string arg) { }

	private FileListInfo FindFileList(CategoryID categoryID) { }

	[CompilerGenerated]
	public static string get_AssetRootHash() { }

	[CompilerGenerated]
	public static string get_CDNServerHostBase() { }

	[CompilerGenerated]
	public static string get_ClientInstallTargetPath() { }

	[CompilerGenerated]
	public AssetPathContext get_CommonAssetPathContext() { }

	[CompilerGenerated]
	public AssetPathContext get_DBAssetPathContext() { }

	[CompilerGenerated]
	public static string get_GameID() { }

	[CompilerGenerated]
	public static AssetPathProvider get_Instance() { }

	[CompilerGenerated]
	public AssetPathContext get_PlatformAssetPathContext() { }

	[CompilerGenerated]
	public AssetPathContext get_TitleCommonAssetPathContext() { }

	[CompilerGenerated]
	public AssetPathContext get_TitlePlatformAssetPathContext() { }

	[CompilerGenerated]
	public static string get_UpdloadID() { }

	public AssetPathEntry GetAssetPathEntry(string assetPathWithPlatform, CategoryID categoryID = 0) { }

	public AssetPathContext GetContext(CategoryID categoryID) { }

	public string GetDownloadURL(AssetPathEntry assetPathEntry) { }

	[AsyncStateMachine(typeof(<GetFile>d__62))]
	private Task<Byte[]> GetFile(string url) { }

	public string GetLocalHashedPath(AssetPathEntry assetPathEntry) { }

	public AssetPathEntry GetPlatformAssetPathEntry(string assetPathWithoutPlatformName, CategoryID categoryID) { }

	public string GetServerDataRawRootPath(CategoryID categoryID) { }

	public List<String> GetTitleBGIds() { }

	public List<TitleBGInfo> GetTitleBGInfos() { }

	public void Initialize(CategoryID categoryId) { }

	[AsyncStateMachine(typeof(<InitializeBoot>d__55))]
	public Task InitializeBoot(Action onFinish) { }

	[AsyncStateMachine(typeof(<InitializeLoad>d__57))]
	public Task InitializeLoad(CategoryID categoryId) { }

	[AsyncStateMachine(typeof(<InitializeLoadV2>d__58))]
	public Task InitializeLoadV2(CategoryID categoryId) { }

	public bool IsContainAssetPathList(string fullPath) { }

	[AsyncStateMachine(typeof(<Load>d__59))]
	private Task Load(CategoryID categoryId) { }

	[AsyncStateMachine(typeof(<LoadFromLocalStorage>d__61))]
	public Task LoadFromLocalStorage(CategoryID categoryId) { }

	[AsyncStateMachine(typeof(<LoadV2>d__60))]
	private Task LoadV2(CategoryID categoryId, string arg) { }

	private void SaveFile(CategoryID categoryId, FileListInfo fileListInfo, Byte[] bytes) { }

	public void SaveTitleBGIds() { }

	[CompilerGenerated]
	public static void set_AssetRootHash(string value) { }

	[CompilerGenerated]
	public static void set_CDNServerHostBase(string value) { }

	[CompilerGenerated]
	private static void set_ClientInstallTargetPath(string value) { }

	[CompilerGenerated]
	private void set_CommonAssetPathContext(AssetPathContext value) { }

	[CompilerGenerated]
	private void set_DBAssetPathContext(AssetPathContext value) { }

	[CompilerGenerated]
	public static void set_GameID(string value) { }

	[CompilerGenerated]
	private static void set_Instance(AssetPathProvider value) { }

	[CompilerGenerated]
	private void set_PlatformAssetPathContext(AssetPathContext value) { }

	[CompilerGenerated]
	private void set_TitleCommonAssetPathContext(AssetPathContext value) { }

	[CompilerGenerated]
	private void set_TitlePlatformAssetPathContext(AssetPathContext value) { }

	[CompilerGenerated]
	public static void set_UpdloadID(string value) { }

	public bool ValidateLocalFile(AssetPathEntry entry) { }

	private bool ValidateSysBgm(int no) { }

	private bool ValidateTitleTextureAsset(string id) { }

}

