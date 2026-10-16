namespace System.Xml.Serialization;

internal class XmlSerializableMapping : XmlTypeMapping
{
	private XmlSchema _schema; //Field offset: 0x3C
	private XmlSchemaComplexType _schemaType; //Field offset: 0x40
	private XmlQualifiedName _schemaTypeName; //Field offset: 0x44

	internal XmlSerializableMapping(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

}

