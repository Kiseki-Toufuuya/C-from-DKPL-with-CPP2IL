namespace UnityEngine.Analytics;

[RequiredByNativeCode(GenerateProxy = True)]
public class AnalyticsEventBase
{
	private string eventName; //Field offset: 0x8
	private int eventVersion; //Field offset: 0xC
	private string eventPrefix; //Field offset: 0x10
	private SendEventOptions sendEventOptions; //Field offset: 0x14

	public AnalyticsEventBase(string eventName, int eventVersion, SendEventOptions sendEventOptions = 0, string eventPrefix = "") { }

}

