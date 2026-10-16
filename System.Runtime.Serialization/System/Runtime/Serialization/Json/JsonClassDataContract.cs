namespace System.Runtime.Serialization.Json;

internal class JsonClassDataContract : JsonDataContract
{
	private class JsonClassDataContractCriticalHelper : JsonDataContractCriticalHelper
	{
		private JsonFormatClassReaderDelegate jsonFormatReaderDelegate; //Field offset: 0x14
		private JsonFormatClassWriterDelegate jsonFormatWriterDelegate; //Field offset: 0x18
		private XmlDictionaryString[] memberNames; //Field offset: 0x1C
		private ClassDataContract traditionalClassDataContract; //Field offset: 0x20
		private string typeName; //Field offset: 0x24

		internal JsonFormatClassReaderDelegate JsonFormatReaderDelegate
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal JsonFormatClassWriterDelegate JsonFormatWriterDelegate
		{
			internal get { } //Length: 11
			internal set { } //Length: 27
		}

		internal XmlDictionaryString[] MemberNames
		{
			internal get { } //Length: 11
		}

		internal ClassDataContract TraditionalClassDataContract
		{
			internal get { } //Length: 11
		}

		public JsonClassDataContractCriticalHelper(ClassDataContract traditionalDataContract) { }

		private void CopyMembersAndCheckDuplicateNames() { }

		internal JsonFormatClassReaderDelegate get_JsonFormatReaderDelegate() { }

		internal JsonFormatClassWriterDelegate get_JsonFormatWriterDelegate() { }

		internal XmlDictionaryString[] get_MemberNames() { }

		internal ClassDataContract get_TraditionalClassDataContract() { }

		internal void set_JsonFormatReaderDelegate(JsonFormatClassReaderDelegate value) { }

		internal void set_JsonFormatWriterDelegate(JsonFormatClassWriterDelegate value) { }

	}

	private JsonClassDataContractCriticalHelper helper; //Field offset: 0xC

	internal JsonFormatClassReaderDelegate JsonFormatReaderDelegate
	{
		internal get { } //Length: 442
	}

	internal JsonFormatClassWriterDelegate JsonFormatWriterDelegate
	{
		internal get { } //Length: 366
	}

	internal XmlDictionaryString[] MemberNames
	{
		internal get { } //Length: 23
	}

	private ClassDataContract TraditionalClassDataContract
	{
		private get { } //Length: 23
	}

	internal virtual string TypeName
	{
		internal get { } //Length: 40
	}

	public JsonClassDataContract(ClassDataContract traditionalDataContract) { }

	internal JsonFormatClassReaderDelegate get_JsonFormatReaderDelegate() { }

	internal JsonFormatClassWriterDelegate get_JsonFormatWriterDelegate() { }

	internal XmlDictionaryString[] get_MemberNames() { }

	private ClassDataContract get_TraditionalClassDataContract() { }

	internal virtual string get_TypeName() { }

	public virtual object ReadJsonValueCore(XmlReaderDelegator jsonReader, XmlObjectSerializerReadContextComplexJson context) { }

	public virtual void WriteJsonValueCore(XmlWriterDelegator jsonWriter, object obj, XmlObjectSerializerWriteContextComplexJson context, RuntimeTypeHandle declaredTypeHandle) { }

}

