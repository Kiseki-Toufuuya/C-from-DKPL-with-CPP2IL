namespace System.Xml;

public class XmlNodeChangedEventArgs : EventArgs
{
	private XmlNodeChangedAction action; //Field offset: 0x8
	private XmlNode node; //Field offset: 0xC
	private XmlNode oldParent; //Field offset: 0x10
	private XmlNode newParent; //Field offset: 0x14
	private string oldValue; //Field offset: 0x18
	private string newValue; //Field offset: 0x1C

	public XmlNodeChangedAction Action
	{
		 get { } //Length: 11
	}

	public XmlNode Node
	{
		 get { } //Length: 11
	}

	public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	public XmlNodeChangedAction get_Action() { }

	public XmlNode get_Node() { }

}

