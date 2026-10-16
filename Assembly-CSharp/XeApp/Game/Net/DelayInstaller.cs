namespace XeApp.Game.Net;

public class DelayInstaller
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public bool retry; //Field offset: 0x8

		public <>c__DisplayClass17_0() { }

		internal void <CoroutinInstall>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public AssetPathEntry entry; //Field offset: 0x8

		public <>c__DisplayClass18_0() { }

		internal bool <TryInstall>b__0(AssetPathEntry _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Action onRetry; //Field offset: 0x8

		public <>c__DisplayClass21_0() { }

		internal void <ShowRetryUI>b__0(ButtonType t) { }

		internal void <ShowRetryUI>b__1(ButtonType t) { }

	}

	[CompilerGenerated]
	private sealed class <CoroutinInstall>d__17 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public DelayInstaller <>4__this; //Field offset: 0x10
		private <>c__DisplayClass17_0 <>8__1; //Field offset: 0x14
		private TransitionLayer <dispLayer>5__2; //Field offset: 0x18

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
		public <CoroutinInstall>d__17(int <>1__state) { }

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
	private static DelayInstaller <Instance>k__BackingField; //Field offset: 0x0
	private Action Updater; //Field offset: 0x8
	private List<AssetPathEntry> Requests; //Field offset: 0xC
	private float LastAddTime; //Field offset: 0x10
	private float AutoWaitTime; //Field offset: 0x14
	public bool IsInstallRunning; //Field offset: 0x18
	private BatchInstaller BatchInstaller; //Field offset: 0x1C
	public float ProcessingPercent; //Field offset: 0x20

	public private static DelayInstaller Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public bool IsAnyDownloading
	{
		 get { } //Length: 66
	}

	public DelayInstaller() { }

	[IteratorStateMachine(typeof(<CoroutinInstall>d__17))]
	private IEnumerator CoroutinInstall() { }

	[CompilerGenerated]
	public static DelayInstaller get_Instance() { }

	public bool get_IsAnyDownloading() { }

	public void OnUpdate() { }

	[CompilerGenerated]
	private static void set_Instance(DelayInstaller value) { }

	private void ShowRetryUI(Action onRetry) { }

	public bool TryInstall(AssetPathEntry entry) { }

	public bool TryInstallCommon(string pathWithoutPlatform) { }

	public bool TryInstallPlatform(string pathWithoutPlatform) { }

	private void UpdateIdle() { }

	private void UpdateInstall() { }

}

