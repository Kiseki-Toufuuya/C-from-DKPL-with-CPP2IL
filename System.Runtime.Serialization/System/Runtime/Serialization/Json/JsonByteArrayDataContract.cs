namespace System.Runtime.Serialization.Json;

internal class JsonByteArrayDataContract : JsonDataContract
{

	public JsonByteArrayDataContract(ByteArrayDataContract traditionalByteArrayDataContract) { }

	public virtual object ReadJsonValueCore(XmlReaderDelegator jsonReader, XmlObjectSerializerReadContextComplexJson context) { }

}

