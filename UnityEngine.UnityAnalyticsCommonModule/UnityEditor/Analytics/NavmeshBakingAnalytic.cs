namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class NavmeshBakingAnalytic : AnalyticsEventBase
{
	private bool new_nav_api; //Field offset: 0x18
	private bool bake_at_runtime; //Field offset: 0x19
	private int height_meshes_count; //Field offset: 0x1C
	private int offmesh_links_count; //Field offset: 0x20

	public NavmeshBakingAnalytic() { }

	[RequiredByNativeCode]
	internal static NavmeshBakingAnalytic CreateNavmeshBakingAnalytic() { }

}

