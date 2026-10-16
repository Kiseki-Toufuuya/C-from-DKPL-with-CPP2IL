namespace Heqet;

public class ConfirmationDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public Image boosterIcon; //Field offset: 0x8

		public <>c__DisplayClass58_0() { }

		internal void <UpdateBoosterIcons>b__0(AssetBundleLoadAssetOperation asset) { }

	}

	[CompilerGenerated]
	private struct <Open>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public ConfirmationDisp <>4__this; //Field offset: 0xC
		public bool visible; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		GotoPlay = 0,
		FormationInfo = 1,
		BooseterInfo = 2,
		FooterBack = 3,
		FooterGotoPlay = 4,
		FooterMusicInfo = 5,
		FooterFormation = 6,
		FooterBooster = 7,
		FooterRecommend = 8,
		FooterRewardInfo = 9,
		DifficultyButtonEasy = 10,
		DifficultyButtonNormal = 11,
		DifficultyButtonHard = 12,
		DifficultyButtonLunatic = 13,
		DifficultyButtonLeft = 14,
		DifficultyButtonRight = 15,
		LaneButtonRight = 16,
		LaneButtonLeft = 17,
		Max = 18,
	}

	private enum eCommonLayerId
	{
		CardIllust = 0,
		DifficultyTop = 1,
		kindKagura = 2,
		KindDanmaku = 3,
		BoosterIcon_root_1 = 4,
		BoosterIcon_root_2 = 5,
		BoosterIcon_root_3 = 6,
		BoosterIcon_root_4 = 7,
		BoosterIcon_root_5 = 8,
		BoosterIcon_root_6 = 9,
		BoosterIcon_root_7 = 10,
		BoosterIcon_root_8 = 11,
		BoosterIcon_deactive_1 = 12,
		BoosterIcon_deactive_2 = 13,
		BoosterIcon_deactive_3 = 14,
		BoosterIcon_deactive_4 = 15,
		BoosterIcon_deactive_5 = 16,
		BoosterIcon_deactive_6 = 17,
		BoosterIcon_deactive_7 = 18,
		BoosterIcon_deactive_8 = 19,
		CardElementAdvantageIcon = 20,
		LaneMode_4 = 21,
		LaneMode_6 = 22,
		Max = 23,
	}

	internal enum eDifficulty
	{
		easy = 0,
		normal = 1,
		hard = 2,
		lunatic = 3,
		max = 4,
	}

	private enum eImageId
	{
		BossIcon = 0,
		StageBack = 1,
		JacketIcon = 2,
		BossElementIcon = 3,
		MainHeroinIcon = 4,
		SubHeroineIcon = 5,
		RewardIcon_1 = 6,
		RewardIcon_2 = 7,
		RewardIcon_3 = 8,
		BoosterIcon_1 = 9,
		BoosterIcon_2 = 10,
		BoosterIcon_3 = 11,
		BoosterIcon_4 = 12,
		BoosterIcon_5 = 13,
		BoosterIcon_6 = 14,
		BoosterIcon_7 = 15,
		BoosterIcon_8 = 16,
		CardElementIcon = 17,
		Max = 18,
	}

	private enum eTextId
	{
		MissonInfo = 0,
		GimmickInfo = 1,
		StageDifficulty = 2,
		BossName = 3,
		BossSecondName = 4,
		MusicName = 5,
		Bpm = 6,
		Max = 7,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private const int booster_icon_num = 7; //Field offset: 0x0
	private const string REARD_ON_ICON_SPRITE_NAME = "reward_icon_on"; //Field offset: 0x0
	private const string REARD_OFF_ICON_SPRITE_NAME = "reward_icon_off"; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private ConfirmationLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private AtlasImage[] m_RewardIcons; //Field offset: 0x120
	private TextMeshProUGUI m_MissonInfoText; //Field offset: 0x124
	private TextMeshProUGUI m_GimmickInfoText; //Field offset: 0x128
	private TextMeshProUGUI m_StageDifficulty; //Field offset: 0x12C
	private TextMeshProUGUI m_BossNameText; //Field offset: 0x130
	private TextMeshProUGUI m_BossSecondNameText; //Field offset: 0x134
	private TextMeshProUGUI m_MusicNameText; //Field offset: 0x138
	private int m_BossIconId; //Field offset: 0x13C
	private int m_BossSkinIconId; //Field offset: 0x140
	private RawImageEx m_BossIconImage; //Field offset: 0x144
	private int m_StageBgId; //Field offset: 0x148
	private RawImageEx m_StageBgImage; //Field offset: 0x14C
	private int m_JacketId; //Field offset: 0x150
	private RawImageEx m_JacketImage; //Field offset: 0x154
	private JacketAssetBunleLoader m_JacketLoader; //Field offset: 0x158
	private int m_MainHeroineIconId; //Field offset: 0x15C
	private int m_MainHeroineSkinId; //Field offset: 0x160
	private RawImageEx m_MainHeroineIconImage; //Field offset: 0x164
	private int m_SubHeroineIconId; //Field offset: 0x168
	private int m_SubHeroineSkinId; //Field offset: 0x16C
	private RawImageEx m_SubHeroineIconImage; //Field offset: 0x170
	private CardIllust m_CardIllust; //Field offset: 0x174
	private int m_BossAttrId; //Field offset: 0x178
	private AtlasImage m_BossAttrImage; //Field offset: 0x17C
	private AtlasImage m_CardAttrImage; //Field offset: 0x180
	[CompilerGenerated]
	private eDifficulty <Difficulty>k__BackingField; //Field offset: 0x184
	[CompilerGenerated]
	private LaneMode <LaneMode>k__BackingField; //Field offset: 0x188
	private DifficultyButton[] m_DifficultyButtons; //Field offset: 0x18C
	private IList<WorldBoosterModel> m_boostItemList; //Field offset: 0x190

	public private eDifficulty Difficulty
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public private LaneMode LaneMode
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	private static ConfirmationDisp() { }

	public ConfirmationDisp() { }

	[CompilerGenerated]
	private bool <Open>b__62_0() { }

	[CompilerGenerated]
	private void <UpdateDisp>b__57_0(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <UpdateDisp>b__57_1(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <UpdateDisp>b__57_2(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <UpdateFormation>b__59_0(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <UpdateFormation>b__59_1(AssetBundleLoadAssetOperation ope) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public eDifficulty get_Difficulty() { }

	[CompilerGenerated]
	public LaneMode get_LaneMode() { }

	protected virtual void InitUguiOther() { }

	public bool isLoadedImages() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__62))]
	public UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	private bool SelectDifficulty(int difficulty) { }

	public void SelectLaneModey(LaneMode laneMode, WorldStageModel stageModel) { }

	public void SequenceDifficulty(int offset) { }

	[CompilerGenerated]
	private void set_Difficulty(eDifficulty value) { }

	[CompilerGenerated]
	private void set_LaneMode(LaneMode value) { }

	public void SetSpelCardIllust(HeqetCardModel model, QUALITY_MODE a_quality, bool a_isAwake, bool a_isPremium) { }

	public void UpdateBoosterIcons(WorldStageModel stageModel) { }

	public int UpdateDisp(WorldStageModel stageModel, int difficulty, LaneMode laneMode) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateFormation() { }

}

