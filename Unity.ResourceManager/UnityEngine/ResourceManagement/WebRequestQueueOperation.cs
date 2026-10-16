namespace UnityEngine.ResourceManagement;

public class WebRequestQueueOperation
{
	private bool m_Completed; //Field offset: 0x8
	public UnityWebRequestAsyncOperation Result; //Field offset: 0xC
	public Action<UnityWebRequestAsyncOperation> OnComplete; //Field offset: 0x10
	internal UnityWebRequest m_WebRequest; //Field offset: 0x14

	public bool IsDone
	{
		 get { } //Length: 25
	}

	public internal UnityWebRequest WebRequest
	{
		 get { } //Length: 11
		internal set { } //Length: 27
	}

	public WebRequestQueueOperation(UnityWebRequest request) { }

	internal void Complete(UnityWebRequestAsyncOperation asyncOp) { }

	public bool get_IsDone() { }

	public UnityWebRequest get_WebRequest() { }

	internal void set_WebRequest(UnityWebRequest value) { }

}

