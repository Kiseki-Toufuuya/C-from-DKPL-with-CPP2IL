namespace Heqet;

public class GalleryJacketLayer : UiScrollListLayerBase, IGalleryLayer
{
	[CompilerGenerated]
	private struct <<Update>b__46_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryJacketLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__46_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryJacketLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__47_0; //Field offset: 0x4
		public static Action<LayerBase> <>9__48_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OpenHelpDialogMain>b__47_0(LayerBase _layer) { }

		internal void <OpenHelpDialogSub>b__48_0(LayerBase _layer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public int have; //Field offset: 0x8

		public <>c__DisplayClass50_0() { }

		internal bool <SetJacketSelectIndex>b__0(int x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public Action<Object> ResultSort; //Field offset: 0x8

		public <>c__DisplayClass55_0() { }

		internal void <PressButtonActon>b__1(LayerBase _layerBase) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_1
	{
		public Action<Object> ResultSort; //Field offset: 0x8

		public <>c__DisplayClass55_1() { }

		internal void <PressButtonActon>b__3(LayerBase _layerBase) { }

	}

	[CompilerGenerated]
	private struct <Open>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryJacketLayer <>4__this; //Field offset: 0xC
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
		ENLARGED = 2,
		INIT_WAIT = 3,
		FIRST_HELP = 4,
		NONE = 5,
	}

	private enum eMainStep
	{
		OPENING = 0,
		MAIN = 1,
		CLOSEING = 2,
		CLOSE = 3,
		ENLARGEDOPEN = 4,
		ENLARGED = 5,
		ENLARGEDCLOSE = 6,
		SORT_DIALOG = 7,
		HELP_DIALOG_MAIN = 8,
		HELP_DIALOG_SUB = 9,
		NONE = 10,
	}

	private static int COLUMN_MAX_NUM; //Field offset: 0x0
	private static int ONE_LINE_NUM; //Field offset: 0x4
	private static float SCROLL_SPPED; //Field offset: 0x8
	private GalleryJacketDisp m_bodyDisp; //Field offset: 0x7C
	private GalleryTopLayer m_topLayer; //Field offset: 0x80
	private JacketEnlargedScreenDisp m_enlargedscreenDisp; //Field offset: 0x84
	private InputActionReference m_inputActionCalcel; //Field offset: 0x88
	private eMainStep m_MainStep; //Field offset: 0x8C
	private eContStep m_ContStep; //Field offset: 0x90
	private int m_max_count; //Field offset: 0x94
	private List<Int32> m_jacket_list; //Field offset: 0x98
	private List<Int32> m_have_jacket_list; //Field offset: 0x9C
	private int m_select_index; //Field offset: 0xA0
	private int m_next_index; //Field offset: 0xA4
	private bool m_enlarged_ui_flg; //Field offset: 0xA8
	private bool m_endscroll_flg; //Field offset: 0xA9
	private bool m_opendialog_flg; //Field offset: 0xAA
	private readonly int NOT_FOUND_JACKET; //Field offset: 0xAC

	public List<Int32> GetHaveJacketList
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

	public int JacketMaxCount
	{
		 get { } //Length: 14
	}

	public int NextIndex
	{
		 get { } //Length: 14
	}

	public int SelectIndex
	{
		 get { } //Length: 14
	}

	private static GalleryJacketLayer() { }

	public GalleryJacketLayer() { }

	[CompilerGenerated]
	private bool <GetJacketIndex>b__56_0(int index) { }

	[CompilerGenerated]
	private bool <Open>b__51_0() { }

	[CompilerGenerated]
	private bool <Open>b__51_1() { }

	[CompilerGenerated]
	private void <PressButtonActon>b__55_0(object _result) { }

	[CompilerGenerated]
	private void <PressButtonActon>b__55_2(object _result) { }

	[AsyncStateMachine(typeof(<<Update>b__46_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__46_0() { }

	[AsyncStateMachine(typeof(<<Update>b__46_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__46_1() { }

	private void ChangeEnlargedScreen(int index) { }

	public bool ChangeJacketImage(MoveDirection dir, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	private void EndScrollAction(int a_event) { }

	protected virtual bool EndUpdateAfter() { }

	public List<Int32> get_GetHaveJacketList() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public int get_JacketMaxCount() { }

	public int get_NextIndex() { }

	public int get_SelectIndex() { }

	public int GetJacketId(int index) { }

	private int GetJacketIndex(MoveDirection dir, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	private bool HaveJacketFlg(int index) { }

	private void HaveUnlockMusic() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void MoveCursor(AxisEventData eventData, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	public void MovePageCursor(AxisEventData eventData) { }

	[AsyncStateMachine(typeof(<Open>d__51))]
	public override UniTask Open(bool visible) { }

	private void OpenHelpDialogMain() { }

	private void OpenHelpDialogSub() { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	private void RebuildPanelList() { }

	protected virtual bool ReleaseLayer() { }

	public void SelectAction(int index) { }

	private void SelectJacket(int index) { }

	private void SetJacketSelectIndex() { }

	public override void SetTopLayer(GalleryTopLayer galleryTopLayer) { }

	public void SubmitAction(int index) { }

	public void TargetPanelFocus(int index) { }

	protected virtual void Update(bool is_active) { }

	private void UpdateSortAndFilterDisp() { }

	public void VisibledNewMark(int index) { }

	public void WhilePressedButtonActon(int btn_id) { }

}

