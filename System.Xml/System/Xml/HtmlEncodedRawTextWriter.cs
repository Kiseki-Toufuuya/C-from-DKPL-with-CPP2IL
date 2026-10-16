namespace System.Xml;

internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter
{
	protected static TernaryTreeReadOnly elementPropertySearch; //Field offset: 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; //Field offset: 0x4
	protected ByteStack elementScope; //Field offset: 0x80
	protected ElementProperties currentElementProperties; //Field offset: 0x84
	private AttributeProperties currentAttributeProperties; //Field offset: 0x88
	private bool endsWithAmpersand; //Field offset: 0x8C
	private Byte[] uriEscapingBuffer; //Field offset: 0x90
	private string mediaType; //Field offset: 0x94
	private bool doNotEscapeUriAttributes; //Field offset: 0x98

	public HtmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings) { }

	public HtmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings) { }

	private void Init(XmlWriterSettings settings) { }

	private void OutputRestAmps() { }

	internal virtual void StartElementContent() { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	public virtual void WriteEntityRef(string name) { }

	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	private void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	protected void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	protected void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	protected void WriteMetaElement() { }

	public virtual void WriteProcessingInstruction(string target, string text) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	private void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

