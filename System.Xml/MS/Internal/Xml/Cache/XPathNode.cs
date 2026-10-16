namespace MS.Internal.Xml.Cache;

internal struct XPathNode
{
	private XPathNodeInfoAtom _info; //Field offset: 0x0
	private ushort _idxSibling; //Field offset: 0x4
	private ushort _idxParent; //Field offset: 0x6
	private ushort _idxSimilar; //Field offset: 0x8
	private ushort _posOffset; //Field offset: 0xA
	private uint _props; //Field offset: 0xC
	private string _value; //Field offset: 0x10

	public bool AllowShortcutTag
	{
		 get { } //Length: 18
	}

	public int CollapsedLinePosition
	{
		 get { } //Length: 32
	}

	public XPathDocument Document
	{
		 get { } //Length: 22
	}

	public bool HasAttribute
	{
		 get { } //Length: 15
	}

	public bool HasCollapsedText
	{
		 get { } //Length: 18
	}

	public bool HasContentChild
	{
		 get { } //Length: 15
	}

	public bool HasNamespaceDecls
	{
		 get { } //Length: 18
	}

	public bool HasSibling
	{
		 get { } //Length: 16
	}

	public bool IsAttrNmsp
	{
		 get { } //Length: 29
	}

	public bool IsText
	{
		 get { } //Length: 76
	}

	public bool IsXmlNamespaceNode
	{
		 get { } //Length: 92
	}

	public int LineNumber
	{
		 get { } //Length: 33
	}

	public int LinePosition
	{
		 get { } //Length: 26
	}

	public string LocalName
	{
		 get { } //Length: 22
	}

	public string NamespaceUri
	{
		 get { } //Length: 22
	}

	public XPathNodeType NodeType
	{
		 get { } //Length: 14
	}

	public XPathNodePageInfo PageInfo
	{
		 get { } //Length: 22
	}

	public string Prefix
	{
		 get { } //Length: 22
	}

	public string Value
	{
		 get { } //Length: 11
	}

	public bool get_AllowShortcutTag() { }

	public int get_CollapsedLinePosition() { }

	public XPathDocument get_Document() { }

	public bool get_HasAttribute() { }

	public bool get_HasCollapsedText() { }

	public bool get_HasContentChild() { }

	public bool get_HasNamespaceDecls() { }

	public bool get_HasSibling() { }

	public bool get_IsAttrNmsp() { }

	public bool get_IsText() { }

	public bool get_IsXmlNamespaceNode() { }

	public int get_LineNumber() { }

	public int get_LinePosition() { }

	public string get_LocalName() { }

	public string get_NamespaceUri() { }

	public XPathNodeType get_NodeType() { }

	public XPathNodePageInfo get_PageInfo() { }

	public string get_Prefix() { }

	public string get_Value() { }

	public int GetParent(out XPathNode[] pageNode) { }

	public int GetSibling(out XPathNode[] pageNode) { }

}

