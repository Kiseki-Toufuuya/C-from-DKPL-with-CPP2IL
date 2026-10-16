namespace System.Runtime.Serialization.Json;

internal class JsonQNameDataContract : JsonDataContract
{

	public JsonQNameDataContract(QNameDataContract traditionalQNameDataContract) { }

	public virtual object ReadJsonValueCore(XmlReaderDelegator jsonReader, XmlObjectSerializerReadContextComplexJson context) { }

}

