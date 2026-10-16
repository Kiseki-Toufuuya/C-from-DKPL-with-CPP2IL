namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[UsedByNativeCode]
public struct BatchCullingContext
{
	public readonly NativeArray<Plane> cullingPlanes; //Field offset: 0x0
	public readonly NativeArray<CullingSplit> cullingSplits; //Field offset: 0xC
	public readonly LODParameters lodParameters; //Field offset: 0x18
	public readonly Matrix4x4 localToWorldMatrix; //Field offset: 0x34
	public readonly BatchCullingViewType viewType; //Field offset: 0x74
	public readonly BatchCullingProjectionType projectionType; //Field offset: 0x78
	public readonly BatchCullingFlags cullingFlags; //Field offset: 0x7C
	public readonly BatchPackedCullingViewID viewID; //Field offset: 0x80
	public readonly uint cullingLayerMask; //Field offset: 0x88
	public readonly ulong sceneCullingMask; //Field offset: 0x90
	public readonly ushort splitExclusionMask; //Field offset: 0x98
	[Obsolete("BatchCullingContext.isOrthographic is deprecated. Use BatchCullingContext.projectionType instead.")]
	public readonly byte isOrthographic; //Field offset: 0x9A
	public readonly int receiverPlaneOffset; //Field offset: 0x9C
	public readonly int receiverPlaneCount; //Field offset: 0xA0
	internal readonly IntPtr occlusionBuffer; //Field offset: 0xA4

	internal BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, byte inExclusionSplitMask, int inReceiverPlaneOffset, int inReceiverPlaneCount, IntPtr inOcclusionBuffer) { }

}

