namespace System.Xml;

internal class DecimalArrayHelperWithString : ArrayHelper<String, Decimal>
{
	public static readonly DecimalArrayHelperWithString Instance; //Field offset: 0x0

	private static DecimalArrayHelperWithString() { }

	public DecimalArrayHelperWithString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, string localName, string namespaceUri, Decimal[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, Decimal[] array, int offset, int count) { }

}

