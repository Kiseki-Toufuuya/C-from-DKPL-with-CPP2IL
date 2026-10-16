namespace XeApp.Core;

public class UnionAssetBundleLoadOperation : AssetBundleLoadOperation
{
	protected string m_AssetBundleName; //Field offset: 0xC
	protected bool m_isLoaded; //Field offset: 0x10
	protected string m_loadingError; //Field offset: 0x14
	protected LoadedAssetBundle m_loadedAssetBundle; //Field offset: 0x18

	public string AssetBundleName
	{
		 get { } //Length: 11
	}

	public UnionAssetBundleLoadOperation(string bundleName) { }

	public string get_AssetBundleName() { }

	public virtual bool IsDone() { }

	public virtual bool IsError() { }

	public virtual bool Update() { }

}

