//Type is in global namespace

public class AddStress : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CoroutineAddStressCPU>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AddStress <>4__this; //Field offset: 0x10

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
		public <CoroutineAddStressCPU>d__10(int <>1__state) { }

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
	private bool <IsAddingStreassOnCroutine>k__BackingField; //Field offset: 0x10
	public long StressTime; //Field offset: 0x18
	private Stopwatch sw; //Field offset: 0x20

	public private bool IsAddingStreassOnCroutine
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public AddStress() { }

	private void AddStressCPU() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<CoroutineAddStressCPU>d__10))]
	private IEnumerator CoroutineAddStressCPU() { }

	[CompilerGenerated]
	public bool get_IsAddingStreassOnCroutine() { }

	[CompilerGenerated]
	private void set_IsAddingStreassOnCroutine(bool value) { }

	private void Start() { }

	private void Update() { }

}

