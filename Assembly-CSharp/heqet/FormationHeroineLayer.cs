namespace Heqet;

public class FormationHeroineLayer : UiScrollListLayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__47_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public FormationHeroineLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__47_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public FormationHeroineLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__48_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <OpenHelpDialog>b__48_0(LayerBase _layer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public Action<Object> ResultSort; //Field offset: 0x8

		public <>c__DisplayClass53_0() { }

		internal void <PressButtonActon>b__1(LayerBase _layerBase) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_1
	{
		public Action<Object> ResultSort; //Field offset: 0x8

		public <>c__DisplayClass53_1() { }

		internal void <PressButtonActon>b__3(LayerBase _layerBase) { }

	}

	private enum eContStep
	{
		FIRST_HELP = 0,
		MAIN = 1,
		NONE = 2,
	}

	private enum eEditMode
	{
		Main = 0,
		Sub = 1,
	}

	private enum eMainStep
	{
		OPEN = 0,
		OPENING = 1,
		MAIN = 2,
		CLOSE = 3,
		CLOSEING = 4,
		HELP_DIALOG = 5,
		SORT_DIALOG = 6,
		NONE = 7,
	}

	private static int ONE_LINE_NUM; //Field offset: 0x0
	private static int PAGE_LINE_NUM; //Field offset: 0x4
	private FormationHeroineDisp m_FormationHeroineDisp; //Field offset: 0x7C
	private InputAction m_Cancel; //Field offset: 0x80
	private TransitionInfo m_transitionInfo; //Field offset: 0x84
	private GameObject m_lastSelected; //Field offset: 0x88
	private eMainStep m_MainStep; //Field offset: 0x8C
	private eContStep m_ContStep; //Field offset: 0x90
	private eEditMode m_edit_mode; //Field offset: 0x94
	private int m_select_index; //Field offset: 0x98
	private int m_main_heroine_index; //Field offset: 0x9C
	private int m_sub_heroine_index; //Field offset: 0xA0
	private int m_main_heroine_id; //Field offset: 0xA4
	private int m_sub_heroine_id; //Field offset: 0xA8
	private int m_max_count; //Field offset: 0xAC
	private List<Int32> m_heroine_list; //Field offset: 0xB0

	public int CurrentEquipId
	{
		 get { } //Length: 37
	}

	public private int CurrentEquipListIndex
	{
		 get { } //Length: 37
		private set { } //Length: 43
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

	public int MainHeroineIndex
	{
		 get { } //Length: 14
	}

	public int SelectIndex
	{
		 get { } //Length: 14
	}

	public int SubHeroineIndex
	{
		 get { } //Length: 14
	}

	private static FormationHeroineLayer() { }

	public FormationHeroineLayer() { }

	[CompilerGenerated]
	private void <PressButtonActon>b__53_0(object _result) { }

	[CompilerGenerated]
	private void <PressButtonActon>b__53_2(object _result) { }

	[AsyncStateMachine(typeof(<<Update>b__47_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__47_0() { }

	[AsyncStateMachine(typeof(<<Update>b__47_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__47_1() { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	protected virtual bool EndUpdateAfter() { }

	private void EquipHeroine(int index) { }

	public int get_CurrentEquipId() { }

	public int get_CurrentEquipListIndex() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public int get_MainHeroineIndex() { }

	public int get_SelectIndex() { }

	public int get_SubHeroineIndex() { }

	public int GetHeroineId(int index) { }

	public GameObject GetSelectObject() { }

	protected virtual void InitAll() { }

	private void InitInputAction() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	public void MoveCursor(AxisEventData eventData, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	public void MovePageCursor(AxisEventData eventData) { }

	public void Open(bool visible) { }

	private void OpenHelpDialog() { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	private void RebuildPanelList() { }

	protected virtual bool ReleaseLayer() { }

	public void SelectAction(int index) { }

	private void SelectHeroine(int index) { }

	private void set_CurrentEquipListIndex(int value) { }

	public void SubmitAction(int index) { }

	protected virtual void Update(bool is_active) { }

	private void UpdateDisp() { }

	private void UpdateSortAndFilterDisp() { }

}

