namespace UnityEngine.UIElements.UIR;

internal class Entry
{
	public EntryType type; //Field offset: 0x8
	public EntryFlags flags; //Field offset: 0xA
	public NativeSlice<Vertex> vertices; //Field offset: 0xC
	public NativeSlice<UInt16> indices; //Field offset: 0x18
	public Texture texture; //Field offset: 0x24
	public float textScale; //Field offset: 0x28
	public float fontSharpness; //Field offset: 0x2C
	public VectorImage gradientsOwner; //Field offset: 0x30
	public Material material; //Field offset: 0x34
	public Action immediateCallback; //Field offset: 0x38
	public Entry nextSibling; //Field offset: 0x3C
	public Entry firstChild; //Field offset: 0x40
	public Entry lastChild; //Field offset: 0x44

	public Entry() { }

	public void Reset() { }

}

