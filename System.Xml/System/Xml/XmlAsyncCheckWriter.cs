namespace System.Xml;

internal class XmlAsyncCheckWriter : XmlWriter
{
	private readonly XmlWriter coreWriter; //Field offset: 0xC
	private Task lastTask; //Field offset: 0x10

	public virtual XmlWriterSettings Settings
	{
		 get { } //Length: 137
	}

	public virtual WriteState WriteState
	{
		 get { } //Length: 53
	}

	public virtual string XmlLang
	{
		 get { } //Length: 53
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 53
	}

	public XmlAsyncCheckWriter(XmlWriter writer) { }

	private void CheckAsync() { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public virtual XmlWriterSettings get_Settings() { }

	public virtual WriteState get_WriteState() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string LookupPrefix(string ns) { }

	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual Task WriteBase64Async(Byte[] buffer, int index, int count) { }

	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual Task WriteCharEntityAsync(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual Task WriteCharsAsync(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	protected private virtual Task WriteEndAttributeAsync() { }

	public virtual void WriteEndDocument() { }

	public virtual void WriteEndElement() { }

	public virtual void WriteEntityRef(string name) { }

	public virtual Task WriteEntityRefAsync(string name) { }

	public virtual void WriteFullEndElement() { }

	public virtual void WriteName(string name) { }

	public virtual void WriteNmToken(string name) { }

	public virtual void WriteNode(XPathNavigator navigator, bool defattr) { }

	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteQualifiedName(string localName, string ns) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual Task WriteRawAsync(Char[] buffer, int index, int count) { }

	public virtual Task WriteRawAsync(string data) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	protected private virtual Task WriteStartAttributeAsync(string prefix, string localName, string ns) { }

	public virtual void WriteStartDocument() { }

	public virtual void WriteStartDocument(bool standalone) { }

	public virtual Task WriteStartDocumentAsync() { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual Task WriteStringAsync(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual Task WriteSurrogateCharEntityAsync(char lowChar, char highChar) { }

	public virtual void WriteValue(long value) { }

	public virtual void WriteValue(int value) { }

	public virtual void WriteValue(decimal value) { }

	public virtual void WriteValue(float value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(bool value) { }

	public virtual void WriteValue(object value) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteWhitespace(string ws) { }

	public virtual Task WriteWhitespaceAsync(string ws) { }

}

