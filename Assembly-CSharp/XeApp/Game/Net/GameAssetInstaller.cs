namespace XeApp.Game.Net;

public class GameAssetInstaller : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public Action onSuccess; //Field offset: 0x8
		public Action onErrorToTilte; //Field offset: 0xC

		public <>c__DisplayClass12_0() { }

		internal void <PrepareAsync>b__0(object _) { }

		internal void <PrepareAsync>b__1(object _) { }

		internal void <PrepareAsync>b__2(object _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Action onSuccess; //Field offset: 0x8

		public <>c__DisplayClass13_0() { }

		internal void <PrepareAsyncForSettingAlldownload>b__0(object _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public bool retry; //Field offset: 0x8
		public bool backToTitle; //Field offset: 0x9
		public Action onErrorToTitle; //Field offset: 0xC
		public Action onSuccess; //Field offset: 0x10
		public Action <>9__4; //Field offset: 0x14
		public Action <>9__5; //Field offset: 0x18
		public SendOrPostCallback <>9__6; //Field offset: 0x1C

		public <>c__DisplayClass15_0() { }

		internal void <Co_Download>b__0() { }

		internal void <Co_Download>b__1() { }

		internal void <Co_Download>b__2(object _) { }

		internal void <Co_Download>b__3(int clearCount) { }

		internal void <Co_Download>b__4() { }

		internal void <Co_Download>b__5() { }

		internal void <Co_Download>b__6(object _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Action onErrorToTitle; //Field offset: 0x8
		public Action onRetry; //Field offset: 0xC

		public <>c__DisplayClass16_0() { }

		internal void <ShowRetryUI>b__0(ButtonType t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public GameAssetInstaller <>4__this; //Field offset: 0x8
		public InstallMode mode; //Field offset: 0xC
		public AssetPathProvider assetPathProvider; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal void <GetInstalledFiles>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <Co_Download>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Action onErrorToTitle; //Field offset: 0x10
		public Action onSuccess; //Field offset: 0x14
		public GameAssetInstaller <>4__this; //Field offset: 0x18
		private <>c__DisplayClass15_0 <>8__1; //Field offset: 0x1C

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <Co_Download>d__15(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <GetInstalledFiles>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ReturnCode> <>t__builder; //Field offset: 0x4
		public GameAssetInstaller <>4__this; //Field offset: 0x10
		public InstallMode mode; //Field offset: 0x14
		private TaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PrepareAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ReturnCode> <>t__builder; //Field offset: 0x4
		public Action onSuccess; //Field offset: 0x10
		public Action onErrorToTilte; //Field offset: 0x14
		public GameAssetInstaller <>4__this; //Field offset: 0x18
		public InstallMode mode; //Field offset: 0x1C
		private TaskAwaiter<ReturnCode> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PrepareAsyncForSettingAlldownload>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ReturnCode> <>t__builder; //Field offset: 0x4
		public Action onSuccess; //Field offset: 0x10
		public GameAssetInstaller <>4__this; //Field offset: 0x14
		private <>c__DisplayClass13_0 <>8__1; //Field offset: 0x18
		private TaskAwaiter<ReturnCode> <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateAssetPathProvider>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ReturnCode> <>t__builder; //Field offset: 0x4
		private AssetPathProvider <assetPathProvider>5__2; //Field offset: 0x10
		private TaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum InstallMode
	{
		None = 0,
		Tutorial = 1,
		Main = 2,
		All = 3,
	}

	internal enum ReturnCode
	{
		Success = 0,
		ErrorToTitle = 1,
	}

	public static bool ForceRetry; //Field offset: 0x0
	private const int SECTOR_SIZE = 4096; //Field offset: 0x0
	[CompilerGenerated]
	private static GameAssetInstaller <Instance>k__BackingField; //Field offset: 0x4
	private BatchInstaller batchInstaller; //Field offset: 0x8
	public float Progress; //Field offset: 0xC
	public long InstallFileSize; //Field offset: 0x10
	public List<AssetPathEntry> InstallFiles; //Field offset: 0x18
	private Dictionary<String, AssetPathEntry> installFileMap; //Field offset: 0x1C
	public Action<InstallMode> onAddInstallFiles; //Field offset: 0x20
	private bool disposedValue; //Field offset: 0x24

	public private static GameAssetInstaller Instance
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	public GameAssetInstaller() { }

	private string BuildTexturePath(string prefix, int imageId) { }

	[IteratorStateMachine(typeof(<Co_Download>d__15))]
	private IEnumerator Co_Download(Action onSuccess, Action onErrorToTitle) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public void Download(Action onSuccess, Action onErrorToTitle) { }

	[CompilerGenerated]
	public static GameAssetInstaller get_Instance() { }

	[AsyncStateMachine(typeof(<GetInstalledFiles>d__25))]
	private Task<ReturnCode> GetInstalledFiles(InstallMode mode) { }

	public float GetProcessing() { }

	private bool IsDownloadNow(InstallMode mode, AssetPathEntry assetPathEntry) { }

	private bool IsEndShowRetry() { }

	private void OnAddMusic(InstallMode mode) { }

	private void OnGacha(InstallMode mode) { }

	[AsyncStateMachine(typeof(<PrepareAsync>d__12))]
	public Task<ReturnCode> PrepareAsync(InstallMode mode, Action onSuccess, Action onErrorToTilte) { }

	[AsyncStateMachine(typeof(<PrepareAsyncForSettingAlldownload>d__13))]
	public Task<ReturnCode> PrepareAsyncForSettingAlldownload(Action onSuccess) { }

	private void RegisterDelegates() { }

	private static int RoundUpFileSize(int size) { }

	[CompilerGenerated]
	private static void set_Instance(GameAssetInstaller value) { }

	private void ShowRetryUI(Action onRetry, Action onErrorToTitle, bool isStorageError = false) { }

	public bool TryAddInstall(AssetPathEntry assetPathEntry, InstallMode mode) { }

	private void TryAddInstallTexture(string prefix, int imageId, InstallMode mode) { }

	[AsyncStateMachine(typeof(<UpdateAssetPathProvider>d__18))]
	private Task<ReturnCode> UpdateAssetPathProvider() { }

}

