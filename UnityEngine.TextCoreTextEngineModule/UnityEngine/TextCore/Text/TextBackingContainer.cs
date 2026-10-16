namespace UnityEngine.TextCore.Text;

[DefaultMember("Item")]
internal struct TextBackingContainer
{
	private UInt32[] m_Array; //Field offset: 0x0
	private int m_Count; //Field offset: 0x4

	public int Capacity
	{
		 get { } //Length: 22
	}

	public int Count
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public uint Item
	{
		 get { } //Length: 35
		 set { } //Length: 66
	}

	public TextBackingContainer(int size) { }

	public int get_Capacity() { }

	public int get_Count() { }

	public uint get_Item(int index) { }

	public void Resize(int size) { }

	public void set_Count(int value) { }

	public void set_Item(int index, uint value) { }

}

