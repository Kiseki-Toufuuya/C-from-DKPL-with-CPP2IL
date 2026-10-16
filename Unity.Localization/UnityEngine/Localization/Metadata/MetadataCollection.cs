namespace UnityEngine.Localization.Metadata;

public class MetadataCollection : IMetadataCollection
{
	[SerializeReference]
	private List<IMetadata> m_Items; //Field offset: 0x8

	public bool HasData
	{
		 get { } //Length: 71
	}

	public override IList<IMetadata> MetadataEntries
	{
		 get { } //Length: 11
	}

	public MetadataCollection() { }

	public override void AddMetadata(IMetadata md) { }

	public override bool Contains(IMetadata md) { }

	public bool get_HasData() { }

	public override IList<IMetadata> get_MetadataEntries() { }

	public override TObject GetMetadata() { }

	public override void GetMetadatas(IList<TObject> foundItems) { }

	public override IList<TObject> GetMetadatas() { }

	public bool HasMetadata() { }

	public override bool RemoveMetadata(IMetadata md) { }

}

