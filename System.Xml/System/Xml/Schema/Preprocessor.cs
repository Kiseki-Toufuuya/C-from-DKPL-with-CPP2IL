namespace System.Xml.Schema;

internal sealed class Preprocessor : BaseProcessor
{
	private static XmlSchema builtInSchemaForXmlNS; //Field offset: 0x0
	private string Xmlns; //Field offset: 0x20
	private string NsXsi; //Field offset: 0x24
	private string targetNamespace; //Field offset: 0x28
	private XmlSchema rootSchema; //Field offset: 0x2C
	private XmlSchema currentSchema; //Field offset: 0x30
	private XmlSchemaForm elementFormDefault; //Field offset: 0x34
	private XmlSchemaForm attributeFormDefault; //Field offset: 0x38
	private XmlSchemaDerivationMethod blockDefault; //Field offset: 0x3C
	private XmlSchemaDerivationMethod finalDefault; //Field offset: 0x40
	private Hashtable schemaLocations; //Field offset: 0x44
	private Hashtable chameleonSchemas; //Field offset: 0x48
	private Hashtable referenceNamespaces; //Field offset: 0x4C
	private Hashtable processedExternals; //Field offset: 0x50
	private SortedList lockList; //Field offset: 0x54
	private XmlReaderSettings readerSettings; //Field offset: 0x58
	private XmlSchema rootSchemaForRedefine; //Field offset: 0x5C
	private ArrayList redefinedList; //Field offset: 0x60
	private XmlResolver xmlResolver; //Field offset: 0x64

	internal Hashtable ChameleonSchemas
	{
		internal set { } //Length: 27
	}

	internal XmlReaderSettings ReaderSettings
	{
		internal set { } //Length: 27
	}

	internal XmlSchema RootSchema
	{
		internal get { } //Length: 11
	}

	internal Hashtable SchemaLocations
	{
		internal set { } //Length: 27
	}

	internal XmlResolver XmlResolver
	{
		internal set { } //Length: 27
	}

	public Preprocessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	private void BuildRefNamespaces(XmlSchema schema) { }

	private void BuildSchemaList(XmlSchema schema) { }

	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	private void Cleanup(XmlSchema schema) { }

	private void CleanupRedefine(XmlSchemaExternal include) { }

	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	internal XmlSchema get_RootSchema() { }

	internal static XmlSchema GetBuildInSchema() { }

	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	private object GetSchemaEntity(Uri ruri) { }

	private void LoadExternals(XmlSchema schema) { }

	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }

	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	private void PreprocessElement(XmlSchemaElement element) { }

	private void PreprocessElementContent(XmlSchemaElement element) { }

	private void PreprocessGroup(XmlSchemaGroup group) { }

	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	private void PreprocessLocalElement(XmlSchemaElement element) { }

	private void PreprocessNotation(XmlSchemaNotation notation) { }

	private void PreprocessParticle(XmlSchemaParticle particle) { }

	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	internal void set_ChameleonSchemas(Hashtable value) { }

	internal void set_ReaderSettings(XmlReaderSettings value) { }

	internal void set_SchemaLocations(Hashtable value) { }

	internal void set_XmlResolver(XmlResolver value) { }

	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	private void SetSchemaDefaults(XmlSchema schema) { }

	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

}

