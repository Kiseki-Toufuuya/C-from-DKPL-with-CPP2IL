namespace XeApp.Core;

public class AssetBundleLoadAssetOperationFull : AssetBundleLoadAssetOperation
{
	protected string m_AssetBundleName; //Field offset: 0xC
	protected string m_AssetName; //Field offset: 0x10
	protected string m_loadingError; //Field offset: 0x14
	protected Type m_Type; //Field offset: 0x18
	protected AssetBundleRequest m_request; //Field offset: 0x1C
	protected Action<AssetBundleLoadAssetOperation> m_OnLoad; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsSetCache>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private bool <EnableLoadErrorLog>k__BackingField; //Field offset: 0x25

	public string AssetBundleName
	{
		 get { } //Length: 11
	}

	public string AssetName
	{
		 get { } //Length: 11
	}

	public bool EnableLoadErrorLog
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool IsSetCache
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public AssetBundleLoadAssetOperationFull(string bundleName, string assetName, Type type, Action<AssetBundleLoadAssetOperation> end_load) { }

	public string get_AssetBundleName() { }

	public string get_AssetName() { }

	[CompilerGenerated]
	public bool get_EnableLoadErrorLog() { }

	[CompilerGenerated]
	public bool get_IsSetCache() { }

	public virtual T GetAsset() { }

	public virtual bool IsDone() { }

	public virtual bool IsError() { }

	public bool IsSameRequest(string bundleName, string assetName, Type type) { }

	[CompilerGenerated]
	public void set_EnableLoadErrorLog(bool value) { }

	[CompilerGenerated]
	public void set_IsSetCache(bool value) { }

	public virtual bool Update() { }

}

