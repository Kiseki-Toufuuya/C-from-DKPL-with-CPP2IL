namespace System.Xml;

internal class XmlTextWriterBase64Encoder : Base64Encoder
{
	private XmlTextEncoder xmlTextEncoder; //Field offset: 0x14

	internal XmlTextWriterBase64Encoder(XmlTextEncoder xmlTextEncoder) { }

	internal virtual void WriteChars(Char[] chars, int index, int count) { }

	internal virtual Task WriteCharsAsync(Char[] chars, int index, int count) { }

}

