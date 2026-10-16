namespace System.Xml;

internal class GuidArrayHelperWithDictionaryString : ArrayHelper<XmlDictionaryString, Guid>
{
	public static readonly GuidArrayHelperWithDictionaryString Instance; //Field offset: 0x0

	private static GuidArrayHelperWithDictionaryString() { }

	public GuidArrayHelperWithDictionaryString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Guid[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, XmlDictionaryString localName, XmlDictionaryString namespaceUri, Guid[] array, int offset, int count) { }

}

