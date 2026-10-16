namespace System;

internal class IOSelectorJob : IThreadPoolWorkItem
{
	private IOOperation operation; //Field offset: 0x8
	private IOAsyncCallback callback; //Field offset: 0xC
	private IOAsyncResult state; //Field offset: 0x10

	public IOSelectorJob(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	public void MarkDisposed() { }

	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

}

