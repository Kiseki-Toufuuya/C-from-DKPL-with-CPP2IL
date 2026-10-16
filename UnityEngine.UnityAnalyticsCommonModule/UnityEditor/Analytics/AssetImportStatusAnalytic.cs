namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
internal class AssetImportStatusAnalytic : AnalyticsEventBase
{
	public string package_name; //Field offset: 0x18
	public int package_items_count; //Field offset: 0x1C
	public int package_import_status; //Field offset: 0x20
	public string error_message; //Field offset: 0x24
	public int project_assets_count; //Field offset: 0x28
	public int unselected_assets_count; //Field offset: 0x2C
	public int selected_new_assets_count; //Field offset: 0x30
	public int selected_changed_assets_count; //Field offset: 0x34
	public int unchanged_assets_count; //Field offset: 0x38
	public String[] selected_asset_extensions; //Field offset: 0x3C

	public AssetImportStatusAnalytic() { }

	[RequiredByNativeCode]
	public static AssetImportStatusAnalytic CreateAssetImportStatusAnalytic() { }

}

