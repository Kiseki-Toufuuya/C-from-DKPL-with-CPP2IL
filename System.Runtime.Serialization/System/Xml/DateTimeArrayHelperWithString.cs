namespace System.Xml;

internal class DateTimeArrayHelperWithString : ArrayHelper<String, DateTime>
{
	public static readonly DateTimeArrayHelperWithString Instance; //Field offset: 0x0

	private static DateTimeArrayHelperWithString() { }

	public DateTimeArrayHelperWithString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, string localName, string namespaceUri, DateTime[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, DateTime[] array, int offset, int count) { }

}

