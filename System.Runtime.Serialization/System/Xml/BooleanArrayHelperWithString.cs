namespace System.Xml;

internal class BooleanArrayHelperWithString : ArrayHelper<String, Boolean>
{
	public static readonly BooleanArrayHelperWithString Instance; //Field offset: 0x0

	private static BooleanArrayHelperWithString() { }

	public BooleanArrayHelperWithString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, string localName, string namespaceUri, Boolean[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, Boolean[] array, int offset, int count) { }

}

