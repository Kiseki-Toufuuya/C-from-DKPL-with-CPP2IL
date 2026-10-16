namespace UnityEngine.ResourceManagement.ResourceProviders;

public class ProviderLoadRequestOptions
{
	[SerializeField]
	private bool m_IgnoreFailures; //Field offset: 0x8
	private int m_WebRequestTimeout; //Field offset: 0xC

	public bool IgnoreFailures
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int WebRequestTimeout
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public ProviderLoadRequestOptions() { }

	public ProviderLoadRequestOptions Copy() { }

	public bool get_IgnoreFailures() { }

	public int get_WebRequestTimeout() { }

	public void set_IgnoreFailures(bool value) { }

	public void set_WebRequestTimeout(int value) { }

}

