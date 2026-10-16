namespace XeApp.Game.Shop;

public class AssetCacheUtil
{
	private readonly int NO_SARCH_ASSET_INDEX; //Field offset: 0x8
	private int CACHE_NUM; //Field offset: 0xC
	private AssetDataEx[] m_AssetCacheArray; //Field offset: 0x10

	public AssetCacheUtil(int cacheNum = 0) { }

	public void AddAssetCache(AssetDataEx assetData) { }

	public void ChangeAssetCachePriority(int index, AssetDataEx assetData) { }

	public AssetDataEx FindAsset(int uniqId) { }

	public int FindAssetIndex(int uniqId) { }

	public AssetDataEx FindAssetWithChangePriority(int uniqId) { }

	private void PriorityShift(int shiftNum) { }

	public void Release() { }

	private void UnLoad(AssetDataEx assetData) { }

}

