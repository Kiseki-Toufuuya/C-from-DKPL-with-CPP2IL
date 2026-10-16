namespace UnityEngine.Localization.Tables;

public abstract class LocalizationTable : ScriptableObject, IMetadataCollection, IComparable<LocalizationTable>
{
	[SerializeField]
	private LocaleIdentifier m_LocaleId; //Field offset: 0xC
	[FormerlySerializedAs("m_KeyDatabase")]
	[HideInInspector]
	[SerializeField]
	private SharedTableData m_SharedData; //Field offset: 0x14
	[SerializeField]
	private MetadataCollection m_Metadata; //Field offset: 0x18
	[SerializeField]
	private List<TableEntryData> m_TableData; //Field offset: 0x1C

	public LocaleIdentifier LocaleIdentifier
	{
		 get { } //Length: 14
		 set { } //Length: 34
	}

	public override IList<IMetadata> MetadataEntries
	{
		 get { } //Length: 23
	}

	public SharedTableData SharedData
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string TableCollectionName
	{
		 get { } //Length: 36
	}

	internal List<TableEntryData> TableData
	{
		internal get { } //Length: 11
	}

	protected LocalizationTable() { }

	public override void AddMetadata(IMetadata md) { }

	public override int CompareTo(LocalizationTable other) { }

	public override bool Contains(IMetadata md) { }

	public abstract void CreateEmpty(TableEntryReference entryReference) { }

	protected long FindKeyId(string key, bool addKey) { }

	public LocaleIdentifier get_LocaleIdentifier() { }

	public override IList<IMetadata> get_MetadataEntries() { }

	public SharedTableData get_SharedData() { }

	public string get_TableCollectionName() { }

	internal List<TableEntryData> get_TableData() { }

	public override TObject GetMetadata() { }

	public override void GetMetadatas(IList<TObject> foundItems) { }

	public override IList<TObject> GetMetadatas() { }

	public override bool RemoveMetadata(IMetadata md) { }

	public void set_LocaleIdentifier(LocaleIdentifier value) { }

	public void set_SharedData(SharedTableData value) { }

	public virtual string ToString() { }

	private void VerifySharedTableDataIsNotNull() { }

}

