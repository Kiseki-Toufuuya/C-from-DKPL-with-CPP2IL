namespace Unity.Services.Core.Internal.Serialization;

internal class NewtonsoftSerializer : IJsonSerializer
{
	private readonly JsonSerializer m_Serializer; //Field offset: 0x8

	public NewtonsoftSerializer(JsonSerializerSettings settings = null) { }

	internal NewtonsoftSerializer(JsonSerializer serializer) { }

	public override T DeserializeObject(string value) { }

}

