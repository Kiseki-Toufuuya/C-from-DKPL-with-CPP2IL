namespace Heqet;

public class BgAssetBundleManager
{
	public readonly int ASSET_CACHE_NUM; //Field offset: 0x8
	private AssetCacheUtil m_AssetCacheUtil; //Field offset: 0xC

	public BgAssetBundleManager() { }

	public AssetDataEx GetAssetData(int uniqId) { }

	public AssetDataEx GetAssetDataWithAutoLoad(int uniqId) { }

	public bool IsLoadAssetData(int bgId) { }

	public AssetDataEx LoadAssetAsync(int bgId) { }

	private AssetDataEx LoadAssetAsyncNoCheck(int bgId) { }

	public void Release() { }

}

