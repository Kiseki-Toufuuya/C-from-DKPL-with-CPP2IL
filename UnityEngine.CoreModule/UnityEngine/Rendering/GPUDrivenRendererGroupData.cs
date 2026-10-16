namespace UnityEngine.Rendering;

internal struct GPUDrivenRendererGroupData
{
	public NativeArray<Int32> rendererGroupID; //Field offset: 0x0
	public NativeArray<Bounds> localBounds; //Field offset: 0xC
	public NativeArray<Vector4> lightmapScaleOffset; //Field offset: 0x18
	public NativeArray<Int32> gameObjectLayer; //Field offset: 0x24
	public NativeArray<UInt32> renderingLayerMask; //Field offset: 0x30
	public NativeArray<Int32> lodGroupID; //Field offset: 0x3C
	public NativeArray<Int32> lightmapIndex; //Field offset: 0x48
	public NativeArray<GPUDrivenPackedRendererData> packedRendererData; //Field offset: 0x54
	public NativeArray<Int32> rendererPriority; //Field offset: 0x60
	public NativeArray<Int32> meshIndex; //Field offset: 0x6C
	public NativeArray<Int16> subMeshStartIndex; //Field offset: 0x78
	public NativeArray<Int32> materialsOffset; //Field offset: 0x84
	public NativeArray<Int16> materialsCount; //Field offset: 0x90
	public NativeArray<Int32> instancesOffset; //Field offset: 0x9C
	public NativeArray<Int32> instancesCount; //Field offset: 0xA8
	public NativeArray<GPUDrivenRendererEditorData> editorData; //Field offset: 0xB4
	public NativeArray<Int32> invalidRendererGroupID; //Field offset: 0xC0
	public NativeArray<Matrix4x4> localToWorldMatrix; //Field offset: 0xCC
	public NativeArray<Matrix4x4> prevLocalToWorldMatrix; //Field offset: 0xD8
	public NativeArray<Int32> rendererGroupIndex; //Field offset: 0xE4
	public NativeArray<Int32> meshID; //Field offset: 0xF0
	public NativeArray<Int16> subMeshCount; //Field offset: 0xFC
	public NativeArray<Int32> subMeshDescOffset; //Field offset: 0x108
	public NativeArray<SubMeshDescriptor> subMeshDesc; //Field offset: 0x114
	public NativeArray<Int32> materialIndex; //Field offset: 0x120
	public NativeArray<Int32> materialID; //Field offset: 0x12C
	public NativeArray<GPUDrivenPackedMaterialData> packedMaterialData; //Field offset: 0x138
	public NativeArray<Int32> materialFilterFlags; //Field offset: 0x144

}

