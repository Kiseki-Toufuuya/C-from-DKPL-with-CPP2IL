namespace System.Runtime.Serialization.Configuration;

public sealed class SerializationSectionGroup : ConfigurationSectionGroup
{

	public DataContractSerializerSection DataContractSerializer
	{
		 get { } //Length: 40
	}

	public NetDataContractSerializerSection NetDataContractSerializer
	{
		 get { } //Length: 40
	}

	public SerializationSectionGroup() { }

	public DataContractSerializerSection get_DataContractSerializer() { }

	public NetDataContractSerializerSection get_NetDataContractSerializer() { }

	public static SerializationSectionGroup GetSectionGroup(Configuration config) { }

}

