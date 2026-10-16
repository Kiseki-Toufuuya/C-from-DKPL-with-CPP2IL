namespace System.Xml;

internal class Int64ArrayHelperWithDictionaryString : ArrayHelper<XmlDictionaryString, Int64>
{
	public static readonly Int64ArrayHelperWithDictionaryString Instance; //Field offset: 0x0

	private static Int64ArrayHelperWithDictionaryString() { }

	public Int64ArrayHelperWithDictionaryString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int64[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int64[] array, int offset, int count) { }

}

