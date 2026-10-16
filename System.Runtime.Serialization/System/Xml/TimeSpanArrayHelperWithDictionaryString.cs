namespace System.Xml;

internal class TimeSpanArrayHelperWithDictionaryString : ArrayHelper<XmlDictionaryString, TimeSpan>
{
	public static readonly TimeSpanArrayHelperWithDictionaryString Instance; //Field offset: 0x0

	private static TimeSpanArrayHelperWithDictionaryString() { }

	public TimeSpanArrayHelperWithDictionaryString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString namespaceUri, TimeSpan[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, TimeSpan[] array, int offset, int count) { }

}

