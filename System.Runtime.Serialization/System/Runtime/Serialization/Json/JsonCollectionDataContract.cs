namespace System.Runtime.Serialization.Json;

internal class JsonCollectionDataContract : JsonDataContract
{
	private class JsonCollectionDataContractCriticalHelper : JsonDataContractCriticalHelper
	{
		private JsonFormatCollectionReaderDelegate jsonFormatReaderDelegate; //Field offset: 0x14
		private JsonFormatGetOnlyCollectionReaderDelegate jsonFormatGetOnlyReaderDelegate; //Field offset: 0x18
		private JsonFormatCollectionWriterDelegate jsonFormatWriterDelegate; //Field offset: 0x1C
		private CollectionDataContract traditionalCollectionDataContract; //Field offset: 0x20

		internal JsonFormatGetOnlyCollectionReaderDelegate JsonFormatGetOnlyReaderDelegate
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal JsonFormatCollectionReaderDelegate JsonFormatReaderDelegate
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal JsonFormatCollectionWriterDelegate JsonFormatWriterDelegate
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal CollectionDataContract TraditionalCollectionDataContract
		{
			internal get { } //Length: 11
		}

		public JsonCollectionDataContractCriticalHelper(CollectionDataContract traditionalDataContract) { }

		internal JsonFormatGetOnlyCollectionReaderDelegate get_JsonFormatGetOnlyReaderDelegate() { }

		internal JsonFormatCollectionReaderDelegate get_JsonFormatReaderDelegate() { }

		internal JsonFormatCollectionWriterDelegate get_JsonFormatWriterDelegate() { }

		internal CollectionDataContract get_TraditionalCollectionDataContract() { }

		internal void set_JsonFormatGetOnlyReaderDelegate(JsonFormatGetOnlyCollectionReaderDelegate value) { }

		internal void set_JsonFormatReaderDelegate(JsonFormatCollectionReaderDelegate value) { }

		internal void set_JsonFormatWriterDelegate(JsonFormatCollectionWriterDelegate value) { }

	}

	private JsonCollectionDataContractCriticalHelper helper; //Field offset: 0xC

	internal JsonFormatGetOnlyCollectionReaderDelegate JsonFormatGetOnlyReaderDelegate
	{
		internal get { } //Length: 766
	}

	internal JsonFormatCollectionReaderDelegate JsonFormatReaderDelegate
	{
		internal get { } //Length: 442
	}

	internal JsonFormatCollectionWriterDelegate JsonFormatWriterDelegate
	{
		internal get { } //Length: 366
	}

	private CollectionDataContract TraditionalCollectionDataContract
	{
		private get { } //Length: 23
	}

	public JsonCollectionDataContract(CollectionDataContract traditionalDataContract) { }

	internal JsonFormatGetOnlyCollectionReaderDelegate get_JsonFormatGetOnlyReaderDelegate() { }

	internal JsonFormatCollectionReaderDelegate get_JsonFormatReaderDelegate() { }

	internal JsonFormatCollectionWriterDelegate get_JsonFormatWriterDelegate() { }

	private CollectionDataContract get_TraditionalCollectionDataContract() { }

	public virtual object ReadJsonValueCore(XmlReaderDelegator jsonReader, XmlObjectSerializerReadContextComplexJson context) { }

	public virtual void WriteJsonValueCore(XmlWriterDelegator jsonWriter, object obj, XmlObjectSerializerWriteContextComplexJson context, RuntimeTypeHandle declaredTypeHandle) { }

}

