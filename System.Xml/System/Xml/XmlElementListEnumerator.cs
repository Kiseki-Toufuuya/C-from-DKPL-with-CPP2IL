namespace System.Xml;

internal class XmlElementListEnumerator : IEnumerator
{
	private XmlElementList list; //Field offset: 0x8
	private XmlNode curElem; //Field offset: 0xC
	private int changeCount; //Field offset: 0x10

	public override object Current
	{
		 get { } //Length: 11
	}

	public XmlElementListEnumerator(XmlElementList list) { }

	public override object get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

}

