namespace System.Threading.Tasks;

internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
{
	private readonly ITaskCompletionAction m_action; //Field offset: 0x8
	private readonly Task m_completingTask; //Field offset: 0xC

	internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask) { }

	public override void MarkAborted(ThreadAbortException e) { }

	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

}

