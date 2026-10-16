namespace UnityEngine.Localization.Metadata;

[Metadata(AllowedTypes = 10, MenuItem = "Preload Assets")]
public class PreloadAssetTableMetadata : IMetadata
{
	internal enum PreloadBehaviour
	{
		NoPreload = 0,
		PreloadAll = 1,
	}

	[SerializeField]
	private PreloadBehaviour m_PreloadBehaviour; //Field offset: 0x8

	public PreloadBehaviour Behaviour
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public PreloadAssetTableMetadata() { }

	public PreloadBehaviour get_Behaviour() { }

	public void set_Behaviour(PreloadBehaviour value) { }

}

