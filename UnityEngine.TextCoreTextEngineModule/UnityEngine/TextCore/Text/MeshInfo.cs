namespace UnityEngine.TextCore.Text;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct MeshInfo
{
	public int vertexCount; //Field offset: 0x0
	public TextCoreVertex[] vertexData; //Field offset: 0x4
	public Material material; //Field offset: 0x8
	[Ignore]
	public int vertexBufferSize; //Field offset: 0xC
	[Ignore]
	public bool applySDF; //Field offset: 0x10
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal GlyphRenderMode glyphRenderMode; //Field offset: 0x14

	public MeshInfo(int size, bool isIMGUI) { }

	internal void Clear(bool uploadChanges) { }

	internal void ClearUnusedVertices() { }

	internal void ResizeMeshInfo(int size, bool isIMGUI) { }

}

