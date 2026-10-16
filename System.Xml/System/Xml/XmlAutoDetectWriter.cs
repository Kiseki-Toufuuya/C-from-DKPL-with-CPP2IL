namespace System.Xml;

internal class XmlAutoDetectWriter : XmlRawWriter
{
	private XmlRawWriter wrapped; //Field offset: 0x14
	private OnRemoveWriter onRemove; //Field offset: 0x18
	private XmlWriterSettings writerSettings; //Field offset: 0x1C
	private XmlEventCache eventCache; //Field offset: 0x20
	private TextWriter textWriter; //Field offset: 0x24
	private Stream strm; //Field offset: 0x28

	internal virtual IXmlNamespaceResolver NamespaceResolver
	{
		internal set { } //Length: 98
	}

	public virtual XmlWriterSettings Settings
	{
		 get { } //Length: 11
	}

	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		internal get { } //Length: 40
	}

	private XmlAutoDetectWriter(XmlWriterSettings writerSettings) { }

	public XmlAutoDetectWriter(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	public XmlAutoDetectWriter(Stream strm, XmlWriterSettings writerSettings) { }

	public virtual void Close() { }

	private void CreateWrappedWriter(XmlOutputMethod outMethod) { }

	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	public virtual void Flush() { }

	public virtual XmlWriterSettings get_Settings() { }

	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	private static bool IsHtmlTag(string tagName) { }

	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	internal virtual void StartElementContent() { }

	private bool TextBlockCreatesWriter(string textBlock) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	internal virtual void WriteEndNamespaceDeclaration() { }

	public virtual void WriteEntityRef(string name) { }

	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteValue(long value) { }

	public virtual void WriteValue(decimal value) { }

	public virtual void WriteValue(float value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteValue(object value) { }

	public virtual void WriteValue(int value) { }

	public virtual void WriteValue(bool value) { }

	public virtual void WriteWhitespace(string ws) { }

	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

