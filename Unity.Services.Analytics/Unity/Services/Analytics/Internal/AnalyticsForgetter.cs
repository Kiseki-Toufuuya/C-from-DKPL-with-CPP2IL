namespace Unity.Services.Analytics.Internal;

internal class AnalyticsForgetter : IAnalyticsForgetter
{
	private enum DataDeletionStatus
	{
		DataAllowed = 0,
		DeletionInProgress = 1,
		SuccessfullyDeleted = 2,
	}

	private readonly string m_CollectUrl; //Field offset: 0x8
	private readonly IPersistence m_Persistence; //Field offset: 0xC
	private readonly IWebRequestHelper m_WebRequestHelper; //Field offset: 0x10
	private Action m_Callback; //Field offset: 0x14
	private DataDeletionStatus m_DeletionStatus; //Field offset: 0x18
	private IWebRequest m_Request; //Field offset: 0x1C

	public override bool DeletionInProgress
	{
		 get { } //Length: 15
	}

	internal AnalyticsForgetter(string collectUrl, IPersistence persistence, IWebRequestHelper webRequestHelper) { }

	public override void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback) { }

	public override bool get_DeletionInProgress() { }

	public override void ResetDataDeletionStatus() { }

	private void SetForgettingStatus(DataDeletionStatus state) { }

	private void UploadComplete(long code) { }

}

