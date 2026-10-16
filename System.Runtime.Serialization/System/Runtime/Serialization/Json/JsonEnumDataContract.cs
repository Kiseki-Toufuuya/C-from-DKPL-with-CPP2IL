namespace System.Runtime.Serialization.Json;

internal class JsonEnumDataContract : JsonDataContract
{
	private class JsonEnumDataContractCriticalHelper : JsonDataContractCriticalHelper
	{
		private bool isULong; //Field offset: 0x14

		public bool IsULong
		{
			 get { } //Length: 11
		}

		public JsonEnumDataContractCriticalHelper(EnumDataContract traditionalEnumDataContract) { }

		public bool get_IsULong() { }

	}

	private JsonEnumDataContractCriticalHelper helper; //Field offset: 0xC

	public bool IsULong
	{
		 get { } //Length: 23
	}

	public JsonEnumDataContract(EnumDataContract traditionalDataContract) { }

	public bool get_IsULong() { }

	public virtual object ReadJsonValueCore(XmlReaderDelegator jsonReader, XmlObjectSerializerReadContextComplexJson context) { }

	public virtual void WriteJsonValueCore(XmlWriterDelegator jsonWriter, object obj, XmlObjectSerializerWriteContextComplexJson context, RuntimeTypeHandle declaredTypeHandle) { }

}

