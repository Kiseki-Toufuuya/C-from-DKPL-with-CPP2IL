namespace System.Xml;

internal class XmlMtomWriter : XmlDictionaryWriter, IXmlMtomWriterInitializer
{
	private static class MimeBoundaryGenerator
	{
		private static long id; //Field offset: 0x0
		private static string prefix; //Field offset: 0x8

		private static MimeBoundaryGenerator() { }

		internal static string Next() { }

	}

	private class MimePart
	{
		internal IList<MtomBinaryData> binaryData; //Field offset: 0x8
		internal string contentID; //Field offset: 0xC
		internal string contentType; //Field offset: 0x10
		internal string contentTransferEncoding; //Field offset: 0x14
		internal int sizeInBytes; //Field offset: 0x18

		internal MimePart(IList<MtomBinaryData> binaryData, string contentID, string contentType, string contentTransferEncoding, int sizeOfBufferedBinaryData, int maxSizeInBytes) { }

		private static int GetSize(string contentID, string contentType, string contentTransferEncoding, int sizeOfBufferedBinaryData, int maxSizeInBytes) { }

	}

	private const int MaxInlinedBytes = 767; //Field offset: 0x0
	private int maxSizeInBytes; //Field offset: 0xC
	private XmlDictionaryWriter writer; //Field offset: 0x10
	private XmlDictionaryWriter infosetWriter; //Field offset: 0x14
	private MimeWriter mimeWriter; //Field offset: 0x18
	private Encoding encoding; //Field offset: 0x1C
	private bool isUTF8; //Field offset: 0x20
	private string contentID; //Field offset: 0x24
	private string contentType; //Field offset: 0x28
	private string initialContentTypeForRootPart; //Field offset: 0x2C
	private string initialContentTypeForMimeMessage; //Field offset: 0x30
	private MemoryStream contentTypeStream; //Field offset: 0x34
	private List<MimePart> mimeParts; //Field offset: 0x38
	private IList<MtomBinaryData> binaryDataChunks; //Field offset: 0x3C
	private int depth; //Field offset: 0x40
	private int totalSizeOfMimeParts; //Field offset: 0x44
	private int sizeOfBufferedBinaryData; //Field offset: 0x48
	private Char[] chars; //Field offset: 0x4C
	private Byte[] bytes; //Field offset: 0x50
	private bool isClosed; //Field offset: 0x54
	private bool ownsStream; //Field offset: 0x55

	private bool IsInitialized
	{
		private get { } //Length: 15
	}

	public virtual XmlWriterSettings Settings
	{
		 get { } //Length: 59
	}

	private XmlDictionaryWriter Writer
	{
		private get { } //Length: 30
	}

	public virtual WriteState WriteState
	{
		 get { } //Length: 59
	}

	public virtual string XmlLang
	{
		 get { } //Length: 59
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 59
	}

	public XmlMtomWriter() { }

	private static string CharSet(Encoding enc) { }

	private void CheckIfEndContentTypeAttribute() { }

	private void CheckIfStartContentTypeAttribute(string localName, string ns) { }

	public virtual void Close() { }

	public virtual void Flush() { }

	public static string GenerateUriForMimePart(int index) { }

	private bool get_IsInitialized() { }

	public virtual XmlWriterSettings get_Settings() { }

	private XmlDictionaryWriter get_Writer() { }

	public virtual WriteState get_WriteState() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	private static string GetBoundaryString() { }

	private static string GetContentTypeForMimeMessage(string boundary, string startUri, string startInfo) { }

	private static string GetContentTypeForRootMimePart(Encoding encoding, string startInfo) { }

	private void Initialize(Stream stream, string startInfo, string boundary, string startUri, bool writeMessageHeaders, bool ownsStream) { }

	private void Initialize() { }

	internal static bool IsUTF8Encoding(Encoding encoding) { }

	public virtual string LookupPrefix(string ns) { }

	public override void SetOutput(Stream stream, Encoding encoding, int maxSizeInBytes, string startInfo, string boundary, string startUri, bool writeMessageHeaders, bool ownsStream) { }

	private void ThrowIfElementIsXOPInclude(string prefix, string localName, string ns) { }

	internal static int ValidateSizeOfMessage(int maxSize, int offset, int size) { }

	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	private void WriteBase64Inline() { }

	private void WriteBase64InlineIfPresent() { }

	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	public virtual void WriteEndDocument() { }

	public virtual void WriteEndElement() { }

	public virtual void WriteEntityRef(string name) { }

	public virtual void WriteFullEndElement() { }

	private void WriteMimeHeaders(string contentID, string contentType, string contentTransferEncoding) { }

	public virtual void WriteName(string name) { }

	public virtual void WriteNmToken(string name) { }

	public virtual void WriteNode(XPathNavigator navigator, bool defattr) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteQualifiedName(string localName, string namespaceUri) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteStartAttribute(string prefix, XmlDictionaryString localName, XmlDictionaryString ns) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartDocument() { }

	public virtual void WriteStartDocument(bool standalone) { }

	public virtual void WriteStartElement(string prefix, XmlDictionaryString localName, XmlDictionaryString ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteString(XmlDictionaryString value) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	protected virtual void WriteTextNode(XmlDictionaryReader reader, bool attribute) { }

	public virtual void WriteValue(XmlDictionaryString value) { }

	public virtual void WriteValue(long value) { }

	public virtual void WriteValue(int value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(object value) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteValue(IStreamProvider value) { }

	public virtual void WriteValue(bool value) { }

	public virtual void WriteWhitespace(string whitespace) { }

	public virtual void WriteXmlnsAttribute(string prefix, string ns) { }

	public virtual void WriteXmlnsAttribute(string prefix, XmlDictionaryString ns) { }

	private void WriteXOPBinaryParts() { }

	private void WriteXOPInclude() { }

}

