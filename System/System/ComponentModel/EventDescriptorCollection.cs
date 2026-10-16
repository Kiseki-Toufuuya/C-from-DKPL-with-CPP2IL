namespace System.ComponentModel;

[DefaultMember("Item")]
public class EventDescriptorCollection : ICollection, IEnumerable, IList
{
	private class ArraySubsetEnumerator : IEnumerator
	{
		private readonly Array _array; //Field offset: 0x8
		private readonly int _total; //Field offset: 0xC
		private int _current; //Field offset: 0x10

		public override object Current
		{
			 get { } //Length: 88
		}

		public ArraySubsetEnumerator(Array array, int count) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	public static readonly EventDescriptorCollection Empty; //Field offset: 0x0
	private EventDescriptor[] _events; //Field offset: 0x8
	private String[] _namedSort; //Field offset: 0xC
	private readonly IComparer _comparer; //Field offset: 0x10
	private bool _eventsOwned; //Field offset: 0x14
	private bool _needSort; //Field offset: 0x15
	private readonly bool _readOnly; //Field offset: 0x16
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x18

	public private int Count
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public override EventDescriptor Item
	{
		 get { } //Length: 103
	}

	private override int System.Collections.ICollection.Count
	{
		private get { } //Length: 11
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 11
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 11
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 31
		private set { } //Length: 351
	}

	private static EventDescriptorCollection() { }

	public EventDescriptorCollection(EventDescriptor[] events) { }

	public EventDescriptorCollection(EventDescriptor[] events, bool readOnly) { }

	public int Add(EventDescriptor value) { }

	public void Clear() { }

	public bool Contains(EventDescriptor value) { }

	private void EnsureEventsOwned() { }

	private void EnsureSize(int sizeNeeded) { }

	[CompilerGenerated]
	public int get_Count() { }

	public override EventDescriptor get_Item(int index) { }

	public IEnumerator GetEnumerator() { }

	public int IndexOf(EventDescriptor value) { }

	public void Insert(int index, EventDescriptor value) { }

	protected void InternalSort(IComparer sorter) { }

	protected void InternalSort(String[] names) { }

	public void Remove(EventDescriptor value) { }

	public void RemoveAt(int index) { }

	[CompilerGenerated]
	private void set_Count(int value) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override int System.Collections.ICollection.get_Count() { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

}

