namespace System.Runtime.Serialization.Json;

internal class ByteArrayHelperWithString : ArrayHelper<String, Byte>
{
	public static readonly ByteArrayHelperWithString Instance; //Field offset: 0x0

	private static ByteArrayHelperWithString() { }

	public ByteArrayHelperWithString() { }

	protected virtual int ReadArray(XmlDictionaryReader reader, string localName, string namespaceUri, Byte[] array, int offset, int count) { }

	private void ThrowConversionException(string value, string type) { }

	private byte ToByte(int value) { }

	internal void WriteArray(XmlWriter writer, Byte[] array, int offset, int count) { }

	protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, Byte[] array, int offset, int count) { }

}

