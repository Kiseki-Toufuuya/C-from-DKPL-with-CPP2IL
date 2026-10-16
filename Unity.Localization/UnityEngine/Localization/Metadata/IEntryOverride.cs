namespace UnityEngine.Localization.Metadata;

public interface IEntryOverride : IMetadata
{

	public EntryOverrideType GetOverride(out TableReference tableReference, out TableEntryReference tableEntryReference) { }

}

