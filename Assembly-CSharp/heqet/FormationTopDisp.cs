namespace Heqet;

public class FormationTopDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public FormationTopDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class BonusParams
	{
		public int psychicPower; //Field offset: 0x8
		public int playerLife; //Field offset: 0xC
		public int playerStock; //Field offset: 0x10
		public int bombStock; //Field offset: 0x14

		public BonusParams() { }

		public static BonusParams op_Addition(BonusParams dest, BonusParams src) { }

	}

	internal enum eButtonId
	{
		EditMitama = 0,
		EditHeroine = 1,
		Help = 2,
		Back = 3,
		FooterEditMitama = 4,
		FooterEditHeroine = 5,
		Max = 6,
	}

	private enum eCommonLayerId
	{
		CardIllust = 0,
		HeroinePreview = 1,
		ExpGauge = 2,
		CursorMitamaEdit = 3,
		CursorHeroineEdit = 4,
		MitamaNotSelected = 5,
		HeroineNotSelected = 6,
		Max = 7,
	}

	private enum eImageId
	{
		CardAttributeIcon = 0,
		MainHeroinIcon = 1,
		SubHeroineIcon = 2,
		MitamaSkillIcon = 3,
		HeroineSkillIcon = 4,
		Max = 5,
	}

	private enum eTextId
	{
		TotalPower = 0,
		TotalLife = 1,
		TotalMitama = 2,
		TotalBomb = 3,
		TotalHeroineName = 4,
		HeroineMainHeroineName = 5,
		HeroineSubHeroineName = 6,
		HeroinePower = 7,
		HeroineLife = 8,
		HeroineMitama = 9,
		HeroineBomb = 10,
		HeroineSkillName = 11,
		HeroineSkillDescription = 12,
		MitamaCardLevel = 13,
		MitamaNextExp = 14,
		MitamaCardCharacterName = 15,
		MitamaCardName = 16,
		MitamaCardSkillName = 17,
		MitamaCardSkillDescription = 18,
		MitamaPower = 19,
		MitamaLife = 20,
		MitamaMitama = 21,
		MitamaBomb = 22,
		Max = 23,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private FormationTopLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private CardIllust m_CardIllust; //Field offset: 0x120
	private int m_MainHeroineId; //Field offset: 0x124
	private int m_MainHeroineSkinId; //Field offset: 0x128
	private RawImageEx m_MainHeroineIconImage; //Field offset: 0x12C
	private int m_SubHeroineId; //Field offset: 0x130
	private int m_SubHeroineSkinId; //Field offset: 0x134
	private RawImageEx m_SubHeroineIconImage; //Field offset: 0x138
	private CharacterAssetBunleLoader m_MainHeroineImageLoader; //Field offset: 0x13C
	private CharacterAssetBunleLoader m_SubHeroineImageLoader; //Field offset: 0x140
	private AtlasImage m_CardAttrImage; //Field offset: 0x144
	private AtlasImage m_MitamaSkillIconImage; //Field offset: 0x148
	private AtlasImage m_HeroineSkillIconImage; //Field offset: 0x14C
	private PlayerBulletRawImage m_PlayerBulletRawImage; //Field offset: 0x150
	private ShearProgressBarSprite m_ExpGauge; //Field offset: 0x154
	private float m_MitamaCardSkillDescFontsize; //Field offset: 0x158
	private float m_HeroineSkillDescFontsize; //Field offset: 0x15C

	private static FormationTopDisp() { }

	public FormationTopDisp() { }

	[CompilerGenerated]
	private bool <Open>b__35_0() { }

	[CompilerGenerated]
	private void <SetMitamaCardIllust>b__37_0() { }

	[CompilerGenerated]
	private void <UpdateDisp>b__32_0(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <UpdateDisp>b__32_1(AssetBundleLoadAssetOperation ope) { }

	private BonusParams ApplyGimmickEffectToParam(GimmickModel gimmickModel) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	private BonusParams GetAchievementBonus() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	private void OnSelectButton(int button_id, BaseEventData e) { }

	[AsyncStateMachine(typeof(<Open>d__35))]
	public UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	protected void SelectBackButton() { }

	public void SetMitamaCardIllust(HeqetCardModel model, QUALITY_MODE a_quality, bool a_isAwake, bool a_isPremium) { }

	public void UpdateDisp(int mitamaCardId, int mainHeroineId, int subHeroineId) { }

	protected virtual void UpdateDispMain() { }

}

