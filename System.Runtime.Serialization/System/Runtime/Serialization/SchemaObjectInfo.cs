namespace System.Runtime.Serialization;

internal class SchemaObjectInfo
{
	internal XmlSchemaType type; //Field offset: 0x8
	internal XmlSchemaElement element; //Field offset: 0xC
	internal XmlSchema schema; //Field offset: 0x10
	internal List<XmlSchemaType> knownTypes; //Field offset: 0x14

	internal SchemaObjectInfo(XmlSchemaType type, XmlSchemaElement element, XmlSchema schema, List<XmlSchemaType> knownTypes) { }

}

