namespace XeApp.Core;

public abstract class AssetBundleLoadAssetOperation : AssetBundleLoadOperation
{

	protected AssetBundleLoadAssetOperation() { }

	public abstract T GetAsset() { }

}

