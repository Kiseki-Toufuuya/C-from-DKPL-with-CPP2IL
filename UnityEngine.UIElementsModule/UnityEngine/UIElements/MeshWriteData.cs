namespace UnityEngine.UIElements;

public class MeshWriteData
{
	internal NativeSlice<Vertex> m_Vertices; //Field offset: 0x8
	internal NativeSlice<UInt16> m_Indices; //Field offset: 0x14
	internal int currentIndex; //Field offset: 0x20
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int currentVertex; //Field offset: 0x24

	internal MeshWriteData() { }

}

