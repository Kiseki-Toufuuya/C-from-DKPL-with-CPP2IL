namespace System.Runtime.Serialization.Json;

internal class JsonUriDataContract : JsonDataContract
{

	public JsonUriDataContract(UriDataContract traditionalUriDataContract) { }

	public virtual object ReadJsonValueCore(XmlReaderDelegator jsonReader, XmlObjectSerializerReadContextComplexJson context) { }

}

