namespace UnityEngine.ResourceManagement.ResourceProviders;

internal class BinaryCatalogInitializationData
{
	[SerializeField]
	public int m_BinaryStorageBufferCacheSize; //Field offset: 0x8
	[SerializeField]
	public int m_CatalogLocationCacheSize; //Field offset: 0xC

	public BinaryCatalogInitializationData() { }

}

