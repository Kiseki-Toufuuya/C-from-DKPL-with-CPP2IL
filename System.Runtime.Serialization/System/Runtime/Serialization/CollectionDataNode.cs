namespace System.Runtime.Serialization;

internal class CollectionDataNode : DataNode<Array>
{
	private IList<IDataNode> items; //Field offset: 0x28
	private string itemName; //Field offset: 0x2C
	private string itemNamespace; //Field offset: 0x30
	private int size; //Field offset: 0x34

	internal string ItemName
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal string ItemNamespace
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal IList<IDataNode> Items
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal int Size
	{
		internal get { } //Length: 11
		internal set { } //Length: 14
	}

	internal CollectionDataNode() { }

	public virtual void Clear() { }

	internal string get_ItemName() { }

	internal string get_ItemNamespace() { }

	internal IList<IDataNode> get_Items() { }

	internal int get_Size() { }

	public virtual void GetData(ElementData element) { }

	internal void set_ItemName(string value) { }

	internal void set_ItemNamespace(string value) { }

	internal void set_Items(IList<IDataNode> value) { }

	internal void set_Size(int value) { }

}

