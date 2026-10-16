namespace System.Xml.Serialization;

public class XmlAttributeEventArgs : EventArgs
{
	private object o; //Field offset: 0x8
	private XmlAttribute attr; //Field offset: 0xC
	private string qnames; //Field offset: 0x10
	private int lineNumber; //Field offset: 0x14
	private int linePosition; //Field offset: 0x18

	internal XmlAttributeEventArgs(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

