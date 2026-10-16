namespace UnityEngine;

internal sealed class UnitySynchronizationContext : SynchronizationContext
{
	private struct WorkRequest
	{
		private readonly SendOrPostCallback m_DelagateCallback; //Field offset: 0x0
		private readonly object m_DelagateState; //Field offset: 0x4
		private readonly ManualResetEvent m_WaitHandle; //Field offset: 0x8

		public WorkRequest(SendOrPostCallback callback, object state, ManualResetEvent waitHandle = null) { }

		public void Invoke() { }

	}

	private readonly List<WorkRequest> m_AsyncWorkQueue; //Field offset: 0xC
	private readonly List<WorkRequest> m_CurrentFrameWork; //Field offset: 0x10
	private readonly int m_MainThreadID; //Field offset: 0x14
	private int m_TrackedCount; //Field offset: 0x18

	internal int MainThreadId
	{
		internal get { } //Length: 11
	}

	private UnitySynchronizationContext(int mainThreadID) { }

	private UnitySynchronizationContext(List<WorkRequest> queue, int mainThreadID) { }

	public virtual SynchronizationContext CreateCopy() { }

	public void Exec() { }

	[RequiredByNativeCode]
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }

	[RequiredByNativeCode]
	private static void ExecuteTasks() { }

	internal int get_MainThreadId() { }

	private bool HasPendingTasks() { }

	[RequiredByNativeCode]
	private static void InitializeSynchronizationContext() { }

	public virtual void OperationCompleted() { }

	public virtual void OperationStarted() { }

	public virtual void Post(SendOrPostCallback callback, object state) { }

	public virtual void Send(SendOrPostCallback callback, object state) { }

}

