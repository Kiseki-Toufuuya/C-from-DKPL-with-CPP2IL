namespace System.Xml.Schema;

public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
{
	private string name; //Field offset: 0x2C
	private XmlSchemaObjectCollection attributes; //Field offset: 0x30
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x34
	private XmlQualifiedName qname; //Field offset: 0x38
	private XmlSchemaAttributeGroup redefined; //Field offset: 0x3C
	private XmlSchemaObjectTable attributeUses; //Field offset: 0x40
	private XmlSchemaAnyAttribute attributeWildcard; //Field offset: 0x44
	private int selfReferenceCount; //Field offset: 0x48

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

	[XmlIgnore]
	internal XmlSchemaObjectTable AttributeUses
	{
		internal get { } //Length: 87
	}

	[XmlIgnore]
	internal XmlSchemaAnyAttribute AttributeWildcard
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

	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	internal XmlSchemaAttributeGroup Redefined
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlIgnore]
	public XmlSchemaAttributeGroup RedefinedAttributeGroup
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	internal int SelfReferenceCount
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	public XmlSchemaAttributeGroup() { }

	internal virtual XmlSchemaObject Clone() { }

	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	public XmlSchemaObjectCollection get_Attributes() { }

	internal XmlSchemaObjectTable get_AttributeUses() { }

	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	public string get_Name() { }

	internal virtual string get_NameAttribute() { }

	public XmlQualifiedName get_QualifiedName() { }

	internal XmlSchemaAttributeGroup get_Redefined() { }

	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	internal int get_SelfReferenceCount() { }

	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	public void set_Name(string value) { }

	internal virtual void set_NameAttribute(string value) { }

	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	internal void set_SelfReferenceCount(int value) { }

	internal void SetQualifiedName(XmlQualifiedName value) { }

}

