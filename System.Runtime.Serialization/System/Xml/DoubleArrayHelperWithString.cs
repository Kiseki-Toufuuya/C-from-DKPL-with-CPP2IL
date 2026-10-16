namespace System.Xml;

internal class DoubleArrayHelperWithString : ArrayHelper<String, Double>
{
	public static readonly DoubleArrayHelperWithString Instance; //Field offset: 0x0

	private static DoubleArrayHelperWithString() { }

	public DoubleArrayHelperWithString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, string localName, string namespaceUri, Double[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, Double[] array, int offset, int count) { }

}

