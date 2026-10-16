namespace XeApp.Game;

[Extension]
public static class UtilGame
{
	internal enum CHARA_ICON_TYPE
	{
		CARD_FULL = 0,
		CARD_FORM = 1,
		CARD_LIST = 2,
		CHARA_BUST_UP = 3,
		CHARA_THUMBNAIL = 4,
		CHARA_ADV_ICON = 5,
		CHARA_ICON = 6,
		CHARA_SD_ICON = 7,
		CHARA_SD2_ICON = 8,
		CHARA_HEROINE_ICON = 9,
		CHARA_HEROINE_UP = 10,
		CHARA_BOSS_HEROINE = 11,
		CHARA_BANNER_HEROINE = 12,
	}

	internal static class NgMotion
	{
		private enum NgEmotionType
		{
			Angry = 1,
			Sad = 2,
			Sweat = 4,
			Talk = 5,
			Heart = 8,
			Jump = 9,
		}


		private static List<NgEmotionType> GetNgEmotions(int heroineId) { }

		public static string GetNormalizedFace(int heroineId, string srcFace) { }

		public static string GetNormalizedMotion(int heroineId, string srcMotion) { }

		public static bool IsNgAngryEmotion(int heroineId) { }

		public static bool IsNgFace(int heroineId, string id) { }

		public static bool IsNgHeartEmotion(int heroineId) { }

		public static bool IsNgMotion(int heroineId, string id) { }

		public static bool IsNgSweatEmotion(int heroineId) { }

		public static bool IsNgTalkEmotion(int heroineId) { }

	}

	public static readonly string DATE_TIME_FORMAT; //Field offset: 0x0

	private static UtilGame() { }

	public static void AddCount(ref int num, int add) { }

	public static int CheckItemStoren(int id) { }

	public static bool CheckLoadedItemIcon(int itemId) { }

	private static string CreateAssetBundleName(CHARA_ICON_TYPE type, int charaId, int skinId, int reserveId = 0) { }

	public static void DeletCharaIcon(CHARA_ICON_TYPE type, int charaId, int skinId, int reserveId = 0, bool unloadAllLoadedObject = true) { }

	public static void DeleteAchievementImage(int iamgeId) { }

	public static void DeleteActiveSkill12Icon(int actId12) { }

	public static void DeleteActiveSkillIcon(int actId) { }

	public static void DeleteAdmobBannerImage(int ImageId, bool unloadAllLoadedObject = true) { }

	public static void DeleteBannerIcon(string bannerId) { }

	public static void DeleteBgImage(int bgId, bool unloadAllLoadedObject = true) { }

	public static void DeleteBoosterItem(int itemId, bool unloadAllLoadedObject = true) { }

	public static void DeleteBoosterItemIcon(int itemId, bool unloadAllLoadedObject = true) { }

	public static void DeleteBossIcon(int charaId, int skinId, bool unloadAllLoadedObject = true) { }

	public static void DeleteBurstLinkSkillIcon(int actId) { }

	public static void DeleteCampaignLogoImage(int categoryId, bool unloadAllLoadedObject = true) { }

	public static void DeleteCardMainTexture(int id, bool unloadAllLoadedObject = true) { }

	public static void DeleteCardStamp(int id, bool unloadAllLoadedObject = true) { }

	public static void DeleteClubEmblemIcon(int id, bool unloadAllLoadedObject = true) { }

	public static void DeleteCoopEventLogo(int id, bool unloadAllLoadedObject = true) { }

	public static void DeleteEmblemIcon(int id, bool unloadAllLoadedObject = true) { }

	public static void DeleteEpisodeImage(int Id) { }

	public static void DeleteEventLogo(int id, bool unloadAllLoadedObject = true) { }

	public static void DeleteGachaLogo(int id, bool unloadAllLoadedObject = true) { }

	public static void DeleteIcon(string path) { }

	public static void DeleteItemIcon(int itemId, bool unloadAllLoadedObject = true) { }

	public static void DeleteJaketImage(int jacketId, bool unloadAllLoadedObject = true) { }

	public static void DeletePassiveSkillIcon(int psvId, bool unloadAllLoadedObject = true) { }

	public static void DeleteSdSkinIcon(int id, bool unloadAllLoadedObject = true) { }

	public static void DeleteShopBanner2Icon(int bannerId, bool unloadAllLoadedObject = true) { }

	public static void DeleteShopBannerIcon(int bannerId, bool unloadAllLoadedObject = true) { }

	public static void DeleteShopItemIcon(int itemId, bool unloadAllLoadedObject = true) { }

	public static void DeleteSpotImage(int spotId, int spotVariationId, int reserveId) { }

	public static void DeleteSpotImage(int spotId, bool unloadAllLoadedObject = true) { }

	public static void DeleteSpotObjectIcon(int objectId, int spotVariationId, int reserveId, bool unloadAllLoadedObject = true) { }

