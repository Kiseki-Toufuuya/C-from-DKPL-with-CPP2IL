namespace XeApp.Game.Net;

public class TakashoManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__50_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <OnAwake>b__50_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public Action onSuccess; //Field offset: 0x8

		public <>c__DisplayClass58_0() { }

		internal void <QuickStartAsync>b__0(object _) { }

		internal void <QuickStartAsync>b__1(object _) { }

	}

	[CompilerGenerated]
	private struct <QuickStartAsync>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Action onSuccess; //Field offset: 0x10
		public bool force; //Field offset: 0x14
		public TakashoManager <>4__this; //Field offset: 0x18
		private <>c__DisplayClass58_0 <>8__1; //Field offset: 0x1C
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const long SOLID_TIME_PERIOD = 1577804400; //Field offset: 0x0
	private const ushort DEFUALT_SOLID_WORKER_ID = 100; //Field offset: 0x0
	[CompilerGenerated]
	private static TakashoManager <Instance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private long <AppBootCount>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private SynchronizationContext <MainSynchronizationContext>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private UnixTime <CurrentUnixTime>k__BackingField; //Field offset: 0x18
	private ServerTimeSloidTimer ServerTimeSloidTimer; //Field offset: 0x20
	[CompilerGenerated]
	private SloidGenerator <SloidGenerator>k__BackingField; //Field offset: 0x24
	private EncryptorManager encryptorManager; //Field offset: 0x28
	private AssetRootUrlProvider assetRootUrlProvider; //Field offset: 0x2C
	private AssetPathProvider assetPathProvider; //Field offset: 0x30
	private AssetBundleProvider assetbundleProvider; //Field offset: 0x34
	private GameAssetInstaller gameAssetInstaller; //Field offset: 0x38
	private DelayInstaller delayInstaller; //Field offset: 0x3C
	private QueueJobManager fileLoadingQueue; //Field offset: 0x40
	private CriResourceProvider criResourceProvider; //Field offset: 0x44
	private RawFileProvider rawFileProvider; //Field offset: 0x48
	private ItemDatabase itemDatabase; //Field offset: 0x4C
	[CompilerGenerated]
	private WebAssetDownloader <WebAssetDownloader>k__BackingField; //Field offset: 0x50
	public GuardInt GameID; //Field offset: 0x54
	[CompilerGenerated]
	private readonly XorShift <RandomGenerator>k__BackingField; //Field offset: 0x5C
	public MultiLanguageParser MaintenanceMessageParser; //Field offset: 0x60
	[CompilerGenerated]
	private string <CurrentLauguage>k__BackingField; //Field offset: 0x64
	public GuardLong ServerCloseAt; //Field offset: 0x68
	private bool isProcessingQuickStart; //Field offset: 0x78
	private bool isQuickStartEnd; //Field offset: 0x79

	public private long AppBootCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public string CurrentLauguage
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private UnixTime CurrentUnixTime
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public QueueJobManager FileLoadingQueue
	{
		 get { } //Length: 11
	}

	public private static TakashoManager Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public private SynchronizationContext MainSynchronizationContext
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public XorShift RandomGenerator
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public private SloidGenerator SloidGenerator
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private WebAssetDownloader WebAssetDownloader
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public TakashoManager() { }

	[CompilerGenerated]
	public long get_AppBootCount() { }

	[CompilerGenerated]
	public string get_CurrentLauguage() { }

	[CompilerGenerated]
	public UnixTime get_CurrentUnixTime() { }

	public QueueJobManager get_FileLoadingQueue() { }

	[CompilerGenerated]
	public static TakashoManager get_Instance() { }

	[CompilerGenerated]
	public SynchronizationContext get_MainSynchronizationContext() { }

	[CompilerGenerated]
	public XorShift get_RandomGenerator() { }

	[CompilerGenerated]
	public SloidGenerator get_SloidGenerator() { }

	[CompilerGenerated]
	public WebAssetDownloader get_WebAssetDownloader() { }

	private void InitServerTime() { }

	private void InitTakashoDeviceContext() { }

	public bool IsServerClosed() { }

	public void OnAppPause(bool pause) { }

	public void OnAwake(MonoBehaviour m) { }

	public void OnDestory() { }

	public void OnUpdate(MonoBehaviour m) { }

	[AsyncStateMachine(typeof(<QuickStartAsync>d__58))]
	public Task QuickStartAsync(bool force, Action onSuccess = null) { }

	[CompilerGenerated]
	private void set_AppBootCount(long value) { }

	[CompilerGenerated]
	public void set_CurrentLauguage(string value) { }

	[CompilerGenerated]
	private void set_CurrentUnixTime(UnixTime value) { }

	[CompilerGenerated]
	private static void set_Instance(TakashoManager value) { }

	[CompilerGenerated]
	private void set_MainSynchronizationContext(SynchronizationContext value) { }

	[CompilerGenerated]
	private void set_SloidGenerator(SloidGenerator value) { }

	[CompilerGenerated]
	private void set_WebAssetDownloader(WebAssetDownloader value) { }

	public void TprEvent(string s) { }

	private void UpdateServetTime() { }

}

