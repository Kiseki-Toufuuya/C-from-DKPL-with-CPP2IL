namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
internal class StallMarkerAnalytic : AnalyticsEventBase
{
	public string Name; //Field offset: 0x18
	public bool HasProgressMarkup; //Field offset: 0x1C
	public double Duration; //Field offset: 0x20

	public StallMarkerAnalytic() { }

	[RequiredByNativeCode]
	internal static StallMarkerAnalytic CreateStallMarkerAnalytic() { }

}

