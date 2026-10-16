namespace System.Xml;

public class XmlDocumentType : XmlLinkedNode
{
	private string name; //Field offset: 0x10
	private string publicId; //Field offset: 0x14
	private string systemId; //Field offset: 0x18
	private string internalSubset; //Field offset: 0x1C
	private bool namespaces; //Field offset: 0x20
	private XmlNamedNodeMap entities; //Field offset: 0x24
	private XmlNamedNodeMap notations; //Field offset: 0x28
	private SchemaInfo schemaInfo; //Field offset: 0x2C

	internal SchemaInfo DtdSchemaInfo
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	public XmlNamedNodeMap Entities
	{
		 get { } //Length: 100
	}

	public string InternalSubset
	{
		 get { } //Length: 11
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 3
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

	public XmlNamedNodeMap Notations
	{
		 get { } //Length: 100
	}

	internal bool ParseWithNamespaces
	{
		internal get { } //Length: 11
	}

	public string PublicId
	{
		 get { } //Length: 11
	}

	public string SystemId
	{
		 get { } //Length: 11
	}

	protected private XmlDocumentType(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	public virtual XmlNode CloneNode(bool deep) { }

	internal SchemaInfo get_DtdSchemaInfo() { }

	public XmlNamedNodeMap get_Entities() { }

	public string get_InternalSubset() { }

	public virtual bool get_IsReadOnly() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public XmlNamedNodeMap get_Notations() { }

	internal bool get_ParseWithNamespaces() { }

	public string get_PublicId() { }

	public string get_SystemId() { }

	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	public virtual void WriteContentTo(XmlWriter w) { }

	public virtual void WriteTo(XmlWriter w) { }

}

