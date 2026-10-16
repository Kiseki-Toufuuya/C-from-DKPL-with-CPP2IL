namespace System.Xml.Serialization;

[AttributeUsage(1052)]
public class XmlTypeAttribute : Attribute
{
	private bool includeInSchema; //Field offset: 0x8
	private string ns; //Field offset: 0xC
	private string typeName; //Field offset: 0x10

	public bool IncludeInSchema
	{
		 get { } //Length: 11
	}

	public string Namespace
	{
		 get { } //Length: 11
	}

	public string TypeName
	{
		 get { } //Length: 29
	}

	internal void AddKeyHash(StringBuilder sb) { }

	public bool get_IncludeInSchema() { }

	public string get_Namespace() { }

	public string get_TypeName() { }

}

