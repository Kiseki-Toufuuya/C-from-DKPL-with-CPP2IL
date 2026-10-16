namespace XeApp.Core;

public class AssetBundleLoadAssetErrorOperation : AssetBundleLoadAssetOperation
{

	public AssetBundleLoadAssetErrorOperation() { }

	public virtual T GetAsset() { }

	public virtual bool IsDone() { }

	public virtual bool IsError() { }

	public virtual bool Update() { }

}

