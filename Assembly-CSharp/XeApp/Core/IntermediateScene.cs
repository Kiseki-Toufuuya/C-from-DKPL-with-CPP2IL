namespace XeApp.Core;

public class IntermediateScene : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public int n; //Field offset: 0x8
		public int r; //Field offset: 0xC

		public <>c__DisplayClass14_0() { }

		internal void <CreateHistory>b__0(string name, int count) { }

	}

	[CompilerGenerated]
	private sealed class <RestertScene>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

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
		public <RestertScene>d__11(int <>1__state) { }

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

	internal struct History
	{
		public string SceneName; //Field offset: 0x0
		public long MemorySize; //Field offset: 0x8
		public long BundleCount; //Field offset: 0x10
		public long BundleRefCountTotal; //Field offset: 0x18

	}

	[CompilerGenerated]
	private static string <NextSceneName>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private Button restertButton; //Field offset: 0x10
	[SerializeField]
	private Text text; //Field offset: 0x14
	public List<History> Histories; //Field offset: 0x18

	public static string NextSceneName
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		 set { } //Length: 84
	}

	private static IntermediateScene() { }

	public IntermediateScene() { }

	private string BuildText() { }

	private History CreateHistory() { }

	[CompilerGenerated]
	public static string get_NextSceneName() { }

	private void OnClickRestert() { }

	[IteratorStateMachine(typeof(<RestertScene>d__11))]
	private IEnumerator RestertScene() { }

	private void Save(string s) { }

	[CompilerGenerated]
	public static void set_NextSceneName(string value) { }

	private void Start() { }

	private void Update() { }

}

