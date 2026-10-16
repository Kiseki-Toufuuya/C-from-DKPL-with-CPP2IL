namespace System.Collections.Specialized;

[DefaultMember("Item")]
public class OrderedDictionary : IOrderedDictionary, IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback
{
	private class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private int _objectReturnType; //Field offset: 0x8
		private IEnumerator _arrayEnumerator; //Field offset: 0xC

		public override object Current
		{
			 get { } //Length: 431
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 210
		}

		public override object Key
		{
			 get { } //Length: 114
		}

		public override object Value
		{
			 get { } //Length: 120
		}

		internal OrderedDictionaryEnumerator(ArrayList array, int objectReturnType) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private class OrderedDictionaryKeyValueCollection : ICollection, IEnumerable
	{
		private ArrayList _objects; //Field offset: 0x8
		private bool _isKeys; //Field offset: 0xC

		private override int System.Collections.ICollection.Count
		{
			private get { } //Length: 40
		}

		private override bool System.Collections.ICollection.IsSynchronized
		{
			private get { } //Length: 3
		}

		private override object System.Collections.ICollection.SyncRoot
		{
			private get { } //Length: 40
		}

		public OrderedDictionaryKeyValueCollection(ArrayList array, bool isKeys) { }

		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		private override int System.Collections.ICollection.get_Count() { }

		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		private override object System.Collections.ICollection.get_SyncRoot() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private ArrayList _objectsArray; //Field offset: 0x8
	private Hashtable _objectsTable; //Field offset: 0xC
	private int _initialCapacity; //Field offset: 0x10
	private IEqualityComparer _comparer; //Field offset: 0x14
	private bool _readOnly; //Field offset: 0x18
	private object _syncRoot; //Field offset: 0x1C
	private SerializationInfo _siInfo; //Field offset: 0x20

	public override int Count
	{
		 get { } //Length: 47
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 11
	}

	public override object Item
	{
		 get { } //Length: 123
		 set { } //Length: 470
	}

	public override object Item
	{
		 get { } //Length: 50
		 set { } //Length: 567
	}

	public override ICollection Keys
	{
		 get { } //Length: 93
	}

	private ArrayList objectsArray
	{
		private get { } //Length: 93
	}

	private Hashtable objectsTable
	{
		private get { } //Length: 105
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 88
	}

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		private get { } //Length: 11
	}

	public override ICollection Values
	{
		 get { } //Length: 93
	}

	public OrderedDictionary() { }

	public OrderedDictionary(int capacity) { }

	public OrderedDictionary(int capacity, IEqualityComparer comparer) { }

	protected OrderedDictionary(SerializationInfo info, StreamingContext context) { }

	public override void Add(object key, object value) { }

	public override void Clear() { }

	public override bool Contains(object key) { }

	public override void CopyTo(Array array, int index) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override object get_Item(int index) { }

	public override object get_Item(object key) { }

	public override ICollection get_Keys() { }

	private ArrayList get_objectsArray() { }

	private Hashtable get_objectsTable() { }

	public override ICollection get_Values() { }

	public override IDictionaryEnumerator GetEnumerator() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private int IndexOfKey(object key) { }

	public override void Insert(int index, object key, object value) { }

	protected override void OnDeserialization(object sender) { }

	public override void Remove(object key) { }

	public override void RemoveAt(int index) { }

	public override void set_Item(object key, object value) { }

	public override void set_Item(int index, object value) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

}

