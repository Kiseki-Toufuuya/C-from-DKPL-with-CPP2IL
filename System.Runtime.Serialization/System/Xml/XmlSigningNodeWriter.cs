namespace System.Xml;

internal class XmlSigningNodeWriter : XmlNodeWriter
{
	private XmlNodeWriter writer; //Field offset: 0x8
	private XmlCanonicalWriter signingWriter; //Field offset: 0xC
	private Byte[] chars; //Field offset: 0x10
	private Byte[] base64Chars; //Field offset: 0x14
	private bool text; //Field offset: 0x18

	public XmlCanonicalWriter CanonicalWriter
	{
		 get { } //Length: 11
	}

	public XmlNodeWriter NodeWriter
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public XmlSigningNodeWriter(bool text) { }

	public virtual void Close() { }

	public virtual void Flush() { }

	public XmlCanonicalWriter get_CanonicalWriter() { }

	public XmlNodeWriter get_NodeWriter() { }

	public void set_NodeWriter(XmlNodeWriter value) { }

	public void SetOutput(XmlNodeWriter writer, Stream stream, bool includeComments, String[] inclusivePrefixes) { }

	public virtual void WriteBase64Text(Byte[] trailBytes, int trailByteCount, Byte[] buffer, int offset, int count) { }

	private void WriteBase64Text(Byte[] buffer, int offset, int count) { }

	public virtual void WriteBoolText(bool value) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(int ch) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDateTimeText(DateTime value) { }

	public virtual void WriteDecimalText(decimal value) { }

	public virtual void WriteDeclaration() { }

	public virtual void WriteDoubleText(double value) { }

	public virtual void WriteEndAttribute() { }

	public virtual void WriteEndElement(string prefix, string localName) { }

	public virtual void WriteEndListText() { }

	public virtual void WriteEndStartElement(bool isEmpty) { }

	public virtual void WriteEscapedText(Byte[] chars, int offset, int count) { }

	public virtual void WriteEscapedText(XmlDictionaryString value) { }

	public virtual void WriteEscapedText(Char[] chars, int offset, int count) { }

	public virtual void WriteEscapedText(string value) { }

	public virtual void WriteFloatText(float value) { }

	public virtual void WriteGuidText(Guid value) { }

	public virtual void WriteInt32Text(int value) { }

	public virtual void WriteInt64Text(long value) { }

	public virtual void WriteListSeparator() { }

	public virtual void WriteQualifiedName(string prefix, XmlDictionaryString localName) { }

	public virtual void WriteStartAttribute(string prefix, XmlDictionaryString localName) { }

	public virtual void WriteStartAttribute(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

	public virtual void WriteStartAttribute(string prefix, string localName) { }

	public virtual void WriteStartElement(string prefix, XmlDictionaryString localName) { }

	public virtual void WriteStartElement(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

	public virtual void WriteStartElement(string prefix, string localName) { }

	public virtual void WriteStartListText() { }

	public virtual void WriteText(Byte[] chars, int offset, int count) { }

	public virtual void WriteText(Char[] chars, int offset, int count) { }

	public virtual void WriteText(string value) { }

	public virtual void WriteText(XmlDictionaryString value) { }

	public virtual void WriteTimeSpanText(TimeSpan value) { }

	public virtual void WriteUInt64Text(ulong value) { }

	public virtual void WriteUniqueIdText(UniqueId value) { }

	public virtual void WriteXmlnsAttribute(string prefix, XmlDictionaryString ns) { }

	public virtual void WriteXmlnsAttribute(string prefix, string ns) { }

	public virtual void WriteXmlnsAttribute(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] nsBuffer, int nsOffset, int nsLength) { }

}

