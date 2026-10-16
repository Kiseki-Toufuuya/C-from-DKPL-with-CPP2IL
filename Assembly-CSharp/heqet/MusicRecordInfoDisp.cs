namespace Heqet;

public class MusicRecordInfoDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public MusicRecordInfoDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Screen = 0,
		Close = 1,
		PrevDifficulty = 2,
		NextDifficulty = 3,
		PrevLane = 4,
		NextLane = 5,
		SwapPanelInfo = 6,
		Max = 7,
	}

	private enum eCommonLayerId
	{
		ScrollRoot = 0,
		ScoreInfoRoot = 1,
		RatingInfoRoot = 2,
		ScoreCamma_1 = 3,
		ScoreCamma_2 = 4,
		ScoreCamma_3 = 5,
		ClearInfoStageClear = 6,
		ClearInfoFullCombo = 7,
		ClearInfoAllBrilliant = 8,
		ClearInfoFramePerfect = 9,
		Diff1 = 10,
		Diff2 = 11,
		Diff3 = 12,
		Diff4 = 13,
		DiffRoot = 14,
		Lane6Key = 15,
		Lane4Key = 16,
		Max = 17,
	}

	internal enum eGameType
	{
		Kagura = 0,
		Danmaku = 1,
	}

	internal enum eHighScoreAtlasImage
	{
		SUJI_0 = 0,
		SUJI_1 = 1,
		SUJI_2 = 2,
		SUJI_3 = 3,
		SUJI_4 = 4,
		SUJI_5 = 5,
		SUJI_6 = 6,
		SUJI_7 = 7,
		SUJI_8 = 8,
		SUJI_9 = 9,
		SUJI_10 = 10,
		NUM = 11,
	}

	private enum eImageId
	{
		JacketIcon = 0,
		RankIcon = 1,
		CategoryBadge = 2,
		Max = 3,
	}

	internal enum eModeType
	{
		StoryMode = 0,
		FreeMode = 1,
	}

	private enum ePanelAnimType
	{
		DisableLoop = 0,
		Entry = 1,
		EnableLoop = 2,
		Egress = 3,
	}

	private enum eTextId
	{
		MusicName = 0,
		Bpm = 1,
		HeightScore = 2,
		TextDiff1 = 3,
		TextDiff2 = 4,
		TextDiff3 = 5,
		TextDiff4 = 6,
		NUM = 7,
	}

	private static readonly String[] m_ImageList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private static Int32[] DisplayInfos; //Field offset: 0x8
	private static readonly String[] m_TextList; //Field offset: 0xC
	private String[] m_ButtonDataList; //Field offset: 0x114
	private readonly String[] RANKS; //Field offset: 0x118
	private readonly String[] BADGES; //Field offset: 0x11C
	private readonly string HIGHSCORE_SPRITE; //Field offset: 0x120
	private readonly string HIGHSCORE_PATH; //Field offset: 0x124
	private List<AtlasImage> m_HighScoreAtlasImgs; //Field offset: 0x128
	private List<Sprite> m_NumberSprites; //Field offset: 0x12C
	private AtlasImage m_MaxLankImage; //Field offset: 0x130
	private AtlasImage m_BadgeImage; //Field offset: 0x134
	private Animator RootAnimator; //Field offset: 0x138
	[CompilerGenerated]
	private Action<Int32> <OnPressButtonAction>k__BackingField; //Field offset: 0x13C
	private int m_JacketId; //Field offset: 0x140
	private RawImageEx m_JacketImage; //Field offset: 0x144
	private JacketAssetBunleLoader m_JacketLoader; //Field offset: 0x148
	private GameObject m_CloseButton; //Field offset: 0x14C
	private Animator m_ScorePanelAnimator; //Field offset: 0x150
	private Animator m_RatingPanelAnimator; //Field offset: 0x154
	private RatingInfo m_RatingInfoPanel; //Field offset: 0x158
	private String[] PanelAnimName; //Field offset: 0x15C
	private bool isDisplayScore; //Field offset: 0x160

	public GameObject CloseButton
	{
		 get { } //Length: 14
	}

	public bool IsDisplayScore
	{
		 get { } //Length: 14
		 set { } //Length: 134
	}

	public Action<Int32> OnPressButtonAction
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static MusicRecordInfoDisp() { }

	public MusicRecordInfoDisp() { }

	[CompilerGenerated]
	private bool <Open>b__45_0() { }

	[CompilerGenerated]
	private void <UpdateDisp>b__50_0(AssetBundleLoadAssetOperation ope) { }

	public void CallbackButton(int id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void GenerateHighScore(long num) { }

	public GameObject get_CloseButton() { }

	public bool get_IsDisplayScore() { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButtonAction() { }

	public GameObject GetScrollRoot() { }

	public virtual void InitLoadAfter() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__45))]
	public UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	public void set_IsDisplayScore(bool value) { }

	[CompilerGenerated]
	public void set_OnPressButtonAction(Action<Int32> value) { }

	public void SwapInfoAnimation(bool displayScore) { }

	public void UpdateDisp(int mudicId, eModeType modeType, eGameType gameType, int _difficulty, LaneMode _laneMode, int _stageId, bool isVisibleScoreInfo) { }

	protected virtual void UpdateDispMain() { }

}

