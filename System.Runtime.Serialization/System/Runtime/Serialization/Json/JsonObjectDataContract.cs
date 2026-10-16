namespace System.Runtime.Serialization.Json;

internal class JsonObjectDataContract : JsonDataContract
{

	public JsonObjectDataContract(DataContract traditionalDataContract) { }

	internal static object ParseJsonNumber(string value, out TypeCode objectTypeCode) { }

	private static object ParseJsonNumber(string value) { }

	public virtual object ReadJsonValueCore(XmlReaderDelegator jsonReader, XmlObjectSerializerReadContextComplexJson context) { }

	public virtual void WriteJsonValueCore(XmlWriterDelegator jsonWriter, object obj, XmlObjectSerializerWriteContextComplexJson context, RuntimeTypeHandle declaredTypeHandle) { }

}

