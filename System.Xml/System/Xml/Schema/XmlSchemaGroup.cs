namespace System.Xml.Schema;

public class XmlSchemaGroup : XmlSchemaAnnotated
{
	private string name; //Field offset: 0x2C
	private XmlSchemaGroupBase particle; //Field offset: 0x30
	private XmlSchemaParticle canonicalParticle; //Field offset: 0x34
	private XmlQualifiedName qname; //Field offset: 0x38
	private XmlSchemaGroup redefined; //Field offset: 0x3C
	private int selfReferenceCount; //Field offset: 0x40

	[XmlIgnore]
	internal XmlSchemaParticle CanonicalParticle
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlAttribute("name")]
	public string Name
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlIgnore]
	internal virtual string NameAttribute
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaGroupBase Particle
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	internal XmlSchemaGroup Redefined
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlIgnore]
	internal int SelfReferenceCount
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	public XmlSchemaGroup() { }

	internal virtual XmlSchemaObject Clone() { }

	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	internal XmlSchemaParticle get_CanonicalParticle() { }

	public string get_Name() { }

	internal virtual string get_NameAttribute() { }

	public XmlSchemaGroupBase get_Particle() { }

	public XmlQualifiedName get_QualifiedName() { }

	internal XmlSchemaGroup get_Redefined() { }

	internal int get_SelfReferenceCount() { }

	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	public void set_Name(string value) { }

	internal virtual void set_NameAttribute(string value) { }

	public void set_Particle(XmlSchemaGroupBase value) { }

	internal void set_Redefined(XmlSchemaGroup value) { }

	internal void set_SelfReferenceCount(int value) { }

	internal void SetQualifiedName(XmlQualifiedName value) { }

}

