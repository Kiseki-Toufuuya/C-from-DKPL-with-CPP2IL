namespace System.Xml.Schema;

internal class XmlUnionConverter : XmlBaseConverter
{
	private XmlValueConverter[] converters; //Field offset: 0x14
	private bool hasAtomicMember; //Field offset: 0x18
	private bool hasListMember; //Field offset: 0x19

	protected XmlUnionConverter(XmlSchemaType schemaType) { }

	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

}

