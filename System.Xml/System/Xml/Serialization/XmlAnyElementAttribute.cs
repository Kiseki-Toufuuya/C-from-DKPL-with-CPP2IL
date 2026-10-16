namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = True)]
public class XmlAnyElementAttribute : Attribute
{
	private string elementName; //Field offset: 0x8
	private string ns; //Field offset: 0xC
	private int order; //Field offset: 0x10

	public string Name
	{
		 get { } //Length: 29
	}

	public string Namespace
	{
		 get { } //Length: 11
	}

	public int Order
	{
		 get { } //Length: 11
	}

	public XmlAnyElementAttribute() { }

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_Name() { }

	public string get_Namespace() { }

	public int get_Order() { }

}

