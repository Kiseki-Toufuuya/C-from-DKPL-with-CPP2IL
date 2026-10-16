namespace GuardProperty;

[DefaultMember("Item")]
[GuardArrayTarget(typeof(long))]
public sealed class GuardLongArray : IEnumerable<Int64>, IEnumerable
{
	private Int32[] hashs; //Field offset: 0x8
	private Int64[] values; //Field offset: 0xC

	public long Item
	{
		 get { } //Length: 462
		 set { } //Length: 255
	}

	public int Length
	{
		 get { } //Length: 23
	}

	public Int64[] Value
	{
		 get { } //Length: 83
		 set { } //Length: 483
	}

	public GuardLongArray() { }

	public int CopyTo(Int64[] dest) { }

	public long get_Item(int idx) { }

	public int get_Length() { }

	public Int64[] get_Value() { }

	public void set_Item(int idx, long value) { }

	public void set_Value(Int64[] value) { }

	private override IEnumerator<Int64> System.Collections.Generic.IEnumerable<System.Int64>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

}

