namespace System.Xml;

internal class XmlBinaryWriter : XmlBaseWriter, IXmlBinaryWriterInitializer
{
	private XmlBinaryNodeWriter writer; //Field offset: 0x58
	private Char[] chars; //Field offset: 0x5C
	private Byte[] bytes; //Field offset: 0x60

	public XmlBinaryWriter() { }

	private void CheckArray(Array array, int offset, int count) { }

	protected virtual XmlSigningNodeWriter CreateSigningNodeWriter() { }

	public override void SetOutput(Stream stream, IXmlDictionary dictionary, XmlBinaryWriterSession session, bool ownsStream) { }

	private void UnsafeWriteArray(string prefix, string localName, string namespaceUri, XmlBinaryNodeType nodeType, int count, Byte* array, Byte* arrayMax) { }

	private void UnsafeWriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, XmlBinaryNodeType nodeType, int count, Byte* array, Byte* arrayMax) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int64[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, TimeSpan[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Guid[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Guid[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, DateTime[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, DateTime[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Decimal[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Decimal[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Double[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Double[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Single[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int32[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Int64[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, TimeSpan[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Int32[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int16[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Int16[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Boolean[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Boolean[] array, int offset, int count) { }

	public virtual void WriteArray(string prefix, string localName, string namespaceUri, Single[] array, int offset, int count) { }

	private void WriteEndArray() { }

	private void WriteStartArray(string prefix, string localName, string namespaceUri, int count) { }

	private void WriteStartArray(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, int count) { }

	protected virtual void WriteTextNode(XmlDictionaryReader reader, bool attribute) { }

}

