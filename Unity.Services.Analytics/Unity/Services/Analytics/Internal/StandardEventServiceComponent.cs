namespace Unity.Services.Analytics.Internal;

internal class StandardEventServiceComponent : IAnalyticsStandardEventComponent, IServiceComponent
{
	private readonly IProjectConfiguration m_Configuration; //Field offset: 0x8
	private readonly IUnstructuredEventRecorder m_AnalyticsService; //Field offset: 0xC

	public StandardEventServiceComponent(IProjectConfiguration configuration, IUnstructuredEventRecorder analyticsService) { }

}

