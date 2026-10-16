namespace System.Xml;

internal class Int64ArrayHelperWithString : ArrayHelper<String, Int64>
{
	public static readonly Int64ArrayHelperWithString Instance; //Field offset: 0x0

	private static Int64ArrayHelperWithString() { }

	public Int64ArrayHelperWithString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, string localName, string namespaceUri, Int64[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, Int64[] array, int offset, int count) { }

}

