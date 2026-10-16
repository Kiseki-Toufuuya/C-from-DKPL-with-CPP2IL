namespace UnityEngine.Localization.Settings;

public class LocalizedAssetDatabase : LocalizedDatabase<AssetTable, AssetTableEntry>
{

	public LocalizedAssetDatabase() { }

	public TObject GetLocalizedAsset(TableEntryReference tableEntryReference, Locale locale = null) { }

	public override TObject GetLocalizedAsset(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null) { }

	public AsyncOperationHandle<TObject> GetLocalizedAssetAsync(TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = 0) { }

	public override AsyncOperationHandle<TObject> GetLocalizedAssetAsync(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = 0) { }

	protected override AsyncOperationHandle<TObject> GetLocalizedAssetAsyncInternal(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, FallbackBehavior fallbackBehavior = 0) { }

	internal virtual void ReleaseTableContents(AssetTable table) { }

}

