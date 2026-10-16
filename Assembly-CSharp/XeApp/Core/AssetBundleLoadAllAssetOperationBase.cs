namespace XeApp.Core;

public abstract class AssetBundleLoadAllAssetOperationBase : AssetBundleLoadOperation
{

	protected AssetBundleLoadAllAssetOperationBase() { }

	public override void ForEach(Action<Object> action) { }

	public abstract T GetAsset(string assetName) { }

	public virtual bool IsError() { }

}

