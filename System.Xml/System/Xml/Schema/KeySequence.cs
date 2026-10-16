namespace System.Xml.Schema;

[DefaultMember("Item")]
internal class KeySequence
{
	private TypedObject[] ks; //Field offset: 0x8
	private int dim; //Field offset: 0xC
	private int hashcode; //Field offset: 0x10
	private int posline; //Field offset: 0x14
	private int poscol; //Field offset: 0x18

	public object Item
	{
		 get { } //Length: 36
		 set { } //Length: 217
	}

	public int PosCol
	{
		 get { } //Length: 11
	}

	public int PosLine
	{
		 get { } //Length: 11
	}

	internal KeySequence(int dim, int line, int col) { }

	public virtual bool Equals(object other) { }

	public object get_Item(int index) { }

	public int get_PosCol() { }

	public int get_PosLine() { }

	public virtual int GetHashCode() { }

	internal bool IsQualified() { }

	public void set_Item(int index, object value) { }

	public virtual string ToString() { }

}

