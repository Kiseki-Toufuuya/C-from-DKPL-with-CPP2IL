namespace Heqet;

public class GalleryHeroineLayer : UiScrollListLayerBase, IGalleryLayer
{
	[CompilerGenerated]
	private struct <<Update>b__62_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryHeroineLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__62_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryHeroineLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__63_0; //Field offset: 0x4
		public static Action<LayerBase> <>9__64_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OpenHelpDialogMain>b__63_0(LayerBase _layer) { }

		internal void <OpenHelpDialogSub>b__64_0(LayerBase _layer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_0
	{
		public int have; //Field offset: 0x8

		public <>c__DisplayClass66_0() { }

		internal bool <SetHeroineSelectIndex>b__0(int x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public Action<Object> ResultSort; //Field offset: 0x8

		public <>c__DisplayClass71_0() { }

		internal void <PressButtonActon>b__1(LayerBase _layerBase) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_1
	{
		public Action<Object> ResultSort; //Field offset: 0x8

		public <>c__DisplayClass71_1() { }

		internal void <PressButtonActon>b__3(LayerBase _layerBase) { }

	}

	[CompilerGenerated]
	private struct <Open>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public GalleryHeroineLayer <>4__this; //Field offset: 0x10
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
	private GalleryHeroineDisp m_bodyDisp; //Field offset: 0x7C
	private GalleryTopLayer m_topLayer; //Field offset: 0x80
	private EnlargedHeroineDisp m_enlargedDisp; //Field offset: 0x84
	[CompilerGenerated]
	private Action <OnClose>k__BackingField; //Field offset: 0x88
	private eMainStep m_MainStep; //Field offset: 0x8C
	private eContStep m_ContStep; //Field offset: 0x90
	private int m_max_count; //Field offset: 0x94
	private int m_init_max_count; //Field offset: 0x98
	private int m_have_heroine_count; //Field offset: 0x9C
	private List<Int32> m_heroine_list; //Field offset: 0xA0
	private int m_favorite_heroine_id; //Field offset: 0xA4
	private List<Int32> m_have_heroine_list; //Field offset: 0xA8
	private int m_select_index; //Field offset: 0xAC
	private int m_next_index; //Field offset: 0xB0
	private bool m_enlarged_ui_flg; //Field offset: 0xB4
	private bool m_endscroll_flg; //Field offset: 0xB5
	private bool m_opendialog_flg; //Field offset: 0xB6
	private readonly int NOT_FOUND_HEROINE; //Field offset: 0xB8

	public int FavoriteHeroineId
	{
		 get { } //Length: 14
	}

	private int FavoriteHeroineIndex
	{
		private get { } //Length: 136
	}

	public List<Int32> GetHaveHeroineList
	{
		 get { } //Length: 14
	}

	public int HaveHeroineCount
	{
		 get { } //Length: 14
	}

	public int HeroineInitMaxCount
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

	public Action OnClose
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public int SelectIndex
	{
		 get { } //Length: 14
	}

	private static GalleryHeroineLayer() { }

	public GalleryHeroineLayer() { }

	[CompilerGenerated]
	private bool <MoveCursor>b__78_0(int index) { }

	[CompilerGenerated]
	private bool <Open>b__67_0() { }

	[CompilerGenerated]
	private bool <Open>b__67_1() { }

	[CompilerGenerated]
	private void <PressButtonActon>b__71_0(object _result) { }

	[CompilerGenerated]
	private void <PressButtonActon>b__71_2(object _result) { }

	[AsyncStateMachine(typeof(<<Update>b__62_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__62_0() { }

	[AsyncStateMachine(typeof(<<Update>b__62_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__62_1() { }

	private void AddDlcList() { }

	private void AddHaveHeroineList() { }

	private void ChangeEnlargedScreen(int index) { }

	public void ChangeJacketImage(MoveDirection dir) { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	private void EndScrollAction(int a_event) { }

	protected virtual bool EndUpdateAfter() { }

	private void FavoriteHeroine(int index) { }

	public int get_FavoriteHeroineId() { }

	private int get_FavoriteHeroineIndex() { }

	public List<Int32> get_GetHaveHeroineList() { }

	public int get_HaveHeroineCount() { }

	public int get_HeroineInitMaxCount() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public int get_NextIndex() { }

	[CompilerGenerated]
	public Action get_OnClose() { }

	public int get_SelectIndex() { }

	public int GetHeroineId(int index) { }

	private bool HaveHeroineFlg(int index) { }

	private void HaveHeroineList() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	private bool IsFavoritMode() { }

	public bool IsOpenEnlargedHeroine() { }

	public bool IsOpenMainHeroine() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void MoveCursor(AxisEventData eventData, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	public void MovePageCursor(AxisEventData eventData) { }

	[AsyncStateMachine(typeof(<Open>d__67))]
	public override UniTask Open(bool visible) { }

	private void OpenHelpDialogMain() { }

	private void OpenHelpDialogSub() { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	private void RebuildPanelList() { }

	protected virtual bool ReleaseLayer() { }

	public void SelectAction(int index) { }

	private void SelectHeroine(int index) { }

	[CompilerGenerated]
	public void set_OnClose(Action value) { }

	private void SetHeroineSelectIndex() { }

	public override void SetTopLayer(GalleryTopLayer galleryTopLayer) { }

	public void SubmitAction(int index) { }

	public void TargetPanelFocus(int index) { }

	protected virtual void Update(bool is_active) { }

	private void UpdateSortAndFilterDisp() { }

	public void VisibledNewMark(int index) { }

}

