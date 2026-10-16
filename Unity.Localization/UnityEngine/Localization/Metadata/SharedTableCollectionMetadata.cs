namespace UnityEngine.Localization.Metadata;

public abstract class SharedTableCollectionMetadata : IMetadata, ISerializationCallbackReceiver
{
	private class Item
	{
		[SerializeField]
		private long m_KeyId; //Field offset: 0x8
		[SerializeField]
		private List<String> m_TableCodes; //Field offset: 0x10

		public long KeyId
		{
			 get { } //Length: 14
			 set { } //Length: 20
		}

		public List<String> Tables
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public Item() { }

		public long get_KeyId() { }

		public List<String> get_Tables() { }

		public void set_KeyId(long value) { }

		public void set_Tables(List<String> value) { }

	}

	[HideInInspector]
	[SerializeField]
	private List<Item> m_Entries; //Field offset: 0x8
	[CompilerGenerated]
	private Dictionary<Int64, HashSet`1<String>> <EntriesLookup>k__BackingField; //Field offset: 0xC

	public Dictionary<Int64, HashSet`1<String>> EntriesLookup
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool IsEmpty
	{
		 get { } //Length: 69
	}

	protected SharedTableCollectionMetadata() { }

	public void AddEntry(long keyId, string code) { }

	public bool Contains(long keyId) { }

	public bool Contains(long keyId, string code) { }

	[CompilerGenerated]
	public Dictionary<Int64, HashSet`1<String>> get_EntriesLookup() { }

	public bool get_IsEmpty() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public void RemoveEntry(long keyId, string code) { }

	[CompilerGenerated]
	public void set_EntriesLookup(Dictionary<Int64, HashSet`1<String>> value) { }

}

