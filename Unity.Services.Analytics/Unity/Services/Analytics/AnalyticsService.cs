namespace Unity.Services.Analytics;

public static class AnalyticsService
{
	private static AnalyticsServiceInstance m_Instance; //Field offset: 0x0
	private static IDispatcherDebug m_DispatcherDebug; //Field offset: 0x4
	private static IBufferDebug m_BufferDebug; //Field offset: 0x8
	private static Action<String, String, DateTime, Byte[]> m_EventRecordedCallback; //Field offset: 0xC
	private static Action<HashSet`1<String>> m_EventsClearingCallback; //Field offset: 0x10
	private static Action<Byte[]> m_FlushStartedCallback; //Field offset: 0x14
	private static Action<Int32, Boolean, Boolean, Boolean, Boolean, Byte[]> m_FlushCompletedCallback; //Field offset: 0x18

	internal static void Initialize(CoreRegistry registry) { }

	internal static void TearDown() { }

}

