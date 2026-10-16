namespace Heqet;

public class ShopDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public ShopDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Decide = 0,
		Back = 1,
		Help = 2,
		Max = 3,
	}

	private enum eCommonLayerId
	{
		ScrollRoot = 0,
		CardIllust = 1,
		StampParent = 2,
		SkillRoot = 3,
		ExpGauge = 4,
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
		ItemName = 0,
		CharacterName = 1,
		Money = 2,
		SkillName = 3,
		SkillDescription = 4,
		CardLv = 5,
		NextExp = 6,
		Stock = 7,
		Life = 8,
		Bomb = 9,
		Power = 10,
		Max = 11,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private ShopLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private CardIllust m_CardIllust; //Field offset: 0x120
	private TextMeshProUGUI m_ItemName; //Field offset: 0x124
	private TextMeshProUGUI m_CharacterNameText; //Field offset: 0x128
	private TextMeshProUGUI m_MoneyText; //Field offset: 0x12C
	private AtlasImage m_CardAttrImage; //Field offset: 0x130
	private AtlasImage m_SkillImage; //Field offset: 0x134
	private Transform m_stampParent; //Field offset: 0x138
	private int m_stampCardId; //Field offset: 0x13C
	private CardIllustStamp m_CardStamp; //Field offset: 0x140
	private ShearProgressBarSprite m_expGauge; //Field offset: 0x144
	private ListNavigation m_navigation; //Field offset: 0x148
	private List<Int32> m_LoadCardImageIdList; //Field offset: 0x14C
	private float m_SkillDescFontSize; //Field offset: 0x150

	private static ShopDisp() { }

	public ShopDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__24_0(AxisEventData eventData) { }

	[CompilerGenerated]
	private bool <Open>b__32_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public GameObject GetScrollRoot() { }

	private void InitStamp() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__32))]
	public UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	protected void ReleaseCardStamp(int cardId) { }

	public void SetEmblemIllust(int heroineId) { }

	public void SetSpelCardIllust(HeqetCardModel model, QUALITY_MODE a_quality, bool a_isAwake, bool a_isPremium) { }

	public void UpdateDisp(ItemData itemData) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateMoney(int money) { }

}

