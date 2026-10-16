namespace System.Xml.Schema;

public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
{
	private XmlQualifiedName refer; //Field offset: 0x40

	[XmlAttribute("refer")]
	public XmlQualifiedName Refer
	{
		 get { } //Length: 11
		 set { } //Length: 135
	}

	public XmlSchemaKeyref() { }

	public XmlQualifiedName get_Refer() { }

	public void set_Refer(XmlQualifiedName value) { }

}

