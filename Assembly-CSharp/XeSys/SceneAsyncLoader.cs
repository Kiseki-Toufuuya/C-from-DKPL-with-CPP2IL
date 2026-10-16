namespace XeSys;

public class SceneAsyncLoader : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <LoadLevel>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SceneAsyncLoader <>4__this; //Field offset: 0x10

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
		public <LoadLevel>d__12(int <>1__state) { }

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
	private string <sceneName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <isLoaded>k__BackingField; //Field offset: 0x14

	public private bool isLoaded
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private string sceneName
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public SceneAsyncLoader() { }

	private void Awake() { }

	public static SceneAsyncLoader Create(string sceneName) { }

	[CompilerGenerated]
	public bool get_isLoaded() { }

	[CompilerGenerated]
	private string get_sceneName() { }

	[IteratorStateMachine(typeof(<LoadLevel>d__12))]
	private IEnumerator LoadLevel() { }

	[CompilerGenerated]
	private void set_isLoaded(bool value) { }

	[CompilerGenerated]
	private void set_sceneName(string value) { }

	private void Start() { }

	private void Update() { }

}

