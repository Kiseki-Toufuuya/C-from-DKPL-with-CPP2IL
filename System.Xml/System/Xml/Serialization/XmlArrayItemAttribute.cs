namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = True)]
public class XmlArrayItemAttribute : Attribute
{
	private string dataType; //Field offset: 0x8
	private string elementName; //Field offset: 0xC
	private XmlSchemaForm form; //Field offset: 0x10
	private string ns; //Field offset: 0x14
	private bool isNullable; //Field offset: 0x18
	private bool isNullableSpecified; //Field offset: 0x19
	private int nestingLevel; //Field offset: 0x1C
	private Type type; //Field offset: 0x20

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

	internal bool IsNullableSpecified
	{
		internal get { } //Length: 11
	}

	public string Namespace
	{
		 get { } //Length: 11
	}

	public int NestingLevel
	{
		 get { } //Length: 11
	}

	public Type Type
	{
		 get { } //Length: 11
	}

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_DataType() { }

	public string get_ElementName() { }

	public XmlSchemaForm get_Form() { }

	public bool get_IsNullable() { }

	internal bool get_IsNullableSpecified() { }

	public string get_Namespace() { }

	public int get_NestingLevel() { }

	public Type get_Type() { }

}

