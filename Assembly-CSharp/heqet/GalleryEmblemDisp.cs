namespace Heqet;

public class GalleryEmblemDisp : DispBase, IGalleryDisp
{
	[CompilerGenerated]
	private struct <Open>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public GalleryEmblemDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Back = 0,
		Select = 1,
		Help = 2,
		Sort = 3,
		Search = 4,
		Max = 5,
	}

	private enum eCommonLayerId
	{
		ScrollRoot = 0,
		Max = 1,
	}

	private enum eImageId
	{
		EmblemImage = 0,
		Max = 1,
	}

	private enum eTextId
	{
		Max = 0,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private GalleryEmblemLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private String[] m_ImageList; //Field offset: 0x11C
	private Animator RootAnimator; //Field offset: 0x120
	private RawImageEx m_EmblemImage; //Field offset: 0x124
	private GalleryEmblemImageLoader m_EmblemImageLoader; //Field offset: 0x128

	private static GalleryEmblemDisp() { }

	public GalleryEmblemDisp() { }

	[CompilerGenerated]
	private bool <Open>b__18_0() { }

	[CompilerGenerated]
	private void <SetTextEmblemData>b__23_0(Sprite sprite) { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected void FastSelectButton() { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__18))]
	public override UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	public void SetEmblemCardCollectionRate(int list_count) { }

	public void SetTextEmblemData(int index) { }

	protected virtual void UpdateDispMain() { }

}

