namespace System.Collections;

[DefaultMember("Item")]
public sealed class BitArray : ICollection, IEnumerable, ICloneable
{
	private class BitArrayEnumeratorSimple : IEnumerator, ICloneable
	{
		private BitArray bitarray; //Field offset: 0x8
		private int index; //Field offset: 0xC
		private int version; //Field offset: 0x10
		private bool currentElement; //Field offset: 0x14

		public override object Current
		{
			 get { } //Length: 237
		}

		internal BitArrayEnumeratorSimple(BitArray bitarray) { }

		public override object Clone() { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private Int32[] m_array; //Field offset: 0x8
	private int m_length; //Field offset: 0xC
	private int _version; //Field offset: 0x10
	private object _syncRoot; //Field offset: 0x14

	public override int Count
	{
		 get { } //Length: 11
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public bool Item
	{
		 get { } //Length: 165
		 set { } //Length: 215
	}

	public int Length
	{
		 get { } //Length: 11
		 set { } //Length: 338
	}

	public override object SyncRoot
	{
		 get { } //Length: 86
	}

	public BitArray(int length) { }

	public BitArray(int length, bool defaultValue) { }

	public BitArray(BitArray bits) { }

	public override object Clone() { }

	public override void CopyTo(Array array, int index) { }

	public bool Get(int index) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	public bool get_Item(int index) { }

	public int get_Length() { }

	public override object get_SyncRoot() { }

	private static int GetArrayLength(int n, int div) { }

	public override IEnumerator GetEnumerator() { }

	public void Set(int index, bool value) { }

	public void set_Item(int index, bool value) { }

	public void set_Length(int value) { }

}

