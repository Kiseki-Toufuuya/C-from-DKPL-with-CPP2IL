namespace Heqet;

public class HeqetStageSelectDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass150_0
	{
		public RawImageEx _img; //Field offset: 0x8

		public <>c__DisplayClass150_0() { }

		internal void <LoadJacket>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass156_0
	{
		public RawImage imgHeroine; //Field offset: 0x8

		public <>c__DisplayClass156_0() { }

		internal void <UpdateHeroineFavorite>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass157_0
	{
		public RawImage imgMitama; //Field offset: 0x8

		public <>c__DisplayClass157_0() { }

		internal void <UpdateMitamaCardFavorite>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	private enum eButtonId
	{
		SUBMIT = 0,
		MUSIC_DIFF_BTN_1 = 1,
		MUSIC_DIFF_BTN_2 = 2,
		MUSIC_DIFF_BTN_3 = 3,
		MUSIC_DIFF_BTN_4 = 4,
		MUSIC_HELP = 5,
		FAVORITE = 6,
		FOOTER_DECIDE = 7,
		FOOTER_MENU = 8,
		FOOTER_FAVORITE = 9,
		FOOTER_INFO = 10,
		FOOTER_FOLDER = 11,
		FOOTER_PARENT_FOLDER = 12,
		SWAP_LOCALIZATION = 13,
		SWAP_MUSIC_INFO = 14,
		LANE_LEFT = 15,
		LANE_RIGHT = 16,
		LANE_LEFT_BLANK = 17,
		LANE_RIGHT_BLANK = 18,
		FAVORITE_HEROINE = 19,
		FAVORITE_MITAMA = 20,
	}

	private enum eCommonLayerId
	{
		SCENE_ANIM_ROOT = 0,
		SCROLL_ROOT = 1,
		CENTER_SPACE = 2,
		ROOT_LOCK = 3,
		ROOT_KEY = 4,
		ROOT_NEW = 5,
		ROOT_DLC = 6,
		ROOT_BPM = 7,
		MUSIC_DIFF_1 = 8,
		MUSIC_DIFF_2 = 9,
		MUSIC_DIFF_3 = 10,
		MUSIC_DIFF_4 = 11,
		MUSIC_DIFF_CHOICE_1 = 12,
		MUSIC_DIFF_CHOICE_2 = 13,
		MUSIC_DIFF_CHOICE_3 = 14,
		MUSIC_DIFF_CHOICE_4 = 15,
		MUSIC_INFO = 16,
		MUSIC_INFO_BG = 17,
		MUSIC_INFO_JACKET = 18,
		MUSIC_INFO_SCORE = 19,
		MUSIC_INFO_RATING = 20,
		CENTER_PANEL = 21,
		SCROLL_BG = 22,
		CENTER_PANEL_BG = 23,
		NON_MUSIC = 24,
		SCORE_CAMMA_1 = 25,
		SCORE_CAMMA_2 = 26,
		SCORE_CAMMA_3 = 27,
		SWAP = 28,
		TITLE = 29,
		SWAP_TITLE_JP = 30,
		SELECT_MUSIC_PANEL = 31,
		SELECT_FOLDER_PANEL = 32,
		MUSIC_SCROLL_ROOT = 33,
		FOLDER_SCROLL_ROOT = 34,
		ROOT_FOLDER_LOCK = 35,
		ROOT_FOLDER_NEW = 36,
		ROOT_FOLDER_DLC = 37,
		ROOT_JACKET_SINGLE = 38,
		ROOT_JACKET_MULTI = 39,
		ANIM_CHOOSING_FLASH = 40,
		ANIM_FOLDER_CHOOSING_FLASH = 41,
		LANE_6 = 42,
		LANE_4 = 43,
		SWAP_MUSIC_INFO_BUTTON = 44,
		DIFFICULTY_SELECT_LEFT = 45,
		DIFFICULTY_SELECT_RIGHT = 46,
	}

	private enum eDispJacket
	{
		Default = 0,
		None = -1,
		Folder = -2,
		Multi = -3,
	}

	private enum eImageId
	{
		MUSIC_GRADE = 0,
		MUSIC_JACKET = 1,
		MUSIC_MULTI_JACKET_1 = 2,
		MUSIC_MULTI_JACKET_2 = 3,
		MUSIC_MULTI_JACKET_3 = 4,
		MUSIC_MULTI_JACKET_4 = 5,
		MUSIC_MULTI_JACKET_5 = 6,
		FAVORITE = 7,
		CATEGORY_BADGE = 8,
		FAVORITE_HEROINE = 9,
		FAVORITE_MITAMA = 10,
	}

	internal enum eOtherSelect
	{
		None = 0,
		Folder = -1,
		Random = -2,
	}

	private enum ePanelAnimType
	{
		DisableLoop = 0,
		Entry = 1,
		EnableLoop = 2,
		Egress = 3,
	}

	private enum eTxtLayerId
	{
		MUSIC_NAME = 0,
		MUSIC_NAME_JP = 1,
		MUSIC_VORCAL = 2,
		MUSIC_VORCAL_JP = 3,
		MUSIC_CIRCLE = 4,
		MUSIC_CIRCLE_JP = 5,
		MUSIC_NONE = 6,
		TEXT_MONEY = 7,
		TEXT_TOTAL_RATING = 8,
		TEXT_DIFF_1 = 9,
		TEXT_DIFF_2 = 10,
		TEXT_DIFF_3 = 11,
		TEXT_DIFF_4 = 12,
		TEXT_DIFF_CHOICE_1 = 13,
		TEXT_DIFF_CHOICE_2 = 14,
		TEXT_DIFF_CHOICE_3 = 15,
		TEXT_DIFF_CHOICE_4 = 16,
		TEXT_SORT_INFO = 17,
		TEXT_SWAP_LOCALIZATION_LABEL = 18,
		TEXT_SWAP_LOCALIZATION = 19,
		TEXT_NOT_APPLICABLE = 20,
		TEXT_FOLDER_NAME = 21,
		TEXT_FOLDER_NAME_JP = 22,
		TEXT_FOLDER_CLEAR_RATE = 23,
		TEXT_FOLDER_COUNT = 24,
		LABEL_FOLDER_COUNT = 25,
		LABEL_FOLDER_CLEAR_COUNT = 26,
	}

	private class LoadMusicJaket
	{
		public int id; //Field offset: 0x8
		public RawImageEx img; //Field offset: 0xC

		public LoadMusicJaket() { }

	}

	private String[] CommonLayerList; //Field offset: 0x114
	private String[] m_ButtonList; //Field offset: 0x118
	private String[] TxtLayerList; //Field offset: 0x11C
	private String[] ImagePath; //Field offset: 0x120
	private List<eCommonLayerId> NoneDispLayerIds; //Field offset: 0x124
	private readonly int HighScoreNumberCount; //Field offset: 0x128
	private readonly string HighScorePath; //Field offset: 0x12C
	private readonly string DifficultyIconPath; //Field offset: 0x130
	private readonly string FolderIconPath; //Field offset: 0x134
	private readonly string FolderBlankIconPath; //Field offset: 0x138
	private Tweener m_KeyDOPunch; //Field offset: 0x13C
	public SceneInOutAnimation m_SceneInOutAnimator; //Field offset: 0x140
	private List<AtlasImage> m_HiScoreAtlsImg; //Field offset: 0x144
	private List<AtlasImage> m_DifficultyIconAtlsImg; //Field offset: 0x148
	private List<AtlasImage> m_FolderIconAtlsImg; //Field offset: 0x14C
	private List<AtlasImage> m_FolderBlankIconAtlsImg; //Field offset: 0x150
	private List<UIWrapperTextMeshPro> m_DiffNumbers; //Field offset: 0x154
	private List<UIWrapperTextMeshPro> m_DiffChoiceNumbers; //Field offset: 0x158
	private Dictionary<Int32, UIWrapperButton> m_ButtonDic; //Field offset: 0x15C
	private Animation m_ChoosingFlashAnimator; //Field offset: 0x160
	private Animation m_FolderChoosingFlashAnimator; //Field offset: 0x164
	private AtlasImage m_categoryBadgeImag; //Field offset: 0x168
	private String[] PanelAnimName; //Field offset: 0x16C
	private Animator m_ScorePanelAnimator; //Field offset: 0x170
	private Animator m_RatingPanelAnimator; //Field offset: 0x174
	private List<MusicDifficulty> m_SkipDifficultys; //Field offset: 0x178
	[CompilerGenerated]
	private Action <OnClickSubmitCallback>k__BackingField; //Field offset: 0x17C
	[CompilerGenerated]
	private Action <OnClickCancelCallback>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private Action <OnClickHelpCallback>k__BackingField; //Field offset: 0x184
	[CompilerGenerated]
	private Action<MusicDifficulty> <OnClickDifficultyCallback>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private Action<LaneMode> <OnClickLaneModeCallback>k__BackingField; //Field offset: 0x18C
	[CompilerGenerated]
	private Action<Boolean> <OnClickFavoriteCallback>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private Action <OnClickInfoCallback>k__BackingField; //Field offset: 0x194
	[CompilerGenerated]
	private Action <OnClickMenuCallback>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private Action <OnClickSwapCallback>k__BackingField; //Field offset: 0x19C
	[CompilerGenerated]
	private Action <OnClickFolderCallback>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private Action<Single> <OnCentarPanelWheelScrollCallback>k__BackingField; //Field offset: 0x1A4
	[CompilerGenerated]
	private Action<Boolean> <OnClickSwapDisplayScore>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private Action <OnClickHeroineFavoriteCallback>k__BackingField; //Field offset: 0x1AC
	[CompilerGenerated]
	private Action <OnClickMitamaFavoriteCallback>k__BackingField; //Field offset: 0x1B0
	private MusicDifficulty m_Difficulty; //Field offset: 0x1B4
	private MusicDifficulty m_Difficulty_Buf; //Field offset: 0x1B8
	[CompilerGenerated]
	private bool <IsLevelFolder>k__BackingField; //Field offset: 0x1BC
	[CompilerGenerated]
	private LaneMode <LaneMode>k__BackingField; //Field offset: 0x1C0
	private bool m_Favorite; //Field offset: 0x1C4
	private JacketAssetBunleLoader[] m_JacketLoaders; //Field offset: 0x1C8
	private FolderJacketAssetBunleLoader m_FolderJacketLoader; //Field offset: 0x1CC
	private int m_JacketId; //Field offset: 0x1D0
	[CompilerGenerated]
	private bool <IsSwapLocalization>k__BackingField; //Field offset: 0x1D4
	private bool isDisplayScore; //Field offset: 0x1D5
	private RatingInfo m_ratingInfo; //Field offset: 0x1D8
	private readonly int DEFAULT_SKIN_ID; //Field offset: 0x1DC
	private CharacterAssetBunleLoader m_HeroineIconLoder; //Field offset: 0x1E0
	private int m_favoriteHeroineId; //Field offset: 0x1E4
	private CharacterAssetBunleLoader m_CardImageLoader; //Field offset: 0x1E8
	private int m_favoriteMitamaCardId; //Field offset: 0x1EC
	private List<LoadMusicJaket> m_LoadMusicJakets; //Field offset: 0x1F0

	public GameObject CenterPanelRoot
	{
		 get { } //Length: 32
	}

	public MusicDifficulty Difficulty
	{
		 get { } //Length: 14
	}

	public bool Favorite
	{
		 get { } //Length: 14
	}

	public GameObject FolderScrollRoot
	{
		 get { } //Length: 32
	}

	public bool IsDisplayScore
	{
		 get { } //Length: 14
		 set { } //Length: 134
	}

	public bool IsLevelFolder
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public bool IsSwapLocalization
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public private LaneMode LaneMode
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public private Action<Single> OnCentarPanelWheelScrollCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickCancelCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action<MusicDifficulty> OnClickDifficultyCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action<Boolean> OnClickFavoriteCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickFolderCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickHelpCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickHeroineFavoriteCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickInfoCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action<LaneMode> OnClickLaneModeCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickMenuCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickMitamaFavoriteCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickSubmitCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action OnClickSwapCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private Action<Boolean> OnClickSwapDisplayScore
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public GameObject ScrollRoot
	{
		 get { } //Length: 32
	}

	public HeqetStageSelectDisp() { }

	[CompilerGenerated]
	private void <UpdateDispHiScore>b__140_0(AtlasImage _img, List<Int32> _digitRevList, int _index) { }

	[CompilerGenerated]
	private void <UpdateMusicFolderJacket>b__153_0(AssetBundleLoadAssetOperation ope) { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	private MusicDifficulty CulcDifficulty(MusicDifficulty _difficulty, int _value) { }

	public void DispDifficultyButton(MusicDifficulty _difficulty, bool _eneble) { }

	private void DispNonMusicText(bool _enable) { }

	public GameObject get_CenterPanelRoot() { }

	public MusicDifficulty get_Difficulty() { }

	public bool get_Favorite() { }

	public GameObject get_FolderScrollRoot() { }

	public bool get_IsDisplayScore() { }

	[CompilerGenerated]
	public bool get_IsLevelFolder() { }

	[CompilerGenerated]
	public bool get_IsSwapLocalization() { }

	[CompilerGenerated]
	public LaneMode get_LaneMode() { }

	[CompilerGenerated]
	private Action<Single> get_OnCentarPanelWheelScrollCallback() { }

	[CompilerGenerated]
	private Action get_OnClickCancelCallback() { }

	[CompilerGenerated]
	private Action<MusicDifficulty> get_OnClickDifficultyCallback() { }

	[CompilerGenerated]
	private Action<Boolean> get_OnClickFavoriteCallback() { }

	[CompilerGenerated]
	private Action get_OnClickFolderCallback() { }

	[CompilerGenerated]
	private Action get_OnClickHelpCallback() { }

	[CompilerGenerated]
	private Action get_OnClickHeroineFavoriteCallback() { }

	[CompilerGenerated]
	private Action get_OnClickInfoCallback() { }

	[CompilerGenerated]
	private Action<LaneMode> get_OnClickLaneModeCallback() { }

	[CompilerGenerated]
	private Action get_OnClickMenuCallback() { }

	[CompilerGenerated]
	private Action get_OnClickMitamaFavoriteCallback() { }

	[CompilerGenerated]
	private Action get_OnClickSubmitCallback() { }

	[CompilerGenerated]
	private Action get_OnClickSwapCallback() { }

	[CompilerGenerated]
	private Action<Boolean> get_OnClickSwapDisplayScore() { }

	public GameObject get_ScrollRoot() { }

	public static bool GetDifficultyText(MusicDifficulty _difficulty, int _level, ref string text) { }

	private Sprite GetSprite(SpriteId _id) { }

	protected virtual void InitUguiOther() { }

	public bool IsPlayingLockShake() { }

	protected virtual void LateUpdate() { }

	private void LoadJacket(JacketAssetBunleLoader loder, int _id, RawImageEx _img) { }

	public void LockShake(Vector3 _punch, int _cnt, float _time) { }

	private void OnCentarPanelWheelScroll(PointerEventData eventData) { }

	private void OnClickButton(int _id) { }

	private void OnClickFavorite() { }

	public void PlayChoosingFlashAnimator() { }

	public void PlayFolderChoosingFlashAnimator() { }

	public virtual void ReleaseAll() { }

	public void set_IsDisplayScore(bool value) { }

	[CompilerGenerated]
	public void set_IsLevelFolder(bool value) { }

	[CompilerGenerated]
	public void set_IsSwapLocalization(bool value) { }

	[CompilerGenerated]
	private void set_LaneMode(LaneMode value) { }

	[CompilerGenerated]
	public void set_OnCentarPanelWheelScrollCallback(Action<Single> value) { }

	[CompilerGenerated]
	public void set_OnClickCancelCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickDifficultyCallback(Action<MusicDifficulty> value) { }

	[CompilerGenerated]
	public void set_OnClickFavoriteCallback(Action<Boolean> value) { }

	[CompilerGenerated]
	public void set_OnClickFolderCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickHelpCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickHeroineFavoriteCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickInfoCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickLaneModeCallback(Action<LaneMode> value) { }

	[CompilerGenerated]
	public void set_OnClickMenuCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickMitamaFavoriteCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickSubmitCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickSwapCallback(Action value) { }

	[CompilerGenerated]
	public void set_OnClickSwapDisplayScore(Action<Boolean> value) { }

	public void SetDifficulty(MusicDifficulty _diff) { }

	public void SetFavorite(bool _value) { }

	public void SetLaneMode(LaneMode _lane) { }

	private void SetSelectMusicCircle(string circle) { }

	private void SetSelectMusicCircleJp(string circle) { }

	private void SetSelectMusicTitle(string title) { }

	private void SetSelectMusicTitleJp(string title) { }

	private void SetSelectMusicVocal(string vocal) { }

	private void SetSelectMusicVocalJp(string vocal) { }

	public void SetupDifficultyButton(MusicDifficulty _difficulty, int _level, string _text, bool _isView) { }

	public void SetViewBpm(bool _enable) { }

	public void SetViewFavorite(bool _enable) { }

	public void UpdateButtonHit(bool _enable) { }

	public void UpdateCategoryBadge(int type) { }

	public void UpdateClearIcon(List<AtlasImage> images, int _flg, MusicDifficulty _difficulty) { }

	public void UpdateDifficultyButton(MusicDifficulty _diff) { }

	public void UpdateDifficultyButtonChoise(MusicDifficulty _difficulty, bool _choise) { }

	public void UpdateDifficultyButtonLevel(MusicDifficulty _difficulty, string _text) { }

	public void UpdateDifficultyCount(int _value) { }

	public void UpdateDispGrade(int _grade) { }

	public void UpdateDispGradeHypen() { }

	public void UpdateDispHiScore(int _score) { }

	public void UpdateDispHiScoreHypen() { }

	protected virtual void UpdateDispMain() { }

	public void UpdateDispMoney(int _money) { }

	public void UpdateDispMusicCommon() { }

	public void UpdateDispRatingInfo(HeqetMusicRecord musicRecord) { }

	public void UpdateDispRatingInfoHypen() { }

	public void UpdateFavorite(bool _value) { }

	public void UpdateFolderClearIcon(int _flg, MusicDifficulty _difficulty) { }

	public void UpdateFolderLock(bool _enable) { }

	public void UpdateFolderMusicCount(int _count, int _clear) { }

	public void UpdateFolderName(ref string _name) { }

	public void UpdateFolderViewClearIcon(Int32[] _enable) { }

	public void UpdateHeroineFavorite(int heroineId) { }

	public void UpdateLane(LaneMode _lane) { }

	public void UpdateLaneButton(LaneMode _lane) { }

	public void UpdateLock(bool _enable) { }

	public void UpdateLockDlc(bool _enable) { }

	public void UpdateMitamaCardFavorite(int mitamaCardId) { }

	public void UpdateMusicClearIcon(int _flg, MusicDifficulty _difficulty) { }

	public void UpdateMusicFolderJacket(int _folderId) { }

	public void UpdateMusicInfo(string _title, string _circle, string _vocal, string _titlejp = "", string _circlejp = "", string _vocaljp = "") { }

	public void UpdateMusicJacket(Int32[] _jackets) { }

	public void UpdateMusicJacket(int _jacketId) { }

	public void UpdateNew(bool _enable) { }

	public void UpdateNoneDispMusic() { }

	public void UpdateNoneMusicFolderJacket() { }

	public void UpdateSelectDifficultyButton(MusicDifficulty _difficulty) { }

	public void UpdateSortInfo(string _info) { }

	public void UpdateSwapTitle(bool _enable) { }

	public void UpdateViewClearIcon(List<AtlasImage> images, Int32[] _enable) { }

	public void UpdateViewClearIcon(bool _enable) { }

	public void ViewFooterButtonByFolder(bool _enable) { }

	public void ViewSelectDifficulty(bool _enable) { }

	public void ViewSelectFolder(bool _enable) { }

	public void ViewSelectMusic(bool _enable) { }

}