	public static void DeleteSpotObjectIcon(int objectId, bool unloadAllLoadedObject = true) { }

	public static void DeleteSpotThumbnail(int id, bool unloadAllLoadedObject = true) { }

	public static void DeleteSpotThumbnail(int spotId, int spotVariationId, int reserveId, bool unloadAllLoadedObject = true) { }

	public static void DeleteSpotThumbnail4(int id, bool unloadAllLoadedObject = true) { }

	public static void DeleteStampIcon(int id, bool unloadAllLoadedObject = true) { }

	public static void DeleteTravelSkillIcon(int travelId) { }

	public static void DeleteTutorialImage(int ImageId, bool unloadAllLoadedObject = true) { }

	public static T FindArray(T[] in_array, Predicate<T> in_match) { }

	public static T FindList(List<T> in_list, Predicate<T> in_match) { }

	public static GameObject FindObj(Transform parent, string name, string parentName = null) { }

	public static AssetBundleLoadAssetOperation GetAchievementImage(int imageId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetActiveSkill12Icon(int actId12, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetActiveSkillIcon(int actId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetAdmobBannerImage(int ImageId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static Vector2 GetAspect(float width, float height) { }

	public static AssetBundleLoadAssetOperation GetBannerIcon(string bannerId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetBgImage(int bgId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetBoosterItem(int itemId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetBoosterItemIcon(int itemId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetBossIcon(int charaId, int skinId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetBurstLinkSkillIcon(int actId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetCampaignLogoImage(int categoryId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetCardMainTexture(int id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetCardStamp(int id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetCharaIcon(CHARA_ICON_TYPE type, int charaId, int skinId, Action<AssetBundleLoadAssetOperation> load_end, int reserveId = 0) { }

	public static string GetCharaIconAssetBundlePath(CHARA_ICON_TYPE type, int charaId, int skinId, int reserveId = 0) { }

	public static AssetBundleLoadAssetOperation GetClubEmblemIcon(int id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static string GetClubEmblemIconPath(int id) { }

	public static Color GetColor(int inColor) { }

	public static AssetBundleLoadAssetOperation GetCoopEventLogo(int id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static DateTime GetDateTime(long unixTime) { }

	public static AssetBundleLoadAssetOperation GetEmblemIcon(int id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static string GetEmblemIconPath(int id) { }

	public static string GetEpisodeIconName(int category) { }

	public static AssetBundleLoadAssetOperation GetEpisodeImage(int Id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetEventLogo(int id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetGachaLogo(int id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static int GetGCD(int x, int y) { }

	public static AssetBundleLoadAssetOperation GetIcon(string path, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetItemIcon(int itemId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static string GetItemIconPath(int itemId) { }

	public static AssetBundleLoadAssetOperation GetJaketImage(int jacketId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static string GetNumberMsgComma(long number) { }

	public static string GetNumberMsgCommaPlus(long number, long max) { }

	public static AssetBundleLoadAssetOperation GetPassiveSkillIcon(int psvId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static int GetPerConv(int num, int min, int max, int r_min, int r_max, bool type = true) { }

	public static float GetPerConv(float num, float min, float max, float r_min, float r_max, bool type = true) { }

	public static float GetPerRange(float num, float min, float max, bool type = true) { }

	public static AssetBundleLoadAssetOperation GetSdSkinIcon(int id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetShopBanner2Icon(int bannerId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetShopBannerIcon(int bannerId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetShopItemIcon(int itemId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static string GetShopItemIconPath(int itemId) { }

	public static void GetSort(ref Int32[2] dt1, int param_num, bool fg1, int list_num) { }

	public static AssetBundleLoadAssetOperation GetSpotImage(int id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetSpotImage(int spotId, int spotVariationId, int reserveId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetSpotObjectIcon(int objectId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetSpotObjectIcon(int objectId, int spotVariationId, int reserveId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetSpotThumbnail(int id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetSpotThumbnail(int spotId, int spotVariationId, int reserveId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetSpotThumbnail4(int id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static string GetSpotThumbnailAssetBundlePath(int id) { }

	public static AssetBundleLoadAssetOperation GetStampIcon(int id, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetTravelSkillIcon(int travelId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetTutorialImage(int ImageId, string langCode, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static string GetTutorialImagePath(int ImageId, string langCode) { }

	public static bool IsLoadAssetBundle(CHARA_ICON_TYPE type, int charaId, int skinId, int reserveId = 0) { }

	public static bool IsValidArray(T[] in_list) { }

	public static bool IsValidList(List<T> in_list) { }

	public static string ReplaceRichTextCommand(string str) { }

	public static void SetLayer(GameObject gameObject, int layerNo, bool needSetChildrens = true) { }

	public static void SetScreenButtonActive(bool isActive) { }

	[Extension]
	public static T SimplexAddComponent(GameObject in_go) { }

}

