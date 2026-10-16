namespace System.Xml;

internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
{
	private int indentLevel; //Field offset: 0x7C
	private int endBlockPos; //Field offset: 0x80
	private string indentChars; //Field offset: 0x84
	private bool newLineOnAttributes; //Field offset: 0x88

	public HtmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings) { }

	protected virtual void FlushBuffer() { }

	private void Init(XmlWriterSettings settings) { }

	internal virtual void StartElementContent() { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	private void WriteIndent() { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

}

