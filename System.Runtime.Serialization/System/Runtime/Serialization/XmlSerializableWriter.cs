namespace System.Runtime.Serialization;

internal class XmlSerializableWriter : XmlWriter
{
	private XmlWriter xmlWriter; //Field offset: 0xC
	private int depth; //Field offset: 0x10
	private object obj; //Field offset: 0x14

	public virtual WriteState WriteState
	{
		 get { } //Length: 40
	}

	public virtual string XmlLang
	{
		 get { } //Length: 40
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 40
	}

	public XmlSerializableWriter() { }

	internal void BeginWrite(XmlWriter xmlWriter, object obj) { }

	public virtual void Close() { }

	internal void EndWrite() { }

	public virtual void Flush() { }

	public virtual WriteState get_WriteState() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string LookupPrefix(string ns) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

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

	public virtual void WriteName(string name) { }

	public virtual void WriteNmToken(string name) { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteQualifiedName(string localName, string ns) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	public virtual void WriteStartDocument() { }

	public virtual void WriteStartDocument(bool standalone) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteWhitespace(string ws) { }

}

