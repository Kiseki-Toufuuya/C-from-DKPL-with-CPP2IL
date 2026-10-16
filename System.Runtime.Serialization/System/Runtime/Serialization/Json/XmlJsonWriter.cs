namespace System.Runtime.Serialization.Json;

internal class XmlJsonWriter : XmlDictionaryWriter, IXmlJsonWriterInitializer
{
	private enum JsonDataType
	{
		None = 0,
		Null = 1,
		Boolean = 2,
		Number = 3,
		String = 4,
		Object = 5,
		Array = 6,
	}

	private class JsonNodeWriter : XmlUTF8NodeWriter
	{

		public JsonNodeWriter() { }

		internal void WriteChars(Char* chars, int charCount) { }

	}

	[Flags]
	private enum NameState
	{
		None = 0,
		IsWritingNameWithMapping = 1,
		IsWritingNameAttribute = 2,
		WrittenNameWithMapping = 4,
	}

	private const char BACK_SLASH = '\u5C'; //Field offset: 0x0
	private const char FORWARD_SLASH = '\u2F'; //Field offset: 0x0
	private const char HIGH_SURROGATE_START = '\uD800'; //Field offset: 0x0
	private const char LOW_SURROGATE_END = '\uDFFF'; //Field offset: 0x0
	private const char MAX_CHAR = '\uFFFE'; //Field offset: 0x0
	private const char WHITESPACE = '\u20'; //Field offset: 0x0
	private const char CARRIAGE_RETURN = '\uD'; //Field offset: 0x0
	private const char NEWLINE = '\uA'; //Field offset: 0x0
	private const char BACKSPACE = '\u8'; //Field offset: 0x0
	private const char FORM_FEED = '\uC'; //Field offset: 0x0
	private const char HORIZONTAL_TABULATION = '\u9'; //Field offset: 0x0
	private const string xmlNamespace = "http://www.w3.org/XML/1998/namespace"; //Field offset: 0x0
	private const string xmlnsNamespace = "http://www.w3.org/2000/xmlns/"; //Field offset: 0x0
	private static BinHexEncoding binHexEncoding; //Field offset: 0x0
	private static Char[] CharacterAbbrevs; //Field offset: 0x4
	private string attributeText; //Field offset: 0xC
	private JsonDataType dataType; //Field offset: 0x10
	private int depth; //Field offset: 0x14
	private bool endElementBuffer; //Field offset: 0x18
	private bool isWritingDataTypeAttribute; //Field offset: 0x19
	private bool isWritingServerTypeAttribute; //Field offset: 0x1A
	private bool isWritingXmlnsAttribute; //Field offset: 0x1B
	private bool isWritingXmlnsAttributeDefaultNs; //Field offset: 0x1C
	private NameState nameState; //Field offset: 0x20
	private JsonNodeType nodeType; //Field offset: 0x24
	private JsonNodeWriter nodeWriter; //Field offset: 0x28
	private JsonNodeType[] scopes; //Field offset: 0x2C
	private string serverTypeValue; //Field offset: 0x30
	private WriteState writeState; //Field offset: 0x34
	private bool wroteServerTypeAttribute; //Field offset: 0x38
	private bool indent; //Field offset: 0x39
	private string indentChars; //Field offset: 0x3C
	private int indentLevel; //Field offset: 0x40

	private static BinHexEncoding BinHexEncoding
	{
		private get { } //Length: 115
	}

	private bool HasOpenAttribute
	{
		private get { } //Length: 37
	}

	private bool IsClosed
	{
		private get { } //Length: 34
	}

	private bool IsWritingCollection
	{
		private get { } //Length: 50
	}

	private bool IsWritingNameAttribute
	{
		private get { } //Length: 15
	}

	private bool IsWritingNameWithMapping
	{
		private get { } //Length: 13
	}

	public virtual XmlWriterSettings Settings
	{
		 get { } //Length: 3
	}

	public virtual WriteState WriteState
	{
		 get { } //Length: 120
	}

	private bool WrittenNameWithMapping
	{
		private get { } //Length: 16
	}

	public virtual string XmlLang
	{
		 get { } //Length: 3
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 3
	}

	public XmlJsonWriter() { }

	public XmlJsonWriter(bool indent, string indentChars) { }

	internal static bool CharacterNeedsEscaping(char ch) { }

	private void CheckText(JsonNodeType nextNodeType) { }

	public virtual void Close() { }

	private void EnterScope(JsonNodeType currentNodeType) { }

	private JsonNodeType ExitScope() { }

	public virtual void Flush() { }

	private static BinHexEncoding get_BinHexEncoding() { }

	private bool get_HasOpenAttribute() { }

	private bool get_IsClosed() { }

	private bool get_IsWritingCollection() { }

	private bool get_IsWritingNameAttribute() { }

	private bool get_IsWritingNameWithMapping() { }

	public virtual XmlWriterSettings get_Settings() { }

	public virtual WriteState get_WriteState() { }

	private bool get_WrittenNameWithMapping() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	private static Char[] GetCharacterAbbrevs() { }

	private void InitializeWriter() { }

	private static bool IsUnicodeNewlineCharacter(char c) { }

	public virtual string LookupPrefix(string ns) { }

	public override void SetOutput(Stream stream, Encoding encoding, bool ownsStream) { }

	private void StartText() { }

	private static void ThrowClosed() { }

	private void ThrowIfServerTypeWritten(string dataTypeSpecified) { }

	private void ThrowInvalidAttributeContent() { }

	private static bool TryEscapeControlCharacter(char ch, out char abbrev) { }

	private bool TrySetWritingNameWithMapping(string localName, string ns) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Guid[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, DateTime[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, TimeSpan[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int16[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Double[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int32[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Boolean[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Int16[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Int32[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Int64[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Single[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Double[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Decimal[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, DateTime[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Guid[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int64[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Decimal[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, TimeSpan[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Boolean[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Single[] array, int offset, int count) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	private void WriteDataTypeServerType() { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	public virtual void WriteEndDocument() { }

	public virtual void WriteEndElement() { }

	public virtual void WriteEntityRef(string name) { }

	private void WriteEscapedJsonString(string str) { }

	public virtual void WriteFullEndElement() { }

	private void WriteIndent() { }

	private void WriteJsonElementName(string localName) { }

	private void WriteJsonQuote() { }

	private void WriteNewLine() { }

	private void WritePrimitiveValue(object value) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteQualifiedName(string localName, string ns) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	private void WriteServerTypeAttribute() { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartDocument(bool standalone) { }

	public virtual void WriteStartDocument() { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	private void WriteValue(ulong value) { }

	public virtual void WriteValue(decimal value) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(float value) { }

	public virtual void WriteValue(int value) { }

	public virtual void WriteValue(long value) { }

	public virtual void WriteValue(Guid value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(bool value) { }

	private void WriteValue(Array array) { }

	public virtual void WriteValue(UniqueId value) { }

	public virtual void WriteValue(object value) { }

	public virtual void WriteValue(TimeSpan value) { }

	public virtual void WriteWhitespace(string ws) { }

	public virtual void WriteXmlAttribute(string localName, string value) { }

	public virtual void WriteXmlAttribute(XmlDictionaryString localName, XmlDictionaryString value) { }

	public virtual void WriteXmlnsAttribute(string prefix, string namespaceUri) { }

	public virtual void WriteXmlnsAttribute(string prefix, XmlDictionaryString namespaceUri) { }

}

