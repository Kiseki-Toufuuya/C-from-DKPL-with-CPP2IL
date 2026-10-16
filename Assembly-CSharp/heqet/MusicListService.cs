namespace Heqet;

public class MusicListService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<HeqetMusicRecord> <>9__38_0; //Field offset: 0x4
		public static Predicate<HeqetMusicRecord> <>9__39_0; //Field offset: 0x8
		public static Predicate<HeqetMusicRecord> <>9__40_0; //Field offset: 0xC
		public static Predicate<HeqetMusicRecord> <>9__42_0; //Field offset: 0x10
		public static Predicate<HeqetMusicRecord> <>9__43_0; //Field offset: 0x14
		public static Predicate<HeqetMusicRecord> <>9__44_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <GetFolderRecordBaseGame>b__44_0(HeqetMusicRecord value) { }

		internal bool <GetFolderRecordCollaboSongs>b__39_0(HeqetMusicRecord value) { }

		internal bool <GetFolderRecordDankaguOriginal>b__42_0(HeqetMusicRecord value) { }

		internal bool <GetFolderRecordNewRelease>b__40_0(HeqetMusicRecord value) { }

		internal bool <GetFolderRecordOpenCall>b__43_0(HeqetMusicRecord value) { }

		internal bool <GetFolderRecordOriginalSongs>b__38_0(HeqetMusicRecord value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public eFilter _filter; //Field offset: 0x8

		public <>c__DisplayClass30_0() { }

		internal bool <GetFolderMusicRecordList>b__0(HeqetMusicFolderModel x) { }

		internal bool <GetFolderMusicRecordList>b__1(DlcListModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public int _id; //Field offset: 0x8

		public <>c__DisplayClass31_0() { }

		internal bool <IsParentFolder>b__0(HeqetMusicFolderModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public int _id; //Field offset: 0x8

		public <>c__DisplayClass32_0() { }

		internal bool <GetChildFolder>b__0(HeqetMusicFolderModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public eFilter _filter; //Field offset: 0x8

		public <>c__DisplayClass33_0() { }

		internal bool <GetFolderData>b__0(DlcListModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public int id; //Field offset: 0x8

		public <>c__DisplayClass41_0() { }

		internal bool <GetFolderRecordRecently>b__0(HeqetMusicRecord value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public int _value; //Field offset: 0x8

		public <>c__DisplayClass45_0() { }

		internal bool <GetFloderRecordDlc>b__0(HeqetMusicRecord x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_1
	{
		public int id; //Field offset: 0x8

		public <>c__DisplayClass45_1() { }

		internal bool <GetFloderRecordDlc>b__1(HeqetMusicRecord value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public int id; //Field offset: 0x8

		public <>c__DisplayClass46_0() { }

		internal bool <GetFloderRecordLevel>b__0(HeqetMusicRecord value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_1
	{
		public int id; //Field offset: 0x8

		public <>c__DisplayClass46_1() { }

		internal bool <GetFloderRecordLevel>b__1(HeqetMusicRecord value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public HeqetMusicRecord _record; //Field offset: 0x8

		public <>c__DisplayClass53_0() { }

		internal bool <CheckStageTypeFilter>b__0() { }

	}

	[CompilerGenerated]
	private struct <InitializeRawPlayMuiscs>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public MusicListService <>4__this; //Field offset: 0x10
		private YieldAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitilaizeAsync>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Result> <>t__builder; //Field offset: 0x4
		public MusicListService <>4__this; //Field offset: 0x10
		public bool isStageSelect; //Field offset: 0x14
		public Sort sort; //Field offset: 0x18
		public Order order; //Field offset: 0x1C
		public ulong filter; //Field offset: 0x20
		public string searchName; //Field offset: 0x28
		public MusicDifficulty difficulty; //Field offset: 0x2C
		public LaneMode laneMode; //Field offset: 0x30
		public int level; //Field offset: 0x34
		public Action<MusicListViewModel> onSuccess; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x3C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eFilter
	{
		All = 1,
		DlcIndex = 10,
		FreeDlcIndex = 50,
		NewRelese = 80,
		OriginalSong = 81,
		CollabSong = 82,
		DankaguOriginal = 83,
		OpenCall = 84,
		Recenty = 90,
		BaseGame = 91,
		LevelParent = 92,
		DlcParent = 93,
		Level = 10000,
	}

	internal enum Filter
	{
		NONE = 0,
		UNLOCK_ALL = 1,
		UNLOCK = 2,
		UNLOCK_NONE = 3,
		FAVORITE_ALL = 4,
		FAVORITE_ONLY = 5,
		STAGE_TYPE_ALL = 6,
		STAGE_TYPE_NOMAL = 7,
		STAGE_TYPE_MEDLAY = 8,
		RANK_ALL = 9,
		RANK_SS = 10,
		RANK_S = 11,
		RANK_A = 12,
		RANK_B = 13,
		RANK_C = 14,
		RANK_D = 15,
		STAGE_CLEAR_ALL = 16,
		STAGE_CLEAR = 17,
		STAGE_CLEAR_NONE = 18,
		FRAME_PERFECT_ALL = 19,
		FRAME_PERFECT = 20,
		FRAME_PERFECT_NONE = 21,
		BRILLIANT_ALL = 22,
		BRILLIANT = 23,
		BRILLIANT_NONE = 24,
		FULLCOMBO_ALL = 25,
		FULLCOMBO = 26,
		FULLCOMBO_NONE = 27,
		SERIES_ALL = 28,
		SERIES_1 = 29,
		SERIES_2 = 30,
		SERIES_3 = 31,
		SERIES_4 = 32,
		SERIES_5 = 33,
		SERIES_6 = 34,
		SERIES_7 = 35,
		SERIES_8 = 36,
		SERIES_9 = 37,
		SERIES_10 = 38,
		SERIES_11 = 39,
		SERIES_12 = 40,
		SERIES_13 = 41,
		SERIES_14 = 42,
		SERIES_15 = 43,
		SERIES_16 = 44,
		SERIES_17 = 45,
		SERIES_18 = 46,
		SERIES_19 = 47,
		SERIES_20 = 48,
		SERIES_21 = 49,
		SERIES_22 = 50,
		SERIES_23 = 51,
		SERIES_24 = 52,
		SERIES_25 = 53,
		SERIES_26 = 54,
		SERIES_27 = 55,
		SERIES_28 = 56,
		SERIES_29 = 57,
		SERIES_30 = 58,
		SERIES_31 = 59,
		SERIES_32 = 60,
		SERIES_33 = 61,
	}

	internal class FolderData
	{
		public int MusicCount; //Field offset: 0x8
		public Int32[2] MusicClearCount; //Field offset: 0xC
		public Int32[2] MusicClearFlg; //Field offset: 0x10
		public Int32[] ViewClearIcon; //Field offset: 0x14
		public Int32[] MusicIdList; //Field offset: 0x18
		public Int32[] MusicBgIds; //Field offset: 0x1C
		public bool keyLock; //Field offset: 0x20

		public FolderData() { }

	}

	internal class LevelFolderData
	{
		public Int32[] MusicCount; //Field offset: 0x8
		public Int32[2] MusicClearCount; //Field offset: 0xC
		public Int32[2] MusicClearFlg; //Field offset: 0x10
		public Int32[] ViewClearIcon; //Field offset: 0x14
		public Boolean[] keyLock; //Field offset: 0x18

		public LevelFolderData() { }

	}

	public class MusicListSorter
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<MusicSortParams, Int64> <>9__7_1; //Field offset: 0x4
			public static Func<MusicSortParams, Int64> <>9__7_2; //Field offset: 0x8
			public static Func<MusicSortParams, Int32> <>9__8_0; //Field offset: 0xC
			public static Func<MusicSortParams, Int32> <>9__8_1; //Field offset: 0x10
			public static Func<MusicSortParams, Single> <>9__8_2; //Field offset: 0x14
			public static Func<MusicSortParams, Single> <>9__8_3; //Field offset: 0x18
			public static Func<MusicSortParams, String> <>9__8_4; //Field offset: 0x1C
			public static Func<MusicSortParams, String> <>9__8_5; //Field offset: 0x20
			public static Func<MusicSortParams, String> <>9__8_6; //Field offset: 0x24
			public static Func<MusicSortParams, String> <>9__8_7; //Field offset: 0x28
			public static Func<MusicSortParams, Single> <>9__8_8; //Field offset: 0x2C
			public static Func<MusicSortParams, Single> <>9__8_9; //Field offset: 0x30
			public static Func<MusicSortParams, Int32> <>9__8_10; //Field offset: 0x34
			public static Func<MusicSortParams, Int32> <>9__8_11; //Field offset: 0x38
			public static Func<MusicSortParams, Int32> <>9__8_12; //Field offset: 0x3C
			public static Func<MusicSortParams, Int32> <>9__8_13; //Field offset: 0x40
			public static Func<MusicSortParams, Int32> <>9__8_14; //Field offset: 0x44
			public static Func<MusicSortParams, Int32> <>9__8_15; //Field offset: 0x48
			public static Func<MusicSortParams, Int32> <>9__8_16; //Field offset: 0x4C
			public static Func<MusicSortParams, Int32> <>9__8_17; //Field offset: 0x50
			public static Func<MusicSortParams, Int32> <>9__8_18; //Field offset: 0x54
			public static Func<MusicSortParams, Int32> <>9__8_19; //Field offset: 0x58

			private static <>c() { }

			public <>c() { }

			internal long <GetSorted>b__7_1(MusicSortParams a) { }

			internal long <GetSorted>b__7_2(MusicSortParams a) { }

			internal int <GetSortedFirstParam>b__8_0(MusicSortParams a) { }

			internal int <GetSortedFirstParam>b__8_1(MusicSortParams a) { }

			internal int <GetSortedFirstParam>b__8_10(MusicSortParams a) { }

			internal int <GetSortedFirstParam>b__8_11(MusicSortParams a) { }

			internal int <GetSortedFirstParam>b__8_12(MusicSortParams a) { }

			internal int <GetSortedFirstParam>b__8_13(MusicSortParams a) { }

			internal int <GetSortedFirstParam>b__8_14(MusicSortParams a) { }

			internal int <GetSortedFirstParam>b__8_15(MusicSortParams a) { }

			internal int <GetSortedFirstParam>b__8_16(MusicSortParams a) { }

			internal int <GetSortedFirstParam>b__8_17(MusicSortParams a) { }

			internal int <GetSortedFirstParam>b__8_18(MusicSortParams a) { }

			internal int <GetSortedFirstParam>b__8_19(MusicSortParams a) { }

			internal float <GetSortedFirstParam>b__8_2(MusicSortParams a) { }

			internal float <GetSortedFirstParam>b__8_3(MusicSortParams a) { }

			internal string <GetSortedFirstParam>b__8_4(MusicSortParams a) { }

			internal string <GetSortedFirstParam>b__8_5(MusicSortParams a) { }

			internal string <GetSortedFirstParam>b__8_6(MusicSortParams a) { }

			internal string <GetSortedFirstParam>b__8_7(MusicSortParams a) { }

			internal float <GetSortedFirstParam>b__8_8(MusicSortParams a) { }

			internal float <GetSortedFirstParam>b__8_9(MusicSortParams a) { }

		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			public MusicSortParams obj; //Field offset: 0x8

			public <>c__DisplayClass7_0() { }

			internal bool <GetSorted>b__4(HeqetMusicRecord record) { }

		}

		private struct MusicSortParams
		{
			public long Id; //Field offset: 0x0
			public string Name; //Field offset: 0x8
			public string Circle; //Field offset: 0xC
			public float Judgment; //Field offset: 0x10
			public float Level; //Field offset: 0x14
			public int Rank; //Field offset: 0x18
			public int HighScore; //Field offset: 0x1C
			public int Nnotes; //Field offset: 0x20
			public int PlayCount; //Field offset: 0x24
			public int Series; //Field offset: 0x28
			public int sortNo; //Field offset: 0x2C

		}

		private List<HeqetMusicRecord> m_Records; //Field offset: 0x8
		private MusicDifficulty m_Difficulty; //Field offset: 0xC
		private LaneMode m_LaneMode; //Field offset: 0x10
		private bool IsSwapLocalizationJapanese; //Field offset: 0x14
		private HeqetMusicSelectionModel m_tmpHeqetMusicSelection; //Field offset: 0x18

		public MusicListSorter(List<HeqetMusicRecord> records, MusicDifficulty selectDiff, bool _swapjapanese, LaneMode _laneMode) { }

		[CompilerGenerated]
		private MusicSortParams <GetSorted>b__7_0(HeqetMusicRecord record) { }

		[CompilerGenerated]
		private HeqetMusicRecord <GetSorted>b__7_3(MusicSortParams obj) { }

		public List<HeqetMusicRecord> GetSorted(Sort sort, Order order) { }

		private IOrderedEnumerable<MusicSortParams> GetSortedFirstParam(IEnumerable<MusicSortParams> list, Sort sort, Order order) { }

	}

	internal class MusicListViewModel
	{
		public List<HeqetMusicRecord> HeqetMusics; //Field offset: 0x8

		public MusicListViewModel() { }

	}

	internal enum Order
	{
		ASC = 0,
		DESC = 1,
	}

	internal enum Result
	{
		Success = 0,
		Cancel = 1,
		ErrorToTitle = 2,
	}

	internal enum Sort
	{
		ID = 0,
		NAME = 1,
		CIRCLE = 2,
		JUDGMENT = 3,
		LEVEL = 4,
		RANK = 5,
		HIGH_SCORE = 6,
		TOTAL_NOTES = 7,
		PLAY_COUNT = 8,
		SERIES = 9,
	}

	private static MusicListService instance; //Field offset: 0x0
	public readonly int DEFAULT_MUSIC_UNLOCK_ALL_DLC_ID; //Field offset: 0x8
	private readonly int RECENTLY_PLAY_COUNT_MAX; //Field offset: 0xC
	public bool IsSwapLocalizationJapanese; //Field offset: 0x10
	public SortFilterStatusModel SortFilter; //Field offset: 0x14
	private List<HeqetMusicRecord> m_HeqetMusicRecords; //Field offset: 0x18
	private List<HeqetMusicRecord> m_HeqetMusicFolderRecords; //Field offset: 0x1C
	private MusicListViewModel m_ViewModel; //Field offset: 0x20
	private Dictionary<Int32, Dictionary`2<Int32, List`1<Int32>>> m_MusicLevelFolders; //Field offset: 0x24
	private Dictionary<Int32, List`1<Int32>> m_MusicDlcFolders; //Field offset: 0x28

	public static ulong FilterAllMask
	{
		 get { } //Length: 8
	}

	public static MusicListService Instance
	{
		 get { } //Length: 356
	}

	public MusicListViewModel ViewModel
	{
		 get { } //Length: 11
	}

	public MusicListService() { }

	public void AddResentlyMusicId(int _musicId) { }

	public void ChangeSortFilter(int sort, int order, ulong filter, string searchName, MusicDifficulty _difficulty, LaneMode _laneMode, int _level, Action<MusicListViewModel> onSuccess) { }

	private bool CheckMusicFavoriteFilter(ulong _filter, HeqetMusicRecord _record) { }

	private bool CheckMusicReleseFilter(ulong _filter, HeqetMusicRecord _record) { }

	private bool CheckSeriesFilter(ulong _filter, HeqetMusicRecord _record) { }

	private bool CheckStageAllBrilliantFilter(ulong _filter, HeqetMusicRecord _record, MusicDifficulty _difficulty, LaneMode _laneMode) { }

	private bool CheckStageClearFilter(ulong _filter, HeqetMusicRecord _record, MusicDifficulty _difficulty, LaneMode _laneMode) { }

	private bool CheckStageFramePerfectFilter(ulong _filter, HeqetMusicRecord _record, MusicDifficulty _difficulty, LaneMode _laneMode) { }

	private bool CheckStageFullComboFilter(ulong _filter, HeqetMusicRecord _record, MusicDifficulty _difficulty, LaneMode _laneMode) { }

	private bool CheckStageRankFilter(ulong _filter, HeqetMusicRecord _record, MusicDifficulty _difficulty, LaneMode _laneMode) { }

	private bool CheckStageTypeFilter(ulong _filter, HeqetMusicRecord _record) { }

	private void ExcuteFilter(ulong _filter, List<HeqetMusicRecord> _records, out List<HeqetMusicRecord>& _list, MusicDifficulty _difficulty, LaneMode _laneMode) { }

	private void ExcuteSort(Sort _sort, Order _order, ref List<HeqetMusicRecord>& _list, MusicDifficulty _difficulty, LaneMode _laneMode) { }

	public static ulong get_FilterAllMask() { }

	public static MusicListService get_Instance() { }

	public MusicListViewModel get_ViewModel() { }

	public HeqetMusicFolderModel GetChildFolder(int _id) { }

	public List<HeqetMusicRecord> GetFloderRecordDlc(int _value) { }

	public List<HeqetMusicRecord> GetFloderRecordLevel(LaneMode _laneMode, int _level) { }

	public FolderData GetFolderData(eFilter _filter) { }

	private List<HeqetMusicRecord> GetFolderMusicRecordList(eFilter _filter, LaneMode _lane) { }

	public List<HeqetMusicRecord> GetFolderRecordBaseGame() { }

	public List<HeqetMusicRecord> GetFolderRecordCollaboSongs() { }

	public List<HeqetMusicRecord> GetFolderRecordDankaguOriginal() { }

	public List<HeqetMusicRecord> GetFolderRecordNewRelease() { }

	public List<HeqetMusicRecord> GetFolderRecordOpenCall() { }

	public List<HeqetMusicRecord> GetFolderRecordOriginalSongs() { }

	public List<HeqetMusicRecord> GetFolderRecordRecently() { }

	private void GetLevelFolderClearData(eFilter _filter, ref FolderData _ret, List<HeqetMusicRecord> _datas) { }

	public LevelFolderData GetLevelFolderData(eFilter _filter) { }

	private void GetNormalFolderClearData(eFilter _filter, ref FolderData _ret, List<HeqetMusicRecord> _datas) { }

	public List<HeqetMusicRecord> GetSortFilterRecord(MusicDifficulty _difficulty, LaneMode _laneMode, int _level) { }

	public List<HeqetMusicRecord> GetSortFilterRecordByLevel(MusicDifficulty _difficulty, LaneMode _laneMode, int _level) { }

	private List<HeqetMusicRecord> GetSortFilterRecordByString(string _filter, List<HeqetMusicRecord> _records) { }

	[AsyncStateMachine(typeof(<InitializeRawPlayMuiscs>d__25))]
	private Task InitializeRawPlayMuiscs(bool isStageSelect) { }

	[AsyncStateMachine(typeof(<InitilaizeAsync>d__24))]
	public Task<Result> InitilaizeAsync(Action<MusicListViewModel> onSuccess, Action onErrorToTitle, bool isStageSelect, Sort sort = 0, Order order = 0, ulong filter = 18446744073709551615, string searchName = null, MusicDifficulty difficulty = 0, LaneMode laneMode = 0, int level = -1, bool force = false) { }

	private bool IsAllHeqetMusicRecordDlc(List<HeqetMusicRecord> _datas) { }

	public bool IsParentFolder(int _id) { }

	public void UpdateFloderRecord(eFilter _filter) { }

	public void UpdateFloderRecord(eFilter _filter, LaneMode _lane) { }

}

