namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class PackageManagerBaseAnalytic : AnalyticsEventBase
{
	public long start_ts; //Field offset: 0x18
	public long duration; //Field offset: 0x20
	public bool blocking; //Field offset: 0x28
	public string package_id; //Field offset: 0x2C
	public int status_code; //Field offset: 0x30
	public string error_message; //Field offset: 0x34

	public PackageManagerBaseAnalytic(string eventName) { }

}

