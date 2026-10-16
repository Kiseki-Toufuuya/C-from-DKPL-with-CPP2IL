namespace System.Xml.Serialization;

public class XmlNodeEventArgs : EventArgs
{
	private object o; //Field offset: 0x8
	private XmlNode xmlNode; //Field offset: 0xC
	private int lineNumber; //Field offset: 0x10
	private int linePosition; //Field offset: 0x14

	internal XmlNodeEventArgs(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

