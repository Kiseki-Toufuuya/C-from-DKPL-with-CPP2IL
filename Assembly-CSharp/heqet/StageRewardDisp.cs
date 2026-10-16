namespace Heqet;

public class StageRewardDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public StageRewardDisp <>4__this; //Field offset: 0xC
		public bool visible; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Close = 0,
		ArrawLeft = 1,
		ArrawRight = 2,
		Max = 3,
	}

	private enum eCommonLayerId
	{
		HeroineRoot = 0,
		HeroinePossess = 1,
		HeroineNotPossess = 2,
		CardRoot = 3,
		CardPossess = 4,
		CardNotPossess = 5,
		CardIllust = 6,
		CardExpGauge = 7,
		MoneyRoot = 8,
		MoneyPossess = 9,
		MoneyNotPossess = 10,
		Max = 11,
	}

	private enum eImageId
	{
		HeroineImage = 0,
		HeroineSkillIcon = 1,
		CardAttrIcon = 2,
		CardSkillIcon = 3,
		Max = 4,
	}

	private enum eTextId
	{
		HeroineName = 0,
		HeroineSkillName = 1,
		HeroineSkillDescription = 2,
		HeroineStock = 3,
		HeroineLife = 4,
		HeroineBomb = 5,
		HeroinePower = 6,
		CardName = 7,
		CardSkillName = 8,
		CardSkillDescription = 9,
		CardCardLv = 10,
		CardStock = 11,
		CardLife = 12,
		CardBomb = 13,
		CardPower = 14,
		CardNextExp = 15,
		MoneyAmount = 16,
		PageText = 17,
		TitleText = 18,
		Max = 19,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private static int s_SkinId; //Field offset: 0xC
	private StageRewardLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private int m_HeroineId; //Field offset: 0x120
	private RawImageEx m_HeroineImage; //Field offset: 0x124
	private AtlasImage m_HeroineSkillIconImage; //Field offset: 0x128
	private AtlasImage m_CardAttrImage; //Field offset: 0x12C
	private AtlasImage m_CardSkillImage; //Field offset: 0x130
	private CardIllust m_CardIllust; //Field offset: 0x134
	private ShearProgressBarSprite m_CardExpGauge; //Field offset: 0x138

	private static StageRewardDisp() { }

	public StageRewardDisp() { }

	[CompilerGenerated]
	private bool <Open>b__24_0() { }

	[CompilerGenerated]
	private void <UpdateHeroineDisp>b__26_0(AssetBundleLoadAssetOperation ope) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__24))]
	public UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	public void SetSpelCardIllust(HeqetCardModel model, QUALITY_MODE a_quality, bool a_isAwake, bool a_isPremium) { }

	public void UpdateCardDisp(HeqetCardModel cardModel, bool isPossess) { }

	public void UpdateDisp(int listIndex, int listMaxCount, string title) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateHeroineDisp(HeqetHeroineModel heroineModel, bool isPossess) { }

	public void UpdateRewardMoneyDisp(RewardMoneyModel rewardMoneyModel) { }

}

