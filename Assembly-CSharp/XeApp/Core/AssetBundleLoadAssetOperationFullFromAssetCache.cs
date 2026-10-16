namespace XeApp.Core;

public class AssetBundleLoadAssetOperationFullFromAssetCache : AssetBundleLoadAssetOperation
{
	protected string m_AssetBundleName; //Field offset: 0xC
	protected string m_AssetName; //Field offset: 0x10
	protected Type m_Type; //Field offset: 0x14
	protected Action<AssetBundleLoadAssetOperation> m_OnLoad; //Field offset: 0x18
	protected object m_Asset; //Field offset: 0x1C
	protected string m_AssetKey; //Field offset: 0x20
	private string profName; //Field offset: 0x24

	public string AssetBundleName
	{
		 get { } //Length: 11
	}

	public AssetBundleLoadAssetOperationFullFromAssetCache(string bundleName, string assetName, Type type, Action<AssetBundleLoadAssetOperation> end_load) { }

	public string get_AssetBundleName() { }

	public virtual T GetAsset() { }

	public virtual bool IsDone() { }

	public virtual bool IsError() { }

	public virtual bool Update() { }

}

