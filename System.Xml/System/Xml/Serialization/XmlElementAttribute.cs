namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = True)]
public class XmlElementAttribute : Attribute
{
	private string dataType; //Field offset: 0x8
	private string elementName; //Field offset: 0xC
	private XmlSchemaForm form; //Field offset: 0x10
	private string ns; //Field offset: 0x14
	private bool isNullable; //Field offset: 0x18
	private Type type; //Field offset: 0x1C
	private int order; //Field offset: 0x20

	public string DataType
	{
		 get { } //Length: 29
	}

	public string ElementName
	{
		 get { } //Length: 29
	}

	public XmlSchemaForm Form
	{
		 get { } //Length: 11
	}

	public bool IsNullable
	{
		 get { } //Length: 11
	}

	public string Namespace
	{
		 get { } //Length: 11
	}

	public int Order
	{
		 get { } //Length: 11
	}

	public Type Type
	{
		 get { } //Length: 11
	}

	public XmlElementAttribute(string elementName) { }

	public XmlElementAttribute(string elementName, Type type) { }

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_DataType() { }

	public string get_ElementName() { }

	public XmlSchemaForm get_Form() { }

	public bool get_IsNullable() { }

	public string get_Namespace() { }

	public int get_Order() { }

	public Type get_Type() { }

}

