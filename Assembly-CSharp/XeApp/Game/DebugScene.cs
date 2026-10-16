namespace XeApp.Game;

public class DebugScene : MainSceneBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int32> <>9__29_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <RemoveLocalSave>b__29_0(int n) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public bool end; //Field offset: 0x8

		public <>c__DisplayClass28_0() { }

		internal void <NextScene>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <NextScene>d__28 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string sceneName; //Field offset: 0x10
		public DebugScene <>4__this; //Field offset: 0x14
		private <>c__DisplayClass28_0 <>8__1; //Field offset: 0x18

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
		public <NextScene>d__28(int <>1__state) { }

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

	internal class ChooseItem
	{
		public string DisplayName; //Field offset: 0x8
		public string SceneName; //Field offset: 0xC
		public Action<ChooseItem> OnTap; //Field offset: 0x10

		public ChooseItem() { }

	}

	internal enum eStepMain
	{
		INIT_ALL = 0,
		INIT_START = 1,
		CONT_MAIN = 2,
		END = 3,
		NUM = 4,
	}

	private static List<ChooseItem> chooseItems; //Field offset: 0x0
	[SerializeField]
	private DebugSceneSelector m_SampleSelector; //Field offset: 0x14
	private eStepMain m_StepMain; //Field offset: 0x18
	private string m_SystemInfo; //Field offset: 0x1C
	private DebugSceneSelector m_CurrentSelector; //Field offset: 0x20
	private Action m_GuiAction; //Field offset: 0x24
	private bool enableChangeGameId; //Field offset: 0x28
	private string gameIdText; //Field offset: 0x2C
	private bool nextScene; //Field offset: 0x30

	public DebugScene() { }

	private void BuildSystemInfo() { }

	private void ContMain() { }

	protected virtual void DoAwake() { }

	protected virtual void DoOnGUI() { }

	protected virtual void DoStart() { }

	protected virtual void DoUpdateMain() { }

	private void InitCanvas() { }

	private void LoadSelectGameId() { }

	[IteratorStateMachine(typeof(<NextScene>d__28))]
	protected virtual IEnumerator NextScene(string sceneName) { }

	private void OnDestroy() { }

	private void OnGUI() { }

	private void OnGUI_Root() { }

	private void OnGUI_SelectGameId() { }

	private void OnGUI_SystemInfo() { }

	private void OnGUI_Viewer() { }

	private void OnTapNextScene(ChooseItem x) { }

	private void OnTapViewer(ChooseItem x) { }

	private void RemoveLocalSave() { }

	private bool TestButton(int x, int y, string name) { }

}

