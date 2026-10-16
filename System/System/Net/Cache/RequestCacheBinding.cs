namespace System.Net.Cache;

internal class RequestCacheBinding
{
	private RequestCache m_RequestCache; //Field offset: 0x8
	private RequestCacheValidator m_CacheValidator; //Field offset: 0xC

	internal RequestCache Cache
	{
		internal get { } //Length: 11
	}

	internal RequestCacheValidator Validator
	{
		internal get { } //Length: 11
	}

	internal RequestCache get_Cache() { }

	internal RequestCacheValidator get_Validator() { }

}

