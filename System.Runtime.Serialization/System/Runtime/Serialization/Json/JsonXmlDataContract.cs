namespace System.Runtime.Serialization.Json;

internal class JsonXmlDataContract : JsonDataContract
{

	public JsonXmlDataContract(XmlDataContract traditionalXmlDataContract) { }

	private List<Type> GetKnownTypesFromContext(XmlObjectSerializerContext context, IList<Type> serializerKnownTypeList) { }

	public virtual object ReadJsonValueCore(XmlReaderDelegator jsonReader, XmlObjectSerializerReadContextComplexJson context) { }

	public virtual void WriteJsonValueCore(XmlWriterDelegator jsonWriter, object obj, XmlObjectSerializerWriteContextComplexJson context, RuntimeTypeHandle declaredTypeHandle) { }

}

