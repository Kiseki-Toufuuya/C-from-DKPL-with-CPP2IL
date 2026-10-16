namespace System.Xml.Serialization;

internal class XmlTypeSerializationSource : SerializationSource
{
	private string attributeOverridesHash; //Field offset: 0x14
	private Type type; //Field offset: 0x18
	private string rootHash; //Field offset: 0x1C

	public XmlTypeSerializationSource(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	public virtual bool Equals(object o) { }

	public virtual int GetHashCode() { }

}

