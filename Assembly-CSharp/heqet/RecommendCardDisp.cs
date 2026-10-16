namespace Heqet;

public class RecommendCardDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public RecommendCardDisp <>4__this; //Field offset: 0xC
		public bool visible; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Close = 0,
		Apply = 1,
		ArrawLeft = 2,
		ArrawRight = 3,
		Max = 4,
	}

	private enum eCommonLayerId
	{
		EquipIcon = 0,
		CardIllust = 1,
		ExpGauge = 2,
		CardDispRoot = 3,
		NotApplicableRoot = 4,
		Max = 5,
	}

	private enum eImageId
	{
		AttrIcon = 0,
		SkillIcon = 1,
		Max = 2,
	}

	private enum eTextId
	{
		Page = 0,
		HeadCategory = 1,
		HeadTitle = 2,
		CardName = 3,
		SkillName = 4,
		SkillDescription = 5,
		CardLv = 6,
		Stock = 7,
		Life = 8,
		Bomb = 9,
		Power = 10,
		NextExp = 11,
		PageText = 12,
		Max = 13,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private RecommendCardLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private AtlasImage m_CardAttrImage; //Field offset: 0x11C
	private AtlasImage m_SkillImage; //Field offset: 0x120
	private CardIllust m_CardIllust; //Field offset: 0x124
	private ShearProgressBarSprite m_expGauge; //Field offset: 0x128
	private Animator RootAnimator; //Field offset: 0x12C

	private static RecommendCardDisp() { }

	public RecommendCardDisp() { }

	[CompilerGenerated]
	private bool <Open>b__20_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__20))]
	public UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	public void SetSpelCardIllust(HeqetCardModel model, QUALITY_MODE a_quality, bool a_isAwake, bool a_isPremium) { }

	public void UpdateDisp(HeqetCardModel cardModel, int listIndex, int listMaxCount, string category, string title, bool isEquip) { }

	protected virtual void UpdateDispMain() { }

}

