namespace GuardProperty;

[DefaultMember("Item")]
[GuardArrayTarget(typeof(bool))]
public sealed class GuardBoolArray : IEnumerable<Boolean>, IEnumerable
{
	private Int32[] hashs; //Field offset: 0x8
	private Boolean[] values; //Field offset: 0xC

	public bool Item
	{
		 get { } //Length: 345
		 set { } //Length: 153
	}

	public int Length
	{
		 get { } //Length: 23
	}

	public Boolean[] Value
	{
		 get { } //Length: 83
		 set { } //Length: 446
	}

	public GuardBoolArray() { }

	public int CopyTo(Boolean[] dest) { }

	public bool get_Item(int idx) { }

	public int get_Length() { }

	public Boolean[] get_Value() { }

	public void set_Item(int idx, bool value) { }

	public void set_Value(Boolean[] value) { }

	private override IEnumerator<Boolean> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

}

