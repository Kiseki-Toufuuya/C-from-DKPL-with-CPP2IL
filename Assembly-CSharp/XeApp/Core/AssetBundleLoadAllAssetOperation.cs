namespace XeApp.Core;

public class AssetBundleLoadAllAssetOperation : AssetBundleLoadAllAssetOperationBase
{
	public static bool IsBugFixGfxThread; //Field offset: 0x0
	private Object[] m_LoadedObjects; //Field offset: 0xC
	protected string m_AssetBundleName; //Field offset: 0x10
	protected string m_loadingError; //Field offset: 0x14
	private AssetBundleRequest m_request; //Field offset: 0x18

	public string AssetBundleName
	{
		 get { } //Length: 11
	}

	public AssetBundleLoadAllAssetOperation(string bundleName) { }

	public virtual void ForEach(Action<Object> action) { }

	public string get_AssetBundleName() { }

	public virtual T GetAsset(string assetName) { }

	public virtual bool IsDone() { }

	public virtual bool IsError() { }

	private void SetupLoadedObjects() { }

	public virtual bool Update() { }

}

