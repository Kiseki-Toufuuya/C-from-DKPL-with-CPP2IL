namespace System.Xml;

internal class DoubleArrayHelperWithDictionaryString : ArrayHelper<XmlDictionaryString, Double>
{
	public static readonly DoubleArrayHelperWithDictionaryString Instance; //Field offset: 0x0

	private static DoubleArrayHelperWithDictionaryString() { }

	public DoubleArrayHelperWithDictionaryString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Double[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Double[] array, int offset, int count) { }

}

