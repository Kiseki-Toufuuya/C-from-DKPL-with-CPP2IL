namespace UnityEngine.AddressableAssets;

internal class DynamicResourceLocator : IResourceLocator
{
	private AddressablesImpl m_Addressables; //Field offset: 0x8
	private string m_AtlasSpriteProviderId; //Field offset: 0xC

	public override IEnumerable<IResourceLocation> AllLocations
	{
		 get { } //Length: 46
	}

	private string AtlasSpriteProviderId
	{
		private get { } //Length: 586
	}

	public override IEnumerable<Object> Keys
	{
		 get { } //Length: 46
	}

	public override string LocatorId
	{
		 get { } //Length: 35
	}

	public DynamicResourceLocator(AddressablesImpl addr) { }

	internal void CreateDynamicLocations(Type type, IList<IResourceLocation> locations, string locName, string subKey, IResourceLocation mainLoc) { }

	public override IEnumerable<IResourceLocation> get_AllLocations() { }

	private string get_AtlasSpriteProviderId() { }

	public override IEnumerable<Object> get_Keys() { }

	public override string get_LocatorId() { }

	public override bool Locate(object key, Type type, out IList<IResourceLocation>& locations) { }

}

