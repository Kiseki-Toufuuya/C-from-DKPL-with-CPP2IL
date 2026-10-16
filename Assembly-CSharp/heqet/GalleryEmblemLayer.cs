namespace Heqet;

public class GalleryEmblemLayer : UiScrollListLayerBase, IGalleryLayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__32_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <OpenHelpDialog>b__32_0(LayerBase _layer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public Action<Object> ResultSort; //Field offset: 0x8

		public <>c__DisplayClass38_0() { }

		internal void <PressButtonActon>b__1(LayerBase _layerBase) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_1
	{
		public Action<Object> ResultSort; //Field offset: 0x8

		public <>c__DisplayClass38_1() { }

		internal void <PressButtonActon>b__3(LayerBase _layerBase) { }

	}

	[CompilerGenerated]
	private struct <Open>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryEmblemLayer <>4__this; //Field offset: 0xC
		public bool visible; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eContStep
	{
		INIT = 0,
		MAIN = 1,
		FIRST_HELP = 2,
		NONE = 3,
	}

	private enum eMainStep
	{
		OPENING = 0,
		MAIN = 1,
		CLOSEING = 2,
		CLOSE = 3,
		SORT_DIALOG = 4,
		HELP_DIALOG = 5,
		NONE = 6,
	}

	private static int COLUMN_MAX_NUM; //Field offset: 0x0
	private static int ONE_LINE_NUM; //Field offset: 0x4
	private GalleryEmblemDisp m_bodyDisp; //Field offset: 0x7C
	private GalleryTopLayer m_topLayer; //Field offset: 0x80
	private InputActionReference m_inputActionCalcel; //Field offset: 0x84
	private eMainStep m_MainStep; //Field offset: 0x88
	private eContStep m_ContStep; //Field offset: 0x8C
	private int m_max_count; //Field offset: 0x90
	private List<Int32> m_emblem_list; //Field offset: 0x94
	private int m_select_index; //Field offset: 0x98

	public int EmblemMaxCount
	{
		 get { } //Length: 14
	}

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public int SelectIndex
	{
		 get { } //Length: 14
	}

	private static GalleryEmblemLayer() { }

	public GalleryEmblemLayer() { }

	[CompilerGenerated]
	private bool <Open>b__34_0() { }

	[CompilerGenerated]
	private void <PressButtonActon>b__38_0(object _result) { }

	[CompilerGenerated]
	private void <PressButtonActon>b__38_2(object _result) { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	protected virtual bool EndUpdateAfter() { }

	public int get_EmblemMaxCount() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public int get_SelectIndex() { }

	public int GetEmblemId(int index) { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void MoveCursor(AxisEventData eventData, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	public void MovePageCursor(AxisEventData eventData) { }

	[AsyncStateMachine(typeof(<Open>d__34))]
	public override UniTask Open(bool visible) { }

	private void OpenHelpDialog() { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	private void RebuildPanelList() { }

	protected virtual bool ReleaseLayer() { }

	public void SelectAction(int index) { }

	private void SelectEmblem(int index) { }

	public override void SetTopLayer(GalleryTopLayer galleryTopLayer) { }

	public void SubmitAction(int index) { }

	protected virtual void Update(bool is_active) { }

	private void UpdateSortAndFilterDisp() { }

}

