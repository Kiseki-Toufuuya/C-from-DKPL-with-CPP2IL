namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class SubsystemsAnalyticInfo : SubsystemsAnalyticBase
{
	private string id; //Field offset: 0x1C
	private string plugin_name; //Field offset: 0x20
	private string version; //Field offset: 0x24
	private string library_name; //Field offset: 0x28

	public SubsystemsAnalyticInfo() { }

	[RequiredByNativeCode]
	internal static SubsystemsAnalyticInfo CreateSubsystemsAnalyticInfo() { }

}

