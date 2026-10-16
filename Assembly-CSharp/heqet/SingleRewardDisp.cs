namespace Heqet;

public class SingleRewardDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public SingleRewardDisp <>4__this; //Field offset: 0xC
		public bool visible; //Field offset: 0x10
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
		HeroineRoot = 0,
		CardRoot = 1,
		CardIllust = 2,
		CardExpGauge = 3,
		Max = 4,
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
		TitleText = 16,
		BodyText = 17,
		Max = 18,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private static int s_SkinId; //Field offset: 0xC
	private String[] m_ButtonDataList; //Field offset: 0x114
	private Animator RootAnimator; //Field offset: 0x118
	private int m_HeroineId; //Field offset: 0x11C
	private RawImageEx m_HeroineImage; //Field offset: 0x120
	private AtlasImage m_HeroineSkillIconImage; //Field offset: 0x124
	private AtlasImage m_CardAttrImage; //Field offset: 0x128
	private AtlasImage m_CardSkillImage; //Field offset: 0x12C
	private CardIllust m_CardIllust; //Field offset: 0x130
	private ShearProgressBarSprite m_CardExpGauge; //Field offset: 0x134
	public Action<Int32> OnButtonAction; //Field offset: 0x138

	private static SingleRewardDisp() { }

	public SingleRewardDisp() { }

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

	public void UpdateCardDisp(HeqetCardModel cardModel) { }

	public void UpdateDisp(string title, string body) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateHeroineDisp(HeqetHeroineModel heroineModel) { }

	public void UpdateRewardMoneyDisp(RewardMoneyModel rewardMoneyModel) { }

}

