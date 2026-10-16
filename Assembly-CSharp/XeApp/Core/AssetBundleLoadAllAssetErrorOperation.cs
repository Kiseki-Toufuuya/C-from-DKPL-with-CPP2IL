namespace XeApp.Core;

public class AssetBundleLoadAllAssetErrorOperation : AssetBundleLoadAllAssetOperationBase
{

	public AssetBundleLoadAllAssetErrorOperation() { }

	public virtual T GetAsset(string assetName) { }

	public virtual bool IsDone() { }

	public virtual bool IsError() { }

	public virtual bool Update() { }

}

