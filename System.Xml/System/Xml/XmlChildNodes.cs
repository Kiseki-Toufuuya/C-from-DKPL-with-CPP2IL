namespace System.Xml;

internal class XmlChildNodes : XmlNodeList
{
	private XmlNode container; //Field offset: 0x8

	public virtual int Count
	{
		 get { } //Length: 85
	}

	public XmlChildNodes(XmlNode container) { }

	public virtual int get_Count() { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual XmlNode Item(int i) { }

}

