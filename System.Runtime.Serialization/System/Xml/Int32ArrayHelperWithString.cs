namespace System.Xml;

internal class Int32ArrayHelperWithString : ArrayHelper<String, Int32>
{
	public static readonly Int32ArrayHelperWithString Instance; //Field offset: 0x0

	private static Int32ArrayHelperWithString() { }

	public Int32ArrayHelperWithString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, string localName, string namespaceUri, Int32[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, Int32[] array, int offset, int count) { }

}

