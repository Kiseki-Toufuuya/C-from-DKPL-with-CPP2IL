namespace System.Xml;

public class XmlProcessingInstruction : XmlLinkedNode
{
	private string target; //Field offset: 0x10
	private string data; //Field offset: 0x14

	public string Data
	{
		 set { } //Length: 144
	}

	public virtual string InnerText
	{
		 get { } //Length: 11
		 set { } //Length: 16
	}

	public virtual string LocalName
	{
		 get { } //Length: 28
	}

	public virtual string Name
	{
		 get { } //Length: 29
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public virtual string Value
	{
		 get { } //Length: 11
		 set { } //Length: 16
	}

	internal virtual string XPLocalName
	{
		internal get { } //Length: 28
	}

	internal virtual XPathNodeType XPNodeType
	{
		internal get { } //Length: 6
	}

	protected private XmlProcessingInstruction(string target, string data, XmlDocument doc) { }

	public virtual XmlNode CloneNode(bool deep) { }

	public virtual string get_InnerText() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Value() { }

	internal virtual string get_XPLocalName() { }

	internal virtual XPathNodeType get_XPNodeType() { }

	public void set_Data(string value) { }

	public virtual void set_InnerText(string value) { }

	public virtual void set_Value(string value) { }

	public virtual void WriteContentTo(XmlWriter w) { }

	public virtual void WriteTo(XmlWriter w) { }

}

