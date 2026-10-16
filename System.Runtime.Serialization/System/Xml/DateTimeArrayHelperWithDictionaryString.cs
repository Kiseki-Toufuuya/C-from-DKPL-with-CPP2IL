namespace System.Xml;

internal class DateTimeArrayHelperWithDictionaryString : ArrayHelper<XmlDictionaryString, DateTime>
{
	public static readonly DateTimeArrayHelperWithDictionaryString Instance; //Field offset: 0x0

	private static DateTimeArrayHelperWithDictionaryString() { }

	public DateTimeArrayHelperWithDictionaryString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString namespaceUri, DateTime[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, DateTime[] array, int offset, int count) { }

}

