namespace Heqet;

public class MitamaEnlargedScreenDisp : DispBase, IGalleryDisp
{
	[CompilerGenerated]
	private struct <Open>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public MitamaEnlargedScreenDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Back = 0,
		Left = 1,
		Right = 2,
		UIShowHide = 3,
		Effect = 4,
		Emblem = 5,
		Help = 6,
		MaskUi = 7,
		Max = 8,
	}

	private enum eCardRarity
	{
		NRare = 0,
		RRare = 1,
		SRRare = 2,
		SSRRare = 3,
	}

	private enum eCommonLayerId
	{
		Arrow = 0,
		Header = 1,
		Footer = 2,
		UIText = 3,
		CardIllust = 4,
		BackText = 5,
		SwitchText = 6,
		SwitchL = 7,
		SwitchR = 8,
		EffectText = 9,
		EmblemText = 10,
		HelpText = 11,
		ArrowL = 12,
		ArrowR = 13,
		HeaderName = 14,
		MaskUI = 15,
		Max = 16,
	}

	private enum eImageId
	{
		MitamaImage = 0,
		Max = 1,
	}

	private enum eTextId
	{
		CardAndCharaName = 0,
		Max = 1,
	}

	private static readonly String[] m_ImageList; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private GalleryMitamaLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private CardIllust m_CardIllust; //Field offset: 0x120
	private bool m_UIShowOrhideFlg; //Field offset: 0x124
	private bool m_IsEffectFlg; //Field offset: 0x125
	private bool m_IsEmblemFlg; //Field offset: 0x126

	private static MitamaEnlargedScreenDisp() { }

	public MitamaEnlargedScreenDisp() { }

	[CompilerGenerated]
	private bool <Open>b__22_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public void ChangeActiveEffect(int id) { }

	public void ChangeActiveEmblem(int id) { }

	public void ChangeShowHideUI(bool flg) { }

	public virtual void Create(LayerBase parent_layer) { }

	protected void FastSelectButton() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__22))]
	public override UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	public void SetMitama(int list_id) { }

	public void SetSpelCardIllust(HeqetCardModel model, QUALITY_MODE a_quality, bool a_isAwake, bool a_isPremium) { }

	protected virtual void UpdateDispMain() { }

	public void WhilePressedButton(int button_id, float sec, bool flg) { }

}

