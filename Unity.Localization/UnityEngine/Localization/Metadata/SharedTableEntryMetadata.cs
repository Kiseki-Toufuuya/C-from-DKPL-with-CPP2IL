namespace UnityEngine.Localization.Metadata;

public abstract class SharedTableEntryMetadata : IMetadata, ISerializationCallbackReceiver
{
	private struct Entry
	{
		public long id; //Field offset: 0x0

	}

	[SerializeField]
	private List<Int64> m_Entries; //Field offset: 0x8
	[SerializeField]
	private List<Entry> m_SharedEntries; //Field offset: 0xC
	private HashSet<Int64> m_EntriesLookup; //Field offset: 0x10

	internal int Count
	{
		internal get { } //Length: 52
	}

	protected SharedTableEntryMetadata() { }

	internal int get_Count() { }

	internal bool IsRegistered(TableEntry entry) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	internal void Register(TableEntry entry) { }

	internal void Unregister(TableEntry entry) { }

}

