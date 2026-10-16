namespace System.Xml;

internal class SingleArrayHelperWithString : ArrayHelper<String, Single>
{
	public static readonly SingleArrayHelperWithString Instance; //Field offset: 0x0

	private static SingleArrayHelperWithString() { }

	public SingleArrayHelperWithString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, string localName, string namespaceUri, Single[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, Single[] array, int offset, int count) { }

}

