namespace System.Xml;

internal class Int32ArrayHelperWithDictionaryString : ArrayHelper<XmlDictionaryString, Int32>
{
	public static readonly Int32ArrayHelperWithDictionaryString Instance; //Field offset: 0x0

	private static Int32ArrayHelperWithDictionaryString() { }

	public Int32ArrayHelperWithDictionaryString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int32[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int32[] array, int offset, int count) { }

}

