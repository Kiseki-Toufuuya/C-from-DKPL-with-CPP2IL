namespace Heqet;

public class TransitionManager
{
	[CompilerGenerated]
	private sealed class <Co_GoToScene>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
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
		public <Co_GoToScene>d__3(int <>1__state) { }

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

	[IteratorStateMachine(typeof(<Co_GoToScene>d__3))]
	private static IEnumerator Co_GoToScene(string sceneName) { }

	private static string GetLayerName(string tagName) { }

	private static string GetLayerTag(TransitionModel model) { }

	private static string GetSceneName(TransitionModel model) { }

	private static string GetSceneName(TransitionID id) { }

	public static TransitionInfo GotoScene(TransitionModel model, Action startAction = null, Action endAction = null, Action optionAction = null) { }

	public static void GoToSceneAsync(string sceneName) { }

	private static bool IsDialogTransition(TransitionModel model) { }

	private static bool IsNotSupport(TransitionModel model) { }

}

