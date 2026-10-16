namespace System.Runtime.Serialization;

internal class ISerializableDataMember
{
	private string name; //Field offset: 0x8
	private IDataNode value; //Field offset: 0xC

	internal string Name
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal IDataNode Value
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	public ISerializableDataMember() { }

	internal string get_Name() { }

	internal IDataNode get_Value() { }

	internal void set_Name(string value) { }

	internal void set_Value(IDataNode value) { }

}

