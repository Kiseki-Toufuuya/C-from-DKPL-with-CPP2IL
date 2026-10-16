namespace System.Runtime.Serialization.Configuration;

public sealed class DataContractSerializerSection : ConfigurationSection
{

	public DeclaredTypeElementCollection DeclaredTypes
	{
		 get { } //Length: 40
	}

	protected virtual ConfigurationPropertyCollection Properties
	{
		 get { } //Length: 40
	}

	public DataContractSerializerSection() { }

	public DeclaredTypeElementCollection get_DeclaredTypes() { }

	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

