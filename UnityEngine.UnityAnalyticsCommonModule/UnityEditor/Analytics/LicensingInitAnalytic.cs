namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class LicensingInitAnalytic : AnalyticsEventBase
{
	public string licensingProtocolVersion; //Field offset: 0x18
	public string licensingClientVersion; //Field offset: 0x1C
	public string channelType; //Field offset: 0x20
	public double initTime; //Field offset: 0x28
	public bool isLegacy; //Field offset: 0x30
	public string sessionId; //Field offset: 0x34
	public string correlationId; //Field offset: 0x38

	public LicensingInitAnalytic() { }

	[RequiredByNativeCode]
	internal static LicensingInitAnalytic CreateLicensingInitAnalytic() { }

}

