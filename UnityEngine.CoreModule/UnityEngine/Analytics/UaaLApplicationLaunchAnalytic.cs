namespace UnityEngine.Analytics;

[RequiredByNativeCode(GenerateProxy = True)]
internal class UaaLApplicationLaunchAnalytic : AnalyticsEventBase
{
	public int launch_type; //Field offset: 0x18
	public int launch_process_type; //Field offset: 0x1C

	public UaaLApplicationLaunchAnalytic() { }

	[RequiredByNativeCode]
	public static UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic() { }

}

