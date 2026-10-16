namespace System.Xml.Schema;

public class XmlSchemaType : XmlSchemaAnnotated
{
	private string name; //Field offset: 0x2C
	private XmlSchemaDerivationMethod final; //Field offset: 0x30
	private XmlSchemaDerivationMethod derivedBy; //Field offset: 0x34
	private XmlSchemaType baseSchemaType; //Field offset: 0x38
	private XmlSchemaDatatype datatype; //Field offset: 0x3C
	private XmlSchemaDerivationMethod finalResolved; //Field offset: 0x40
	private SchemaElementDecl elementDecl; //Field offset: 0x44
	private XmlQualifiedName qname; //Field offset: 0x48
	private XmlSchemaType redefined; //Field offset: 0x4C
	private XmlSchemaContentType contentType; //Field offset: 0x50

	[XmlIgnore]
	public XmlSchemaType BaseXmlSchemaType
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	public XmlSchemaDatatype Datatype
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod DerivedBy
	{
		 get { } //Length: 11
	}

	internal SchemaElementDecl ElementDecl
	{
		internal get { } //Length: 20
		internal set { } //Length: 32
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
		 get { } //Length: 11
	}

	[XmlIgnore]
	public override bool IsMixed
	{
		 get { } //Length: 3
		 set { } //Length: 3
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
		 get { } //Length: 20
	}

	[XmlIgnore]
	internal XmlSchemaType Redefined
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal XmlSchemaContentType SchemaContentType
	{
		internal get { } //Length: 11
	}

	[XmlIgnore]
	public XmlTypeCode TypeCode
	{
		 get { } //Length: 158
	}

	[XmlIgnore]
	internal XmlValueConverter ValueConverter
	{
		internal get { } //Length: 98
	}

	public XmlSchemaType() { }

	public XmlSchemaType get_BaseXmlSchemaType() { }

	public XmlSchemaDatatype get_Datatype() { }

	public XmlSchemaDerivationMethod get_DerivedBy() { }

	internal SchemaElementDecl get_ElementDecl() { }

	public XmlSchemaDerivationMethod get_Final() { }

	public XmlSchemaDerivationMethod get_FinalResolved() { }

	public override bool get_IsMixed() { }

	public string get_Name() { }

	internal virtual string get_NameAttribute() { }

	public XmlQualifiedName get_QualifiedName() { }

	internal XmlSchemaType get_Redefined() { }

	internal XmlSchemaContentType get_SchemaContentType() { }

	public XmlTypeCode get_TypeCode() { }

	internal XmlValueConverter get_ValueConverter() { }

	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	internal void set_ElementDecl(SchemaElementDecl value) { }

	public void set_Final(XmlSchemaDerivationMethod value) { }

	public override void set_IsMixed(bool value) { }

	public void set_Name(string value) { }

	internal virtual void set_NameAttribute(string value) { }

	internal void set_Redefined(XmlSchemaType value) { }

	internal void SetBaseSchemaType(XmlSchemaType value) { }

	internal void SetContentType(XmlSchemaContentType value) { }

	internal void SetDatatype(XmlSchemaDatatype value) { }

	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	internal void SetQualifiedName(XmlQualifiedName value) { }

}

