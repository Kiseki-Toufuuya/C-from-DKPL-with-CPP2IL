namespace System.Xml;

internal class Int16ArrayHelperWithDictionaryString : ArrayHelper<XmlDictionaryString, Int16>
{
	public static readonly Int16ArrayHelperWithDictionaryString Instance; //Field offset: 0x0

	private static Int16ArrayHelperWithDictionaryString() { }

	public Int16ArrayHelperWithDictionaryString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int16[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Int16[] array, int offset, int count) { }

}

