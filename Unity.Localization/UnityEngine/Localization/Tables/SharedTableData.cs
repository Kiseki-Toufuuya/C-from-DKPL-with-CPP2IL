namespace UnityEngine.Localization.Tables;

public class SharedTableData : ScriptableObject, ISerializationCallbackReceiver
{
	internal class SharedTableEntry
	{
		[SerializeField]
		private long m_Id; //Field offset: 0x8
		[SerializeField]
		private string m_Key; //Field offset: 0x10
		[SerializeField]
		private MetadataCollection m_Metadata; //Field offset: 0x14

		public internal long Id
		{
			 get { } //Length: 14
			internal set { } //Length: 20
		}

		public internal string Key
		{
			 get { } //Length: 11
			internal set { } //Length: 27
		}

		public MetadataCollection Metadata
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public SharedTableEntry() { }

		public long get_Id() { }

		public string get_Key() { }

		public MetadataCollection get_Metadata() { }

		internal void set_Id(long value) { }

		internal void set_Key(string value) { }

		public void set_Metadata(MetadataCollection value) { }

		public virtual string ToString() { }

	}

	public const long EmptyId = 0; //Field offset: 0x0
	internal const string NewEntryKey = "New Entry"; //Field offset: 0x0
	[FormerlySerializedAs("m_TableName")]
	[SerializeField]
	private string m_TableCollectionName; //Field offset: 0xC
	[FormerlySerializedAs("m_TableNameGuidString")]
	[SerializeField]
	private string m_TableCollectionNameGuidString; //Field offset: 0x10
	[SerializeField]
	private List<SharedTableEntry> m_Entries; //Field offset: 0x14
	[MetadataType(MetadataType::SharedTableData (2))]
	[SerializeField]
	private MetadataCollection m_Metadata; //Field offset: 0x18
	[SerializeReference]
	private IKeyGenerator m_KeyGenerator; //Field offset: 0x1C
	private Guid m_TableCollectionNameGuid; //Field offset: 0x20
	private Dictionary<Int64, SharedTableEntry> m_IdDictionary; //Field offset: 0x30
	private Dictionary<String, SharedTableEntry> m_KeyDictionary; //Field offset: 0x34

	public List<SharedTableEntry> Entries
	{
		 get { } //Length: 11
		 set { } //Length: 117
	}

	public IKeyGenerator KeyGenerator
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public MetadataCollection Metadata
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public string TableCollectionName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public internal Guid TableCollectionNameGuid
	{
		 get { } //Length: 18
		internal set { } //Length: 16
	}

	public SharedTableData() { }

	public SharedTableEntry AddKey(string key = null) { }

	public SharedTableEntry AddKey(string key, long id) { }

	private SharedTableEntry AddKeyInternal(string key, long id) { }

	private SharedTableEntry AddKeyInternal(string key) { }

	public void Clear() { }

	private static int ComputeLevenshteinDistance(string a, string b) { }

	public bool Contains(long id) { }

	public bool Contains(string key) { }

	[Obsolete("FindSimilarKey will be removed in the future, please use Unity Search. See TableEntrySearchData class for further details.")]
	public SharedTableEntry FindSimilarKey(string text, out int distance) { }

	private SharedTableEntry FindWithId(long id) { }

	private SharedTableEntry FindWithKey(string key) { }

	public List<SharedTableEntry> get_Entries() { }

	public IKeyGenerator get_KeyGenerator() { }

	public MetadataCollection get_Metadata() { }

	public string get_TableCollectionName() { }

	public Guid get_TableCollectionNameGuid() { }

	public SharedTableEntry GetEntry(long id) { }

	public SharedTableEntry GetEntry(string key) { }

	public SharedTableEntry GetEntryFromReference(TableEntryReference tableEntryReference) { }

	public long GetId(string key) { }

	public long GetId(string key, bool addNewKey) { }

	public string GetKey(long id) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public bool RemapId(long currentId, long newId) { }

	public void RemoveKey(string key) { }

	public void RemoveKey(long id) { }

	private void RemoveKeyInternal(SharedTableEntry entry) { }

	public void RenameKey(string oldValue, string newValue) { }

	public void RenameKey(long id, string newValue) { }

	private void RenameKeyInternal(SharedTableEntry entry, string newValue) { }

	public void set_Entries(List<SharedTableEntry> value) { }

	public void set_KeyGenerator(IKeyGenerator value) { }

	public void set_Metadata(MetadataCollection value) { }

	public void set_TableCollectionName(string value) { }

	internal void set_TableCollectionNameGuid(Guid value) { }

	public virtual string ToString() { }

}

