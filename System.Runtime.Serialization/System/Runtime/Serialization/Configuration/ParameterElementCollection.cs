namespace System.Runtime.Serialization.Configuration;

[ConfigurationCollection(typeof(ParameterElement), AddItemName = "parameter", CollectionType = ConfigurationElementCollectionType::BasicMap (0))]
[DefaultMember("Item")]
public sealed class ParameterElementCollection : ConfigurationElementCollection
{

	public virtual ConfigurationElementCollectionType CollectionType
	{
		 get { } //Length: 40
	}

	protected virtual string ElementName
	{
		 get { } //Length: 40
	}

	public ParameterElement Item
	{
		 get { } //Length: 40
		 set { } //Length: 40
	}

	public ParameterElementCollection() { }

	public void Add(ParameterElement element) { }

	public void Clear() { }

	public bool Contains(string typeName) { }

	protected virtual ConfigurationElement CreateNewElement() { }

	public virtual ConfigurationElementCollectionType get_CollectionType() { }

	protected virtual string get_ElementName() { }

	public ParameterElement get_Item(int index) { }

	protected virtual object GetElementKey(ConfigurationElement element) { }

	public int IndexOf(ParameterElement element) { }

	public void Remove(ParameterElement element) { }

	public void RemoveAt(int index) { }

	public void set_Item(int index, ParameterElement value) { }

}

