namespace Heqet;

public class EnlargedHeroineDisp : DispBase, IGalleryDisp
{
	[CompilerGenerated]
	private struct <Open>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public EnlargedHeroineDisp <>4__this; //Field offset: 0xC
		public bool visible; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetHeroine>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public EnlargedHeroineDisp <>4__this; //Field offset: 0x8
		private int <characterId>5__2; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

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
		Help = 4,
		MaskUi = 5,
		Max = 6,
	}

	private enum eCommonLayerId
	{
		Arrow = 0,
		Header = 1,
		Footer = 2,
		HeaderName = 3,
		BackText = 4,
		SwitchText = 5,
		SwitchL = 6,
		SwitchR = 7,
		NaviText = 8,
		HelpText = 9,
		UIText = 10,
		ArrowL = 11,
		ArrowR = 12,
		MaskUI = 13,
		Max = 14,
	}

	private enum eImageId
	{
		Max = 0,
	}

	private enum eTextId
	{
		NameText = 0,
		Max = 1,
	}

	private const string HEROINE_BG = "bg_black"; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x0
	private const string CHARACTER_LIVE2D = "character_live2d"; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private GalleryHeroineLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private InputActionReference m_InputActionNavigate; //Field offset: 0x120
	private Live2DModel m_characterLive2D; //Field offset: 0x124
	private Camera m_uiCamera; //Field offset: 0x128
	private bool m_actieSelf; //Field offset: 0x12C
	private readonly Vector3 LIVE2D_SCALE; //Field offset: 0x130
	private Camera OverCamera; //Field offset: 0x13C
	private string OverSortingLayerName; //Field offset: 0x140
	private Camera TopCamera; //Field offset: 0x144
	private string TopSortingLayerName; //Field offset: 0x148
	private Camera MiddleCamera; //Field offset: 0x14C
	private string MiddleSortingLayerName; //Field offset: 0x150
	private Camera BottomCamera; //Field offset: 0x154
	private string BottomSortingLayerName; //Field offset: 0x158
	private Camera BgCamera; //Field offset: 0x15C
	private string BgSortingLayerName; //Field offset: 0x160

	private static EnlargedHeroineDisp() { }

	public EnlargedHeroineDisp() { }

	[CompilerGenerated]
	private bool <Open>b__39_0() { }

	[CompilerGenerated]
	private bool <SetHeroine>b__41_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	private void ChangeAnimation() { }

	public void ChangeShowHideUI(bool flg) { }

	public void CharacterLive2DSetUp(Live2DModel live2DModel, TYPE type) { }

	public virtual void Create(LayerBase parent_layer) { }

	private Live2DModel CreateLive2D(int id, int skinId) { }

	private void InitCamera() { }

	private void InitLive2DRawImage(string rawObjName, TYPE type) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	private void Live2DSetUp(Live2DModel live2DModel, TYPE type) { }

	[AsyncStateMachine(typeof(<Open>d__39))]
	public override UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	private void ResetCamera() { }

	[AsyncStateMachine(typeof(<SetHeroine>d__41))]
	public UniTaskVoid SetHeroine() { }

	protected virtual void UpdateDispMain() { }

}

