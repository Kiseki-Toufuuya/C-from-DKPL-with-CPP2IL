namespace XeApp.Core;

public interface IAssetBundleFileLoader
{

	public void LoadRequest(string loadPath, string assetBundleName, Func<AssetBundle, Boolean> onSuccess, Func<Boolean> onFailed) { }

	public void OnUnload(string assetBundleName) { }

}

