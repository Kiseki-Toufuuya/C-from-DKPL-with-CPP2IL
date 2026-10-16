namespace XeApp.Game;

public class AssetBundleLoadRequestManger : Singleton<AssetBundleLoadRequestManger>, IDisposable
{

	public AssetBundleLoadRequestManger() { }

	public override void Dispose() { }

	public bool IsLoadedAssetBundle(int keyId) { }

	public void LateUpdate() { }

	public UnionAssetBundleLoadOperation LoadAssetBundleData(string assetBundleName) { }

	public AssetBundleLoadAssetOperation LoadAssetData(string assetBundleName, string assetName, Type type, Action<AssetBundleLoadAssetOperation> on_load) { }

	public int RequsetLoadAssetBundle(string assetBundleName, string assetName, Type type, Action<AssetBundleLoadAssetOperation> on_load) { }

	public void Update() { }

}

