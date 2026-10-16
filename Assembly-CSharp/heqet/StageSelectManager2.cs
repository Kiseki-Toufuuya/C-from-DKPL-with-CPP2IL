namespace Heqet;

public class StageSelectManager2
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__84_2; //Field offset: 0x4
		public static Func<HeqetMusicModel, Int32> <>9__150_2; //Field offset: 0x8
		public static Func<HeqetMusicModel, Int32> <>9__150_3; //Field offset: 0xC
		public static Func<HeqetMusicModel, Boolean> <>9__150_4; //Field offset: 0x10
		public static Func<HeqetMusicModel, Int32> <>9__150_5; //Field offset: 0x14
		public static Func<HeqetMusicModel, Boolean> <>9__150_6; //Field offset: 0x18
		public static Func<HeqetMusicModel, Int32> <>9__150_7; //Field offset: 0x1C
		public static Func<HeqetMusicSelectionModel, Boolean> <>9__150_8; //Field offset: 0x20
		public static Func<HeqetMusicSelectionModel, Int32> <>9__150_9; //Field offset: 0x24
		public static Func<HeqetMusicModel, Boolean> <>9__150_10; //Field offset: 0x28
		public static Func<HeqetMusicModel, Int32> <>9__150_11; //Field offset: 0x2C
		public static Func<HeqetMusicModel, Boolean> <>9__150_12; //Field offset: 0x30
		public static Func<HeqetMusicModel, Int32> <>9__150_13; //Field offset: 0x34
		public static Func<HeqetMusicModel, Boolean> <>9__150_14; //Field offset: 0x38
		public static Func<HeqetMusicModel, Int32> <>9__150_15; //Field offset: 0x3C
		public static Func<KeyValuePair`2<Int32, UnlockMusicData>, Boolean> <>9__170_0; //Field offset: 0x40
		public static Func<KeyValuePair`2<Int32, UnlockMusicData>, Int32> <>9__170_1; //Field offset: 0x44
		public static Func<KeyValuePair`2<Int32, UnlockMusicData>, UnlockMusicData> <>9__170_2; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal bool <CulcUnlockCost>b__170_0(KeyValuePair<Int32, UnlockMusicData> x) { }

		internal int <CulcUnlockCost>b__170_1(KeyValuePair<Int32, UnlockMusicData> x) { }

		internal UnlockMusicData <CulcUnlockCost>b__170_2(KeyValuePair<Int32, UnlockMusicData> x) { }

		internal void <Initialize>b__84_2() { }

		internal bool <UpdateDispFolderJacket>b__150_10(HeqetMusicModel m) { }

		internal int <UpdateDispFolderJacket>b__150_11(HeqetMusicModel hm) { }

		internal bool <UpdateDispFolderJacket>b__150_12(HeqetMusicModel m) { }

		internal int <UpdateDispFolderJacket>b__150_13(HeqetMusicModel hm) { }

		internal bool <UpdateDispFolderJacket>b__150_14(HeqetMusicModel m) { }

		internal int <UpdateDispFolderJacket>b__150_15(HeqetMusicModel hm) { }

		internal int <UpdateDispFolderJacket>b__150_2(HeqetMusicModel m) { }

		internal int <UpdateDispFolderJacket>b__150_3(HeqetMusicModel hm) { }

		internal bool <UpdateDispFolderJacket>b__150_4(HeqetMusicModel m) { }

		internal int <UpdateDispFolderJacket>b__150_5(HeqetMusicModel hm) { }

		internal bool <UpdateDispFolderJacket>b__150_6(HeqetMusicModel m) { }

		internal int <UpdateDispFolderJacket>b__150_7(HeqetMusicModel hm) { }

		internal bool <UpdateDispFolderJacket>b__150_8(HeqetMusicSelectionModel m) { }

		internal int <UpdateDispFolderJacket>b__150_9(HeqetMusicSelectionModel hm) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass124_0
	{
		public int _id; //Field offset: 0x8

		public <>c__DisplayClass124_0() { }

		internal bool <SetTargetMusicId>b__0(HeqetMusicRecord x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass150_0
	{
		public StageSelectManager2 <>4__this; //Field offset: 0x8
		public int level; //Field offset: 0xC
		public MusicDifficulty value; //Field offset: 0x10
		public Func<HeqetMusicModel, Boolean> <>9__0; //Field offset: 0x14
		public Func<HeqetMusicModel, Boolean> <>9__1; //Field offset: 0x18

		public <>c__DisplayClass150_0() { }

		internal bool <UpdateDispFolderJacket>b__0(HeqetMusicModel m) { }

		internal bool <UpdateDispFolderJacket>b__1(HeqetMusicModel m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass169_0
	{
		public int _id; //Field offset: 0x8

		public <>c__DisplayClass169_0() { }

		internal bool <UpdateUnlockMusic>b__0(HeqetMusicRecord x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass96_0
	{
		public int id; //Field offset: 0x8

		public <>c__DisplayClass96_0() { }

		internal bool <OnChangeTargetPanelCallback>b__0(HeqetMusicRecord x) { }

	}

	private enum eFolderState
	{
		Normal = 0,
		Level = 1,
	}

	private enum eOtherSelect
	{
		None = 0,
		Random = 1,
	}

	private class MusicCostParamater
	{
		public int BaseCost; //Field offset: 0x8
		public float CostRate; //Field offset: 0xC
		public int MaxCount; //Field offset: 0x10

		public MusicCostParamater() { }

	}

	public const int DISPLAY_COUNT = 12; //Field offset: 0x0
	private static readonly Int32[] BackgroundForRandom; //Field offset: 0x0
	public const int DISPLAY_PAGE_COUNT = 7; //Field offset: 0x0
	private int m_TargetIndex; //Field offset: 0x8
	private int m_FolderId; //Field offset: 0xC
	private int m_FolderViewId; //Field offset: 0x10
	private Dictionary<Int32, Int32> m_TypeFolderIds; //Field offset: 0x14
	private int m_FolderLevel; //Field offset: 0x18
	private int m_SelectIdBuf; //Field offset: 0x1C
	private int m_SelectLevelIdBuf; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsSwapLocalization>k__BackingField; //Field offset: 0x24
	private HeqetMusicRecord m_TargetHeqetMusicRecord; //Field offset: 0x28
	private List<HeqetMusicRecord> m_HeqetMusicRecords; //Field offset: 0x2C
	public BgAssetBundleManager BgAssetBundleManager; //Field offset: 0x30
	public JacketAssetBundleManager JacketAssetBundleManager; //Field offset: 0x34
	private List<Int32> m_UnlockIds; //Field offset: 0x38
	private HeqetStageSelectScroll m_Scroll; //Field offset: 0x3C
	private HeqetStageSelectScroll m_MusicScroll; //Field offset: 0x40
	private HeqetStageSelectScroll m_FolderScroll; //Field offset: 0x44
	private int m_FolderType; //Field offset: 0x48
	private ScrollRectEx m_ScrollEx; //Field offset: 0x4C
	private bool isAllDefaultMusicUnlock; //Field offset: 0x50
	private int m_OtherSelect; //Field offset: 0x54
	private Dictionary<Int32, FolderData> m_FolderData; //Field offset: 0x58
	private Dictionary<Int32, LevelFolderData> m_LevelFolderData; //Field offset: 0x5C
	[CompilerGenerated]
	private SortFilterDisp <SortFilterDisp>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private StageSelectBgDisp <StageSelectBgDisp>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private HeqetStageSelectDisp <Disp>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private List<HeqetMusicPanelDisp> <MusicPanels>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private List<HeqetFolderPanelDisp> <FolderPanels>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private Action <DispNewCallback>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private Action <PlayMusicCallback>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private bool <EnableListControll>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	private bool <IsDispScorePanel>k__BackingField; //Field offset: 0x7D
	private eFolderState m_FolderState; //Field offset: 0x80
	private MusicCostParamater m_MusicCostParamater; //Field offset: 0x84

	public private HeqetStageSelectDisp Disp
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private Action DispNewCallback
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private bool EnableListControll
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public private List<HeqetFolderPanelDisp> FolderPanels
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool IsAllDefaultMusicUnlock
	{
		 get { } //Length: 11
	}

	public bool IsDispScorePanel
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	private bool IsFolder
	{
		private get { } //Length: 79
	}

	public bool IsMusicListLoading
	{
		 get { } //Length: 15
	}

	public bool IsNotApplicableMusic
	{
		 get { } //Length: 57
	}

	public bool IsRandomSelect
	{
		 get { } //Length: 15
	}

	public bool IsScrollMoving
	{
		 get { } //Length: 34
	}

	public private bool IsSwapLocalization
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int MusicId
	{
		 get { } //Length: 47
	}

	public private List<HeqetMusicPanelDisp> MusicPanels
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private Action PlayMusicCallback
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public ScrollRectEx ScrollRectEx
	{
		 set { } //Length: 27
	}

	public int SelectedId
	{
		 get { } //Length: 37
	}

	public private SortFilterDisp SortFilterDisp
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private StageSelectBgDisp StageSelectBgDisp
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	private static StageSelectManager2() { }

	public StageSelectManager2() { }

	[CompilerGenerated]
	private Task<Result> <Initialize>b__84_0() { }

	[CompilerGenerated]
	private void <Initialize>b__84_1(MusicListViewModel list) { }

	[CompilerGenerated]
	private void <Initialize>b__84_3(MusicListViewModel _model) { }

	[CompilerGenerated]
	private bool <IsEmptyFolderSelected>b__74_0(HeqetMusicFolderModel hmf) { }

	[CompilerGenerated]
	private void <Setup>b__107_0(bool value) { }

	[CompilerGenerated]
	private bool <UpdateFolderPanel>b__121_0(HeqetMusicFolderModel x) { }

	[CompilerGenerated]
	private bool <UpdateFolderPanel>b__121_1(HeqetMusicFolderModel x) { }

	[CompilerGenerated]
	private void <UpdateSortFilter>b__176_0(MusicListViewModel _model) { }

	public void AddResentlyMusicId(int _musicId) { }

	public void ChangeSelectFolder() { }

	public void ChangeSelectMusic() { }

	public void ChangeSelectMusicScroll() { }

	public void ClickFavorite(bool _value) { }

	public void CloseFolderPanel() { }

	private List<HeqetMusicRecord> CreateDispMusicList(List<HeqetMusicRecord> _musicRecods) { }

	private void CreateUnlockIndexList(List<HeqetMusicRecord> _musicRecords, ref List<Int32>& _list) { }

	public int CulcUnlockCost() { }

	public void FolderCancel() { }

	[CompilerGenerated]
	private HeqetStageSelectDisp get_Disp() { }

	[CompilerGenerated]
	private Action get_DispNewCallback() { }

	[CompilerGenerated]
	private bool get_EnableListControll() { }

	[CompilerGenerated]
	private List<HeqetFolderPanelDisp> get_FolderPanels() { }

	public bool get_IsAllDefaultMusicUnlock() { }

	[CompilerGenerated]
	public bool get_IsDispScorePanel() { }

	private bool get_IsFolder() { }

	public bool get_IsMusicListLoading() { }

	public bool get_IsNotApplicableMusic() { }

	public bool get_IsRandomSelect() { }

	public bool get_IsScrollMoving() { }

	[CompilerGenerated]
	private bool get_IsSwapLocalization() { }

	public int get_MusicId() { }

	[CompilerGenerated]
	private List<HeqetMusicPanelDisp> get_MusicPanels() { }

	[CompilerGenerated]
	private Action get_PlayMusicCallback() { }

	public int get_SelectedId() { }

	[CompilerGenerated]
	private SortFilterDisp get_SortFilterDisp() { }

	[CompilerGenerated]
	private StageSelectBgDisp get_StageSelectBgDisp() { }

	public int GetDlcId() { }

	private FolderData GetFolderData(eFilter _filter) { }

	public string GetMusicTitle() { }

	public void Initialize() { }

	public bool IsChildFolder() { }

	private bool IsDispLock() { }

	public bool IsEmptyFolderSelected() { }

	public bool IsParentFolder() { }

	public bool IsUnlockDlc() { }

	public bool IsUnlockDlc(int _id) { }

	public bool IsUnlockMusic() { }

	public bool IsUnlockMusic(int _musicId, int _dlcId) { }

	public void KeyDownScroll(int _value) { }

	public void KeyPressScroll(int _value) { }

	private void OnBeginDragMouse() { }

	private void OnChangeTargetFolderPanelCallback() { }

	private void OnChangeTargetPanelCallback() { }

	private void OnClickDifficulty(MusicDifficulty _diff) { }

	private void OnDragMouse(Vector2 _vec) { }

	private void OnEndDragMouse() { }

	private void OnStateIdleEnd() { }

	private void OnStateIdleFirst() { }

	private void OnStateIdleStart() { }

	private void OnStateIdleStartFolder() { }

	private void OnUpdateLaneMode(LaneMode _laneMode) { }

	private void OnWheelScrollMouse(float _value) { }

	public void OpenFolderPanel() { }

	public void PlayMusic() { }

	public void ReloadFolderList() { }

	[CompilerGenerated]
	public void set_Disp(HeqetStageSelectDisp value) { }

	[CompilerGenerated]
	public void set_DispNewCallback(Action value) { }

	[CompilerGenerated]
	public void set_EnableListControll(bool value) { }

	[CompilerGenerated]
	public void set_FolderPanels(List<HeqetFolderPanelDisp> value) { }

	[CompilerGenerated]
	public void set_IsDispScorePanel(bool value) { }

	[CompilerGenerated]
	public void set_IsSwapLocalization(bool value) { }

	[CompilerGenerated]
	public void set_MusicPanels(List<HeqetMusicPanelDisp> value) { }

	[CompilerGenerated]
	public void set_PlayMusicCallback(Action value) { }

	public void set_ScrollRectEx(ScrollRectEx value) { }

	[CompilerGenerated]
	public void set_SortFilterDisp(SortFilterDisp value) { }

	[CompilerGenerated]
	public void set_StageSelectBgDisp(StageSelectBgDisp value) { }

	private void SetDifficultyByLevel(int _level) { }

	public void SetFolderPearentId() { }

	public void SetFolderType() { }

	public void SetTargetMusicId(int _id) { }

	public void Setup() { }

	private void SetupDifficultyButton(bool _isNone) { }

	private void SetupDifficultyButton() { }

	private void SetupDifficultyButtonByLevel(int _level) { }

	private void SetupDifficultyButtonNone() { }

	public void SetupDisp() { }

	public void SetupMusicCostParam(int _base, float _rate, int _max) { }

	public void StopMusic() { }

	public void UpdateDifficultyDown(int _value) { }

	public void UpdateDifficultyUp(int _value) { }

	private void UpdateDispBackground(Int32[] _BackgroundIds) { }

	public void UpdateDispCenterRandomPanel() { }

	public void UpdateDispChangeCenter() { }

	public void UpdateDispChangeDifficulty() { }

	private void UpdateDispFolderCenter() { }

	private void UpdateDispFolderJacket() { }

	private void UpdateDispGrade() { }

	private void UpdateDispGradeHypen() { }

	private void UpdateDispHiScore() { }

	private void UpdateDispHiScoreHypen() { }

	public void UpdateDispInfo() { }

	private void UpdateDispJacket(int _jacketId) { }

	private void UpdateDispJacket() { }

	private void UpdateDispLock() { }

	public void UpdateDispMoney() { }

	private void UpdateDispMultiJacket(Int32[] _jacketIds) { }

	public void UpdateDispNew() { }

	private void UpdateDispRatingInfo() { }

	private void UpdateDispRatingInfoHypen() { }

	public void UpdateFolder() { }

	private void UpdateFolderCenter() { }

	private void UpdateFolderClearCount() { }

	private void UpdateFolderListOnLaneModeChanged() { }

	private void UpdateFolderPanel() { }

	private void UpdateFolderScroll() { }

	public void UpdateFormationFavorite() { }

	private void UpdateLevelMusicListOnLaneModeChanged() { }

	private void UpdateMusicClearIcon() { }

	public void UpdateMusicList() { }

	private void UpdateMusicListOnLaneModeChanged(LaneMode _laneMode) { }

	public void UpdateMusicPanels() { }

	public void UpdateNew() { }

	public void UpdateSortFilter() { }

	public void UpdateSortInfo() { }

	public void UpdateStageSelectBg() { }

	public void UpdateSwapTitle(bool _enable) { }

	public void UpdateUnlockMusic(int _id, int _cost) { }

	private void ViewScrollSelectFolder(bool _enable) { }

	private void ViewScrollSelectMusic(bool _enable) { }

}

