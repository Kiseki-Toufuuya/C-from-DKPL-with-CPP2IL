namespace System.Runtime;

internal abstract class AsyncEventArgs : IAsyncEventArgs
{
	private enum OperationState
	{
		Created = 0,
		PendingCompletion = 1,
		CompletedSynchronously = 2,
		CompletedAsynchronously = 3,
	}

	private OperationState state; //Field offset: 0x8
	private object asyncState; //Field offset: 0xC
	private AsyncEventArgsCallback callback; //Field offset: 0x10
	private Exception exception; //Field offset: 0x14

	public override object AsyncState
	{
		 get { } //Length: 11
	}

	public override Exception Exception
	{
		 get { } //Length: 11
	}

	private OperationState State
	{
		private set { } //Length: 229
	}

	protected AsyncEventArgs() { }

	public void Complete(bool completedSynchronously) { }

	public override void Complete(bool completedSynchronously, Exception exception) { }

	public override object get_AsyncState() { }

	public override Exception get_Exception() { }

	private void set_State(OperationState value) { }

	protected void SetAsyncState(AsyncEventArgsCallback callback, object state) { }

}

