namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class ProjectSettingsInformationAnalytic : AnalyticsEventBase
{
	private int agent_types_count; //Field offset: 0x18
	private int areas_count; //Field offset: 0x1C

	public ProjectSettingsInformationAnalytic() { }

	[RequiredByNativeCode]
	internal static ProjectSettingsInformationAnalytic CreateProjectSettingsInformationAnalytic() { }

}

