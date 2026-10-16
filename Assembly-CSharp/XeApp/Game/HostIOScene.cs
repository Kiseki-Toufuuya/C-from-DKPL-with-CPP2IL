namespace XeApp.Game;

public class HostIOScene : MainSceneBase
{
	[CompilerGenerated]
	private sealed class <Co_Test>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public HostIOScene <>4__this; //Field offset: 0x10
		private StringBuilder <sb>5__2; //Field offset: 0x14

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
		public <Co_Test>d__13(int <>1__state) { }

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
	private sealed class <InstallBGM>d__15 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public HostIOManager host; //Field offset: 0x10
		public HostIOScene <>4__this; //Field offset: 0x14
		public string targetDir; //Field offset: 0x18
		private String[] <files>5__2; //Field offset: 0x1C
		private int <n>5__3; //Field offset: 0x20
		private String[] <>7__wrap3; //Field offset: 0x24
		private int <>7__wrap4; //Field offset: 0x28
		private string <file>5__6; //Field offset: 0x2C

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
		public <InstallBGM>d__15(int <>1__state) { }

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

	[SerializeField]
	private InputField inputFieldIPAddr; //Field offset: 0x14
	[SerializeField]
	private Toggle toggleEnable; //Field offset: 0x18
	[SerializeField]
	private Toggle toggleLogEnable; //Field offset: 0x1C
	[SerializeField]
	private Toggle toggleMaster; //Field offset: 0x20
	[SerializeField]
	private Toggle toggleFumen; //Field offset: 0x24
	[SerializeField]
	private Button buttonTest; //Field offset: 0x28
	[SerializeField]
	private Button buttonSave; //Field offset: 0x2C
	[SerializeField]
	private Button buttonBack; //Field offset: 0x30
	[SerializeField]
	private Text textResult; //Field offset: 0x34
	private HostIOManager manager; //Field offset: 0x38

	public HostIOScene() { }

	[IteratorStateMachine(typeof(<Co_Test>d__13))]
	private IEnumerator Co_Test() { }

	protected virtual void DoAwake() { }

	[IteratorStateMachine(typeof(<InstallBGM>d__15))]
	private IEnumerator InstallBGM(HostIOManager host, string targetDir) { }

	public void OnBack() { }

	public void OnBGMInstall() { }

	public void OnLogExport() { }

	public void OnSave() { }

	public void OnTest() { }

}

