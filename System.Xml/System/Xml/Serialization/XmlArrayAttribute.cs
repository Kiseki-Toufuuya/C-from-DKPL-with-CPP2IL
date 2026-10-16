namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = False)]
public class XmlArrayAttribute : Attribute
{
	private string elementName; //Field offset: 0x8
	private XmlSchemaForm form; //Field offset: 0xC
	private bool isNullable; //Field offset: 0x10
	private string ns; //Field offset: 0x14
	private int order; //Field offset: 0x18

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

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_ElementName() { }

	public XmlSchemaForm get_Form() { }

	public bool get_IsNullable() { }

	public string get_Namespace() { }

	public int get_Order() { }

}

