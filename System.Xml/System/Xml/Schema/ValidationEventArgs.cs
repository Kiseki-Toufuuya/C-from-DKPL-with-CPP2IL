namespace System.Xml.Schema;

public class ValidationEventArgs : EventArgs
{
	private XmlSchemaException ex; //Field offset: 0x8
	private XmlSeverityType severity; //Field offset: 0xC

	public XmlSchemaException Exception
	{
		 get { } //Length: 11
	}

	public XmlSeverityType Severity
	{
		 get { } //Length: 11
	}

	internal ValidationEventArgs(XmlSchemaException ex) { }

	internal ValidationEventArgs(XmlSchemaException ex, XmlSeverityType severity) { }

	public XmlSchemaException get_Exception() { }

	public XmlSeverityType get_Severity() { }

}

