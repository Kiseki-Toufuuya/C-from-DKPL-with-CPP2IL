namespace Heqet;

public class ExcuteStateCooutine
{
	[CompilerGenerated]
	private sealed class <DummyTask>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0

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
		public <DummyTask>d__18(int <>1__state) { }

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
	private sealed class <OnProsessEnd>d__17 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public ExcuteStateCooutine<T> <>4__this; //Field offset: 0x0

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
		public <OnProsessEnd>d__17(int <>1__state) { }

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

	private T state; //Field offset: 0x0
	private T nextState; //Field offset: 0x0
	private T beforeState; //Field offset: 0x0
	private IEnumerator ProsessEnd; //Field offset: 0x0
	private IEnumerator Prosess; //Field offset: 0x0
	private IEnumerator m_OnProsessEnd; //Field offset: 0x0
	public ExcuteStateCooutineTask now; //Field offset: 0x0
	public ExcuteStateCooutineTask next; //Field offset: 0x0
	private Dictionary<T, ExcuteStateCooutineTask> tasks; //Field offset: 0x0

	public T GetBeforeState
	{
		 get { } //Length: 11
	}

	public T GetNextState
	{
		 get { } //Length: 11
	}

	public T GetState
	{
		 get { } //Length: 11
	}

	public ExcuteStateCooutine`1() { }

	public void AddState(T _state, ExcuteStateCooutineTask _task) { }

	public void ChangeState(T _state) { }

	public void ChangeStateOverride(T _state) { }

	public void Clear() { }

	[IteratorStateMachine(typeof(<DummyTask>d__18))]
	private IEnumerator DummyTask() { }

	public T get_GetBeforeState() { }

	public T get_GetNextState() { }

	public T get_GetState() { }

	[IteratorStateMachine(typeof(<OnProsessEnd>d__17))]
	private IEnumerator OnProsessEnd() { }

	public void Update() { }

}

