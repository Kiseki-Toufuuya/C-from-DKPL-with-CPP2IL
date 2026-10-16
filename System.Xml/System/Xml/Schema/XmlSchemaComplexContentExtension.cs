namespace System.Xml.Schema;

public class XmlSchemaComplexContentExtension : XmlSchemaContent
{
	private XmlSchemaParticle particle; //Field offset: 0x2C
	private XmlSchemaObjectCollection attributes; //Field offset: 0x30
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x34
	private XmlQualifiedName baseTypeName; //Field offset: 0x38

	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes
	{
		 get { } //Length: 11
	}

	[XmlAttribute("base")]
	public XmlQualifiedName BaseTypeName
	{
		 get { } //Length: 11
		 set { } //Length: 135
	}

	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public XmlSchemaParticle Particle
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlSchemaComplexContentExtension() { }

	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	public XmlSchemaObjectCollection get_Attributes() { }

	public XmlQualifiedName get_BaseTypeName() { }

	public XmlSchemaParticle get_Particle() { }

	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	public void set_BaseTypeName(XmlQualifiedName value) { }

	public void set_Particle(XmlSchemaParticle value) { }

	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

}

