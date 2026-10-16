namespace Unity.Services.Analytics.Internal;

internal interface IWebRequest : IDisposable
{

	public bool IsNetworkError
	{
		 get { } //Length: 0
	}

	public bool get_IsNetworkError() { }

	public UnityWebRequestAsyncOperation SendWebRequest() { }

	public void SetRequestHeader(string key, string value) { }

}

