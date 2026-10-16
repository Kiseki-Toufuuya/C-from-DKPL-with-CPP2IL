namespace System.Runtime.Serialization;

internal class ClassDataNode : DataNode<Object>
{
	private IList<ExtensionDataMember> members; //Field offset: 0x28

	internal IList<ExtensionDataMember> Members
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal ClassDataNode() { }

	public virtual void Clear() { }

	internal IList<ExtensionDataMember> get_Members() { }

	internal void set_Members(IList<ExtensionDataMember> value) { }

}

