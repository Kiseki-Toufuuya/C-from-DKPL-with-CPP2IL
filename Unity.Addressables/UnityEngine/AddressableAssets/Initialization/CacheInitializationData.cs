namespace UnityEngine.AddressableAssets.Initialization;

public class CacheInitializationData
{
	[FormerlySerializedAs("m_compressionEnabled")]
	[SerializeField]
	private bool m_CompressionEnabled; //Field offset: 0x8
	[FormerlySerializedAs("m_cacheDirectoryOverride")]
	[SerializeField]
	private string m_CacheDirectoryOverride; //Field offset: 0xC
	[FormerlySerializedAs("m_limitCacheSize")]
	[SerializeField]
	private bool m_LimitCacheSize; //Field offset: 0x10
	[FormerlySerializedAs("m_maximumCacheSize")]
	[SerializeField]
	private long m_MaximumCacheSize; //Field offset: 0x18

	public string CacheDirectoryOverride
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool CompressionEnabled
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool LimitCacheSize
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public long MaximumCacheSize
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	public CacheInitializationData() { }

	public string get_CacheDirectoryOverride() { }

	public bool get_CompressionEnabled() { }

	public bool get_LimitCacheSize() { }

	public long get_MaximumCacheSize() { }

	public void set_CacheDirectoryOverride(string value) { }

	public void set_CompressionEnabled(bool value) { }

	public void set_LimitCacheSize(bool value) { }

	public void set_MaximumCacheSize(long value) { }

}

