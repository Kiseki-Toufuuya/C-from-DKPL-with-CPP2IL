namespace System.Xml.Schema;

public class XmlSchemaElement : XmlSchemaParticle
{
	private bool isAbstract; //Field offset: 0x58
	private bool hasAbstractAttribute; //Field offset: 0x59
	private bool isNillable; //Field offset: 0x5A
	private bool hasNillableAttribute; //Field offset: 0x5B
	private bool isLocalTypeDerivationChecked; //Field offset: 0x5C
	private XmlSchemaDerivationMethod block; //Field offset: 0x60
	private XmlSchemaDerivationMethod final; //Field offset: 0x64
	private XmlSchemaForm form; //Field offset: 0x68
	private string defaultValue; //Field offset: 0x6C
	private string fixedValue; //Field offset: 0x70
	private string name; //Field offset: 0x74
	private XmlQualifiedName refName; //Field offset: 0x78
	private XmlQualifiedName substitutionGroup; //Field offset: 0x7C
	private XmlQualifiedName typeName; //Field offset: 0x80
	private XmlSchemaType type; //Field offset: 0x84
	private XmlQualifiedName qualifiedName; //Field offset: 0x88
	private XmlSchemaType elementType; //Field offset: 0x8C
	private XmlSchemaDerivationMethod blockResolved; //Field offset: 0x90
	private XmlSchemaDerivationMethod finalResolved; //Field offset: 0x94
	private XmlSchemaObjectCollection constraints; //Field offset: 0x98
	private SchemaElementDecl elementDecl; //Field offset: 0x9C

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("block")]
	public XmlSchemaDerivationMethod Block
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved
	{
		 get { } //Length: 14
	}

	[XmlElement("key", typeof(XmlSchemaKey))]
	[XmlElement("keyref", typeof(XmlSchemaKeyref))]
	[XmlElement("unique", typeof(XmlSchemaUnique))]
	public XmlSchemaObjectCollection Constraints
	{
		 get { } //Length: 99
	}

	[DefaultValue(null)]
	[XmlAttribute("default")]
	public string DefaultValue
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	internal SchemaElementDecl ElementDecl
	{
		internal get { } //Length: 14
		internal set { } //Length: 33
	}

	[XmlIgnore]
	public XmlSchemaType ElementSchemaType
	{
		 get { } //Length: 14
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("final")]
	public XmlSchemaDerivationMethod Final
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved
	{
		 get { } //Length: 14
	}

	[DefaultValue(null)]
	[XmlAttribute("fixed")]
	public string FixedValue
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[DefaultValue(XmlSchemaForm::None (0))]
	[XmlAttribute("form")]
	public XmlSchemaForm Form
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[XmlIgnore]
	internal bool HasAbstractAttribute
	{
		internal get { } //Length: 11
	}

	internal bool HasConstraints
	{
		internal get { } //Length: 42
	}

	[XmlIgnore]
	internal bool HasNillableAttribute
	{
		internal get { } //Length: 11
	}

	[DefaultValue(False)]
	[XmlAttribute("abstract")]
	public bool IsAbstract
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	internal bool IsLocalTypeDerivationChecked
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	[DefaultValue(False)]
	[XmlAttribute("nillable")]
	public bool IsNillable
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	[DefaultValue(null)]
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
	internal virtual string NameString
	{
		internal get { } //Length: 43
	}

	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		 get { } //Length: 14
	}

	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		 get { } //Length: 11
		 set { } //Length: 135
	}

	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	public XmlSchemaType SchemaType
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	[XmlAttribute("type")]
	public XmlQualifiedName SchemaTypeName
	{
		 get { } //Length: 14
		 set { } //Length: 138
	}

	[XmlAttribute("substitutionGroup")]
	public XmlQualifiedName SubstitutionGroup
	{
		 get { } //Length: 11
		 set { } //Length: 135
	}

	public XmlSchemaElement() { }

	internal virtual XmlSchemaObject Clone() { }

	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	public XmlSchemaDerivationMethod get_Block() { }

	public XmlSchemaDerivationMethod get_BlockResolved() { }

	public XmlSchemaObjectCollection get_Constraints() { }

	public string get_DefaultValue() { }

	internal SchemaElementDecl get_ElementDecl() { }

	public XmlSchemaType get_ElementSchemaType() { }

	public XmlSchemaDerivationMethod get_Final() { }

	public XmlSchemaDerivationMethod get_FinalResolved() { }

	public string get_FixedValue() { }

	public XmlSchemaForm get_Form() { }

	internal bool get_HasAbstractAttribute() { }

	internal bool get_HasConstraints() { }

	internal bool get_HasNillableAttribute() { }

	public bool get_IsAbstract() { }

	internal bool get_IsLocalTypeDerivationChecked() { }

	public bool get_IsNillable() { }

	public string get_Name() { }

	internal virtual string get_NameAttribute() { }

	internal virtual string get_NameString() { }

	public XmlQualifiedName get_QualifiedName() { }

	public XmlQualifiedName get_RefName() { }

	public XmlSchemaType get_SchemaType() { }

	public XmlQualifiedName get_SchemaTypeName() { }

	public XmlQualifiedName get_SubstitutionGroup() { }

	public void set_Block(XmlSchemaDerivationMethod value) { }

	public void set_DefaultValue(string value) { }

	internal void set_ElementDecl(SchemaElementDecl value) { }

	public void set_Final(XmlSchemaDerivationMethod value) { }

	public void set_FixedValue(string value) { }

	public void set_Form(XmlSchemaForm value) { }

	public void set_IsAbstract(bool value) { }

	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	public void set_IsNillable(bool value) { }

	public void set_Name(string value) { }

	internal virtual void set_NameAttribute(string value) { }

	public void set_RefName(XmlQualifiedName value) { }

	public void set_SchemaType(XmlSchemaType value) { }

	public void set_SchemaTypeName(XmlQualifiedName value) { }

	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	internal void SetElementType(XmlSchemaType value) { }

	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	internal void SetQualifiedName(XmlQualifiedName value) { }

}

