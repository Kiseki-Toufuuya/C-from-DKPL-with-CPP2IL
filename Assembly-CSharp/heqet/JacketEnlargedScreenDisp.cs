namespace Heqet;

public class JacketEnlargedScreenDisp : DispBase, IGalleryDisp
{
	[CompilerGenerated]
	private struct <Open>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public JacketEnlargedScreenDisp <>4__this; //Field offset: 0x10
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
		Help = 4,
		MaskUi = 5,
		Max = 6,
	}

	private enum eCommonLayerId
	{
		Arrow = 0,
		Header = 1,
		Footer = 2,
		UIText = 3,
		JacketStatus = 4,
		BackText = 5,
		SwitchText = 6,
		SwitchL = 7,
		SwitchR = 8,
		ArrowL = 9,
		ArrowR = 10,
		HeaderName = 11,
		HelpText = 12,
		MaskUI = 13,
		Max = 14,
	}

	private enum eImageId
	{
		JacketImage = 0,
		Max = 1,
	}

	private enum eTextId
	{
		SongAndCircleName = 0,
		Max = 1,
	}

	private static readonly String[] m_ImageList; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private GalleryJacketLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private RawImageEx m_JacketImage; //Field offset: 0x11C
	private Animator RootAnimator; //Field offset: 0x120
	private Jacket2kAssetBunleLoader m_jacket2kLoader; //Field offset: 0x124
	private bool m_UIShowOrhideFlg; //Field offset: 0x128

	private static JacketEnlargedScreenDisp() { }

	public JacketEnlargedScreenDisp() { }

	[CompilerGenerated]
	private bool <Open>b__20_0() { }

	[CompilerGenerated]
	private void <SetJacket>b__23_0(AssetBundleLoadAssetOperation ope) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public void ChangeShowHideUI(bool flg) { }

	public virtual void Create(LayerBase parent_layer) { }

	protected void FastSelectButton() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__20))]
	public override UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	public void SetJacket(int list_id) { }

	protected virtual void UpdateDispMain() { }

	public void WhilePressedButton(int button_id, float sec, bool flg) { }

}

