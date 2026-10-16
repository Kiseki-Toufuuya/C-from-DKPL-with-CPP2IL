namespace Unity.Services.Analytics.Internal;

internal class AnalyticsWebRequest : UnityWebRequest, IWebRequest, IDisposable
{

	public override bool IsNetworkError
	{
		 get { } //Length: 24
	}

	internal AnalyticsWebRequest(string url, string method) { }

	public override bool get_IsNetworkError() { }

	private override UnityWebRequestAsyncOperation Unity.Services.Analytics.Internal.IWebRequest.SendWebRequest() { }

	private override void Unity.Services.Analytics.Internal.IWebRequest.SetRequestHeader(string key, string value) { }

}

