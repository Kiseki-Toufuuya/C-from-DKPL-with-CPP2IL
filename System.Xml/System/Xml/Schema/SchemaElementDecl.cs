namespace System.Xml.Schema;

internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo
{
	internal static readonly SchemaElementDecl Empty; //Field offset: 0x0
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; //Field offset: 0x40
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; //Field offset: 0x44
	private bool isIdDeclared; //Field offset: 0x48
	private bool hasNonCDataAttribute; //Field offset: 0x49
	private bool isAbstract; //Field offset: 0x4A
	private bool isNillable; //Field offset: 0x4B
	private bool hasRequiredAttribute; //Field offset: 0x4C
	private bool isNotationDeclared; //Field offset: 0x4D
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; //Field offset: 0x50
	private ContentValidator contentValidator; //Field offset: 0x54
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x58
	private XmlSchemaDerivationMethod block; //Field offset: 0x5C
	private CompiledIdentityConstraint[] constraints; //Field offset: 0x60
	private XmlSchemaElement schemaElement; //Field offset: 0x64

	internal XmlSchemaAnyAttribute AnyAttribute
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs
	{
		internal get { } //Length: 11
	}

	internal XmlSchemaDerivationMethod Block
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal CompiledIdentityConstraint[] Constraints
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal ContentValidator ContentValidator
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs
	{
		internal get { } //Length: 11
	}

	internal bool HasDefaultAttribute
	{
		internal get { } //Length: 15
	}

	internal bool HasNonCDataAttribute
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal bool HasRequiredAttribute
	{
		internal get { } //Length: 11
	}

	internal bool IsAbstract
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal bool IsIdDeclared
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal bool IsNillable
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal bool IsNotationDeclared
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes
	{
		internal get { } //Length: 11
	}

	internal XmlSchemaElement SchemaElement
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	private override bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes
	{
		private get { } //Length: 11
	}

	private static SchemaElementDecl() { }

	internal SchemaElementDecl(XmlQualifiedName name, string prefix) { }

	internal SchemaElementDecl() { }

	internal SchemaElementDecl(XmlSchemaDatatype dtype) { }

	internal void AddAttDef(SchemaAttDef attdef) { }

	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	internal SchemaElementDecl Clone() { }

	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	internal XmlSchemaDerivationMethod get_Block() { }

	internal CompiledIdentityConstraint[] get_Constraints() { }

	internal ContentValidator get_ContentValidator() { }

	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	internal bool get_HasDefaultAttribute() { }

	internal bool get_HasNonCDataAttribute() { }

	internal bool get_HasRequiredAttribute() { }

	internal bool get_IsAbstract() { }

	internal bool get_IsIdDeclared() { }

	internal bool get_IsNillable() { }

	internal bool get_IsNotationDeclared() { }

	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	internal XmlSchemaElement get_SchemaElement() { }

	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	internal void set_Block(XmlSchemaDerivationMethod value) { }

	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	internal void set_ContentValidator(ContentValidator value) { }

	internal void set_HasNonCDataAttribute(bool value) { }

	internal void set_IsAbstract(bool value) { }

	internal void set_IsIdDeclared(bool value) { }

	internal void set_IsNillable(bool value) { }

	internal void set_IsNotationDeclared(bool value) { }

	internal void set_SchemaElement(XmlSchemaElement value) { }

	private override bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	private override IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	private override IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

}

