namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
internal class TestAnalytic : AnalyticsEventBase
{
	public int param; //Field offset: 0x18

	public TestAnalytic() { }

	[RequiredByNativeCode]
	public static TestAnalytic CreateTestAnalytic() { }

}

