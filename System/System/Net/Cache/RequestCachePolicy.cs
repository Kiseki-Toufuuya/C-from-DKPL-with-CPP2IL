namespace System.Net.Cache;

public class RequestCachePolicy
{
	private RequestCacheLevel m_Level; //Field offset: 0x8

	public RequestCacheLevel Level
	{
		 get { } //Length: 11
	}

	public RequestCachePolicy(RequestCacheLevel level) { }

	public RequestCacheLevel get_Level() { }

	public virtual string ToString() { }

}

