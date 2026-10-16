namespace UnityEngine.Rendering;

[UsedByNativeCode]
internal struct GPUDrivenRendererGroupDataNative
{
	public Int32* rendererGroupID; //Field offset: 0x0
	public Bounds* localBounds; //Field offset: 0x4
	public Vector4* lightmapScaleOffset; //Field offset: 0x8
	public Int32* gameObjectLayer; //Field offset: 0xC
	public UInt32* renderingLayerMask; //Field offset: 0x10
	public Int32* lodGroupID; //Field offset: 0x14
	public MotionVectorGenerationMode* motionVecGenMode; //Field offset: 0x18
	public GPUDrivenPackedRendererData* packedRendererData; //Field offset: 0x1C
	public Int32* rendererPriority; //Field offset: 0x20
	public Int32* meshIndex; //Field offset: 0x24
	public Int16* subMeshStartIndex; //Field offset: 0x28
	public Int32* materialsOffset; //Field offset: 0x2C
	public Int16* materialsCount; //Field offset: 0x30
	public Int32* instancesOffset; //Field offset: 0x34
	public Int32* instancesCount; //Field offset: 0x38
	public GPUDrivenRendererEditorData* editorData; //Field offset: 0x3C
	public int rendererGroupCount; //Field offset: 0x40
	public Int32* invalidRendererGroupID; //Field offset: 0x44
	public int invalidRendererGroupIDCount; //Field offset: 0x48
	public Matrix4x4* localToWorldMatrix; //Field offset: 0x4C
	public Matrix4x4* prevLocalToWorldMatrix; //Field offset: 0x50
	public Int32* rendererGroupIndex; //Field offset: 0x54
	public int instanceCount; //Field offset: 0x58
	public Int32* meshID; //Field offset: 0x5C
	public Int16* subMeshCount; //Field offset: 0x60
	public Int32* subMeshDescOffset; //Field offset: 0x64
	public int meshCount; //Field offset: 0x68
	public SubMeshDescriptor* subMeshDesc; //Field offset: 0x6C
	public int subMeshDescCount; //Field offset: 0x70
	public Int32* materialIndex; //Field offset: 0x74
	public int materialIndexCount; //Field offset: 0x78
	public Int32* materialID; //Field offset: 0x7C
	public GPUDrivenPackedMaterialData* packedMaterialData; //Field offset: 0x80
	public Int32* materialFilterFlags; //Field offset: 0x84
	public int materialCount; //Field offset: 0x88

}

