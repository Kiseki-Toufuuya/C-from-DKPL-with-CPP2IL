namespace Heqet.DlcList;

public class DlcListTopLayer : UiScrollListLayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__20_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public DlcListTopLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__20_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public DlcListTopLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__20_2>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public DlcListTopLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__17_1; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <InitAll>b__17_1(LayerBase _layer) { }

	}

	private enum eMainStep
	{
		OPEN = 0,
		OPENING = 1,
		MAIN = 2,
		CLOSE = 3,
		CLOSEING = 4,
		WAIT_HELP = 5,
		WAIT_DLC_DETAIL = 6,
		NONE = 7,
	}

	private static int ONE_LINE_NUM; //Field offset: 0x0
	private static int PAGE_PANEL_COUNT; //Field offset: 0x4
	private DlcListTopDisp m_dlcListDisp; //Field offset: 0x7C
	private int m_select_panel_index; //Field offset: 0x80
	private int m_max_count; //Field offset: 0x84
	private GameObject m_lastSelected; //Field offset: 0x88
	private List<Int32> m_dlcList; //Field offset: 0x8C
	private eMainStep m_MainStep; //Field offset: 0x90

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

	private static DlcListTopLayer() { }

	public DlcListTopLayer() { }

	[CompilerGenerated]
	private void <CreateSubLayerPanel>b__24_0(int dlc_id) { }

	[CompilerGenerated]
	private bool <CreateSubLayerPanel>b__24_1(int list_id) { }

	[CompilerGenerated]
	private void <InitAll>b__17_0(int btn_id) { }

	[CompilerGenerated]
	private void <InitAll>b__17_2(AxisEventData eventData) { }

	[AsyncStateMachine(typeof(<<Update>b__20_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__20_0() { }

	[AsyncStateMachine(typeof(<<Update>b__20_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__20_1() { }

	[AsyncStateMachine(typeof(<<Update>b__20_2>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__20_2() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public int GetDlcId(int index) { }

	public GameObject GetSelectObject() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void MoveCursor(AxisEventData eventData, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SelectAction(int index) { }

	public void SubmitAction(int stage_data_id) { }

	protected virtual void Update(bool is_active) { }

}

