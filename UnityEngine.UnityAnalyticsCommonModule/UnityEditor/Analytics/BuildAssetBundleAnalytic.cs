namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class BuildAssetBundleAnalytic : AnalyticsEventBase
{
	public bool success; //Field offset: 0x18
	public string error; //Field offset: 0x1C

	public BuildAssetBundleAnalytic() { }

	[RequiredByNativeCode]
	internal static BuildAssetBundleAnalytic CreateBuildAssetBundleAnalytic() { }

}

