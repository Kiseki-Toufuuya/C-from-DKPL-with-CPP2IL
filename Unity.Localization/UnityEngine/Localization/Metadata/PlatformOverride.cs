namespace UnityEngine.Localization.Metadata;

[Metadata(AllowedTypes = 240, AllowMultiple = False)]
public class PlatformOverride : IEntryOverride, IMetadata, ISerializationCallbackReceiver
{
	private class PlatformOverrideData
	{
		public RuntimePlatform platform; //Field offset: 0x8
		public EntryOverrideType entryOverrideType; //Field offset: 0xC
		public TableReference tableReference; //Field offset: 0x10
		public TableEntryReference tableEntryReference; //Field offset: 0x30

		public PlatformOverrideData() { }

		public virtual string ToString() { }

	}

	[SerializeField]
	private List<PlatformOverrideData> m_PlatformOverrides; //Field offset: 0x8
	private PlatformOverrideData m_PlayerPlatformOverride; //Field offset: 0xC

	public PlatformOverride() { }

	public void AddPlatformEntryOverride(RuntimePlatform platform, TableEntryReference entry) { }

	public void AddPlatformOverride(RuntimePlatform platform, TableReference table, TableEntryReference entry, EntryOverrideType entryOverrideType = 3) { }

	public void AddPlatformTableOverride(RuntimePlatform platform, TableReference table) { }

	public override EntryOverrideType GetOverride(out TableReference tableReference, out TableEntryReference tableEntryReference) { }

	public EntryOverrideType GetOverride(out TableReference tableReference, out TableEntryReference tableEntryReference, RuntimePlatform platform) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public bool RemovePlatformOverride(RuntimePlatform platform) { }

}

