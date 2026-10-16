namespace Heqet;

public class GalleryHeroineDisp : DispBase, IGalleryDisp
{
	[CompilerGenerated]
	private struct <Open>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public GalleryHeroineDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Back = 0,
		Select = 1,
		Favorite = 2,
		Help = 3,
		Sort = 4,
		Search = 5,
		Max = 6,
	}

	private enum eCommonLayerId
	{
		ScrollRoot = 0,
		GetAllHeroine = 1,
		SeriesHeader = 2,
		ExplanationHeader = 3,
		HeroineInfo = 4,
		Max = 5,
	}

	private enum eImageId
	{
		HeroineImage = 0,
		Max = 1,
	}

	private enum eTextId
	{
		FlavorText = 0,
		AliasNameText = 1,
		CharacterNameText = 2,
		IllustratorNameText = 3,
		CollectionText = 4,
		CollectionRateText = 5,
		DebutWorkText = 6,
		SortText = 7,
		FilterText = 8,
		NoHitText = 9,
		HeaderText = 10,
		TEXT_SERIES_LABEL = 11,
		TEXT_DETAIL_LABEL = 12,
		Max = 13,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private GalleryHeroineLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private String[] m_ImageList; //Field offset: 0x11C
	private Animator RootAnimator; //Field offset: 0x120
	private RawImageEx m_HeroineImage; //Field offset: 0x124
	private CharacterAssetBunleLoader m_HeroineImageLoader; //Field offset: 0x128
	private readonly int DEFAULT_SKIN_ID; //Field offset: 0x12C
	private readonly int NOT_FOUND_HEROINE; //Field offset: 0x130
	private float m_flavorTextFontSize; //Field offset: 0x134
	private readonly int LINES_TOBE_AUTOSIZED; //Field offset: 0x138
	private readonly int LENGTH_TOBE_AUTOSIZED; //Field offset: 0x13C

	private static GalleryHeroineDisp() { }

	public GalleryHeroineDisp() { }

	[CompilerGenerated]
	private bool <Open>b__23_0() { }

	[CompilerGenerated]
	private void <SetTextHeroineData>b__30_0(AssetBundleLoadAssetOperation ope) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected void FastSelectButton() { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__23))]
	public override UniTask Open(bool visible) { }

	private void ParameterDisplay(bool flg) { }

	public virtual void ReleaseAll() { }

	public void SetFavoritMode() { }

	public void SetHeroineCardCollectionRate() { }

	public void SetTextHeroineData(int index) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateSortAndFilerDisp(bool isFilter, string sortName) { }

}

