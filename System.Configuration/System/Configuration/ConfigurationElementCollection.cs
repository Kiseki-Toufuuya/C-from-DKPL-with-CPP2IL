namespace System.Configuration;

[DebuggerDisplay("Count = {Count}")]
public abstract class ConfigurationElementCollection : ConfigurationElement
{

	public override ConfigurationElementCollectionType CollectionType
	{
		 get { } //Length: 40
	}

	protected override string ElementName
	{
		 get { } //Length: 40
	}

	protected abstract ConfigurationElement CreateNewElement() { }

	public override ConfigurationElementCollectionType get_CollectionType() { }

	protected override string get_ElementName() { }

	protected abstract object GetElementKey(ConfigurationElement element) { }

}

