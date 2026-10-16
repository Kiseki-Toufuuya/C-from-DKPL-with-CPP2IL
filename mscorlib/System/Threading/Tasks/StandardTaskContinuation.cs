namespace System.Threading.Tasks;

internal class StandardTaskContinuation : TaskContinuation
{
	internal readonly Task m_task; //Field offset: 0x8
	internal readonly TaskContinuationOptions m_options; //Field offset: 0xC
	private readonly TaskScheduler m_taskScheduler; //Field offset: 0x10

	internal StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	internal virtual void Run(Task completedTask, bool bCanInlineContinuationTask) { }

}

