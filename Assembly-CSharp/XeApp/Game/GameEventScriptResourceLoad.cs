namespace XeApp.Game;

public class GameEventScriptResourceLoad : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <LayoutLoad>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string data; //Field offset: 0x10
		public GameEventScriptResourceLoad <>4__this; //Field offset: 0x14

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
		public <LayoutLoad>d__8(int <>1__state) { }

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

	private List<uGuiBaseObject> m_LayoutRequestList; //Field offset: 0x10
	private List<Coroutine> m_LayoutLoadCor; //Field offset: 0x14
	private List<String> m_RequestList; //Field offset: 0x18

	public GameEventScriptResourceLoad() { }

	private void Awake() { }

	public uGuiBaseObject GetUiObject(int id) { }

	public bool IsLoaded() { }

	[IteratorStateMachine(typeof(<LayoutLoad>d__8))]
	private IEnumerator LayoutLoad(string data) { }

	public int LayoutLoadRequest(string path) { }

	public int LayoutLoadRequestAdd(string path) { }

	public void LayoutLoadStart() { }

	private void OnDestroy() { }

	private void Start() { }

	private void Update() { }

}

