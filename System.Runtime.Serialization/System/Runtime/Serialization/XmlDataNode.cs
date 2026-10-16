namespace System.Runtime.Serialization;

internal class XmlDataNode : DataNode<Object>
{
	private IList<XmlAttribute> xmlAttributes; //Field offset: 0x28
	private IList<XmlNode> xmlChildNodes; //Field offset: 0x2C
	private XmlDocument ownerDocument; //Field offset: 0x30

	internal XmlDocument OwnerDocument
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal IList<XmlAttribute> XmlAttributes
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal IList<XmlNode> XmlChildNodes
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal XmlDataNode() { }

	public virtual void Clear() { }

	internal XmlDocument get_OwnerDocument() { }

	internal IList<XmlAttribute> get_XmlAttributes() { }

	internal IList<XmlNode> get_XmlChildNodes() { }

	internal void set_OwnerDocument(XmlDocument value) { }

	internal void set_XmlAttributes(IList<XmlAttribute> value) { }

	internal void set_XmlChildNodes(IList<XmlNode> value) { }

}

