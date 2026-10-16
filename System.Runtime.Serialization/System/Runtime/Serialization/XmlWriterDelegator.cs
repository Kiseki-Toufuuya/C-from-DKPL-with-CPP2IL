namespace System.Runtime.Serialization;

internal class XmlWriterDelegator
{
	private const int CharChunkSize = 76; //Field offset: 0x0
	private const int ByteChunkSize = 57; //Field offset: 0x0
	protected XmlWriter writer; //Field offset: 0x8
	protected XmlDictionaryWriter dictionaryWriter; //Field offset: 0xC
	internal int depth; //Field offset: 0x10
	private int prefixes; //Field offset: 0x14

	internal XmlWriter Writer
	{
		internal get { } //Length: 11
	}

	internal WriteState WriteState
	{
		internal get { } //Length: 40
	}

	internal string XmlLang
	{
		internal get { } //Length: 40
	}

	internal XmlSpace XmlSpace
	{
		internal get { } //Length: 308
	}

	public XmlWriterDelegator(XmlWriter writer) { }

	private Exception CreateInvalidPrimitiveTypeException(Type type) { }

	internal void Flush() { }

	internal XmlWriter get_Writer() { }

	internal WriteState get_WriteState() { }

	internal string get_XmlLang() { }

	internal XmlSpace get_XmlSpace() { }

	internal string LookupPrefix(string ns) { }

	internal void WriteAnyType(object value, Type valueType) { }

	internal void WriteAnyType(object value) { }

	internal void WriteAttributeBool(string prefix, XmlDictionaryString attrName, XmlDictionaryString attrNs, bool value) { }

	private void WriteAttributeBoolValue(bool value) { }

	internal void WriteAttributeInt(string prefix, XmlDictionaryString attrName, XmlDictionaryString attrNs, int value) { }

	private void WriteAttributeIntValue(int value) { }

	internal void WriteAttributeQualifiedName(string attrPrefix, XmlDictionaryString attrName, XmlDictionaryString attrNs, string name, string ns) { }

	internal void WriteAttributeQualifiedName(string attrPrefix, XmlDictionaryString attrName, XmlDictionaryString attrNs, XmlDictionaryString name, XmlDictionaryString ns) { }

	private void WriteAttributeQualifiedNameValue(string name, string ns) { }

	private void WriteAttributeQualifiedNameValue(XmlDictionaryString name, XmlDictionaryString ns) { }

	internal void WriteAttributeString(string prefix, XmlDictionaryString attrName, XmlDictionaryString attrNs, XmlDictionaryString value) { }

	internal void WriteAttributeString(string prefix, XmlDictionaryString attrName, XmlDictionaryString attrNs, string value) { }

	internal void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	private void WriteAttributeStringValue(XmlDictionaryString value) { }

	private void WriteAttributeStringValue(string value) { }

	internal override void WriteBase64(Byte[] bytes) { }

	internal override void WriteBoolean(bool value) { }

	public void WriteBoolean(bool value, XmlDictionaryString name, XmlDictionaryString ns) { }

	public void WriteBooleanArray(Boolean[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	public void WriteChar(char value, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal override void WriteChar(char value) { }

	public void WriteDateTime(DateTime value, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal override void WriteDateTime(DateTime value) { }

	public void WriteDateTimeArray(DateTime[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	public void WriteDecimal(decimal value, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal override void WriteDecimal(decimal value) { }

	public void WriteDecimalArray(Decimal[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	public void WriteDouble(double value, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal override void WriteDouble(double value) { }

	public void WriteDoubleArray(Double[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	private void WriteEndAttribute() { }

	public void WriteEndElement() { }

	internal void WriteEndElementPrimitive() { }

	internal void WriteExtensionData(IDataNode dataNode) { }

	public void WriteFloat(float value, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal override void WriteFloat(float value) { }

	internal void WriteGuid(Guid value) { }

	public void WriteGuid(Guid value, XmlDictionaryString name, XmlDictionaryString ns) { }

	public void WriteInt(int value, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal override void WriteInt(int value) { }

	public void WriteInt32Array(Int32[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	public void WriteInt64Array(Int64[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	internal override void WriteLong(long value) { }

	public void WriteLong(long value, XmlDictionaryString name, XmlDictionaryString ns) { }

	public void WriteNamespaceDecl(XmlDictionaryString ns) { }

	internal override void WriteQName(XmlQualifiedName value) { }

	internal void WriteQualifiedName(string localName, string ns) { }

	internal void WriteQualifiedName(XmlDictionaryString localName, XmlDictionaryString ns) { }

	internal void WriteRaw(string data) { }

	internal void WriteRaw(Char[] buffer, int index, int count) { }

	internal override void WriteShort(short value) { }

	public void WriteShort(short value, XmlDictionaryString name, XmlDictionaryString ns) { }

	public void WriteSignedByte(sbyte value, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal override void WriteSignedByte(sbyte value) { }

	public void WriteSingleArray(Single[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	private void WriteStartAttribute(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	private void WriteStartAttribute(string prefix, string localName, string ns) { }

	internal override void WriteStartElement(string prefix, string localName, string ns) { }

	public void WriteStartElement(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	internal void WriteStartElement(string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	internal void WriteStartElement(string localName, string ns) { }

	internal void WriteStartElementPrimitive(XmlDictionaryString localName, XmlDictionaryString namespaceUri) { }

	internal void WriteString(string value) { }

	internal void WriteTimeSpan(TimeSpan value) { }

	public void WriteTimeSpan(TimeSpan value, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal override void WriteUnsignedByte(byte value) { }

	public void WriteUnsignedByte(byte value, XmlDictionaryString name, XmlDictionaryString ns) { }

	public void WriteUnsignedInt(uint value, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal override void WriteUnsignedInt(uint value) { }

	public void WriteUnsignedLong(ulong value, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal override void WriteUnsignedLong(ulong value) { }

	public void WriteUnsignedShort(ushort value, XmlDictionaryString name, XmlDictionaryString ns) { }

	internal override void WriteUnsignedShort(ushort value) { }

	internal void WriteUri(Uri value) { }

	internal void WriteXmlnsAttribute(string prefix, XmlDictionaryString ns) { }

	internal void WriteXmlnsAttribute(string ns) { }

	internal void WriteXmlnsAttribute(XmlDictionaryString ns) { }

}

