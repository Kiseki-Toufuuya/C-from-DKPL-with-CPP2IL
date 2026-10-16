namespace Heqet.DlcList;

public class DlcListDetailesLayer : UiScrollListLayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__28_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public DlcListDetailesLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__28_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public DlcListDetailesLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__25_1; //Field offset: 0x4
		public static Func<HeqetMusicSelectionModel, Int32> <>9__26_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <InitAll>b__25_1(LayerBase _layer) { }

		internal int <InitResourceWait>b__26_0(HeqetMusicSelectionModel a) { }

	}

	private enum eMainStep
	{
		OPEN = 0,
		OPENING = 1,
		MAIN = 2,
		CLOSE = 3,
		CLOSEING = 4,
		WAIT_HELP = 5,
		WAIT_STORE = 6,
		NONE = 7,
	}

	private static int ONE_LINE_NUM; //Field offset: 0x0
	private static int PAGE_PANEL_COUNT; //Field offset: 0x4
	private DlcListDetailsDisp m_dlcDetailDisp; //Field offset: 0x7C
	private int m_select_panel_index; //Field offset: 0x80
	private int m_max_count; //Field offset: 0x84
	private List<HeqetMusicModel> m_music_list; //Field offset: 0x88
	private GameObject m_lastSelected; //Field offset: 0x8C
	[CompilerGenerated]
	private int <DlcId>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private int <FolderId>k__BackingField; //Field offset: 0x94
	private eMainStep m_MainStep; //Field offset: 0x98

	public int DlcId
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int FolderId
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
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

	private static DlcListDetailesLayer() { }

	public DlcListDetailesLayer() { }

	[CompilerGenerated]
	private void <CreateSubLayerPanel>b__32_0(int id) { }

	[CompilerGenerated]
	private HeqetMusicModel <CreateSubLayerPanel>b__32_1(int list_id) { }

	[CompilerGenerated]
	private bool <CreateSubLayerPanel>b__32_2(int list_id) { }

	[CompilerGenerated]
	private void <InitAll>b__25_0(int btn_id) { }

	[CompilerGenerated]
	private void <InitAll>b__25_2(AxisEventData eventData) { }

	[CompilerGenerated]
	private void <InitAll>b__25_3(AxisEventData eventData) { }

	[AsyncStateMachine(typeof(<<Update>b__28_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__28_0() { }

	[AsyncStateMachine(typeof(<<Update>b__28_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__28_1() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	protected virtual bool EndUpdateAfter() { }

	[CompilerGenerated]
	public int get_DlcId() { }

	[CompilerGenerated]
	public int get_FolderId() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public GameObject GetSelectObject() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void MoveCursor(AxisEventData eventData, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	public void MovePageCursor(AxisEventData eventData) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SelectAction(int index) { }

	[CompilerGenerated]
	public void set_DlcId(int value) { }

	[CompilerGenerated]
	public void set_FolderId(int value) { }

	public void SubmitAction(int stage_data_id) { }

	protected virtual void Update(bool is_active) { }

}

