namespace System.Threading.Tasks;

[DebuggerDisplay("Id={Id}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskSchedulerDebugView))]
public abstract class TaskScheduler
{
	public sealed class SystemThreadingTasks_TaskSchedulerDebugView
	{

	}

	private static readonly TaskScheduler s_defaultTaskScheduler; //Field offset: 0x0
	internal static int s_taskSchedulerIdCounter; //Field offset: 0x4
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; //Field offset: 0x8
	private static readonly Lock _unobservedTaskExceptionLockObject; //Field offset: 0xC
	private int m_taskSchedulerId; //Field offset: 0x8

	public static TaskScheduler Current
	{
		 get { } //Length: 143
	}

	public static TaskScheduler Default
	{
		 get { } //Length: 60
	}

	public int Id
	{
		 get { } //Length: 129
	}

	internal static TaskScheduler InternalCurrent
	{
		internal get { } //Length: 192
	}

	internal override bool RequiresAtomicStartTransition
	{
		internal get { } //Length: 3
	}

	private static TaskScheduler() { }

	protected TaskScheduler() { }

	public static TaskScheduler FromCurrentSynchronizationContext() { }

	public static TaskScheduler get_Current() { }

	public static TaskScheduler get_Default() { }

	public int get_Id() { }

	internal static TaskScheduler get_InternalCurrent() { }

	internal override bool get_RequiresAtomicStartTransition() { }

	internal override void NotifyWorkItemProgress() { }

	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	protected private abstract void QueueTask(Task task) { }

	protected private override bool TryDequeue(Task task) { }

	protected bool TryExecuteTask(Task task) { }

	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

}

