namespace Google.Protobuf.Collections;

[DefaultMember("Item")]
internal sealed class ReadOnlyDictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable
{
	private readonly IDictionary<TKey, TValue> wrapped; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 64
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override TValue Item
	{
		 get { } //Length: 208
		 set { } //Length: 42
	}

	public override ICollection<TKey> Keys
	{
		 get { } //Length: 63
	}

	public override ICollection<TValue> Values
	{
		 get { } //Length: 63
	}

	public ReadOnlyDictionary`2(IDictionary<TKey, TValue> wrapped) { }

	public override void Add(TKey key, TValue value) { }

	public override void Add(KeyValuePair<TKey, TValue> item) { }

	public override void Clear() { }

	public override bool Contains(KeyValuePair<TKey, TValue> item) { }

	public override bool ContainsKey(TKey key) { }

	public override void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }

	public virtual bool Equals(object obj) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override TValue get_Item(TKey key) { }

	public override ICollection<TKey> get_Keys() { }

	public override ICollection<TValue> get_Values() { }

	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	public virtual int GetHashCode() { }

	public override bool Remove(TKey key) { }

	public override bool Remove(KeyValuePair<TKey, TValue> item) { }

	public override void set_Item(TKey key, TValue value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

	public override bool TryGetValue(TKey key, out TValue value) { }

}

