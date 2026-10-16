namespace UnityEngine.UIElements.UIR;

internal class MeshHandle : LinkedPoolItem<MeshHandle>
{
	internal Alloc allocVerts; //Field offset: 0xC
	internal Alloc allocIndices; //Field offset: 0x1C
	internal uint triangleCount; //Field offset: 0x2C
	internal Page allocPage; //Field offset: 0x30
	internal uint allocTime; //Field offset: 0x34
	internal uint updateAllocID; //Field offset: 0x38

	public MeshHandle() { }

}

