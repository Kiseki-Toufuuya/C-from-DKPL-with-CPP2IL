namespace Unity.Services.Core;

internal static class UnityThreadUtils
{
	private static int s_UnityThreadId; //Field offset: 0x0
	[CompilerGenerated]
	private static TaskScheduler <UnityThreadScheduler>k__BackingField; //Field offset: 0x4

	private static TaskScheduler UnityThreadScheduler
	{
		[CompilerGenerated]
		private set { } //Length: 69
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::SubsystemRegistration (4))]
	private static void CaptureUnityThreadInfo() { }

	[CompilerGenerated]
	private static void set_UnityThreadScheduler(TaskScheduler value) { }

}

