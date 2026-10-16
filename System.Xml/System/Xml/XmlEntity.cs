namespace System.Xml;

public class XmlEntity : XmlNode
{
	private string publicId; //Field offset: 0xC
	private string systemId; //Field offset: 0x10
	private string notationName; //Field offset: 0x14
	private string name; //Field offset: 0x18
	private string unparsedReplacementStr; //Field offset: 0x1C
	private string baseURI; //Field offset: 0x20
	private XmlLinkedNode lastChild; //Field offset: 0x24
	private bool childrenFoliating; //Field offset: 0x28

	public virtual string BaseURI
	{
		 get { } //Length: 11
	}

	public virtual string InnerText
	{
		 get { } //Length: 16
		 set { } //Length: 72
	}

	public virtual string InnerXml
	{
		 set { } //Length: 72
	}

	internal virtual bool IsContainer
	{
		internal get { } //Length: 3
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 3
	}

	internal virtual XmlLinkedNode LastNode
	{
		internal get { } //Length: 199
		internal set { } //Length: 27
	}

	public virtual string LocalName
	{
		 get { } //Length: 11
	}

	public virtual string Name
	{
		 get { } //Length: 11
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public string SystemId
	{
		 get { } //Length: 11
	}

	internal XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	public virtual XmlNode CloneNode(bool deep) { }

	public virtual string get_BaseURI() { }

	public virtual string get_InnerText() { }

	internal virtual bool get_IsContainer() { }

	public virtual bool get_IsReadOnly() { }

	internal virtual XmlLinkedNode get_LastNode() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public string get_SystemId() { }

	internal virtual bool IsValidChildType(XmlNodeType type) { }

	public virtual void set_InnerText(string value) { }

	public virtual void set_InnerXml(string value) { }

	internal virtual void set_LastNode(XmlLinkedNode value) { }

	internal void SetBaseURI(string inBaseURI) { }

	public virtual void WriteContentTo(XmlWriter w) { }

	public virtual void WriteTo(XmlWriter w) { }

}

