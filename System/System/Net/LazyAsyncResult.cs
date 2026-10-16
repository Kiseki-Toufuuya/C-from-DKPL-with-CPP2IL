namespace System.Net;

internal class LazyAsyncResult : IAsyncResult
{
	private class ThreadContext
	{
		internal int m_NestedIOCount; //Field offset: 0x8

		public ThreadContext() { }

	}

	[ThreadStatic]
	private static ThreadContext t_ThreadContext; //Field offset: 0x80000000
	private object m_AsyncObject; //Field offset: 0x8
	private object m_AsyncState; //Field offset: 0xC
	private AsyncCallback m_AsyncCallback; //Field offset: 0x10
	private object m_Result; //Field offset: 0x14
	private int m_IntCompleted; //Field offset: 0x18
	private bool m_EndCalled; //Field offset: 0x1C
	private bool m_UserEvent; //Field offset: 0x1D
	private object m_Event; //Field offset: 0x20

	protected AsyncCallback AsyncCallback
	{
		 get { } //Length: 11
	}

	internal object AsyncObject
	{
		internal get { } //Length: 11
	}

	public override object AsyncState
	{
		 get { } //Length: 11
	}

	public override WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 134
	}

	public override bool CompletedSynchronously
	{
		 get { } //Length: 39
	}

	private static ThreadContext CurrentThreadContext
	{
		private get { } //Length: 125
	}

	internal bool EndCalled
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal bool InternalPeekCompleted
	{
		internal get { } //Length: 18
	}

	public override bool IsCompleted
	{
		 get { } //Length: 42
	}

	internal LazyAsyncResult(object myObject, object myState, AsyncCallback myCallBack) { }

	protected override void Cleanup() { }

	protected override void Complete(IntPtr userToken) { }

	protected AsyncCallback get_AsyncCallback() { }

	internal object get_AsyncObject() { }

	public override object get_AsyncState() { }

	public override WaitHandle get_AsyncWaitHandle() { }

	public override bool get_CompletedSynchronously() { }

	private static ThreadContext get_CurrentThreadContext() { }

	internal bool get_EndCalled() { }

	internal bool get_InternalPeekCompleted() { }

	public override bool get_IsCompleted() { }

	internal object InternalWaitForCompletion() { }

	internal void InvokeCallback(object result) { }

	internal void InvokeCallback() { }

	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	internal void set_EndCalled(bool value) { }

	private object WaitForCompletion(bool snap) { }

	private void WorkerThreadComplete(object state) { }

}

