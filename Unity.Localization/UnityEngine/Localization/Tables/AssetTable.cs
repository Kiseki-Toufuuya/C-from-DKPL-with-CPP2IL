namespace UnityEngine.Localization.Tables;

public class AssetTable : DetailedLocalizationTable<AssetTableEntry>, IPreloadRequired
{
	private AsyncOperationHandle m_PreloadOperationHandle; //Field offset: 0x24

	public override AsyncOperationHandle PreloadOperation
	{
		 get { } //Length: 92
	}

	private ResourceManager ResourceManager
	{
		private get { } //Length: 60
	}

	public AssetTable() { }

	public virtual AssetTableEntry CreateTableEntry() { }

	public override AsyncOperationHandle get_PreloadOperation() { }

	private ResourceManager get_ResourceManager() { }

	public AsyncOperationHandle<TObject> GetAssetAsync(TableEntryReference entryReference) { }

	internal AsyncOperationHandle<TObject> GetAssetAsync(AssetTableEntry entry) { }

	private AsyncOperationHandle PreloadAssets() { }

	public void ReleaseAsset(AssetTableEntry entry) { }

	public void ReleaseAsset(TableEntryReference entry) { }

	public void ReleaseAssets() { }

}

