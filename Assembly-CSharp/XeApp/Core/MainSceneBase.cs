namespace XeApp.Core;

public class MainSceneBase : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <NextScene>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
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
		public <NextScene>d__11(int <>1__state) { }

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
	private GameObject m_GameManagerPrefab; //Field offset: 0x10

	public MainSceneBase() { }

	private void Awake() { }

	protected override void DoAwake() { }

	protected override void DoDestroy() { }

	protected override void DoOnGUI() { }

	protected override void DoStart() { }

	protected override void DoUpdateMain() { }

	public static AsyncOperation LoadSceneAsyncWrapper(string sceneName) { }

	[IteratorStateMachine(typeof(<NextScene>d__11))]
	protected override IEnumerator NextScene(string sceneName) { }

	private void OnDestroy() { }

	private void Start() { }

	private void Update() { }

}

