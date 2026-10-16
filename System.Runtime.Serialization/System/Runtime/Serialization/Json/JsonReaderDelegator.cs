namespace System.Runtime.Serialization.Json;

internal class JsonReaderDelegator : XmlReaderDelegator
{
	private class DateTimeArrayJsonHelperWithString : ArrayHelper<String, DateTime>
	{
		private DateTimeFormat dateTimeFormat; //Field offset: 0x8

		public DateTimeArrayJsonHelperWithString(DateTimeFormat dateTimeFormat) { }

		protected virtual int ReadArray(XmlDictionaryReader reader, string localName, string namespaceUri, DateTime[] array, int offset, int count) { }

		protected virtual void WriteArray(XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, DateTime[] array, int offset, int count) { }

	}

	private DateTimeFormat dateTimeFormat; //Field offset: 0x14
	private DateTimeArrayJsonHelperWithString dateTimeArrayHelper; //Field offset: 0x18

	private DateTimeArrayJsonHelperWithString DateTimeArrayHelper
	{
		private get { } //Length: 93
	}

	internal XmlDictionaryReaderQuotas ReaderQuotas
	{
		internal get { } //Length: 41
	}

	public JsonReaderDelegator(XmlReader reader) { }

	public JsonReaderDelegator(XmlReader reader, DateTimeFormat dateTimeFormat) { }

	private DateTimeArrayJsonHelperWithString get_DateTimeArrayHelper() { }

	internal XmlDictionaryReaderQuotas get_ReaderQuotas() { }

	internal static DateTime ParseJsonDate(string originalDateTimeValue, DateTimeFormat dateTimeFormat) { }

	internal static DateTime ParseJsonDateInDefaultFormat(string originalDateTimeValue) { }

	internal static XmlQualifiedName ParseQualifiedName(string qname) { }

	internal virtual Byte[] ReadContentAsBase64() { }

	internal virtual char ReadContentAsChar() { }

	internal virtual DateTime ReadContentAsDateTime() { }

	internal virtual XmlQualifiedName ReadContentAsQName() { }

	internal virtual ulong ReadContentAsUnsignedLong() { }

	internal virtual Byte[] ReadElementContentAsBase64() { }

	internal virtual char ReadElementContentAsChar() { }

	internal virtual DateTime ReadElementContentAsDateTime() { }

	internal virtual ulong ReadElementContentAsUnsignedLong() { }

	internal bool TryReadJsonDateTimeArray(XmlObjectSerializerReadContext context, XmlDictionaryString itemName, XmlDictionaryString itemNamespace, int arrayLength, out DateTime[] array) { }

}

