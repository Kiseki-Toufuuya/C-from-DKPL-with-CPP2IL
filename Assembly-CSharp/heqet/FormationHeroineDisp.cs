namespace Heqet;

public class FormationHeroineDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public FormationHeroineDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Back = 0,
		Search = 1,
		Sort = 2,
		MainTab = 3,
		SubTab = 4,
		Help = 5,
		Max = 6,
	}

	private enum eCommonLayerId
	{
		ScrollRoot = 0,
		HeroinePreview = 1,
		MainHeroineActiveFrame = 2,
		SubHeroineFActiverame = 3,
		MainHeroineNotSelected = 4,
		SubHeroineNotSelected = 5,
		Max = 6,
	}

	private enum eImageId
	{
		MainHeroinePreview = 0,
		SubHeroinePreview = 1,
		SkillIcon = 2,
		Max = 3,
	}

	private enum eTextId
	{
		MainHeroineName = 0,
		SubHerioneName = 1,
		HeroinePower = 2,
		HeroineLife = 3,
		HeroineMitama = 4,
		HeroineBomb = 5,
		HeroineSkillName = 6,
		HeroineSkillDescription = 7,
		SortText = 8,
		SearchText = 9,
		Max = 10,
	}

	private const int skinId = 1; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private FormationHeroineLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private RawImageEx m_MainHeroineImage; //Field offset: 0x120
	private RawImageEx m_SubHeroineImage; //Field offset: 0x124
	private PlayerBulletRawImage m_PlayerBulletRawImage; //Field offset: 0x128
	private AtlasImage m_HeroineSkillIconImage; //Field offset: 0x12C
	private int m_mainHeroineID; //Field offset: 0x130
	private int m_subHeroineID; //Field offset: 0x134
	private CharacterAssetBunleLoader m_MainHeroineImageLoader; //Field offset: 0x138
	private CharacterAssetBunleLoader m_SubHeroineImageLoader; //Field offset: 0x13C
	private float m_SkillDescFontSize; //Field offset: 0x140

	private static FormationHeroineDisp() { }

	public FormationHeroineDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__21_0(AxisEventData eventData) { }

	[CompilerGenerated]
	private void <InitUguiOther>b__21_1(AxisEventData eventData) { }

	[CompilerGenerated]
	private GameObject <InitUguiOther>b__21_2() { }

	[CompilerGenerated]
	private bool <Open>b__28_0() { }

	[CompilerGenerated]
	private void <SetHeroineIcon>b__32_0(AssetBundleLoadAssetOperation ope) { }

	[CompilerGenerated]
	private void <SetHeroineIcon>b__32_1(AssetBundleLoadAssetOperation ope) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void EditMode(bool isMain) { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__28))]
	public UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	private void SetHeroineIcon(int mainHeroineId, int subHeroineId) { }

	public void UpdateDisp(HeroineData mainData, HeroineData subData) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateSortAndFilerDisp(bool isFilter, string sortName) { }

}

