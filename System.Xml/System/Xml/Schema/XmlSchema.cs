namespace System.Xml.Schema;

[XmlRoot("schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
public class XmlSchema : XmlSchemaObject
{
	private static int globalIdCounter; //Field offset: 0x0
	private XmlSchemaForm attributeFormDefault; //Field offset: 0x20
	private XmlSchemaForm elementFormDefault; //Field offset: 0x24
	private XmlSchemaDerivationMethod blockDefault; //Field offset: 0x28
	private XmlSchemaDerivationMethod finalDefault; //Field offset: 0x2C
	private string targetNs; //Field offset: 0x30
	private string version; //Field offset: 0x34
	private XmlSchemaObjectCollection includes; //Field offset: 0x38
	private XmlSchemaObjectCollection items; //Field offset: 0x3C
	private string id; //Field offset: 0x40
	private XmlAttribute[] moreAttributes; //Field offset: 0x44
	private bool isCompiled; //Field offset: 0x48
	private bool isCompiledBySet; //Field offset: 0x49
	private bool isPreprocessed; //Field offset: 0x4A
	private bool isRedefined; //Field offset: 0x4B
	private int errorCount; //Field offset: 0x4C
	private XmlSchemaObjectTable attributes; //Field offset: 0x50
	private XmlSchemaObjectTable attributeGroups; //Field offset: 0x54
	private XmlSchemaObjectTable elements; //Field offset: 0x58
	private XmlSchemaObjectTable types; //Field offset: 0x5C
	private XmlSchemaObjectTable groups; //Field offset: 0x60
	private XmlSchemaObjectTable notations; //Field offset: 0x64
	private XmlSchemaObjectTable identityConstraints; //Field offset: 0x68
	private ArrayList importedSchemas; //Field offset: 0x6C
	private ArrayList importedNamespaces; //Field offset: 0x70
	private int schemaId; //Field offset: 0x74
	private Uri baseUri; //Field offset: 0x78
	private bool isChameleon; //Field offset: 0x7C
	private Hashtable ids; //Field offset: 0x80
	private XmlDocument document; //Field offset: 0x84

	[DefaultValue(XmlSchemaForm::None (0))]
	[XmlAttribute("attributeFormDefault")]
	public XmlSchemaForm AttributeFormDefault
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups
	{
		 get { } //Length: 87
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Attributes
	{
		 get { } //Length: 87
	}

	[XmlIgnore]
	internal Uri BaseUri
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("blockDefault")]
	public XmlSchemaDerivationMethod BlockDefault
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[XmlIgnore]
	internal XmlDocument Document
	{
		internal get { } //Length: 99
	}

	[DefaultValue(XmlSchemaForm::None (0))]
	[XmlAttribute("elementFormDefault")]
	public XmlSchemaForm ElementFormDefault
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Elements
	{
		 get { } //Length: 87
	}

	[XmlIgnore]
	internal int ErrorCount
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("finalDefault")]
	public XmlSchemaDerivationMethod FinalDefault
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Groups
	{
		 get { } //Length: 11
	}

	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlIgnore]
	internal virtual string IdAttribute
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	[XmlIgnore]
	internal XmlSchemaObjectTable IdentityConstraints
	{
		internal get { } //Length: 11
	}

	[XmlIgnore]
	internal Hashtable Ids
	{
		internal get { } //Length: 14
	}

	internal ArrayList ImportedNamespaces
	{
		internal get { } //Length: 87
	}

	internal ArrayList ImportedSchemas
	{
		internal get { } //Length: 87
	}

	[XmlElement("import", typeof(XmlSchemaImport))]
	[XmlElement("include", typeof(XmlSchemaInclude))]
	[XmlElement("redefine", typeof(XmlSchemaRedefine))]
	public XmlSchemaObjectCollection Includes
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	internal bool IsChameleon
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	[XmlIgnore]
	internal bool IsCompiledBySet
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	[XmlIgnore]
	internal bool IsPreprocessed
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	[XmlIgnore]
	internal bool IsRedefined
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("notation", typeof(XmlSchemaNotation))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection Items
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Notations
	{
		 get { } //Length: 11
	}

	[XmlIgnore]
	internal int SchemaId
	{
		internal get { } //Length: 89
	}

	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes
	{
		 get { } //Length: 509
	}

	[XmlAttribute("targetNamespace", DataType = "anyURI")]
	public string TargetNamespace
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[XmlAttribute("version", DataType = "token")]
	public string Version
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	private static XmlSchema() { }

	public XmlSchema() { }

	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	internal XmlSchema Clone() { }

	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	internal XmlSchema DeepClone() { }

	public XmlSchemaForm get_AttributeFormDefault() { }

	public XmlSchemaObjectTable get_AttributeGroups() { }

	public XmlSchemaObjectTable get_Attributes() { }

	internal Uri get_BaseUri() { }

	public XmlSchemaDerivationMethod get_BlockDefault() { }

	internal XmlDocument get_Document() { }

	public XmlSchemaForm get_ElementFormDefault() { }

	public XmlSchemaObjectTable get_Elements() { }

	internal int get_ErrorCount() { }

	public XmlSchemaDerivationMethod get_FinalDefault() { }

	public XmlSchemaObjectTable get_Groups() { }

	public string get_Id() { }

	internal virtual string get_IdAttribute() { }

	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	internal Hashtable get_Ids() { }

	internal ArrayList get_ImportedNamespaces() { }

	internal ArrayList get_ImportedSchemas() { }

	public XmlSchemaObjectCollection get_Includes() { }

	internal bool get_IsChameleon() { }

	internal bool get_IsCompiledBySet() { }

	internal bool get_IsPreprocessed() { }

	internal bool get_IsRedefined() { }

	public XmlSchemaObjectCollection get_Items() { }

	public XmlSchemaObjectTable get_Notations() { }

	internal int get_SchemaId() { }

	public XmlSchemaObjectTable get_SchemaTypes() { }

	public string get_TargetNamespace() { }

	public string get_Version() { }

	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	internal void set_BaseUri(Uri value) { }

	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	public void set_ElementFormDefault(XmlSchemaForm value) { }

	internal void set_ErrorCount(int value) { }

	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	public void set_Id(string value) { }

	internal virtual void set_IdAttribute(string value) { }

	internal void set_IsChameleon(bool value) { }

	internal void set_IsCompiledBySet(bool value) { }

	internal void set_IsPreprocessed(bool value) { }

	internal void set_IsRedefined(bool value) { }

	public void set_TargetNamespace(string value) { }

	public void set_Version(string value) { }

	internal void SetIsCompiled(bool isCompiled) { }

	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

