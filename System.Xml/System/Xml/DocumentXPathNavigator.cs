namespace System.Xml;

internal sealed class DocumentXPathNavigator : XPathNavigator
{
	private XmlDocument document; //Field offset: 0x8
	private XmlNode source; //Field offset: 0xC
	private int attributeIndex; //Field offset: 0x10
	private XmlElement namespaceParent; //Field offset: 0x14

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 113
	}

	public virtual string LocalName
	{
		 get { } //Length: 40
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 187
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 30
	}

	public virtual XPathNodeType NodeType
	{
		 get { } //Length: 53
	}

	public virtual string Prefix
	{
		 get { } //Length: 187
	}

	public virtual IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 40
	}

	public virtual object UnderlyingObject
	{
		 get { } //Length: 24
	}

	public virtual string Value
	{
		 get { } //Length: 468
	}

	private string ValueDocument
	{
		private get { } //Length: 69
	}

	private string ValueText
	{
		private get { } //Length: 270
	}

	public DocumentXPathNavigator(XmlDocument document, XmlNode node) { }

	public DocumentXPathNavigator(DocumentXPathNavigator other) { }

	private void CalibrateText() { }

	private static bool CheckAttributePosition(XmlAttribute attribute, out XmlAttributeCollection attributes, int index) { }

	public virtual XPathNavigator Clone() { }

	private XmlNode FirstChild(XmlNode node) { }

	private XmlNode FirstChildTail(XmlNode child) { }

	public virtual bool get_IsEmptyElement() { }

	public virtual string get_LocalName() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XPathNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	public virtual object get_UnderlyingObject() { }

	public virtual string get_Value() { }

	private string get_ValueDocument() { }

	private string get_ValueText() { }

	public virtual bool IsSamePosition(XPathNavigator other) { }

	private static bool IsValidChild(XmlNode parent, XmlNode child) { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToFirstChild() { }

	public virtual bool MoveToFirstNamespace(XPathNamespaceScope scope) { }

	private static bool MoveToFirstNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index) { }

	private static bool MoveToFirstNamespaceLocal(XmlAttributeCollection attributes, ref int index) { }

	public virtual bool MoveToNamespace(string name) { }

	public virtual bool MoveToNext() { }

	public virtual bool MoveToNextAttribute() { }

	public virtual bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	private static bool MoveToNextNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index) { }

	private static bool MoveToNextNamespaceLocal(XmlAttributeCollection attributes, ref int index) { }

	public virtual bool MoveToParent() { }

	private XmlNode NextSibling(XmlNode node) { }

	private XmlNode NextSiblingTail(XmlNode node, XmlNode sibling) { }

	private XmlNode ParentNode(XmlNode node) { }

	private XmlNode ParentNodeTail(XmlNode parent) { }

	private bool PathHasDuplicateNamespace(XmlElement top, XmlElement bottom, string localName) { }

	private XmlNode PreviousText(XmlNode node) { }

	private XmlNode PreviousTextTail(XmlNode node, XmlNode text) { }

	private static bool ResetAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, out int index) { }

	internal void ResetPosition(XmlNode node) { }

	private XmlNode TextEnd(XmlNode node) { }

}

