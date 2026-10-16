namespace Heqet;

public class GalleryAchievementLayer : UiScrollListLayerBase, IGalleryLayer
{
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
	private sealed class <>c__DisplayClass50_0
	{
		public int have; //Field offset: 0x8

		public <>c__DisplayClass50_0() { }

		internal bool <SetAchievementSelectIndex>b__0(int x) { }

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
		public GalleryAchievementLayer <>4__this; //Field offset: 0xC
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
		INIT_WAIT = 2,
		FIRST_HELP = 3,
		NONE = 4,
	}

	private enum eMainStep
	{
		OPENING = 0,
		MAIN = 1,
		CLOSEING = 2,
		CLOSE = 3,
		SORT_DIALOG = 4,
		HELP_DIALOG = 5,
		WAIT_REWARD = 6,
		NONE = 7,
	}

	private static int COLUMN_MAX_NUM; //Field offset: 0x0
	private static int ONE_LINE_NUM; //Field offset: 0x4
	private static int PAGE_PANEL_COUNT; //Field offset: 0x8
	private static float SCROLL_SPPED; //Field offset: 0xC
	private GalleryAchievementDisp m_bodyDisp; //Field offset: 0x7C
	private GalleryTopLayer m_topLayer; //Field offset: 0x80
	private InputActionReference m_inputActionCalcel; //Field offset: 0x84
	private eMainStep m_MainStep; //Field offset: 0x88
	private eContStep m_ContStep; //Field offset: 0x8C
	private int m_max_count; //Field offset: 0x90
	private List<Int32> m_achievement_list; //Field offset: 0x94
	private int m_init_max_count; //Field offset: 0x98
	private List<Int32> m_have_achievement_list; //Field offset: 0x9C
	private int m_select_index; //Field offset: 0xA0
	private int m_next_index; //Field offset: 0xA4
	private bool m_endscroll_flg; //Field offset: 0xA8
	private bool m_opendialog_flg; //Field offset: 0xA9
	private readonly int NOT_FOUND_ACHIEVE; //Field offset: 0xAC

	public int AchievementInitMaxCount
	{
		 get { } //Length: 14
	}

	public int AchievementMaxCount
	{
		 get { } //Length: 14
	}

	public List<Int32> GetHaveAchievementList
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

	private static GalleryAchievementLayer() { }

	public GalleryAchievementLayer() { }

	[CompilerGenerated]
	private bool <Open>b__51_0() { }

	[CompilerGenerated]
	private bool <Open>b__51_1() { }

	[CompilerGenerated]
	private void <PressButtonActon>b__55_0(object _result) { }

	[CompilerGenerated]
	private void <PressButtonActon>b__55_2(object _result) { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	private void EndScrollAction(int a_event) { }

	protected virtual bool EndUpdateAfter() { }

	public int get_AchievementInitMaxCount() { }

	public int get_AchievementMaxCount() { }

	public List<Int32> get_GetHaveAchievementList() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public int get_NextIndex() { }

	public int get_SelectIndex() { }

	public int GetAchievementId(int index) { }

	public bool HaveAchievementFlg(int index) { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void MoveCursor(AxisEventData eventData, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	public void MovePageCursor(AxisEventData eventData) { }

	[AsyncStateMachine(typeof(<Open>d__51))]
	public override UniTask Open(bool visible) { }

	private void OpenHelpDialog() { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	private void RebuildPanelList() { }

	protected virtual bool ReleaseLayer() { }

	private void SelectAchievement(int index) { }

	public void SelectAction(int index) { }

	private void SetAchievementSelectIndex() { }

	public override void SetTopLayer(GalleryTopLayer galleryTopLayer) { }

	public void SubmitAction(int index) { }

	public void TargetPanelFocus(int index) { }

	protected virtual void Update(bool is_active) { }

	private void UpdateSortAndFilterDisp() { }

	public void VisibledNewMark(int index) { }

}

