namespace System.Collections.Specialized;

public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback
{
	public class NameObjectEntry
	{
		internal string Key; //Field offset: 0x8
		internal object Value; //Field offset: 0xC

		internal NameObjectEntry(string name, object value) { }

	}

	public class NameObjectKeysEnumerator : IEnumerator
	{
		private int _pos; //Field offset: 0x8
		private NameObjectCollectionBase _coll; //Field offset: 0xC
		private int _version; //Field offset: 0x10

		public override object Current
		{
			 get { } //Length: 148
		}

		internal NameObjectKeysEnumerator(NameObjectCollectionBase coll) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private static StringComparer defaultComparer; //Field offset: 0x0
	private bool _readOnly; //Field offset: 0x8
	private ArrayList _entriesArray; //Field offset: 0xC
	private IEqualityComparer _keyComparer; //Field offset: 0x10
	private Hashtable _entriesTable; //Field offset: 0x14
	private NameObjectEntry _nullKeyEntry; //Field offset: 0x18
	private SerializationInfo _serializationInfo; //Field offset: 0x1C
	private int _version; //Field offset: 0x20
	private object _syncRoot; //Field offset: 0x24

	public override int Count
	{
		 get { } //Length: 40
	}

	protected bool IsReadOnly
	{
		 get { } //Length: 11
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 88
	}

	private static NameObjectCollectionBase() { }

	protected NameObjectCollectionBase(SerializationInfo info, StreamingContext context) { }

	internal NameObjectCollectionBase(DBNull dummy) { }

	protected NameObjectCollectionBase() { }

	protected NameObjectCollectionBase(IEqualityComparer equalityComparer) { }

	protected NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer) { }

	protected void BaseAdd(string name, object value) { }

	protected object BaseGet(int index) { }

	protected object BaseGet(string name) { }

	protected string BaseGetKey(int index) { }

	protected void BaseRemove(string name) { }

	protected void BaseSet(string name, object value) { }

	private NameObjectEntry FindEntry(string key) { }

	public override int get_Count() { }

	protected bool get_IsReadOnly() { }

	public override IEnumerator GetEnumerator() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override void OnDeserialization(object sender) { }

	private void Reset() { }

	private void Reset(int capacity) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

}

