namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
internal class AssetExportAnalytic : AnalyticsEventBase
{
	public string package_name; //Field offset: 0x18
	public string error_message; //Field offset: 0x1C
	public int items_count; //Field offset: 0x20
	public String[] asset_extensions; //Field offset: 0x24
	public bool include_upm_dependencies; //Field offset: 0x28

	public AssetExportAnalytic() { }

	[RequiredByNativeCode]
	public static AssetExportAnalytic CreateAssetExportAnalytic() { }

}

