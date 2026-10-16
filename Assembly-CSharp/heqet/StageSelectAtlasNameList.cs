namespace Heqet;

public class StageSelectAtlasNameList
{
	internal enum SpriteId
	{
		GRADE_D = 0,
		GRADE_C = 1,
		GRADE_B = 2,
		GRADE_A = 3,
		GRADE_S = 4,
		GRADE_SS = 5,
		GRADE_NONE = 6,
		FAVORITE_OFF = 7,
		FAVORITE_ON = 8,
		MUSIC_ATTR_ALL = 9,
		MUSIC_ATTR_EM = 10,
		MUSIC_ATTR_CO = 11,
		MUSIC_ATTR_RO = 12,
		MUSIC_ATTR_BASE_ALL = 13,
		MUSIC_ATTR_BASE_EM = 14,
		MUSIC_ATTR_BASE_CO = 15,
		MUSIC_ATTR_BASE_RO = 16,
		SUJI_0 = 17,
		SUJI_1 = 18,
		SUJI_2 = 19,
		SUJI_3 = 20,
		SUJI_4 = 21,
		SUJI_5 = 22,
		SUJI_6 = 23,
		SUJI_7 = 24,
		SUJI_8 = 25,
		SUJI_9 = 26,
		SUJI_X = 27,
		SUJI_HYPEN = 28,
		SCORE_SUJI_0 = 29,
		SCORE_SUJI_1 = 30,
		SCORE_SUJI_2 = 31,
		SCORE_SUJI_3 = 32,
		SCORE_SUJI_4 = 33,
		SCORE_SUJI_5 = 34,
		SCORE_SUJI_6 = 35,
		SCORE_SUJI_7 = 36,
		SCORE_SUJI_8 = 37,
		SCORE_SUJI_9 = 38,
		SCORE_SUJI_HYPEN = 39,
		DIFF_MOJI_EASY = 40,
		DIFF_MOJI_NORMAL = 41,
		DIFF_MOJI_HARD = 42,
		DIFF_MOJI_LUNATIC = 43,
		BTN_DIFF_NONE = 44,
		BTN_DIFF_EASY = 45,
		BTN_DIFF_NORMAL = 46,
		BTN_DIFF_HARD = 47,
		BTN_DIFF_LUNATIC = 48,
		CLEAR_ICON = 49,
		CLEAR_FULLCOMBO_ICON = 50,
		CLEAR_ALLBRILLIANT_ICON = 51,
		DIFF_EASY_SUJI_0 = 52,
		DIFF_EASY_SUJI_1 = 53,
		DIFF_EASY_SUJI_2 = 54,
		DIFF_EASY_SUJI_3 = 55,
		DIFF_EASY_SUJI_4 = 56,
		DIFF_EASY_SUJI_5 = 57,
		DIFF_EASY_SUJI_6 = 58,
		DIFF_EASY_SUJI_7 = 59,
		DIFF_EASY_SUJI_8 = 60,
		DIFF_EASY_SUJI_9 = 61,
		MUSIC_NONE_EASY_HYPEN = 62,
		DIFF_NORMAL_SUJI_0 = 63,
		DIFF_NORMAL_SUJI_1 = 64,
		DIFF_NORMAL_SUJI_2 = 65,
		DIFF_NORMAL_SUJI_3 = 66,
		DIFF_NORMAL_SUJI_4 = 67,
		DIFF_NORMAL_SUJI_5 = 68,
		DIFF_NORMAL_SUJI_6 = 69,
		DIFF_NORMAL_SUJI_7 = 70,
		DIFF_NORMAL_SUJI_8 = 71,
		DIFF_NORMAL_SUJI_9 = 72,
		MUSIC_NONE_NORMAL_HYPEN = 73,
		DIFF_HARD_SUJI_0 = 74,
		DIFF_HARD_SUJI_1 = 75,
		DIFF_HARD_SUJI_2 = 76,
		DIFF_HARD_SUJI_3 = 77,
		DIFF_HARD_SUJI_4 = 78,
		DIFF_HARD_SUJI_5 = 79,
		DIFF_HARD_SUJI_6 = 80,
		DIFF_HARD_SUJI_7 = 81,
		DIFF_HARD_SUJI_8 = 82,
		DIFF_HARD_SUJI_9 = 83,
		MUSIC_NONE_HARD_HYPEN = 84,
		DIFF_LUNATIC_SUJI_0 = 85,
		DIFF_LUNATIC_SUJI_1 = 86,
		DIFF_LUNATIC_SUJI_2 = 87,
		DIFF_LUNATIC_SUJI_3 = 88,
		DIFF_LUNATIC_SUJI_4 = 89,
		DIFF_LUNATIC_SUJI_5 = 90,
		DIFF_LUNATIC_SUJI_6 = 91,
		DIFF_LUNATIC_SUJI_7 = 92,
		DIFF_LUNATIC_SUJI_8 = 93,
		DIFF_LUNATIC_SUJI_9 = 94,
		DIFF_LUNATIC_SUJI_X = 95,
		MUSIC_NONE_LUNATIC_HYPEN = 96,
		LOCK_ICON = 97,
		MUSIC_ATTR_OBI_ALL = 98,
		MUSIC_ATTR_OBI_EM = 99,
		MUSIC_ATTR_OBI_CO = 100,
		MUSIC_ATTR_OBI_RO = 101,
		MUSIC_ATTR_PIC_ALL = 102,
		MUSIC_ATTR_PIC_EM = 103,
		MUSIC_ATTR_PIC_CO = 104,
		MUSIC_ATTR_PIC_RO = 105,
		MUSIC_ATTR_FRAME_ALL = 106,
		MUSIC_ATTR_FRAME_EM = 107,
		MUSIC_ATTR_FRAME_CO = 108,
		MUSIC_ATTR_FRAME_RO = 109,
		MUSIC_ATTR_FRAME_ALL_EX = 110,
		MUSIC_ATTR_FRAME_EM_EX = 111,
		MUSIC_ATTR_FRAME_CO_EX = 112,
		MUSIC_ATTR_FRAME_RO_EX = 113,
		MUSIC_ATTR_FRAME_ALL_ANOTHER = 114,
		MUSIC_ATTR_FRAME_EM_ANOTHER = 115,
		MUSIC_ATTR_FRAME_CO_ANOTHER = 116,
		MUSIC_ATTR_FRAME_RO_ANOTHER = 117,
		DIFF_BEGINNER_ICON = 118,
		DIFF_EASY_ICON = 119,
		DIFF_NORMAL_ICON = 120,
		DIFF_HARD_ICON = 121,
		DIFF_LUNATIC_ICON = 122,
		SELECT_MUSIC_FRAME = 123,
		SELECT_MUSIC_FRAME_EX = 124,
		SELECT_MUSIC_FRAME_ANOTHER = 125,
		BONUS_ICON_RED = 126,
		BONUS_ICON_GREEN = 127,
		SELECT_MUSIC_OBI = 128,
		SELECT_MUSIC_OBI_EX = 129,
		TOP1_RANKING_ICON = 130,
		TOP2_RANKING_ICON = 131,
		TOP3_RANKING_ICON = 132,
		UNDER_RANKING_ICON = 133,
		TAB_TOGGLE_ON = 134,
		TAB_TOGGLE_OFF = 135,
		BOOST_NORMAL = 136,
		BOOST_RAID = 137,
		TYPE_PLATE_ALL = 138,
		TYPE_PLATE_KAGURA = 139,
		TYPE_PLATE_EX = 140,
		TYPE_PLATE_ANOTHER = 141,
		JACKET_LIST_KAGURA = 142,
		JACKET_LIST_EX = 143,
		JACKET_LIST_ANOTHER = 144,
		MUSIC_FULLCOMBO = 145,
		MUSIC_ALLBRILLIANT = 146,
		STAR_BEGINNER_ICON = 147,
		STAR_EASY_ICON = 148,
		STAR_NORMAL_ICON = 149,
		STAR_HARD_ICON = 150,
		STAR_LUNATIC_ICON = 151,
		FRAME_PERFECT_ICON = 152,
		ALL_BRILLIANT_ICON = 153,
		FULL_COMBO_ICON = 154,
		STAGE_CLEAR_ICON = 155,
		NONE_CLEAR_ICON = 156,
		BADGE_COLLABORATION = 157,
		BADGE_MOVIE = 158,
		BADGE_CONTEST_0 = 159,
		BADGE_CONTEST_1 = 160,
		BADGE_ORIGINAL = 161,
		BADGE_YUKKURI = 162,
	}

