namespace Unity.Services.Analytics;

internal class AnalyticsServiceInstance : IAnalyticsService, IUnstructuredEventRecorder
{
	private const string k_ForgetCallingId = "com.unity.services.analytics.Events.RequestDataDeletion"; //Field offset: 0x0
	private const string k_StartUpCallingId = "com.unity.services.analytics.Events.Startup"; //Field offset: 0x0
	private const string k_PlayerChangedCallingId = "com.unity.services.analytics.Events.PlayerChanged"; //Field offset: 0x0
	internal const string k_InvokedByUserCallingId = "com.unity.services.analytics.Events.UserInvoked"; //Field offset: 0x0
	private readonly TimeSpan k_BackgroundSessionRefreshPeriod; //Field offset: 0x8
	private readonly TransactionCurrencyConverter converter; //Field offset: 0x10
	private readonly IIdentityManager m_UserIdentity; //Field offset: 0x14
	private readonly ISessionManager m_Session; //Field offset: 0x18
	private readonly IConsentManager m_ConsentManager; //Field offset: 0x1C
	private readonly IDataGenerator m_DataGenerator; //Field offset: 0x20
	private readonly IDispatcher m_DataDispatcher; //Field offset: 0x24
	private readonly IAnalyticsForgetter m_AnalyticsForgetter; //Field offset: 0x28
	private readonly IAnalyticsServiceSystemCalls m_SystemCalls; //Field offset: 0x2C
	private readonly IAnalyticsContainer m_Container; //Field offset: 0x30
	internal IBuffer m_DataBuffer; //Field offset: 0x34
	private int m_BufferLengthAtLastGameRunning; //Field offset: 0x38
	private DateTime m_ApplicationPauseTime; //Field offset: 0x40
	private bool m_IsActive; //Field offset: 0x48
	private bool m_StartUpEventsRecorded; //Field offset: 0x49

	internal int AutoflushPeriodMultiplier
	{
		internal get { } //Length: 89
	}

	internal AnalyticsServiceInstance(IDataGenerator dataGenerator, IBuffer realBuffer, IDispatcher dispatcher, IAnalyticsForgetter forgetter, IIdentityManager userIdentity, string environment, IAnalyticsServiceSystemCalls systemCalls, IAnalyticsContainer container, ISessionManager session, IConsentManager consent) { }

	private void Activate() { }

	internal void ApplicationPaused(bool paused) { }

	internal void ApplicationQuit() { }

	private void DataDeletionCompleted() { }

	private void Deactivate() { }

	internal void DeactivateWithDataDeletionRequest() { }

	private void DeactivateWithFlush() { }

	public override void Flush() { }

	internal int get_AutoflushPeriodMultiplier() { }

	private void PlayerChanged() { }

	internal void RecordGameRunningIfNecessary() { }

	private void RecordStartupEvents(string callingId) { }

	internal void ResumeDataDeletionIfNecessary() { }

}

