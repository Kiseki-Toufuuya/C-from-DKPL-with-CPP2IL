namespace System.Runtime.Serialization;

internal class AttributeData
{
	public string prefix; //Field offset: 0x8
	public string ns; //Field offset: 0xC
	public string localName; //Field offset: 0x10
	public string value; //Field offset: 0x14

	public AttributeData() { }

}

