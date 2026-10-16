namespace Unity.Services.Analytics.Internal;

internal class AnalyticsUserIdServiceComponent : IAnalyticsUserId, IServiceComponent
{
	private readonly IAnalyticsService m_AnalyticsService; //Field offset: 0x8

	public AnalyticsUserIdServiceComponent(IAnalyticsService analyticsService) { }

}

