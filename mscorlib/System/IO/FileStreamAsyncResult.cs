namespace System.IO;

internal class FileStreamAsyncResult : IAsyncResult
{
	private object state; //Field offset: 0x8
	private bool completed; //Field offset: 0xC
	private ManualResetEvent wh; //Field offset: 0x10
	private AsyncCallback cb; //Field offset: 0x14
	private bool completedSynch; //Field offset: 0x18
	public int Count; //Field offset: 0x1C
	public int OriginalCount; //Field offset: 0x20
	public int BytesRead; //Field offset: 0x24
	private AsyncCallback realcb; //Field offset: 0x28

	public override object AsyncState
	{
		 get { } //Length: 11
	}

	public override WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 11
	}

	public override bool CompletedSynchronously
	{
		 get { } //Length: 11
	}

	public override bool IsCompleted
	{
		 get { } //Length: 11
	}

	public FileStreamAsyncResult(AsyncCallback cb, object state) { }

	private static void CBWrapper(IAsyncResult ares) { }

	public override object get_AsyncState() { }

	public override WaitHandle get_AsyncWaitHandle() { }

	public override bool get_CompletedSynchronously() { }

	public override bool get_IsCompleted() { }

}

