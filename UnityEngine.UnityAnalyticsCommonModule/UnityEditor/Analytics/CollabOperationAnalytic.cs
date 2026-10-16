namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class CollabOperationAnalytic : AnalyticsEventBase
{
	public string category; //Field offset: 0x18
	public string operation; //Field offset: 0x1C
	public string result; //Field offset: 0x20
	public long start_ts; //Field offset: 0x28
	public long duration; //Field offset: 0x30

	public CollabOperationAnalytic() { }

	[RequiredByNativeCode]
	internal static CollabOperationAnalytic CreateCollabOperationAnalytic() { }

}

