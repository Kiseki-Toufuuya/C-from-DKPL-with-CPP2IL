namespace System.Xml.Schema;

public class XmlSchemaAttribute : XmlSchemaAnnotated
{
	private string defaultValue; //Field offset: 0x2C
	private string fixedValue; //Field offset: 0x30
	private string name; //Field offset: 0x34
	private XmlSchemaForm form; //Field offset: 0x38
	private XmlSchemaUse use; //Field offset: 0x3C
	private XmlQualifiedName refName; //Field offset: 0x40
	private XmlQualifiedName typeName; //Field offset: 0x44
	private XmlQualifiedName qualifiedName; //Field offset: 0x48
	private XmlSchemaSimpleType type; //Field offset: 0x4C
	private XmlSchemaSimpleType attributeType; //Field offset: 0x50
	private SchemaAttDef attDef; //Field offset: 0x54

	internal SchemaAttDef AttDef
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlIgnore]
	public XmlSchemaSimpleType AttributeSchemaType
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	internal XmlSchemaDatatype Datatype
	{
		internal get { } //Length: 24
	}

	[DefaultValue(null)]
	[XmlAttribute("default")]
	public string DefaultValue
	{
		 get { } //Length: 11
		 set { } //Length: 27
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

	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		 get { } //Length: 11
		 set { } //Length: 135
	}

	[XmlElement("simpleType")]
	public XmlSchemaSimpleType SchemaType
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlAttribute("type")]
	public XmlQualifiedName SchemaTypeName
	{
		 get { } //Length: 11
		 set { } //Length: 135
	}

	[DefaultValue(XmlSchemaUse::None (0))]
	[XmlAttribute("use")]
	public XmlSchemaUse Use
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public XmlSchemaAttribute() { }

	internal virtual XmlSchemaObject Clone() { }

	internal SchemaAttDef get_AttDef() { }

	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	internal XmlSchemaDatatype get_Datatype() { }

	public string get_DefaultValue() { }

	public string get_FixedValue() { }

	public XmlSchemaForm get_Form() { }

	public string get_Name() { }

	internal virtual string get_NameAttribute() { }

	public XmlQualifiedName get_QualifiedName() { }

	public XmlQualifiedName get_RefName() { }

	public XmlSchemaSimpleType get_SchemaType() { }

	public XmlQualifiedName get_SchemaTypeName() { }

	public XmlSchemaUse get_Use() { }

	internal void set_AttDef(SchemaAttDef value) { }

	public void set_DefaultValue(string value) { }

	public void set_FixedValue(string value) { }

	public void set_Form(XmlSchemaForm value) { }

	public void set_Name(string value) { }

	internal virtual void set_NameAttribute(string value) { }

	public void set_RefName(XmlQualifiedName value) { }

	public void set_SchemaType(XmlSchemaSimpleType value) { }

	public void set_SchemaTypeName(XmlQualifiedName value) { }

	public void set_Use(XmlSchemaUse value) { }

	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	internal void SetQualifiedName(XmlQualifiedName value) { }

}

