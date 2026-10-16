namespace System.Runtime.Serialization.Json;

internal class JsonStringDataContract : JsonDataContract
{

	public JsonStringDataContract(StringDataContract traditionalStringDataContract) { }

	public virtual object ReadJsonValueCore(XmlReaderDelegator jsonReader, XmlObjectSerializerReadContextComplexJson context) { }

}

