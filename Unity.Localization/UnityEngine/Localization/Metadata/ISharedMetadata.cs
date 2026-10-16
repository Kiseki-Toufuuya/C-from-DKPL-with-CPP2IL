namespace UnityEngine.Localization.Metadata;

[HideInInspector]
public interface ISharedMetadata : IMetadata
{

	public void AddEntry(long keyId) { }

	public bool Contains(long keyId) { }

	public void RemoveEntry(long keyId) { }

}

