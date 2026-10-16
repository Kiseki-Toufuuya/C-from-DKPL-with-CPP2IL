namespace GuardProperty;

[DefaultMember("Item")]
[GuardArrayTarget(typeof(int))]
public sealed class GuardIntArray : IEnumerable<Int32>, IEnumerable
{
	private Int32[] hashs; //Field offset: 0x8
	private Int32[] values; //Field offset: 0xC

	public int Item
	{
		 get { } //Length: 438
		 set { } //Length: 238
	}

	public int Length
	{
		 get { } //Length: 23
	}

	public Int32[] Value
	{
		 get { } //Length: 83
	}

	public GuardIntArray(int size) { }

	public int CopyTo(Int32[] dest) { }

	public int get_Item(int idx) { }

	public int get_Length() { }

	public Int32[] get_Value() { }

	public void set_Item(int idx, int value) { }

	private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

}

