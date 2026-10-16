namespace System.Xml;

internal class DecimalArrayHelperWithDictionaryString : ArrayHelper<XmlDictionaryString, Decimal>
{
	public static readonly DecimalArrayHelperWithDictionaryString Instance; //Field offset: 0x0

	private static DecimalArrayHelperWithDictionaryString() { }

	public DecimalArrayHelperWithDictionaryString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Decimal[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Decimal[] array, int offset, int count) { }

}

