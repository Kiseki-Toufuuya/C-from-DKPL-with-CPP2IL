namespace System.Xml;

internal class XmlElementList : XmlNodeList
{
	private string asterisk; //Field offset: 0x8
	private int changeCount; //Field offset: 0xC
	private string name; //Field offset: 0x10
	private string localName; //Field offset: 0x14
	private string namespaceURI; //Field offset: 0x18
	private XmlNode rootNode; //Field offset: 0x1C
	private int curInd; //Field offset: 0x20
	private XmlNode curElem; //Field offset: 0x24
	private bool empty; //Field offset: 0x28
	private bool atomized; //Field offset: 0x29
	private int matchCount; //Field offset: 0x2C
	private WeakReference listener; //Field offset: 0x30

	internal int ChangeCount
	{
		internal get { } //Length: 11
	}

	public virtual int Count
	{
		 get { } //Length: 256
	}

	private XmlElementList(XmlNode parent) { }

	internal XmlElementList(XmlNode parent, string name) { }

	internal void ConcurrencyCheck(XmlNodeChangedEventArgs args) { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	internal int get_ChangeCount() { }

	public virtual int get_Count() { }

	public virtual IEnumerator GetEnumerator() { }

	private XmlNode GetMatchingNode(XmlNode n, bool bNext) { }

	public XmlNode GetNextNode(XmlNode n) { }

	private XmlNode GetNthMatchingNode(XmlNode n, bool bNext, int nCount) { }

	private bool IsMatch(XmlNode curNode) { }

	public virtual XmlNode Item(int index) { }

	private XmlNode NextElemInPreOrder(XmlNode curNode) { }

	private XmlNode PrevElemInPreOrder(XmlNode curNode) { }

	protected virtual void PrivateDisposeNodeList() { }

}

