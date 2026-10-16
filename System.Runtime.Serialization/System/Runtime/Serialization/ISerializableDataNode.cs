namespace System.Runtime.Serialization;

internal class ISerializableDataNode : DataNode<Object>
{
	private string factoryTypeName; //Field offset: 0x28
	private string factoryTypeNamespace; //Field offset: 0x2C
	private IList<ISerializableDataMember> members; //Field offset: 0x30

	internal string FactoryTypeName
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal string FactoryTypeNamespace
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal IList<ISerializableDataMember> Members
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal ISerializableDataNode() { }

	public virtual void Clear() { }

	internal string get_FactoryTypeName() { }

	internal string get_FactoryTypeNamespace() { }

	internal IList<ISerializableDataMember> get_Members() { }

	public virtual void GetData(ElementData element) { }

	internal void set_FactoryTypeName(string value) { }

	internal void set_FactoryTypeNamespace(string value) { }

	internal void set_Members(IList<ISerializableDataMember> value) { }

}

