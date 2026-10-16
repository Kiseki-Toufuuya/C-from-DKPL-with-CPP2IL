namespace System.Runtime.Serialization.Json;

[TypeForwardedFrom("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
public static class JsonReaderWriterFactory
{
	private const string DefaultIndentChars = "  "; //Field offset: 0x0

	public static XmlDictionaryReader CreateJsonReader(Stream stream, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateJsonReader(Byte[] buffer, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateJsonReader(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose) { }

	public static XmlDictionaryReader CreateJsonReader(Byte[] buffer, int offset, int count, XmlDictionaryReaderQuotas quotas) { }

	public static XmlDictionaryReader CreateJsonReader(Byte[] buffer, int offset, int count, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose) { }

	public static XmlDictionaryWriter CreateJsonWriter(Stream stream) { }

	public static XmlDictionaryWriter CreateJsonWriter(Stream stream, Encoding encoding) { }

	public static XmlDictionaryWriter CreateJsonWriter(Stream stream, Encoding encoding, bool ownsStream) { }

	public static XmlDictionaryWriter CreateJsonWriter(Stream stream, Encoding encoding, bool ownsStream, bool indent) { }

	public static XmlDictionaryWriter CreateJsonWriter(Stream stream, Encoding encoding, bool ownsStream, bool indent, string indentChars) { }

}

