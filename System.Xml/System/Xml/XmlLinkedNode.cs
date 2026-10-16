namespace System.Xml;

public abstract class XmlLinkedNode : XmlNode
{
	internal XmlLinkedNode next; //Field offset: 0xC

	public virtual XmlNode NextSibling
	{
		 get { } //Length: 71
	}

	public virtual XmlNode PreviousSibling
	{
		 get { } //Length: 100
	}

	internal XmlLinkedNode(XmlDocument doc) { }

	public virtual XmlNode get_NextSibling() { }

	public virtual XmlNode get_PreviousSibling() { }

}

