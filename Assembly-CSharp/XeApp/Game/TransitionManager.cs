namespace XeApp.Game;

public class TransitionManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static SendOrPostCallback <>9__7_1; //Field offset: 0x4
		public static Action<LayerBase> <>9__8_5; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <GotoScene>b__8_5(LayerBase layer) { }

		internal void <GotoSceneToLuncher>b__7_1(object _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public TransitionModel model; //Field offset: 0x8

		public <>c__DisplayClass7_0() { }

		internal void <GotoSceneToLuncher>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public TransitionModel model; //Field offset: 0x8
		public string sceneName; //Field offset: 0xC
		public SendOrPostCallback <>9__7; //Field offset: 0x10
		public SendOrPostCallback <>9__8; //Field offset: 0x14

		public <>c__DisplayClass8_0() { }

		internal void <GotoScene>b__0() { }

		internal void <GotoScene>b__1() { }

		internal void <GotoScene>b__2(LayerBase layer) { }

		internal void <GotoScene>b__3(LayerBase layer) { }

		internal void <GotoScene>b__4(LayerBase layer) { }

		internal void <GotoScene>b__6(LayerBase layer) { }

		internal void <GotoScene>b__7(object _) { }

		internal void <GotoScene>b__8(object _) { }

	}

	[CompilerGenerated]
	private sealed class <Co_GoToScene>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string sceneName; //Field offset: 0x10

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
		public <Co_GoToScene>d__4(int <>1__state) { }

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

	internal class TransitionInfo
	{
		private TransitionModel m_TransitionModel; //Field offset: 0x8
		private LayerBase m_LayerBase; //Field offset: 0xC
		private string m_LayerTag; //Field offset: 0x10
		private bool m_IsSceneChange; //Field offset: 0x14
		private bool m_IsDialog; //Field offset: 0x15
		private bool m_IsNotSupport; //Field offset: 0x16

		public TransitionInfo(TransitionModel model, string tag, bool isSceneChange, bool isDialog, bool isNotSupport, LayerBase layerBase = null) { }

		public TransitionInfo() { }

		public LayerBase GetLayerBase() { }

		public TransitionModel GetModel() { }

		public string GetTagName() { }

		public bool IsBackLayer() { }

		public bool IsDialogTransition() { }

		public bool IsNotSupport() { }

		public bool IsSceneChange() { }

	}


	public TransitionManager() { }

	[IteratorStateMachine(typeof(<Co_GoToScene>d__4))]
	private static IEnumerator Co_GoToScene(string sceneName) { }

	public void DeleteRootLayerToAppointTag(string tag) { }

	public void DeleteUntilRootLayer() { }

	private void DisableCanvas() { }

	private string GetLayerName(string tagName) { }

	private string GetLayerTag(TransitionModel model) { }

	private string GetSceneName(TransitionModel model) { }

	private void GoToLoginBonus() { }

	public static void GoToLoginBonusAsync() { }

	public TransitionInfo GotoScene(TransitionModel model, Action startAction = null, Action endAction = null, Action optionAction = null) { }

	public static void GoToSceneAsync(string sceneName) { }

	public void GotoSceneToLuncher(TransitionModel model) { }

	private void GoToTitle() { }

	public static void GoToTitleAsync() { }

	private bool IsDialogTransition(TransitionModel model) { }

	private bool IsNotSupport(TransitionModel model) { }

}

