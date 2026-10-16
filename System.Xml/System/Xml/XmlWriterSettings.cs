namespace System.Xml;

public sealed class XmlWriterSettings
{
	private bool useAsync; //Field offset: 0x8
	private Encoding encoding; //Field offset: 0xC
	private bool omitXmlDecl; //Field offset: 0x10
	private NewLineHandling newLineHandling; //Field offset: 0x14
	private string newLineChars; //Field offset: 0x18
	private TriState indent; //Field offset: 0x1C
	private string indentChars; //Field offset: 0x20
	private bool newLineOnAttributes; //Field offset: 0x24
	private bool closeOutput; //Field offset: 0x25
	private NamespaceHandling namespaceHandling; //Field offset: 0x28
	private ConformanceLevel conformanceLevel; //Field offset: 0x2C
	private bool checkCharacters; //Field offset: 0x30
	private bool writeEndDocumentOnClose; //Field offset: 0x31
	private XmlOutputMethod outputMethod; //Field offset: 0x34
	private List<XmlQualifiedName> cdataSections; //Field offset: 0x38
	private bool doNotEscapeUriAttributes; //Field offset: 0x3C
	private bool mergeCDataSections; //Field offset: 0x3D
	private string mediaType; //Field offset: 0x40
	private string docTypeSystem; //Field offset: 0x44
	private string docTypePublic; //Field offset: 0x48
	private XmlStandalone standalone; //Field offset: 0x4C
	private bool autoXmlDecl; //Field offset: 0x50
	private bool isReadOnly; //Field offset: 0x51

	public bool Async
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	internal bool AutoXmlDeclaration
	{
		internal get { } //Length: 11
		internal set { } //Length: 62
	}

	internal List<XmlQualifiedName> CDataSectionElements
	{
		internal get { } //Length: 11
	}

	public bool CheckCharacters
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	public bool CloseOutput
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	public ConformanceLevel ConformanceLevel
	{
		 get { } //Length: 11
		 set { } //Length: 130
	}

	internal string DocTypePublic
	{
		internal get { } //Length: 11
		internal set { } //Length: 72
	}

	internal string DocTypeSystem
	{
		internal get { } //Length: 11
		internal set { } //Length: 72
	}

	public bool DoNotEscapeUriAttributes
	{
		 get { } //Length: 11
	}

	public Encoding Encoding
	{
		 get { } //Length: 11
		 set { } //Length: 72
	}

	public bool Indent
	{
		 get { } //Length: 15
		 set { } //Length: 72
	}

	public string IndentChars
	{
		 get { } //Length: 11
		 set { } //Length: 142
	}

	internal TriState IndentInternal
	{
		internal get { } //Length: 11
	}

	internal bool IsQuerySpecific
	{
		internal get { } //Length: 78
	}

	internal string MediaType
	{
		internal get { } //Length: 11
	}

	internal bool MergeCDataSections
	{
		internal get { } //Length: 11
	}

	public NamespaceHandling NamespaceHandling
	{
		 get { } //Length: 11
		 set { } //Length: 130
	}

	public string NewLineChars
	{
		 get { } //Length: 11
		 set { } //Length: 142
	}

	public NewLineHandling NewLineHandling
	{
		 get { } //Length: 11
		 set { } //Length: 130
	}

	public bool NewLineOnAttributes
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	public bool OmitXmlDeclaration
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	public internal XmlOutputMethod OutputMethod
	{
		 get { } //Length: 11
		internal set { } //Length: 14
	}

	internal bool ReadOnly
	{
		internal set { } //Length: 14
	}

	internal XmlStandalone Standalone
	{
		internal get { } //Length: 11
		internal set { } //Length: 62
	}

	public bool WriteEndDocumentOnClose
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	public XmlWriterSettings() { }

	private void CheckReadOnly(string propertyName) { }

	public XmlWriterSettings Clone() { }

	internal XmlWriter CreateWriter(Stream output) { }

	internal XmlWriter CreateWriter(TextWriter output) { }

	public bool get_Async() { }

	internal bool get_AutoXmlDeclaration() { }

	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	public bool get_CheckCharacters() { }

	public bool get_CloseOutput() { }

	public ConformanceLevel get_ConformanceLevel() { }

	internal string get_DocTypePublic() { }

	internal string get_DocTypeSystem() { }

	public bool get_DoNotEscapeUriAttributes() { }

	public Encoding get_Encoding() { }

	public bool get_Indent() { }

	public string get_IndentChars() { }

	internal TriState get_IndentInternal() { }

	internal bool get_IsQuerySpecific() { }

	internal string get_MediaType() { }

	internal bool get_MergeCDataSections() { }

	public NamespaceHandling get_NamespaceHandling() { }

	public string get_NewLineChars() { }

	public NewLineHandling get_NewLineHandling() { }

	public bool get_NewLineOnAttributes() { }

	public bool get_OmitXmlDeclaration() { }

	public XmlOutputMethod get_OutputMethod() { }

	internal XmlStandalone get_Standalone() { }

	public bool get_WriteEndDocumentOnClose() { }

	private void Initialize() { }

	public void set_Async(bool value) { }

	internal void set_AutoXmlDeclaration(bool value) { }

	public void set_CheckCharacters(bool value) { }

	public void set_CloseOutput(bool value) { }

	public void set_ConformanceLevel(ConformanceLevel value) { }

	internal void set_DocTypePublic(string value) { }

	internal void set_DocTypeSystem(string value) { }

	public void set_Encoding(Encoding value) { }

	public void set_Indent(bool value) { }

	public void set_IndentChars(string value) { }

	public void set_NamespaceHandling(NamespaceHandling value) { }

	public void set_NewLineChars(string value) { }

	public void set_NewLineHandling(NewLineHandling value) { }

	public void set_NewLineOnAttributes(bool value) { }

	public void set_OmitXmlDeclaration(bool value) { }

	internal void set_OutputMethod(XmlOutputMethod value) { }

	internal void set_ReadOnly(bool value) { }

	internal void set_Standalone(XmlStandalone value) { }

	public void set_WriteEndDocumentOnClose(bool value) { }

}

