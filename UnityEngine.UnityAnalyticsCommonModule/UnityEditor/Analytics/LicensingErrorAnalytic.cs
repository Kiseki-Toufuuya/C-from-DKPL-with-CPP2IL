namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class LicensingErrorAnalytic : AnalyticsEventBase
{
	public string licensingErrorType; //Field offset: 0x18
	public string additionalData; //Field offset: 0x1C
	public string errorMessage; //Field offset: 0x20
	public string correlationId; //Field offset: 0x24
	public string sessionId; //Field offset: 0x28

	public LicensingErrorAnalytic() { }

	[RequiredByNativeCode]
	internal static LicensingErrorAnalytic CreateLicensingErrorAnalytic() { }

}

