namespace System.Runtime.Serialization.Json;

internal class JsonWriterDelegator : XmlWriterDelegator
{
	private DateTimeFormat dateTimeFormat; //Field offset: 0x18

	public JsonWriterDelegator(XmlWriter writer) { }

	public JsonWriterDelegator(XmlWriter writer, DateTimeFormat dateTimeFormat) { }

	internal virtual void WriteBase64(Byte[] bytes) { }

	internal virtual void WriteBoolean(bool value) { }

	internal virtual void WriteChar(char value) { }

	internal virtual void WriteDateTime(DateTime value) { }

	private void WriteDateTimeInDefaultFormat(DateTime value) { }

	internal virtual void WriteDecimal(decimal value) { }

	internal virtual void WriteDouble(double value) { }

	internal virtual void WriteFloat(float value) { }

	internal virtual void WriteInt(int value) { }

	internal void WriteJsonBooleanArray(Boolean[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	internal void WriteJsonDateTimeArray(DateTime[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	internal void WriteJsonDecimalArray(Decimal[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	internal void WriteJsonDoubleArray(Double[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	internal void WriteJsonInt32Array(Int32[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	internal void WriteJsonInt64Array(Int64[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	internal void WriteJsonSingleArray(Single[] value, XmlDictionaryString itemName, XmlDictionaryString itemNamespace) { }

	internal virtual void WriteLong(long value) { }

	internal virtual void WriteQName(XmlQualifiedName value) { }

	internal virtual void WriteShort(short value) { }

	internal virtual void WriteSignedByte(sbyte value) { }

	internal virtual void WriteStartElement(string prefix, string localName, string ns) { }

	internal virtual void WriteUnsignedByte(byte value) { }

	internal virtual void WriteUnsignedInt(uint value) { }

	internal virtual void WriteUnsignedLong(ulong value) { }

	internal virtual void WriteUnsignedShort(ushort value) { }

}

