namespace XeApp.Game.Net;

public class EmbeddedAssetProvider
{
	private static EmbeddedAssetProvider instance; //Field offset: 0x0
	public Dictionary<String, Int32> EmbeddedAssetMap; //Field offset: 0x8
	public Dictionary<String, Int32> EmbeddedAssetMap2; //Field offset: 0xC

	public static EmbeddedAssetProvider Instance
	{
		 get { } //Length: 254
	}

	public EmbeddedAssetProvider() { }

	public static EmbeddedAssetProvider get_Instance() { }

	public void Initialize() { }

}

