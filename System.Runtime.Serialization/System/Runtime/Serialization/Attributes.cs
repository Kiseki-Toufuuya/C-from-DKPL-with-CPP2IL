namespace System.Runtime.Serialization;

internal class Attributes
{
	private static XmlDictionaryString[] serializationLocalNames; //Field offset: 0x0
	private static XmlDictionaryString[] schemaInstanceLocalNames; //Field offset: 0x4
	internal string Id; //Field offset: 0x8
	internal string Ref; //Field offset: 0xC
	internal string XsiTypeName; //Field offset: 0x10
	internal string XsiTypeNamespace; //Field offset: 0x14
	internal string XsiTypePrefix; //Field offset: 0x18
	internal bool XsiNil; //Field offset: 0x1C
	internal string ClrAssembly; //Field offset: 0x20
	internal string ClrType; //Field offset: 0x24
	internal int ArraySZSize; //Field offset: 0x28
	internal string FactoryTypeName; //Field offset: 0x2C
	internal string FactoryTypeNamespace; //Field offset: 0x30
	internal string FactoryTypePrefix; //Field offset: 0x34
	internal bool UnrecognizedAttributesFound; //Field offset: 0x38

	private static Attributes() { }

	public Attributes() { }

	internal void Read(XmlReaderDelegator reader) { }

	private void ReadArraySize(XmlReaderDelegator reader) { }

	private void ReadFactoryType(XmlReaderDelegator reader) { }

	private void ReadId(XmlReaderDelegator reader) { }

	private void ReadRef(XmlReaderDelegator reader) { }

	private void ReadXsiNil(XmlReaderDelegator reader) { }

	private void ReadXsiType(XmlReaderDelegator reader) { }

	internal void Reset() { }

}

