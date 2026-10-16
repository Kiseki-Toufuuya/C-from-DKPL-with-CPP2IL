namespace UnityEngine.Rendering;

[UsedByNativeCode]
internal struct GPUDrivenLODGroupDataNative
{
	public Int32* lodGroupID; //Field offset: 0x0
	public Int32* lodOffset; //Field offset: 0x4
	public Int32* lodCount; //Field offset: 0x8
	public LODFadeMode* fadeMode; //Field offset: 0xC
	public Vector3* worldSpaceReferencePoint; //Field offset: 0x10
	public Single* worldSpaceSize; //Field offset: 0x14
	public Int16* renderersCount; //Field offset: 0x18
	public Boolean* lastLODIsBillboard; //Field offset: 0x1C
	public Byte* forceLODMask; //Field offset: 0x20
	public int lodGroupCount; //Field offset: 0x24
	public Int32* invalidLODGroupID; //Field offset: 0x28
	public int invalidLODGroupCount; //Field offset: 0x2C
	public Int16* lodRenderersCount; //Field offset: 0x30
	public Single* lodScreenRelativeTransitionHeight; //Field offset: 0x34
	public Single* lodFadeTransitionWidth; //Field offset: 0x38
	public int lodDataCount; //Field offset: 0x3C

}

