namespace Heqet;

public class AchievementRewardDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public AchievementRewardDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Close = 0,
		Max = 1,
	}

	private enum eCommonLayerId
	{
		CardRoot = 0,
		CardPossess = 1,
		CardNotPossess = 2,
		CardIllust = 3,
		CardExpGauge = 4,
		Arrow = 5,
		Heroine = 6,
		Max = 7,
	}

	private enum eImageId
	{
		CardAttrIcon = 0,
		CardSkillIcon = 1,
		Max = 2,
	}

	private enum eTextId
	{
		CardName = 0,
		CardSkillName = 1,
		CardSkillDescription = 2,
		CardCardLv = 3,
		CardStock = 4,
		CardLife = 5,
		CardBomb = 6,
		CardPower = 7,
		CardNextExp = 8,
		RewardHeader = 9,
		PageText = 10,
		Max = 11,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private static int s_SkinId; //Field offset: 0xC
	private AchievementRewardLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private AtlasImage m_CardAttrImage; //Field offset: 0x120
	private AtlasImage m_CardSkillImage; //Field offset: 0x124
	private CardIllust m_CardIllust; //Field offset: 0x128
	private ShearProgressBarSprite m_CardExpGauge; //Field offset: 0x12C

	private static AchievementRewardDisp() { }

	public AchievementRewardDisp() { }

	[CompilerGenerated]
	private bool <Open>b__21_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__21))]
	public UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	public void SetSpelCardIllust(HeqetCardModel model, QUALITY_MODE a_quality, bool a_isAwake, bool a_isPremium) { }

	public void UpdateCardDisp(HeqetCardModel cardModel, bool isPossess) { }

	public void UpdateDisp(int listIndex, int listMaxCount) { }

	protected virtual void UpdateDispMain() { }

}

