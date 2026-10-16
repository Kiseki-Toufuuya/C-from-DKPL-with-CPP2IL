namespace UnityEngine.UIElements;

[Extension]
internal static class ManagedJobExtension
{

	[Extension]
	public static JobHandle ScheduleOrRunJob(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = null) { }

}

