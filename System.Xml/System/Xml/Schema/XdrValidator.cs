namespace System.Xml.Schema;

internal sealed class XdrValidator : BaseValidator
{
	private HWStack validationStack; //Field offset: 0x40
	private Hashtable attPresence; //Field offset: 0x44
	private XmlQualifiedName name; //Field offset: 0x48
	private XmlNamespaceManager nsManager; //Field offset: 0x4C
	private bool isProcessContents; //Field offset: 0x50
	private Hashtable IDs; //Field offset: 0x54
	private IdRefNode idRefListHead; //Field offset: 0x58
	private Parser inlineSchemaParser; //Field offset: 0x5C

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

	internal XdrValidator(BaseValidator validator) { }

	internal XdrValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	internal void AddID(string name, object node) { }

	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	private void CheckForwardRefs() { }

	private void CheckValue(string value, SchemaAttDef attdef) { }

	public virtual void CompleteValidation() { }

	public virtual object FindId(string name) { }

	private bool get_HasSchema() { }

	private bool get_IsInlineSchemaStarted() { }

	public virtual bool get_PreserveWhitespace() { }

	private void Init() { }

	private void LoadSchema(string uri) { }

	private void LoadSchemaFromLocation(string uri) { }

	private void Pop() { }

	private void ProcessElement() { }

	private void ProcessInlineSchema() { }

	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	private void Push(XmlQualifiedName elementName) { }

	private XmlQualifiedName QualifiedName(string name, string ns) { }

	private SchemaElementDecl ThoroughGetElementDecl() { }

	public virtual void Validate() { }

	private void ValidateChildElement() { }

	private void ValidateElement() { }

	private void ValidateEndElement() { }

	private void ValidateEndStartElement() { }

	private void ValidateStartElement() { }

}

