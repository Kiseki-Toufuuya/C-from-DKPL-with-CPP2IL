namespace Heqet;

public class GalleryHelpDisp : DispBase, IGalleryDisp
{
	[CompilerGenerated]
	private struct <Open>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public GalleryHelpDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Back = 0,
		Select = 1,
		Max = 2,
	}

	private enum eCommonLayerId
	{
		ScrollRoot = 0,
		Max = 1,
	}

	private enum eImageId
	{
		Max = 0,
	}

	private enum eTextId
	{
		TITLE = 0,
		Max = 1,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private GalleryHelpLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private String[] m_ImageList; //Field offset: 0x11C
	private Animator RootAnimator; //Field offset: 0x120

	private static GalleryHelpDisp() { }

	public GalleryHelpDisp() { }

	[CompilerGenerated]
	private bool <Open>b__16_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected void FastSelectButton() { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__16))]
	public override UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	protected virtual void UpdateDispMain() { }

}

