namespace XeApp.Game.Net;

public class BatchInstaller : IDisposable
{
	public class InstallContext
	{
		public StatusInfo StatusInfo; //Field offset: 0x8
		public InstallFileInfo FileInfo; //Field offset: 0x28
		public bool ErrorLogged; //Field offset: 0x2C
		public float TimeoutTimer; //Field offset: 0x30
		public long PrevByte; //Field offset: 0x38
		public int LogHandle; //Field offset: 0x40

		public InstallContext() { }

	}

	internal class InstallFileInfo
	{
		[CompilerGenerated]
		private AssetPathEntry <PathEntry>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private double <Processing>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private bool <IsFinished>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private bool <IsRunning>k__BackingField; //Field offset: 0x19
		[CompilerGenerated]
		private int <Index>k__BackingField; //Field offset: 0x1C

		public int Index
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public bool IsFinished
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public bool IsRunning
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public AssetPathEntry PathEntry
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public double Processing
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 18
		}

		public InstallFileInfo() { }

		[CompilerGenerated]
		public int get_Index() { }

		[CompilerGenerated]
		public bool get_IsFinished() { }

		[CompilerGenerated]
		public bool get_IsRunning() { }

		[CompilerGenerated]
		public AssetPathEntry get_PathEntry() { }

		[CompilerGenerated]
		public double get_Processing() { }

		[CompilerGenerated]
		public void set_Index(int value) { }

		[CompilerGenerated]
		public void set_IsFinished(bool value) { }

		[CompilerGenerated]
		public void set_IsRunning(bool value) { }

		[CompilerGenerated]
		public void set_PathEntry(AssetPathEntry value) { }

		[CompilerGenerated]
		public void set_Processing(double value) { }

	}

	internal enum LogType
	{
		Detail = 0,
		File = 1,
		Error = 2,
	}

	internal enum Status
	{
		Stop = 0,
		Busy = 1,
		Complete = 2,
		ErrorOccured = 3,
		ErrorStopped = 4,
		StopProcessing = 5,
	}

	public const int INSTALLER_NUM = 4; //Field offset: 0x0
	public static int CRI_TIMEOUT_SEC; //Field offset: 0x0
	public static float APP_TIMEOUT_FRAME; //Field offset: 0x4
	public static bool IsForceDLError; //Field offset: 0x8
	private static bool IsInitModule; //Field offset: 0x9
	private static List<CriFsWebInstaller> AbandomentInstallers; //Field offset: 0xC
	[CompilerGenerated]
	private Status <LoadStatus>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private bool <IsStorageError>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private List<InstallFileInfo> <InstallFiles>k__BackingField; //Field offset: 0x10
	private Queue<CriFsWebInstaller> IdleInstallers; //Field offset: 0x14
	private List<CriFsWebInstaller> BusyInstallers; //Field offset: 0x18
	private InstallContext[] InstallContexts; //Field offset: 0x1C
	private Dictionary<CriFsWebInstaller, InstallContext> InstallerToContext; //Field offset: 0x20
	private bool IsDisposed; //Field offset: 0x24
	private bool IsSendExeption; //Field offset: 0x25
	private int StopProcessFrameCount; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsFewStorageError>k__BackingField; //Field offset: 0x2C

	public List<InstallFileInfo> InstallFiles
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool IsFewStorageError
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsStorageError
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Status LoadStatus
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	private static BatchInstaller() { }

	public BatchInstaller(int installConcurrency = 4) { }

	private void ConsumeInstallQueue() { }

	[Conditional("GAME_DEBUG")]
	private void DebugEvent(LogType logType, Func<String> a) { }

	private void Dispose(bool disposing) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public static void FinalModule() { }

	private int FindNextLoadIndex() { }

	[CompilerGenerated]
	public List<InstallFileInfo> get_InstallFiles() { }

	[CompilerGenerated]
	public bool get_IsFewStorageError() { }

	[CompilerGenerated]
	public bool get_IsStorageError() { }

	[CompilerGenerated]
	public Status get_LoadStatus() { }

	public float GetProcessing() { }

	private int GetRestInstallCount() { }

	public static void InitModule() { }

	public bool IsAppTimeout() { }

	public bool IsLoading(AssetPathEntry assetPathEntry) { }

	private void OnBatchInstallError(InstallContext context) { }

	public void RequestStop() { }

	public void ResetFewStorageError() { }

	[CompilerGenerated]
	public void set_InstallFiles(List<InstallFileInfo> value) { }

	[CompilerGenerated]
	public void set_IsFewStorageError(bool value) { }

	[CompilerGenerated]
	public void set_IsStorageError(bool value) { }

	[CompilerGenerated]
	public void set_LoadStatus(Status value) { }

	public void Setup(List<AssetPathEntry> assetPathEntries) { }

	public void Start() { }

	public void Update() { }

	private int UpdateBusyInstallers() { }

	private void WatchDogStorage() { }

	private void WriteDownloadFileInfo(InstallContext context) { }

}

