namespace System.Xml;

internal sealed class XmlCanonicalWriter
{
	private struct Attribute
	{
		public int prefixOffset; //Field offset: 0x0
		public int prefixLength; //Field offset: 0x4
		public int localNameOffset; //Field offset: 0x8
		public int localNameLength; //Field offset: 0xC
		public int nsOffset; //Field offset: 0x10
		public int nsLength; //Field offset: 0x14
		public int offset; //Field offset: 0x18
		public int length; //Field offset: 0x1C

	}

	private class AttributeSorter : IComparer
	{
		private XmlCanonicalWriter writer; //Field offset: 0x8

		public AttributeSorter(XmlCanonicalWriter writer) { }

		public override int Compare(object obj1, object obj2) { }

		public void Sort() { }

	}

	private struct Element
	{
		public int prefixOffset; //Field offset: 0x0
		public int prefixLength; //Field offset: 0x4
		public int localNameOffset; //Field offset: 0x8
		public int localNameLength; //Field offset: 0xC

	}

	private struct Scope
	{
		public int xmlnsAttributeCount; //Field offset: 0x0
		public int xmlnsOffset; //Field offset: 0x4

	}

	private struct XmlnsAttribute
	{
		public int prefixOffset; //Field offset: 0x0
		public int prefixLength; //Field offset: 0x4
		public int nsOffset; //Field offset: 0x8
		public int nsLength; //Field offset: 0xC
		public bool referred; //Field offset: 0x10

	}

	private const string xmlnsNamespace = "http://www.w3.org/2000/xmlns/"; //Field offset: 0x0
	private const int maxBytesPerChar = 3; //Field offset: 0x0
	private static readonly Boolean[] isEscapedAttributeChar; //Field offset: 0x0
	private static readonly Boolean[] isEscapedElementChar; //Field offset: 0x4
	private XmlUTF8NodeWriter writer; //Field offset: 0x8
	private MemoryStream elementStream; //Field offset: 0xC
	private Byte[] elementBuffer; //Field offset: 0x10
	private XmlUTF8NodeWriter elementWriter; //Field offset: 0x14
	private bool inStartElement; //Field offset: 0x18
	private int depth; //Field offset: 0x1C
	private Scope[] scopes; //Field offset: 0x20
	private int xmlnsAttributeCount; //Field offset: 0x24
	private XmlnsAttribute[] xmlnsAttributes; //Field offset: 0x28
	private int attributeCount; //Field offset: 0x2C
	private Attribute[] attributes; //Field offset: 0x30
	private Attribute attribute; //Field offset: 0x34
	private Element element; //Field offset: 0x54
	private Byte[] xmlnsBuffer; //Field offset: 0x64
	private int xmlnsOffset; //Field offset: 0x68
	private int xmlnsStartOffset; //Field offset: 0x6C
	private bool includeComments; //Field offset: 0x70
	private String[] inclusivePrefixes; //Field offset: 0x74

	private static XmlCanonicalWriter() { }

	public XmlCanonicalWriter() { }

	private void AddAttribute(ref Attribute attribute) { }

	private void AddXmlnsAttribute(ref XmlnsAttribute xmlnsAttribute) { }

	public void Close() { }

	private int Compare(ref Attribute attribute1, ref Attribute attribute2) { }

	private int Compare(Byte[] buffer1, int offset1, int length1, Byte[] buffer2, int offset2, int length2) { }

	private int Compare(Byte[] buffer, int offset1, int length1, int offset2, int length2) { }

	private int Compare(ref XmlnsAttribute xmlnsAttribute1, ref XmlnsAttribute xmlnsAttribute2) { }

	private void EndElement() { }

	private void EnsureXmlnsBuffer(int byteCount) { }

	private bool Equals(Byte[] buffer1, int offset1, int length1, Byte[] buffer2, int offset2, int length2) { }

	public void Flush() { }

	private bool IsInclusivePrefix(ref XmlnsAttribute xmlnsAttribute) { }

	private void ResolvePrefix(ref Attribute attribute) { }

	private void ResolvePrefix(int prefixOffset, int prefixLength, out int nsOffset, out int nsLength) { }

	private void ResolvePrefixes() { }

	public void SetOutput(Stream stream, bool includeComments, String[] inclusivePrefixes) { }

	private void SortAttributes() { }

	private void StartElement() { }

	private void ThrowClosed() { }

	private void ThrowIfClosed() { }

	public void WriteCharEntity(int ch) { }

	public void WriteComment(string value) { }

	public void WriteDeclaration() { }

	public void WriteEndAttribute() { }

	public void WriteEndElement(string prefix, string localName) { }

	public void WriteEndStartElement(bool isEmpty) { }

	public void WriteEscapedText(Byte[] chars, int offset, int count) { }

	public void WriteEscapedText(Char[] chars, int offset, int count) { }

	public void WriteEscapedText(string value) { }

	public void WriteStartAttribute(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

	public void WriteStartAttribute(string prefix, string localName) { }

	public void WriteStartElement(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] localNameBuffer, int localNameOffset, int localNameLength) { }

	public void WriteStartElement(string prefix, string localName) { }

	public void WriteText(string value) { }

	public void WriteText(Byte[] chars, int offset, int count) { }

	public void WriteText(int ch) { }

	public void WriteText(Char[] chars, int offset, int count) { }

	private void WriteXmlnsAttribute(ref XmlnsAttribute xmlnsAttribute) { }

	public void WriteXmlnsAttribute(Byte[] prefixBuffer, int prefixOffset, int prefixLength, Byte[] nsBuffer, int nsOffset, int nsLength) { }

	public void WriteXmlnsAttribute(string prefix, string ns) { }

}

