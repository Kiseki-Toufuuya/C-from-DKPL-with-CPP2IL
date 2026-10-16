namespace System.Xml.Schema;

internal class XsdSimpleValue
{
	private XmlSchemaSimpleType xmlType; //Field offset: 0x8
	private object typedValue; //Field offset: 0xC

	public object TypedValue
	{
		 get { } //Length: 11
	}

	public XmlSchemaSimpleType XmlType
	{
		 get { } //Length: 11
	}

	public XsdSimpleValue(XmlSchemaSimpleType st, object value) { }

	public object get_TypedValue() { }

	public XmlSchemaSimpleType get_XmlType() { }

}

