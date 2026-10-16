namespace Heqet;

public class GalleryMitamaDisp : DispBase, IGalleryDisp
{
	[CompilerGenerated]
	private struct <Open>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public GalleryMitamaDisp <>4__this; //Field offset: 0x10
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
		CardIllust = 1,
		GetAllMitama = 2,
		SkillName = 3,
		LifeIcon = 4,
		BombIcon = 5,
		PowerIcon = 6,
		SkillIcon = 7,
		MitamaInfo = 8,
		Max = 9,
	}

	private enum eImageId
	{
		MitamaImage = 0,
		SkillIcon = 1,
		Max = 2,
	}

	private enum eTextId
	{
		FlavorText = 0,
		AliasNameText = 1,
		CharacterNameText = 2,
		IllustratorNameText = 3,
		CollectionText = 4,
		CollectionRateText = 5,
		SkillNameText = 6,
		PlayerStock = 7,
		Life = 8,
		Bomb = 9,
		Power = 10,
		SortText = 11,
		FilterText = 12,
		NoHitText = 13,
		HeaderText = 14,
		Max = 15,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private GalleryMitamaLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private String[] m_ImageList; //Field offset: 0x11C
	private Animator RootAnimator; //Field offset: 0x120
	private CardIllust m_CardIllust; //Field offset: 0x124
	private AtlasImage m_SkillIconImage; //Field offset: 0x128
	private readonly int NOT_FOUND_MITAMA; //Field offset: 0x12C
	private float m_flavorTextFontSize; //Field offset: 0x130
	private readonly int LINES_TOBE_AUTOSIZED; //Field offset: 0x134
	private readonly int LENGTH_TOBE_AUTOSIZED; //Field offset: 0x138

	private static GalleryMitamaDisp() { }

	public GalleryMitamaDisp() { }

	[CompilerGenerated]
	private bool <Open>b__22_0() { }

	[CompilerGenerated]
	private void <SetSpelCardIllust>b__30_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected void FastSelectButton() { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__22))]
	public override UniTask Open(bool visible) { }

	private void ParameterDisplay(bool flg) { }

	public virtual void ReleaseAll() { }

	public void SetFavoritMode() { }

	public void SetMitamaCardCollectionRate() { }

	public void SetSpelCardIllust(HeqetCardModel model, QUALITY_MODE a_quality, bool a_isAwake, bool a_isPremium) { }

	public void SetTextMitamaData(int index) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateSortAndFilerDisp(bool isFilter, string sortName) { }

}

