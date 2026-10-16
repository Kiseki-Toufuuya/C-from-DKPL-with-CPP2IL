namespace System.Xml.Schema;

[DefaultMember("Item")]
internal sealed class BitSet
{
	private int count; //Field offset: 0x8
	private UInt32[] bits; //Field offset: 0xC

	public int Count
	{
		 get { } //Length: 11
	}

	public bool IsEmpty
	{
		 get { } //Length: 72
	}

	public bool Item
	{
		 get { } //Length: 83
	}

	private BitSet() { }

	public BitSet(int count) { }

	public void And(BitSet other) { }

	public void Clear() { }

	public BitSet Clone() { }

	private void EnsureLength(int nRequiredLength) { }

	public virtual bool Equals(object obj) { }

	public bool Get(int index) { }

	public int get_Count() { }

	public bool get_IsEmpty() { }

	public bool get_Item(int index) { }

	public virtual int GetHashCode() { }

	public bool Intersects(BitSet other) { }

	public int NextSet(int startFrom) { }

	public void Or(BitSet other) { }

	public void Set(int index) { }

	private int Subscript(int bitIndex) { }

}

