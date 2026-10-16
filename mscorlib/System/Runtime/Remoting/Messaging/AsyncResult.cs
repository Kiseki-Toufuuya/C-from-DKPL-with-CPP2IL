namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem
{
	private object async_state; //Field offset: 0x8
	private WaitHandle handle; //Field offset: 0xC
	private object async_delegate; //Field offset: 0x10
	private IntPtr data; //Field offset: 0x14
	private object object_data; //Field offset: 0x18
	private bool sync_completed; //Field offset: 0x1C
	private bool completed; //Field offset: 0x1D
	private bool endinvoke_called; //Field offset: 0x1E
	private object async_callback; //Field offset: 0x20
	private ExecutionContext current; //Field offset: 0x24
	private ExecutionContext original; //Field offset: 0x28
	private long add_time; //Field offset: 0x30
	private MonoMethodMessage call_message; //Field offset: 0x38
	private IMessageCtrl message_ctrl; //Field offset: 0x3C
	private IMessage reply_message; //Field offset: 0x40
	private WaitCallback orig_cb; //Field offset: 0x44

	public override object AsyncDelegate
	{
		 get { } //Length: 11
	}

	public override object AsyncState
	{
		 get { } //Length: 11
	}

	public override WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 294
	}

	internal MonoMethodMessage CallMessage
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	public override bool CompletedSynchronously
	{
		 get { } //Length: 11
	}

	public bool EndInvokeCalled
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public override bool IsCompleted
	{
		 get { } //Length: 11
	}

	public override IMessageSink NextSink
	{
		 get { } //Length: 3
	}

	internal AsyncResult() { }

	public override IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	internal IMessage EndInvoke() { }

	public override object get_AsyncDelegate() { }

	public override object get_AsyncState() { }

	public override WaitHandle get_AsyncWaitHandle() { }

	internal MonoMethodMessage get_CallMessage() { }

	public override bool get_CompletedSynchronously() { }

	public bool get_EndInvokeCalled() { }

	public override bool get_IsCompleted() { }

	public override IMessageSink get_NextSink() { }

	public override IMessage GetReplyMessage() { }

	internal object Invoke() { }

	internal void set_CallMessage(MonoMethodMessage value) { }

	public void set_EndInvokeCalled(bool value) { }

	internal void SetCompletedSynchronously(bool completed) { }

	public override void SetMessageCtrl(IMessageCtrl mc) { }

	public override IMessage SyncProcessMessage(IMessage msg) { }

	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

}