	public const int SUJI_X = 10; //Field offset: 0x0
	public static String[] SpriteName; //Field offset: 0x0

	private static StageSelectAtlasNameList() { }

	public StageSelectAtlasNameList() { }

	public static string GetAttrBaseImg(int musicAttr) { }

	public static string GetAttrFrameImg(int musicAttr, bool isPlanA, bool isAnother) { }

	public static string GetAttrImg(int musicAttr) { }

	public static string GetAttrObiImg(int musicAttr) { }

	public static string GetAttrPicImg(int musicAttr) { }

	public static string GetBadgeImg(int type) { }

	public static string GetBonusTypeImg(bool isCenter) { }

	public static string GetBoostImg(bool isRaid) { }

	public static string GetBtnFavoriteImg(bool fav) { }

	public static string GetBtnMusicLockImg() { }

	public static string GetDiffAllBrilliant() { }

	public static string GetDiffClearImg(int diff) { }

	public static string GetDiffFullComboImg() { }

	public static string GetDiffNoClearImg() { }

	public static string GetJacketTypeImg(bool isPlanA, bool isAnother) { }

	public static string GetMusicDiffImg(int diff) { }

	public static string GetMusicDiffSTarImg(int diff) { }

	public static string GetMusicHyphen() { }

	public static string GetMusicLevelNone(MusicDifficulty _diff) { }

	public static string GetMusicLevelSuji(MusicDifficulty _diff, int _suji) { }

	public static string GetMusicTypeImg(bool isPlanA, bool isAnother) { }

	public static string GetRankImg(int rank) { }

	public static string GetRateScoreSujiImg(int rate) { }

	public static string GetRateSujiImg(int rate) { }

	public static string GetSelectMusicBaseImg(bool isPlanA) { }

	public static string GetSpriteName(int index) { }

	public static bool IsFavorite(string favoriteAtlasImg) { }

}

