namespace Unity.Services.Core.Internal;

internal class TaskAsyncOperation : AsyncOperationBase
{
	internal static TaskScheduler Scheduler; //Field offset: 0x0
	private Task m_Task; //Field offset: 0x8

	public virtual bool IsCompleted
	{
		 get { } //Length: 34
	}

	public virtual bool get_IsCompleted() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	internal static void SetScheduler() { }

}

