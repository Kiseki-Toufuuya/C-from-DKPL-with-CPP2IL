namespace Heqet;

public class SortFilterManager
{
	internal enum FILTER_TARGET_TYPE
	{
		HEQET_FILTER_HEROINE = 0,
		HEQET_FILTER_CARD = 1,
		HEQET_FILTER_MUSIC = 2,
		HEQET_FILTER_HEROINE_SKILL = 3,
		HEQET_FILTER_HEROINE_JACKET = 4,
	}

	internal enum SORT_FILTER_TYPE
	{
		HEQET_FRM_CARD = 0,
		HEQET_FRM_HEROINE = 1,
		HEQET_GALLERY_MITAMA = 2,
		HEQET_GALLERY_HEROINE = 3,
		HEQET_GALLERY_EMBLEM = 4,
		HEQET_CONFIG_EMBLEM_SETTING = 5,
		HEQET_GALLERY_JACKET = 6,
		HEQET_GALLERY_ACHIEVE = 7,
		HEQET_GALLERY_MUSIC = 8,
		HEQET_MUSIC_SELECT = 9,
	}

	private static SortFilterManager instance; //Field offset: 0x0
	private static Int32[] SortCardIds; //Field offset: 0x4
	private static Int32[] SortHeroineIds; //Field offset: 0x8
	private static Int32[] SortGalleryCardIds; //Field offset: 0xC
	private static Int32[] SortGalleryHeroineIds; //Field offset: 0x10
	private static Int32[] SortEmblemIds; //Field offset: 0x14
	private static Int32[] SortJacketIds; //Field offset: 0x18
	private static Int32[] SortGalleryAchievementIds; //Field offset: 0x1C
	private static Int32[] SortGalleryMusicIds; //Field offset: 0x20
	private static Int32[] SortMusicSelectIds; //Field offset: 0x24
	private Dictionary<SORT_FILTER_TYPE, Int32[]> m_SortItemIdMaps; //Field offset: 0x8
	private Dictionary<Int32, Int32> ConvertHankakuToHiragana; //Field offset: 0xC

	public static SortFilterManager Instance
	{
		 get { } //Length: 170
	}

	private static SortFilterManager() { }

	public SortFilterManager() { }

	public bool CheckFilterSearchMessageCard(int _id, string _word) { }

	public bool CheckFilterSearchMessageGalleryHeroine(int _id, string _word) { }

	public bool CheckFilterSearchMessageHeroine(int _id, string _word) { }

	public bool CheckFilterSearchMessageHeroineName(int _id, string _word) { }

	public bool CheckFilterSearchMessageHeroineSkill(int _id, string _word) { }

	public bool CheckFilterSearchMessageJacket(int _id, string _word) { }

	public string CulcConvertAlphabetOmoji2Komoji(string _target) { }

	public string CulcConvertHiragana(ref string _target) { }

	public static SortFilterManager get_Instance() { }

	public string GetFilterSearchMessage(FILTER_TARGET_TYPE _type, int _id) { }

	private string GetFilterSearchMessageCard(int _id) { }

	private string GetFilterSearchMessageHeroine(int _id) { }

	public string GetFilterSearchMessageJP(int _id) { }

	private string GetFilterSearchMessageMusic(int _id, bool _vocal = true) { }

	private string GetFilterSearchMessageMusicJp(int _id) { }

	public string GetFilterSearchYomiMessage(FILTER_TARGET_TYPE _type, int _id) { }

	private string GetFilterSearchYomiMessageCard(int _id) { }

	private string GetFilterSearchYomiMessageHeroine(int _id) { }

	private string GetFilterSearchYomiMessageHeroineSkill(int _id) { }

	private string GetFilterSearchYomiMessageMusic(int _id) { }

	public string GetSortLabelMessage(SORT_FILTER_TYPE _type, int _id) { }

	public string GetSortNameForSortFilterType(SORT_FILTER_TYPE _type, int _id, bool isAsc) { }

}

