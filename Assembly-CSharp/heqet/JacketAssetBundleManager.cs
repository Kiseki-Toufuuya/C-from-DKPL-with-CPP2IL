namespace Heqet;

public class JacketAssetBundleManager
{
	public readonly int ASSET_CACHE_NUM; //Field offset: 0x8
	private AssetCacheUtil m_AssetCacheUtil; //Field offset: 0xC

	public JacketAssetBundleManager() { }

	public AssetDataEx GetAssetData(int uniqId) { }

	public AssetDataEx GetAssetDataWithAutoLoad(int uniqId) { }

	public AssetDataEx LoadAssetAsync(int jacketId) { }

	private AssetDataEx LoadAssetAsyncNoCheck(int jacketId) { }

	public void Release() { }

}

