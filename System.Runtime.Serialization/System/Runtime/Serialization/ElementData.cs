namespace System.Runtime.Serialization;

internal class ElementData
{
	public string localName; //Field offset: 0x8
	public string ns; //Field offset: 0xC
	public string prefix; //Field offset: 0x10
	public int attributeCount; //Field offset: 0x14
	public AttributeData[] attributes; //Field offset: 0x18
	public IDataNode dataNode; //Field offset: 0x1C
	public int childElementIndex; //Field offset: 0x20

	public ElementData() { }

	public void AddAttribute(string prefix, string ns, string name, string value) { }

	private void GrowAttributesIfNeeded() { }

}

