namespace CriWare;

public class CriFsRequest : CriDisposable
{
	[CompilerGenerated]
	private sealed class <CheckDone>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CriFsRequest <>4__this; //Field offset: 0x10

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
		public <CheckDone>d__23(int <>1__state) { }

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

	internal sealed class DoneDelegate : MulticastDelegate
	{

		public DoneDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CriFsRequest request, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CriFsRequest request) { }

	}

	[CompilerGenerated]
	private DoneDelegate <doneDelegate>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <isDone>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private string <error>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <isDisposed>k__BackingField; //Field offset: 0x24

	public DoneDelegate doneDelegate
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string error
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool isDisposed
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public private bool isDone
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public CriFsRequest() { }

	[IteratorStateMachine(typeof(<CheckDone>d__23))]
	private IEnumerator CheckDone() { }

	protected override void Dispose(bool disposing) { }

	public virtual void Dispose() { }

	protected void Done() { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public DoneDelegate get_doneDelegate() { }

	[CompilerGenerated]
	public string get_error() { }

	[CompilerGenerated]
	public bool get_isDisposed() { }

	[CompilerGenerated]
	public bool get_isDone() { }

	[CompilerGenerated]
	protected void set_doneDelegate(DoneDelegate value) { }

	[CompilerGenerated]
	protected void set_error(string value) { }

	[CompilerGenerated]
	protected void set_isDisposed(bool value) { }

	[CompilerGenerated]
	private void set_isDone(bool value) { }

	public override void Stop() { }

	public override void Update() { }

	public YieldInstruction WaitForDone(MonoBehaviour mb) { }

}

