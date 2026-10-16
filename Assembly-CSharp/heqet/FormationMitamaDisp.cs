namespace Heqet;

public class FormationMitamaDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public FormationMitamaDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetBeforeCardIconAsync>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public int card_id; //Field offset: 0x8
		public FormationMitamaDisp <>4__this; //Field offset: 0xC
		private CancellationToken <ct>5__2; //Field offset: 0x10
		private AssetBundleLoadAssetOperation <op>5__3; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Back = 0,
		Search = 1,
		Sort = 2,
		Help = 3,
		LvUp = 4,
		Max = 5,
	}

	private enum eCommonLayerId
	{
		ScrollRoot = 0,
		ExpGauge = 1,
		CardIllust = 2,
		BeforeInfoRoot = 3,
		BeforeExpGauge = 4,
		Max = 5,
	}

	private enum eDiff
	{
		Up = 0,
		Down = 1,
		Equal = 2,
	}

	private enum eImageId
	{
		BossElementIcon = 0,
		LevelUpCircle = 1,
		BeforeCardImage = 2,
		SkillIcon = 3,
		Max = 4,
	}

	private enum eTextId
	{
		CardName = 0,
		CardPower = 1,
		SkillName = 2,
		SkillDescription = 3,
		Level = 4,
		Life = 5,
		Mitama = 6,
		Bomb = 7,
		SkillType = 8,
		Money = 9,
		NextExp = 10,
		HeroineName = 11,
		SortText = 12,
		SearchText = 13,
		BeforeLevel = 14,
		BeforeLife = 15,
		BeforeMitama = 16,
		BeforeBomb = 17,
		BeforePower = 18,
		DiffUpLife = 19,
		DiffUpMitama = 20,
		DiffUpBomb = 21,
		DiffUpPower = 22,
		DiffDownLife = 23,
		DiffDownMitama = 24,
		DiffDownBomb = 25,
		DiffDownPower = 26,
		DiffEqualLife = 27,
		DiffEqualMitama = 28,
		DiffEqualBomb = 29,
		DiffEqualPower = 30,
		NoHitText = 31,
		Max = 32,
	}

	private static int DEFAULT_SKIN_ID; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x4
	private static readonly Int32[] DiffLifeIds; //Field offset: 0x8
	private static readonly Int32[] DiffPowerIds; //Field offset: 0xC
	private static readonly Int32[] DiffMitamaIds; //Field offset: 0x10
	private static readonly Int32[] DiffBombIds; //Field offset: 0x14
	private static readonly String[] m_ImageList; //Field offset: 0x18
	private static readonly String[] m_LayerIdList; //Field offset: 0x1C
	private FormationMitamaLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private TextMeshProUGUI m_MitamaCardName; //Field offset: 0x120
	private TextMeshProUGUI m_CardPower; //Field offset: 0x124
	private TextMeshProUGUI m_SkillName; //Field offset: 0x128
	private TextMeshProUGUI m_SkillDescription; //Field offset: 0x12C
	private TextMeshProUGUI m_Level; //Field offset: 0x130
	private TextMeshProUGUI m_Life; //Field offset: 0x134
	private TextMeshProUGUI m_Mitama; //Field offset: 0x138
	private TextMeshProUGUI m_Bomb; //Field offset: 0x13C
	private TextMeshProUGUI m_SkillType; //Field offset: 0x140
	private TextMeshProUGUI m_Money; //Field offset: 0x144
	private TextMeshProUGUI m_NextExp; //Field offset: 0x148
	private TextMeshProUGUI m_HeroineName; //Field offset: 0x14C
	private AtlasImage m_AttrImage; //Field offset: 0x150
	private AtlasImage m_LevelUpCircleImage; //Field offset: 0x154
	private AtlasImage m_SkillIconImage; //Field offset: 0x158
	private RawImageEx m_beforeCardImage; //Field offset: 0x15C
	private int m_lastLoadBeforeCardId; //Field offset: 0x160
	private CardIllust m_CardIllust; //Field offset: 0x164
	private ShearProgressBarSprite m_ExpGauge; //Field offset: 0x168
	private ShearProgressBarSprite m_BeforeExpGauge; //Field offset: 0x16C
	private float m_SkillDescFontSize; //Field offset: 0x170
	private int m_lastLoadCardImageId; //Field offset: 0x174

	public bool isPressLvUpButton
	{
		 get { } //Length: 43
	}

	private static FormationMitamaDisp() { }

	public FormationMitamaDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__40_0(AxisEventData eventData) { }

	[CompilerGenerated]
	private void <InitUguiOther>b__40_1(AxisEventData eventData) { }

	[CompilerGenerated]
	private GameObject <InitUguiOther>b__40_2() { }

	[CompilerGenerated]
	private bool <Open>b__51_0() { }

	[CompilerGenerated]
	private void <SetSpelCardIllust>b__53_0() { }

	public void CallbackButtonUp(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public bool get_isPressLvUpButton() { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__51))]
	public UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	[AsyncStateMachine(typeof(<SetBeforeCardIconAsync>d__54))]
	private UniTaskVoid SetBeforeCardIconAsync(int card_id) { }

	private void SetDiffParam(Int32[] textIds, int value) { }

	public void SetLevelUpCircle(float ratio) { }

	public void SetSpelCardIllust(int mitamaCardId) { }

	public void UpdateDisp(CardData selectCardData, CardData equipCardData) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateNoHitTextVisibility(bool visible) { }

	public void UpdateSortAndFilerDisp(bool isFilter, string sortName) { }

	private void VisibleDiffParam(Int32[] textIds, bool visible) { }

}

