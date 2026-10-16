namespace System.Xml;

internal abstract class XmlRawWriter : XmlWriter
{
	protected XmlRawWriterBase64Encoder base64Encoder; //Field offset: 0xC
	protected IXmlNamespaceResolver resolver; //Field offset: 0x10

	internal override IXmlNamespaceResolver NamespaceResolver
	{
		internal set { } //Length: 27
	}

	internal override bool SupportsNamespaceDeclarationInChunks
	{
		internal get { } //Length: 3
	}

	public virtual WriteState WriteState
	{
		 get { } //Length: 72
	}

	public virtual string XmlLang
	{
		 get { } //Length: 72
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 72
	}

	protected XmlRawWriter() { }

	internal override void Close(WriteState currentState) { }

	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	public virtual WriteState get_WriteState() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string LookupPrefix(string ns) { }

	internal override void OnRootElement(ConformanceLevel conformanceLevel) { }

	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	internal abstract void StartElementContent() { }

	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual Task WriteBase64Async(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual Task WriteCharEntityAsync(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual Task WriteCharsAsync(Char[] buffer, int index, int count) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	internal override void WriteEndBase64() { }

	internal override Task WriteEndBase64Async() { }

	public virtual void WriteEndDocument() { }

	public virtual void WriteEndElement() { }

	internal abstract void WriteEndElement(string prefix, string localName, string ns) { }

	internal override void WriteEndNamespaceDeclaration() { }

	internal override Task WriteEndNamespaceDeclarationAsync() { }

	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	public virtual void WriteFullEndElement() { }

	public virtual void WriteName(string name) { }

	internal abstract void WriteNamespaceDeclaration(string prefix, string ns) { }

	internal override Task WriteNamespaceDeclarationAsync(string prefix, string ns) { }

	public virtual void WriteNmToken(string name) { }

	public virtual void WriteNode(XPathNavigator navigator, bool defattr) { }

	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	internal override void WriteQualifiedName(string prefix, string localName, string ns) { }

	public virtual void WriteQualifiedName(string localName, string ns) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual Task WriteRawAsync(string data) { }

	public virtual Task WriteRawAsync(Char[] buffer, int index, int count) { }

	public virtual void WriteStartDocument() { }

	public virtual void WriteStartDocument(bool standalone) { }

	public virtual Task WriteStartDocumentAsync() { }

	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	internal override Task WriteStartNamespaceDeclarationAsync(string prefix) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual Task WriteSurrogateCharEntityAsync(char lowChar, char highChar) { }

	public virtual void WriteValue(object value) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteWhitespace(string ws) { }

	public virtual Task WriteWhitespaceAsync(string ws) { }

	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	internal override void WriteXmlDeclaration(string xmldecl) { }

	internal override Task WriteXmlDeclarationAsync(XmlStandalone standalone) { }

}

