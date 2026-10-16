namespace UnityEngine.Localization.Tables;

public class TableEntry : IMetadataCollection
{
	private SharedTableEntry m_SharedTableEntry; //Field offset: 0x8
	[CompilerGenerated]
	private LocalizationTable <Table>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private TableEntryData <Data>k__BackingField; //Field offset: 0x10

	internal TableEntryData Data
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	public string Key
	{
		 get { } //Length: 86
		 set { } //Length: 72
	}

	public long KeyId
	{
		 get { } //Length: 26
	}

	public string LocalizedValue
	{
		 get { } //Length: 23
	}

	public override IList<IMetadata> MetadataEntries
	{
		 get { } //Length: 30
	}

	public SharedTableEntry SharedEntry
	{
		 get { } //Length: 75
	}

	public internal LocalizationTable Table
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	public TableEntry() { }

	public override void AddMetadata(IMetadata md) { }

	public void AddSharedMetadata(SharedTableCollectionMetadata md) { }

	public void AddSharedMetadata(SharedTableEntryMetadata md) { }

	public void AddTagMetadata() { }

	public override bool Contains(IMetadata md) { }

	[CompilerGenerated]
	internal TableEntryData get_Data() { }

	public string get_Key() { }

	public long get_KeyId() { }

	public string get_LocalizedValue() { }

	public override IList<IMetadata> get_MetadataEntries() { }

	public SharedTableEntry get_SharedEntry() { }

	[CompilerGenerated]
	public LocalizationTable get_Table() { }

	public override TObject GetMetadata() { }

	public override void GetMetadatas(IList<TObject> foundItems) { }

	public override IList<TObject> GetMetadatas() { }

	public bool HasTagMetadata() { }

	public override bool RemoveMetadata(IMetadata md) { }

	public void RemoveSharedMetadata(SharedTableEntryMetadata md) { }

	public void RemoveSharedMetadata(SharedTableCollectionMetadata md) { }

	public void RemoveTagMetadata() { }

	[CompilerGenerated]
	internal void set_Data(TableEntryData value) { }

	public void set_Key(string value) { }

	[CompilerGenerated]
	internal void set_Table(LocalizationTable value) { }

	public virtual string ToString() { }

}

