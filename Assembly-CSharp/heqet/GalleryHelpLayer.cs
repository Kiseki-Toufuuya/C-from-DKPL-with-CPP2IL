namespace Heqet;

public class GalleryHelpLayer : UiScrollListLayerBase, IGalleryLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public int helpid; //Field offset: 0x8

		public <>c__DisplayClass46_0() { }

		internal void <OpenHelpDialogSelect>b__0(LayerBase _layer) { }

	}

	[CompilerGenerated]
	private struct <Open>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryHelpLayer <>4__this; //Field offset: 0xC
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
		NONE = 2,
	}

	private enum eMainStep
	{
		OPENING = 0,
		MAIN = 1,
		CLOSEING = 2,
		CLOSE = 3,
		HELP_DIALOG = 4,
		NONE = 5,
	}

	private static int ONE_LINE_NUM; //Field offset: 0x0
	private static int PAGE_PANEL_COUNT; //Field offset: 0x4
	private static float SCROLL_SPPED; //Field offset: 0x8
	private GalleryHelpDisp m_bodyDisp; //Field offset: 0x7C
	private GalleryTopLayer m_topLayer; //Field offset: 0x80
	private InputActionReference m_inputActionCalcel; //Field offset: 0x84
	private eMainStep m_MainStep; //Field offset: 0x88
	private eContStep m_ContStep; //Field offset: 0x8C
	private int m_max_count; //Field offset: 0x90
	private List<Int32> m_help_list; //Field offset: 0x94
	private int m_select_index; //Field offset: 0x98
	private int m_next_index; //Field offset: 0x9C
	private bool m_endscroll_flg; //Field offset: 0xA0

	public int HelpMaxCount
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

	public int NextIndex
	{
		 get { } //Length: 14
	}

	public int SelectIndex
	{
		 get { } //Length: 14
	}

	private static GalleryHelpLayer() { }

	public GalleryHelpLayer() { }

	[CompilerGenerated]
	private bool <Open>b__39_0() { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	private void EndScrollAction(int a_event) { }

	protected virtual bool EndUpdateAfter() { }

	public int get_HelpMaxCount() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public int get_NextIndex() { }

	public int get_SelectIndex() { }

	public int GetHelpId(int index) { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void MoveCursor(AxisEventData eventData, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	public void MovePageCusor(AxisEventData eventData) { }

	[AsyncStateMachine(typeof(<Open>d__39))]
	public override UniTask Open(bool visible) { }

	private void OpenHelpDialogSelect(int index) { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	protected virtual bool ReleaseLayer() { }

	public void SelectAction(int index) { }

	private void SelectHelp(int index) { }

	public override void SetTopLayer(GalleryTopLayer galleryTopLayer) { }

	public void SubmitAction(int index) { }

	public void TargetPanelFocus(int index) { }

	protected virtual void Update(bool is_active) { }

}

