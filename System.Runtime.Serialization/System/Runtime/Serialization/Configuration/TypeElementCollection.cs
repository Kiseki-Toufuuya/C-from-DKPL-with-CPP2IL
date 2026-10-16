namespace System.Runtime.Serialization.Configuration;

[ConfigurationCollection(typeof(TypeElement), CollectionType = ConfigurationElementCollectionType::BasicMap (0))]
[DefaultMember("Item")]
public sealed class TypeElementCollection : ConfigurationElementCollection
{

	public virtual ConfigurationElementCollectionType CollectionType
	{
		 get { } //Length: 40
	}

	protected virtual string ElementName
	{
		 get { } //Length: 40
	}

	public TypeElement Item
	{
		 get { } //Length: 40
		 set { } //Length: 40
	}

	public TypeElementCollection() { }

	public void Add(TypeElement element) { }

	public void Clear() { }

	protected virtual ConfigurationElement CreateNewElement() { }

	public virtual ConfigurationElementCollectionType get_CollectionType() { }

	protected virtual string get_ElementName() { }

	public TypeElement get_Item(int index) { }

	protected virtual object GetElementKey(ConfigurationElement element) { }

	public int IndexOf(TypeElement element) { }

	public void Remove(TypeElement element) { }

	public void RemoveAt(int index) { }

	public void set_Item(int index, TypeElement value) { }

}

