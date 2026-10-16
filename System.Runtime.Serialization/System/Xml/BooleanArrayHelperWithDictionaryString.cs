namespace System.Xml;

internal class BooleanArrayHelperWithDictionaryString : ArrayHelper<XmlDictionaryString, Boolean>
{
	public static readonly BooleanArrayHelperWithDictionaryString Instance; //Field offset: 0x0

	private static BooleanArrayHelperWithDictionaryString() { }

	public BooleanArrayHelperWithDictionaryString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Boolean[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Boolean[] array, int offset, int count) { }

}

