namespace System.Xml.Linq;

public class XAttribute : XObject
{
	internal XAttribute next; //Field offset: 0x10
	internal XName name; //Field offset: 0x14
	internal string value; //Field offset: 0x18

	public bool IsNamespaceDeclaration
	{
		 get { } //Length: 112
	}

	public XName Name
	{
		 get { } //Length: 11
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public string Value
	{
		 get { } //Length: 11
	}

	public XAttribute(XName name, object value) { }

	public XAttribute(XAttribute other) { }

	public bool get_IsNamespaceDeclaration() { }

	public XName get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public string get_Value() { }

	internal string GetPrefixOfNamespace(XNamespace ns) { }

	public virtual string ToString() { }

	private static void ValidateAttribute(XName name, string value) { }

}

