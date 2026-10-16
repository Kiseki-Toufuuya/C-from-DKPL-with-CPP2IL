namespace Google.Protobuf.Collections;

[DefaultMember("Item")]
public sealed class MapField : IDeepCloneable<MapField`2<TKey, TValue>>, IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IEquatable<MapField`2<TKey, TValue>>, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TKey, TValue> <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<TKey, TValue>, TKey> <>9__14_0; //Field offset: 0x0
		public static Func<KeyValuePair`2<TKey, TValue>, TValue> <>9__16_0; //Field offset: 0x0
		public static Func<KeyValuePair`2<TKey, TValue>, DictionaryEntry> <>9__40_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TKey <get_Keys>b__14_0(KeyValuePair<TKey, TValue> pair) { }

		internal TValue <get_Values>b__16_0(KeyValuePair<TKey, TValue> pair) { }

		internal DictionaryEntry <System.Collections.ICollection.CopyTo>b__40_0(KeyValuePair<TKey, TValue> pair) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public TValue value; //Field offset: 0x0

		public <>c__DisplayClass7_0() { }

		internal bool <ContainsValue>b__0(KeyValuePair<TKey, TValue> pair) { }

	}

	internal sealed class Codec
	{
		public class MessageAdapter : IMessage
		{
			private static readonly Byte[] ZeroLengthMessageStreamData; //Field offset: 0x0
			private readonly Codec<TKey, TValue> codec; //Field offset: 0x0
			[CompilerGenerated]
			private TKey <Key>k__BackingField; //Field offset: 0x0
			[CompilerGenerated]
			private TValue <Value>k__BackingField; //Field offset: 0x0

			private override MessageDescriptor Google.Protobuf.IMessage.Descriptor
			{
				private get { } //Length: 3
			}

			internal TKey Key
			{
				[CompilerGenerated]
				internal get { } //Length: 11
				[CompilerGenerated]
				internal set { } //Length: 14
			}

			internal TValue Value
			{
				[CompilerGenerated]
				internal get { } //Length: 11
				[CompilerGenerated]
				internal set { } //Length: 14
			}

			private static MessageAdapter() { }

			internal MessageAdapter(Codec<TKey, TValue> codec) { }

			public override int CalculateSize() { }

			[CompilerGenerated]
			internal TKey get_Key() { }

			[CompilerGenerated]
			internal TValue get_Value() { }

			private override MessageDescriptor Google.Protobuf.IMessage.get_Descriptor() { }

			public override void MergeFrom(CodedInputStream input) { }

			internal void Reset() { }

			[CompilerGenerated]
			internal void set_Key(TKey value) { }

			[CompilerGenerated]
			internal void set_Value(TValue value) { }

			public override void WriteTo(CodedOutputStream output) { }

		}

		private readonly FieldCodec<TKey> keyCodec; //Field offset: 0x0
		private readonly FieldCodec<TValue> valueCodec; //Field offset: 0x0
		private readonly uint mapTag; //Field offset: 0x0

		internal uint MapTag
		{
			internal get { } //Length: 11
		}

		public Codec(FieldCodec<TKey> keyCodec, FieldCodec<TValue> valueCodec, uint mapTag) { }

		internal uint get_MapTag() { }

	}

	private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private readonly IEnumerator<KeyValuePair`2<TKey, TValue>> enumerator; //Field offset: 0x0

		public override object Current
		{
			 get { } //Length: 278
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 219
		}

		public override object Key
		{
			 get { } //Length: 86
		}

		public override object Value
		{
			 get { } //Length: 91
		}

		internal DictionaryEnumerator(IEnumerator<KeyValuePair`2<TKey, TValue>> enumerator) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	private class MapView : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection
	{
		private readonly MapField<TKey, TValue> parent; //Field offset: 0x0
		private readonly Func<KeyValuePair`2<TKey, TValue>, T> projection; //Field offset: 0x0
		private readonly Func<T, Boolean> containsCheck; //Field offset: 0x0

		public override int Count
		{
			 get { } //Length: 30
		}

		public override bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public override bool IsSynchronized
		{
			 get { } //Length: 3
		}

		public override object SyncRoot
		{
			 get { } //Length: 11
		}

		internal MapView`1(MapField<TKey, TValue> parent, Func<KeyValuePair`2<TKey, TValue>, T> projection, Func<T, Boolean> containsCheck) { }

		public override void Add(T item) { }

		public override void Clear() { }

		public override bool Contains(T item) { }

		public override void CopyTo(T[] array, int arrayIndex) { }

		public override void CopyTo(Array array, int index) { }

		public override int get_Count() { }

		public override bool get_IsReadOnly() { }

		public override bool get_IsSynchronized() { }

		public override object get_SyncRoot() { }

		public override IEnumerator<T> GetEnumerator() { }

		public override bool Remove(T item) { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private static readonly EqualityComparer<TValue> ValueEqualityComparer; //Field offset: 0x0
	private static readonly EqualityComparer<TKey> KeyEqualityComparer; //Field offset: 0x0
	private readonly Dictionary<TKey, LinkedListNode`1<KeyValuePair`2<TKey, TValue>>> map; //Field offset: 0x0
	private readonly LinkedList<KeyValuePair`2<TKey, TValue>> list; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 23
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override TValue Item
	{
		 get { } //Length: 146
		 set { } //Length: 257
	}

	public override ICollection<TKey> Keys
	{
		 get { } //Length: 517
	}

	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		private get { } //Length: 31
	}

	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		private get { } //Length: 31
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 8
	}

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IDictionary.Item
	{
		private get { } //Length: 249
		private set { } //Length: 155
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 101
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 101
	}

	public override ICollection<TValue> Values
	{
		 get { } //Length: 504
	}

	private static MapField`2() { }

	public MapField`2() { }

	public override void Add(TKey key, TValue value) { }

	public void Add(IDictionary<TKey, TValue> entries) { }

	public void AddEntriesFrom(CodedInputStream input, Codec<TKey, TValue> codec) { }

	public int CalculateSize(Codec<TKey, TValue> codec) { }

	public override void Clear() { }

	public override MapField<TKey, TValue> Clone() { }

	public override bool ContainsKey(TKey key) { }

	private bool ContainsValue(TValue value) { }

	public override bool Equals(MapField<TKey, TValue> other) { }

	public virtual bool Equals(object other) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override TValue get_Item(TKey key) { }

	public override ICollection<TKey> get_Keys() { }

	public override ICollection<TValue> get_Values() { }

	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	public virtual int GetHashCode() { }

	public override bool Remove(TKey key) { }

	public override void set_Item(TKey key, TValue value) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }

	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }

	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override void System.Collections.IDictionary.Add(object key, object value) { }

	private override bool System.Collections.IDictionary.Contains(object key) { }

	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	private override object System.Collections.IDictionary.get_Item(object key) { }

	private override ICollection System.Collections.IDictionary.get_Keys() { }

	private override ICollection System.Collections.IDictionary.get_Values() { }

	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	private override void System.Collections.IDictionary.Remove(object key) { }

	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

	public override bool TryGetValue(TKey key, out TValue value) { }

	public void WriteTo(CodedOutputStream output, Codec<TKey, TValue> codec) { }

}

