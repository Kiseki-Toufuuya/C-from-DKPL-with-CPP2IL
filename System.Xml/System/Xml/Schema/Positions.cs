namespace System.Xml.Schema;

[DefaultMember("Item")]
internal class Positions
{
	private ArrayList positions; //Field offset: 0x8

	public int Count
	{
		 get { } //Length: 40
	}

	public Position Item
	{
		 get { } //Length: 115
	}

	public Positions() { }

	public int Add(int symbol, object particle) { }

	public int get_Count() { }

	public Position get_Item(int pos) { }

}

