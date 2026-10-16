namespace UnityEngine.Localization.Metadata;

public interface IMetadataCollection
{

	public IList<IMetadata> MetadataEntries
	{
		 get { } //Length: 0
	}

	public void AddMetadata(IMetadata md) { }

	public bool Contains(IMetadata md) { }

	public IList<IMetadata> get_MetadataEntries() { }

	public TObject GetMetadata() { }

	public void GetMetadatas(IList<TObject> foundItems) { }

	public IList<TObject> GetMetadatas() { }

	public bool RemoveMetadata(IMetadata md) { }

}

