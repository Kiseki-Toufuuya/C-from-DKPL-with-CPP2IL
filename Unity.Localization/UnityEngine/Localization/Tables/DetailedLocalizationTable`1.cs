namespace UnityEngine.Localization.Tables;

[DefaultMember("Item")]
public abstract class DetailedLocalizationTable : LocalizationTable, IDictionary<Int64, TEntry>, ICollection<KeyValuePair`2<Int64, TEntry>>, IEnumerable<KeyValuePair`2<Int64, TEntry>>, IEnumerable, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TEntry> <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<Int64, TEntry>, TEntry> <>9__33_1; //Field offset: 0x0
		public static Func<TableEntryData, Int64> <>9__41_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TEntry <CheckForMissingSharedTableDataEntries>b__33_1(KeyValuePair<Int64, TEntry> e) { }

		internal long <OnAfterDeserialize>b__41_0(TableEntryData o) { }

	}

	private Dictionary<Int64, TEntry> m_TableEntries; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 41
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override TEntry Item
	{
		 get { } //Length: 47
		 set { } //Length: 295
	}

	public TEntry Item
	{
		 get { } //Length: 73
		 set { } //Length: 190
	}

	private override ICollection<Int64> System.Collections.Generic.IDictionary<System.Int64,TEntry>.Keys
	{
		private get { } //Length: 41
	}

	public override ICollection<TEntry> Values
	{
		 get { } //Length: 41
	}

	protected DetailedLocalizationTable`1() { }

	[CompilerGenerated]
	private bool <CheckForMissingSharedTableDataEntries>b__33_0(KeyValuePair<Int64, TEntry> e) { }

	public override void Add(long keyId, TEntry value) { }

	public override void Add(KeyValuePair<Int64, TEntry> item) { }

	public override TEntry AddEntry(long keyId, string localized) { }

	public TEntry AddEntry(string key, string localized) { }

	public TEntry AddEntryFromReference(TableEntryReference entryReference, string localized) { }

	public IList<TEntry> CheckForMissingSharedTableDataEntries(MissingEntryAction action = 0) { }

	public override void Clear() { }

	public override bool Contains(KeyValuePair<Int64, TEntry> item) { }

	public override bool ContainsKey(long keyId) { }

	public bool ContainsValue(string localized) { }

	public override void CopyTo(KeyValuePair<Int64, TEntry>[] array, int arrayIndex) { }

	public virtual void CreateEmpty(TableEntryReference entryReference) { }

	internal TEntry CreateTableEntry(TableEntryData data) { }

	public abstract TEntry CreateTableEntry() { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public TEntry get_Item(string keyName) { }

	public override TEntry get_Item(long key) { }

	public override ICollection<TEntry> get_Values() { }

	public override TEntry GetEntry(long keyId) { }

	public TEntry GetEntry(string key) { }

	public TEntry GetEntryFromReference(TableEntryReference entryReference) { }

	public override IEnumerator<KeyValuePair`2<Int64, TEntry>> GetEnumerator() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public override bool Remove(long keyId) { }

	public override bool Remove(KeyValuePair<Int64, TEntry> item) { }

	public override bool RemoveEntry(long keyId) { }

	public bool RemoveEntry(string key) { }

	public void set_Item(string keyName, TEntry value) { }

	public override void set_Item(long key, TEntry value) { }

	private override ICollection<Int64> System.Collections.Generic.IDictionary<System.Int64,TEntry>.get_Keys() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

	public override bool TryGetValue(long keyId, out TEntry value) { }

}

