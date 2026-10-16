namespace System.Xml.Schema;

public class XmlSchemaGroupRef : XmlSchemaParticle
{
	private XmlQualifiedName refName; //Field offset: 0x58
	private XmlSchemaGroupBase particle; //Field offset: 0x5C
	private XmlSchemaGroup refined; //Field offset: 0x60

	[XmlIgnore]
	public XmlSchemaGroupBase Particle
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	internal XmlSchemaGroup Redefined
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		 get { } //Length: 11
		 set { } //Length: 135
	}

	public XmlSchemaGroupRef() { }

	public XmlSchemaGroupBase get_Particle() { }

	internal XmlSchemaGroup get_Redefined() { }

	public XmlQualifiedName get_RefName() { }

	internal void set_Redefined(XmlSchemaGroup value) { }

	public void set_RefName(XmlQualifiedName value) { }

	internal void SetParticle(XmlSchemaGroupBase value) { }

}

