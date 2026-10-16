namespace System.Xml;

internal class Int16ArrayHelperWithString : ArrayHelper<String, Int16>
{
	public static readonly Int16ArrayHelperWithString Instance; //Field offset: 0x0

	private static Int16ArrayHelperWithString() { }

	public Int16ArrayHelperWithString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, string localName, string namespaceUri, Int16[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, Int16[] array, int offset, int count) { }

}

