namespace System.Xml;

public abstract class XmlWriter : IDisposable
{
	private Char[] writeNodeBuffer; //Field offset: 0x8

	public override XmlWriterSettings Settings
	{
		 get { } //Length: 3
	}

	public abstract WriteState WriteState
	{
		 get { } //Length: 0
	}

	public override string XmlLang
	{
		 get { } //Length: 11
	}

	public override XmlSpace XmlSpace
	{
		 get { } //Length: 6
	}

	protected XmlWriter() { }

	public override void Close() { }

	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public abstract void Flush() { }

	public override XmlWriterSettings get_Settings() { }

	public abstract WriteState get_WriteState() { }

	public override string get_XmlLang() { }

	public override XmlSpace get_XmlSpace() { }

	public abstract string LookupPrefix(string ns) { }

	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	public void WriteAttributeString(string localName, string ns, string value) { }

	public void WriteAttributeString(string localName, string value) { }

	public abstract void WriteBase64(Byte[] buffer, int index, int count) { }

	public override Task WriteBase64Async(Byte[] buffer, int index, int count) { }

	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	public abstract void WriteCData(string text) { }

	public abstract void WriteCharEntity(char ch) { }

	public override Task WriteCharEntityAsync(char ch) { }

	public abstract void WriteChars(Char[] buffer, int index, int count) { }

	public override Task WriteCharsAsync(Char[] buffer, int index, int count) { }

	public abstract void WriteComment(string text) { }

	public abstract void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public void WriteElementString(string localName, string value) { }

	public void WriteElementString(string localName, string ns, string value) { }

	public abstract void WriteEndAttribute() { }

	protected private override Task WriteEndAttributeAsync() { }

	public abstract void WriteEndDocument() { }

	public abstract void WriteEndElement() { }

	public abstract void WriteEntityRef(string name) { }

	public override Task WriteEntityRefAsync(string name) { }

	public abstract void WriteFullEndElement() { }

	private void WriteLocalNamespaces(XPathNavigator nsNav) { }

	public override void WriteName(string name) { }

	public override void WriteNmToken(string name) { }

	public override void WriteNode(XPathNavigator navigator, bool defattr) { }

	public override void WriteNode(XmlReader reader, bool defattr) { }

	public abstract void WriteProcessingInstruction(string name, string text) { }

	public override void WriteQualifiedName(string localName, string ns) { }

	public abstract void WriteRaw(string data) { }

	public abstract void WriteRaw(Char[] buffer, int index, int count) { }

	public override Task WriteRawAsync(string data) { }

	public override Task WriteRawAsync(Char[] buffer, int index, int count) { }

	public void WriteStartAttribute(string localName, string ns) { }

	public abstract void WriteStartAttribute(string prefix, string localName, string ns) { }

	protected private override Task WriteStartAttributeAsync(string prefix, string localName, string ns) { }

	public abstract void WriteStartDocument(bool standalone) { }

	public abstract void WriteStartDocument() { }

	public override Task WriteStartDocumentAsync() { }

	public void WriteStartElement(string localName, string ns) { }

	public void WriteStartElement(string localName) { }

	public abstract void WriteStartElement(string prefix, string localName, string ns) { }

	public abstract void WriteString(string text) { }

	public override Task WriteStringAsync(string text) { }

	public abstract void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public override Task WriteSurrogateCharEntityAsync(char lowChar, char highChar) { }

	public override void WriteValue(long value) { }

	public override void WriteValue(int value) { }

	public override void WriteValue(decimal value) { }

	public override void WriteValue(float value) { }

	public override void WriteValue(double value) { }

	public override void WriteValue(DateTime value) { }

	public override void WriteValue(bool value) { }

	public override void WriteValue(string value) { }

	public override void WriteValue(object value) { }

	public abstract void WriteWhitespace(string ws) { }

	public override Task WriteWhitespaceAsync(string ws) { }

}

