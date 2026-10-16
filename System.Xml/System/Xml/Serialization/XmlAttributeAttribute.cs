namespace System.Xml.Serialization;

[AttributeUsage(10624)]
public class XmlAttributeAttribute : Attribute
{
	private string attributeName; //Field offset: 0x8
	private string dataType; //Field offset: 0xC
	private Type type; //Field offset: 0x10
	private XmlSchemaForm form; //Field offset: 0x14
	private string ns; //Field offset: 0x18

	public string AttributeName
	{
		 get { } //Length: 29
	}

	public string DataType
	{
		 get { } //Length: 29
		 set { } //Length: 27
	}

	public XmlSchemaForm Form
	{
		 get { } //Length: 11
	}

	public string Namespace
	{
		 get { } //Length: 11
	}

	public XmlAttributeAttribute(string attributeName) { }

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_AttributeName() { }

	public string get_DataType() { }

	public XmlSchemaForm get_Form() { }

	public string get_Namespace() { }

	public void set_DataType(string value) { }

}

