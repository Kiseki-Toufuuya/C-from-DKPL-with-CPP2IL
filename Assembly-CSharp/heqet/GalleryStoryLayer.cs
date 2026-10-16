namespace Heqet;

public class GalleryStoryLayer : UiScrollListLayerBase, IGalleryLayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<EpisodeModel> <>9__40_0; //Field offset: 0x4
		public static Action<LayerBase> <>9__50_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OpenHelpDialog>b__50_0(LayerBase _layer) { }

		internal int <StoryListGenerate>b__40_0(EpisodeModel a, EpisodeModel b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public KeyValuePair<Int32, GalleryItem> save; //Field offset: 0x8

		public <>c__DisplayClass40_0() { }

		internal bool <StoryListGenerate>b__1(EpisodeModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_1
	{
		public int i; //Field offset: 0x8

		public <>c__DisplayClass40_1() { }

		internal bool <StoryListGenerate>b__2(int x) { }

	}

	[CompilerGenerated]
	private struct <Open>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryStoryLayer <>4__this; //Field offset: 0xC
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
		STARTSTORY = 2,
		FADEIN = 3,
		PLAYSTORY = 4,
		FIRST_HELP = 5,
		NONE = 6,
	}

	private enum eMainStep
	{
		OPENING = 0,
		MAIN = 1,
		CLOSEING = 2,
		CLOSE = 3,
		DIALOGOPEN = 4,
		CONT_MAIN = 5,
		CONT_END = 6,
		HELP_DIALOG = 7,
		NONE = 8,
	}

	private static int COLUMN_MAX_NUM; //Field offset: 0x0
	private static int ONE_LINE_NUM; //Field offset: 0x4
	private static int PAGE_PANEL_COUNT; //Field offset: 0x8
	private static float SCROLL_SPPED; //Field offset: 0xC
	private GalleryStoryDisp m_bodyDisp; //Field offset: 0x7C
	private ReadStoryDialogLayer m_storyDialogLayer; //Field offset: 0x80
	private GalleryTopLayer m_topLayer; //Field offset: 0x84
	private InputActionReference m_inputActionCalcel; //Field offset: 0x88
	private eMainStep m_MainStep; //Field offset: 0x8C
	private eContStep m_ContStep; //Field offset: 0x90
	private int m_max_count; //Field offset: 0x94
	private List<Int32> m_story_list; //Field offset: 0x98
	private int m_select_index; //Field offset: 0x9C
	private int m_category_index; //Field offset: 0xA0
	private int m_category_min; //Field offset: 0xA4
	private int m_category_max; //Field offset: 0xA8
	private int m_next_index; //Field offset: 0xAC
	private List<Int32> m_have_category_list; //Field offset: 0xB0
	private bool m_endscroll_flg; //Field offset: 0xB4
	private bool m_opendialog_flg; //Field offset: 0xB5

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

	public int StoryMaxCount
	{
		 get { } //Length: 14
	}

	private static GalleryStoryLayer() { }

	public GalleryStoryLayer() { }

	[CompilerGenerated]
	private void <ContMain>b__51_0() { }

	[CompilerGenerated]
	private bool <Open>b__52_0() { }

	private void ArrowDisplay() { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	private void EndScrollAction(int a_event) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public int get_NextIndex() { }

	public int get_SelectIndex() { }

	public int get_StoryMaxCount() { }

	public int GetStoryId(int index) { }

	private void HaveStoryCategory() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void MoveCursor(AxisEventData eventData, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	public void MovePageCursor(AxisEventData eventData) { }

	[AsyncStateMachine(typeof(<Open>d__52))]
	public override UniTask Open(bool visible) { }

	private void OpenHelpDialog() { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	private void RebuildPanelList(int categoryId) { }

	protected virtual bool ReleaseLayer() { }

	public void SelectAction(int index) { }

	private void SelectStory(int index) { }

	public override void SetTopLayer(GalleryTopLayer galleryTopLayer) { }

	private void StoryListGenerate(int categoryId) { }

	public void SubmitAction(int index) { }

	public void TargetPanelFocus(int index) { }

	protected virtual void Update(bool is_active) { }

	public void VisibledNewMark(int index) { }

}

