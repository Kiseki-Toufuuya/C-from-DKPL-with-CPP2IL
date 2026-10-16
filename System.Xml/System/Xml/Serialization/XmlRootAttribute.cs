namespace System.Xml.Serialization;

[AttributeUsage(9244)]
public class XmlRootAttribute : Attribute
{
	private string dataType; //Field offset: 0x8
	private string elementName; //Field offset: 0xC
	private bool isNullable; //Field offset: 0x10
	private string ns; //Field offset: 0x14

	public string DataType
	{
		 get { } //Length: 29
		 set { } //Length: 27
	}

	public string ElementName
	{
		 get { } //Length: 29
		 set { } //Length: 27
	}

	public bool IsNullable
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string Namespace
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlRootAttribute() { }

	public XmlRootAttribute(string elementName) { }

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_DataType() { }

	public string get_ElementName() { }

	public bool get_IsNullable() { }

	public string get_Namespace() { }

	public void set_DataType(string value) { }

	public void set_ElementName(string value) { }

	public void set_IsNullable(bool value) { }

	public void set_Namespace(string value) { }

}

