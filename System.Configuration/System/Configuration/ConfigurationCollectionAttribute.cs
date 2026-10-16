namespace System.Configuration;

[AttributeUsage(132)]
public sealed class ConfigurationCollectionAttribute : Attribute
{

	public string AddItemName
	{
		 set { } //Length: 3
	}

	public ConfigurationElementCollectionType CollectionType
	{
		 set { } //Length: 3
	}

	public ConfigurationCollectionAttribute(Type itemType) { }

	public void set_AddItemName(string value) { }

	public void set_CollectionType(ConfigurationElementCollectionType value) { }

}

