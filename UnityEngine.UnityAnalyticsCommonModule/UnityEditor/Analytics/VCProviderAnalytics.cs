namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class VCProviderAnalytics : AnalyticsEventBase
{
	public string Mode; //Field offset: 0x18

	public VCProviderAnalytics() { }

	[RequiredByNativeCode]
	internal static VCProviderAnalytics CreateVCProviderAnalytics() { }

}

