namespace UnityEngine.Rendering;

internal struct GPUDrivenLODGroupData
{
	public NativeArray<Int32> lodGroupID; //Field offset: 0x0
	public NativeArray<Int32> lodOffset; //Field offset: 0xC
	public NativeArray<Int32> lodCount; //Field offset: 0x18
	public NativeArray<LODFadeMode> fadeMode; //Field offset: 0x24
	public NativeArray<Vector3> worldSpaceReferencePoint; //Field offset: 0x30
	public NativeArray<Single> worldSpaceSize; //Field offset: 0x3C
	public NativeArray<Int16> renderersCount; //Field offset: 0x48
	public NativeArray<Boolean> lastLODIsBillboard; //Field offset: 0x54
	public NativeArray<Byte> forceLODMask; //Field offset: 0x60
	public NativeArray<Int32> invalidLODGroupID; //Field offset: 0x6C
	public NativeArray<Int16> lodRenderersCount; //Field offset: 0x78
	public NativeArray<Single> lodScreenRelativeTransitionHeight; //Field offset: 0x84
	public NativeArray<Single> lodFadeTransitionWidth; //Field offset: 0x90

}

