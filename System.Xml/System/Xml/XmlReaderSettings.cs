namespace System.Xml;

public sealed class XmlReaderSettings
{
	private static Nullable<Boolean> s_enableLegacyXmlSettings; //Field offset: 0x0
	private bool useAsync; //Field offset: 0x8
	private XmlNameTable nameTable; //Field offset: 0xC
	private XmlResolver xmlResolver; //Field offset: 0x10
	private int lineNumberOffset; //Field offset: 0x14
	private int linePositionOffset; //Field offset: 0x18
	private ConformanceLevel conformanceLevel; //Field offset: 0x1C
	private bool checkCharacters; //Field offset: 0x20
	private long maxCharactersInDocument; //Field offset: 0x28
	private long maxCharactersFromEntities; //Field offset: 0x30
	private bool ignoreWhitespace; //Field offset: 0x38
	private bool ignorePIs; //Field offset: 0x39
	private bool ignoreComments; //Field offset: 0x3A
	private DtdProcessing dtdProcessing; //Field offset: 0x3C
	private ValidationType validationType; //Field offset: 0x40
	private XmlSchemaValidationFlags validationFlags; //Field offset: 0x44
	private XmlSchemaSet schemas; //Field offset: 0x48
	private ValidationEventHandler valEventHandler; //Field offset: 0x4C
	private bool closeInput; //Field offset: 0x50
	private bool isReadOnly; //Field offset: 0x51
	[CompilerGenerated]
	private bool <IsXmlResolverSet>k__BackingField; //Field offset: 0x52

	public bool Async
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	public bool CheckCharacters
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	public bool CloseInput
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	public ConformanceLevel ConformanceLevel
	{
		 get { } //Length: 11
		 set { } //Length: 130
	}

	public DtdProcessing DtdProcessing
	{
		 get { } //Length: 11
		 set { } //Length: 130
	}

	public bool IgnoreComments
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	public bool IgnoreProcessingInstructions
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	public bool IgnoreWhitespace
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	internal bool IsXmlResolverSet
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public int LineNumberOffset
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	public int LinePositionOffset
	{
		 get { } //Length: 11
		 set { } //Length: 62
	}

	public long MaxCharactersFromEntities
	{
		 get { } //Length: 14
		 set { } //Length: 141
	}

	public long MaxCharactersInDocument
	{
		 get { } //Length: 14
		 set { } //Length: 141
	}

	public XmlNameTable NameTable
	{
		 get { } //Length: 11
		 set { } //Length: 72
	}

	internal bool ReadOnly
	{
		internal set { } //Length: 14
	}

	public XmlSchemaSet Schemas
	{
		 get { } //Length: 87
		 set { } //Length: 72
	}

	public XmlSchemaValidationFlags ValidationFlags
	{
		 get { } //Length: 11
		 set { } //Length: 130
	}

	public ValidationType ValidationType
	{
		 get { } //Length: 11
		 set { } //Length: 130
	}

	public XmlResolver XmlResolver
	{
		 set { } //Length: 76
	}

	public XmlReaderSettings() { }

	internal XmlReader AddValidation(XmlReader reader) { }

	private void CheckReadOnly(string propertyName) { }

	public XmlReaderSettings Clone() { }

	private static XmlResolver CreateDefaultResolver() { }

	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	internal static bool EnableLegacyXmlSettings() { }

	public bool get_Async() { }

	public bool get_CheckCharacters() { }

	public bool get_CloseInput() { }

	public ConformanceLevel get_ConformanceLevel() { }

	public DtdProcessing get_DtdProcessing() { }

	public bool get_IgnoreComments() { }

	public bool get_IgnoreProcessingInstructions() { }

	public bool get_IgnoreWhitespace() { }

	[CompilerGenerated]
	internal bool get_IsXmlResolverSet() { }

	public int get_LineNumberOffset() { }

	public int get_LinePositionOffset() { }

	public long get_MaxCharactersFromEntities() { }

	public long get_MaxCharactersInDocument() { }

	public XmlNameTable get_NameTable() { }

	public XmlSchemaSet get_Schemas() { }

	public XmlSchemaValidationFlags get_ValidationFlags() { }

	public ValidationType get_ValidationType() { }

	internal ValidationEventHandler GetEventHandler() { }

	internal XmlResolver GetXmlResolver() { }

	internal XmlResolver GetXmlResolver_CheckConfig() { }

	private void Initialize(XmlResolver resolver) { }

	private void Initialize() { }

	public void set_Async(bool value) { }

	public void set_CheckCharacters(bool value) { }

	public void set_CloseInput(bool value) { }

	public void set_ConformanceLevel(ConformanceLevel value) { }

	public void set_DtdProcessing(DtdProcessing value) { }

	public void set_IgnoreComments(bool value) { }

	public void set_IgnoreProcessingInstructions(bool value) { }

	public void set_IgnoreWhitespace(bool value) { }

	[CompilerGenerated]
	internal void set_IsXmlResolverSet(bool value) { }

	public void set_LineNumberOffset(int value) { }

	public void set_LinePositionOffset(int value) { }

	public void set_MaxCharactersFromEntities(long value) { }

	public void set_MaxCharactersInDocument(long value) { }

	public void set_NameTable(XmlNameTable value) { }

	internal void set_ReadOnly(bool value) { }

	public void set_Schemas(XmlSchemaSet value) { }

	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	public void set_ValidationType(ValidationType value) { }

	public void set_XmlResolver(XmlResolver value) { }

}

