namespace System.Xml.Schema;

internal sealed class XsdValidator : BaseValidator
{
	private static readonly XmlSchemaDatatype dtCDATA; //Field offset: 0x0
	private static readonly XmlSchemaDatatype dtQName; //Field offset: 0x4
	private static readonly XmlSchemaDatatype dtStringArray; //Field offset: 0x8
	private int startIDConstraint; //Field offset: 0x40
	private HWStack validationStack; //Field offset: 0x44
	private Hashtable attPresence; //Field offset: 0x48
	private XmlNamespaceManager nsManager; //Field offset: 0x4C
	private bool bManageNamespaces; //Field offset: 0x50
	private Hashtable IDs; //Field offset: 0x54
	private IdRefNode idRefListHead; //Field offset: 0x58
	private Parser inlineSchemaParser; //Field offset: 0x5C
	private XmlSchemaContentProcessing processContents; //Field offset: 0x60
	private string NsXmlNs; //Field offset: 0x64
	private string NsXs; //Field offset: 0x68
	private string NsXsi; //Field offset: 0x6C
	private string XsiType; //Field offset: 0x70
	private string XsiNil; //Field offset: 0x74
	private string XsiSchemaLocation; //Field offset: 0x78
	private string XsiNoNamespaceSchemaLocation; //Field offset: 0x7C
	private string XsdSchema; //Field offset: 0x80

	private bool HasIdentityConstraints
	{
		private get { } //Length: 15
	}

	private bool HasSchema
	{
		private get { } //Length: 27
	}

	private bool IsInlineSchemaStarted
	{
		private get { } //Length: 15
	}

	public virtual bool PreserveWhitespace
	{
		 get { } //Length: 54
	}

	private static XsdValidator() { }

	internal XsdValidator(BaseValidator validator) { }

	internal XsdValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	internal void AddID(string name, object node) { }

	private void AddIdentityConstraints() { }

	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	private void CheckForwardRefs() { }

	private void CheckValue(string value, SchemaAttDef attdef) { }

	public virtual void CompleteValidation() { }

	private void ElementIdentityConstraints() { }

	private void EndElementIdentityConstraints() { }

	private SchemaElementDecl FastGetElementDecl(object particle) { }

	public virtual object FindId(string name) { }

	private bool get_HasIdentityConstraints() { }

	private bool get_HasSchema() { }

	private bool get_IsInlineSchemaStarted() { }

	public virtual bool get_PreserveWhitespace() { }

	private void Init() { }

	public bool IsXSDRoot(string localName, string ns) { }

	private void LoadSchema(string uri, string url) { }

	private void LoadSchemaFromLocation(string uri, string url) { }

	private void Pop() { }

	private void ProcessElement(object particle) { }

	private void ProcessInlineSchema() { }

	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	private void Push(XmlQualifiedName elementName) { }

	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	private object UnWrapUnion(object typedValue) { }

	public virtual void Validate() { }

	private object ValidateChildElement() { }

	private void ValidateElement() { }

	private void ValidateEndElement() { }

	private void ValidateEndStartElement() { }

	private void ValidateStartElement() { }

	private void ValidateStartElementIdentityConstraints() { }

}

