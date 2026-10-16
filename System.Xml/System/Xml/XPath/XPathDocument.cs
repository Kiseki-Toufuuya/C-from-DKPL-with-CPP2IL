namespace System.Xml.XPath;

public class XPathDocument
{
	private XPathNode[] pageText; //Field offset: 0x8
	private XPathNode[] pageXmlNmsp; //Field offset: 0xC
	private int idxText; //Field offset: 0x10
	private int idxXmlNmsp; //Field offset: 0x14
	private XmlNameTable nameTable; //Field offset: 0x18
	private bool hasLineInfo; //Field offset: 0x1C
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; //Field offset: 0x20

	internal bool HasLineInfo
	{
		internal get { } //Length: 11
	}

	internal XmlNameTable NameTable
	{
		internal get { } //Length: 11
	}

	internal bool get_HasLineInfo() { }

	internal XmlNameTable get_NameTable() { }

	internal int GetCollapsedTextNode(out XPathNode[] pageText) { }

	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

}

