namespace MS.Internal.Xml.Cache;

internal sealed class XPathNodeInfoAtom
{
	private string _localName; //Field offset: 0x8
	private string _namespaceUri; //Field offset: 0xC
	private string _prefix; //Field offset: 0x10
	private XPathNode[] _pageParent; //Field offset: 0x14
	private XPathNode[] _pageSibling; //Field offset: 0x18
	private XPathDocument _doc; //Field offset: 0x1C
	private int _lineNumBase; //Field offset: 0x20
	private int _linePosBase; //Field offset: 0x24
	private XPathNodePageInfo _pageInfo; //Field offset: 0x28

	public XPathDocument Document
	{
		 get { } //Length: 11
	}

	public int LineNumberBase
	{
		 get { } //Length: 11
	}

	public int LinePositionBase
	{
		 get { } //Length: 11
	}

	public string LocalName
	{
		 get { } //Length: 11
	}

	public string NamespaceUri
	{
		 get { } //Length: 11
	}

	public XPathNodePageInfo PageInfo
	{
		 get { } //Length: 11
	}

	public XPathNode[] ParentPage
	{
		 get { } //Length: 11
	}

	public string Prefix
	{
		 get { } //Length: 11
	}

	public XPathNode[] SiblingPage
	{
		 get { } //Length: 11
	}

	public XPathDocument get_Document() { }

	public int get_LineNumberBase() { }

	public int get_LinePositionBase() { }

	public string get_LocalName() { }

	public string get_NamespaceUri() { }

	public XPathNodePageInfo get_PageInfo() { }

	public XPathNode[] get_ParentPage() { }

	public string get_Prefix() { }

	public XPathNode[] get_SiblingPage() { }

}

