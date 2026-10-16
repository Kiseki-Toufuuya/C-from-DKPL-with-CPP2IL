namespace MS.Internal.Xml.Cache;

internal sealed class XPathNodePageInfo
{
	private int _pageNum; //Field offset: 0x8
	private int _nodeCount; //Field offset: 0xC
	private XPathNode[] _pageNext; //Field offset: 0x10

	public XPathNode[] NextPage
	{
		 get { } //Length: 11
	}

	public int NodeCount
	{
		 get { } //Length: 11
	}

	public int PageNumber
	{
		 get { } //Length: 11
	}

	public XPathNode[] get_NextPage() { }

	public int get_NodeCount() { }

	public int get_PageNumber() { }

}

