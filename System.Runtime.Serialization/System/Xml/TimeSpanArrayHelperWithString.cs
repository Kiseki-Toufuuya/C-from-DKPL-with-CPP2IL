namespace System.Xml;

internal class TimeSpanArrayHelperWithString : ArrayHelper<String, TimeSpan>
{
	public static readonly TimeSpanArrayHelperWithString Instance; //Field offset: 0x0

	private static TimeSpanArrayHelperWithString() { }

	public TimeSpanArrayHelperWithString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, string localName, string namespaceUri, TimeSpan[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, TimeSpan[] array, int offset, int count) { }

}

