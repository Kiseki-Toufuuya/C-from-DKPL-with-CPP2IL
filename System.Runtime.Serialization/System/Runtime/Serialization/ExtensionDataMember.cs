namespace System.Runtime.Serialization;

internal class ExtensionDataMember
{
	private string name; //Field offset: 0x8
	private string ns; //Field offset: 0xC
	private IDataNode value; //Field offset: 0x10
	private int memberIndex; //Field offset: 0x14

	public int MemberIndex
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string Name
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string Namespace
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public IDataNode Value
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public ExtensionDataMember() { }

	public int get_MemberIndex() { }

	public string get_Name() { }

	public string get_Namespace() { }

	public IDataNode get_Value() { }

	public void set_MemberIndex(int value) { }

	public void set_Name(string value) { }

	public void set_Namespace(string value) { }

	public void set_Value(IDataNode value) { }

}

