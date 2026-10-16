namespace XeApp.Game;

public class TryInstallManager
{
	private static TryInstallManager m_Instance; //Field offset: 0x0
	private List<String> m_InstallPathList; //Field offset: 0x8
	private StringBuilder sb; //Field offset: 0xC

	public static TryInstallManager Instance
	{
		 get { } //Length: 40
	}

	public TryInstallManager() { }

	private string BuildTextureImagePath(string prefix, int imageID, int suffix1, int suffix2) { }

	private string BuildTextureImagePath(string prefix, int imageID, string suffix) { }

	private string BuildTextureImagePath(string prefix, string strId) { }

	private string BuildTextureImagePath(string prefix, int imageID) { }

	private string BuildTextureImagePathNoUnderBar(string prefix, int imageID, int suffix1, int suffix2) { }

	private string BuildVoiceName(string prefix, int characterID, int no) { }

	public static void Create() { }

	public static TryInstallManager get_Instance() { }

	public bool IsAnyDownloading() { }

	public void TryInstallBackground(int backgroundID) { }

	public void TryInstallBossAttackVoiceMenu(int characterID) { }

	public void TryInstallBossHeroineImage(int charId, int skinId, int reserveId) { }

	public long TryInstallCardBackground(int cardID, bool isTryInstall = true) { }

	public void TryInstallCardSpell(int cardID) { }

	public void TryInstallCharacterBookVoiceMenu(int characterID) { }

	public void TryInstallCharacterSystemRythmGame(int characterID) { }

	public void TryInstallCharacterSystemVoiceAll(int characterID) { }

	public void TryInstallCharacterSystemVoiceGacha(int characterID) { }

	public void TryInstallCharacterSystemVoiceHome(int characterID) { }

	public void TryInstallCharacterSystemVoiceLoginBomus(int characterID) { }

	public void TryInstallCharacterSystemVoiceMenu(int characterID) { }

	public bool TryInstallCommon(string AssetBundlePath) { }

	public void TryInstallExpeditionBg(int spotId, int variationId, int reserveId) { }

	public void TryInstallFormationCard(int cardID) { }

	public void TryInstallHeroineUp(int charId, int skinId, int reserveId) { }

	public void TryInstallInGameBackgorund(int backgroundID) { }

	public void TryInstallJacket(int jacketID) { }

	public void TryInstallLive2DModel(int charaId, int skinId, int type) { }

	public void TryInstallMenuLive2DModel(int charaId, int skinId, RENDER_TYPE type) { }

	public bool TryInstallPlatform(string AssetBundlePath) { }

	public void TryInstallShopBanner(int bannerID) { }

	public void TryInstallShopBanner2(int bannerID) { }

	public bool TryInstallSound(string cuesheetName) { }

	public void TryInstallSpotMapIcon(int spotId, int variationId, int reserveId) { }

	public void TryInstallSpotThumbnail(string thumbnailId) { }

	public void TryInstallTexturePrefabAnim(string prefix, int imageID) { }

}

