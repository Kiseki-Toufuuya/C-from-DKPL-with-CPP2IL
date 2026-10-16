namespace Heqet;

public class GalleryJacketDisp : DispBase, IGalleryDisp
{
	[CompilerGenerated]
	private struct <Open>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public GalleryJacketDisp <>4__this; //Field offset: 0x10
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

	private enum eTextId
	{
		SongName = 0,
		CircleName = 1,
		SortText = 2,
		FilterText = 3,
		NoHitText = 4,
		Max = 5,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private GalleryJacketLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private readonly int NOT_FOUND_JACKET; //Field offset: 0x120

	private static GalleryJacketDisp() { }

	public GalleryJacketDisp() { }

	[CompilerGenerated]
	private bool <Open>b__15_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected void FastSelectButton() { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__15))]
	public override UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	public void SetSongNameText(int index) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateSortAndFilerDisp(bool isFilter, string sortName) { }

}

