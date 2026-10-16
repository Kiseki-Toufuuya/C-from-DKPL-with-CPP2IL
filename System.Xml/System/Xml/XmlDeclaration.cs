namespace System.Xml;

public class XmlDeclaration : XmlLinkedNode
{
	private string version; //Field offset: 0x10
	private string encoding; //Field offset: 0x14
	private string standalone; //Field offset: 0x18

	public string Encoding
	{
		 get { } //Length: 11
		 set { } //Length: 50
	}

	public virtual string InnerText
	{
		 get { } //Length: 279
		 set { } //Length: 785
	}

	public virtual string LocalName
	{
		 get { } //Length: 28
	}

	public virtual string Name
	{
		 get { } //Length: 35
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public string Standalone
	{
		 get { } //Length: 11
		 set { } //Length: 275
	}

	public virtual string Value
	{
		 get { } //Length: 28
		 set { } //Length: 31
	}

	public internal string Version
	{
		 get { } //Length: 11
		internal set { } //Length: 27
	}

	protected private XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc) { }

	public virtual XmlNode CloneNode(bool deep) { }

	public string get_Encoding() { }

	public virtual string get_InnerText() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public string get_Standalone() { }

	public virtual string get_Value() { }

	public string get_Version() { }

	private bool IsValidXmlVersion(string ver) { }

	public void set_Encoding(string value) { }

	public virtual void set_InnerText(string value) { }

	public void set_Standalone(string value) { }

	public virtual void set_Value(string value) { }

	internal void set_Version(string value) { }

	public virtual void WriteContentTo(XmlWriter w) { }

	public virtual void WriteTo(XmlWriter w) { }

}

