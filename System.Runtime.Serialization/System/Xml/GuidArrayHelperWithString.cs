namespace System.Xml;

internal class GuidArrayHelperWithString : ArrayHelper<String, Guid>
{
	public static readonly GuidArrayHelperWithString Instance; //Field offset: 0x0

	private static GuidArrayHelperWithString() { }

	public GuidArrayHelperWithString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, string localName, string namespaceUri, Guid[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, Guid[] array, int offset, int count) { }

}

