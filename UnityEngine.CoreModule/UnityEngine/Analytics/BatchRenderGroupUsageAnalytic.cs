namespace UnityEngine.Analytics;

[RequiredByNativeCode(GenerateProxy = True)]
internal class BatchRenderGroupUsageAnalytic : AnalyticsEventBase
{
	public int maxBRGInstance; //Field offset: 0x18
	public int maxMeshCount; //Field offset: 0x1C
	public int maxMaterialCount; //Field offset: 0x20
	public int maxDrawCommandBatch; //Field offset: 0x24

	public BatchRenderGroupUsageAnalytic() { }

	[RequiredByNativeCode]
	public static BatchRenderGroupUsageAnalytic CreateBatchRenderGroupUsageAnalytic() { }

}

