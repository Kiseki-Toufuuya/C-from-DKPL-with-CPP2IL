namespace System.Xml;

internal class SingleArrayHelperWithDictionaryString : ArrayHelper<XmlDictionaryString, Single>
{
	public static readonly SingleArrayHelperWithDictionaryString Instance; //Field offset: 0x0

	private static SingleArrayHelperWithDictionaryString() { }

	public SingleArrayHelperWithDictionaryString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Single[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Single[] array, int offset, int count) { }

}

