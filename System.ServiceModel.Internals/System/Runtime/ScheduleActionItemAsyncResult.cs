namespace System.Runtime;

internal abstract class ScheduleActionItemAsyncResult : AsyncResult
{
	private static Action<Object> doWork; //Field offset: 0x0

	private static ScheduleActionItemAsyncResult() { }

	protected ScheduleActionItemAsyncResult(AsyncCallback callback, object state) { }

	private static void DoWork(object state) { }

	public static void End(IAsyncResult result) { }

	protected abstract void OnDoWork() { }

	protected void Schedule() { }

}

