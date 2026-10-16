namespace System.Runtime.Serialization.Configuration;

[ConfigurationCollection(typeof(DeclaredTypeElement))]
[DefaultMember("Item")]
public sealed class DeclaredTypeElementCollection : ConfigurationElementCollection
{

	public DeclaredTypeElement Item
	{
		 get { } //Length: 40
		 set { } //Length: 40
	}

	public DeclaredTypeElementCollection() { }

	public void Add(DeclaredTypeElement element) { }

	public void Clear() { }

	public bool Contains(string typeName) { }

	protected virtual ConfigurationElement CreateNewElement() { }

	public DeclaredTypeElement get_Item(int index) { }

	public DeclaredTypeElement get_Item(string typeName) { }

	protected virtual object GetElementKey(ConfigurationElement element) { }

	public int IndexOf(DeclaredTypeElement element) { }

	public void Remove(DeclaredTypeElement element) { }

	public void Remove(string typeName) { }

	public void RemoveAt(int index) { }

	public void set_Item(int index, DeclaredTypeElement value) { }

	public void set_Item(string typeName, DeclaredTypeElement value) { }

}

