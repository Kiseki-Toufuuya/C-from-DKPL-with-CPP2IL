namespace Heqet;

public class GalleryMitamaLayer : UiScrollListLayerBase, IGalleryLayer
{
	[CompilerGenerated]
	private struct <<Update>b__61_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryMitamaLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__61_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryMitamaLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__62_0; //Field offset: 0x4
		public static Action<LayerBase> <>9__63_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OpenHelpDialogMain>b__62_0(LayerBase _layer) { }

		internal void <OpenHelpDialogSub>b__63_0(LayerBase _layer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public int have; //Field offset: 0x8

		public <>c__DisplayClass65_0() { }

		internal bool <SetMitamaSelectIndex>b__0(int x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public Action<Object> ResultSort; //Field offset: 0x8

		public <>c__DisplayClass70_0() { }

		internal void <PressButtonActon>b__1(LayerBase _layerBase) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_1
	{
		public Action<Object> ResultSort; //Field offset: 0x8

		public <>c__DisplayClass70_1() { }

		internal void <PressButtonActon>b__3(LayerBase _layerBase) { }

	}

	[CompilerGenerated]
	private struct <Open>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public GalleryMitamaLayer <>4__this; //Field offset: 0x10
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
	private GalleryMitamaDisp m_bodyDisp; //Field offset: 0x7C
	private GalleryTopLayer m_topLayer; //Field offset: 0x80
	private MitamaEnlargedScreenDisp m_enlargedscreenDisp; //Field offset: 0x84
	[CompilerGenerated]
	private Action <OnClose>k__BackingField; //Field offset: 0x88
	private eMainStep m_MainStep; //Field offset: 0x8C
	private eContStep m_ContStep; //Field offset: 0x90
	private int m_max_count; //Field offset: 0x94
	private int m_init_max_count; //Field offset: 0x98
	private List<Int32> m_mitama_list; //Field offset: 0x9C
	private int m_select_index; //Field offset: 0xA0
	private int m_next_index; //Field offset: 0xA4
	private int m_favorite_card_id; //Field offset: 0xA8
	private List<Int32> m_have_mitama_list; //Field offset: 0xAC
	private bool m_enlarged_ui_flg; //Field offset: 0xB0
	private bool m_endscroll_flg; //Field offset: 0xB1
	private bool m_opendialog_flg; //Field offset: 0xB2
	private readonly int NOT_FOUND_MITAMA; //Field offset: 0xB4

	public int FavoriteCardId
	{
		 get { } //Length: 14
	}

	private int FavoriteCardIndex
	{
		private get { } //Length: 136
	}

	public List<Int32> GetHaveMitamaList
	{
		 get { } //Length: 14
	}

	public List<Int32> GetMitamaList
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

	public int MitamaInitMaxCount
	{
		 get { } //Length: 14
	}

	public int MitamaMaxCount
	{
		 get { } //Length: 14
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

	private static GalleryMitamaLayer() { }

	public GalleryMitamaLayer() { }

	[CompilerGenerated]
	private bool <MoveCursor>b__78_0(int index) { }

	[CompilerGenerated]
	private bool <Open>b__66_0() { }

	[CompilerGenerated]
	private bool <Open>b__66_1() { }

	[CompilerGenerated]
	private void <PressButtonActon>b__70_0(object _result) { }

	[CompilerGenerated]
	private void <PressButtonActon>b__70_2(object _result) { }

	[AsyncStateMachine(typeof(<<Update>b__61_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__61_0() { }

	[AsyncStateMachine(typeof(<<Update>b__61_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__61_1() { }

	private void AddHaveMitamaList() { }

	private void ChangeEnlargedScreen(int index) { }

	public void ChangeMitamaImage(MoveDirection dir) { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	private void EndScrollAction(int a_event) { }

	protected virtual bool EndUpdateAfter() { }

	private void FavoriteCard(int index) { }

	public int get_FavoriteCardId() { }

	private int get_FavoriteCardIndex() { }

	public List<Int32> get_GetHaveMitamaList() { }

	public List<Int32> get_GetMitamaList() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public int get_MitamaInitMaxCount() { }

	public int get_MitamaMaxCount() { }

	public int get_NextIndex() { }

	[CompilerGenerated]
	public Action get_OnClose() { }

	public int get_SelectIndex() { }

	public int GetMitamaId(int index) { }

	private bool HaveMitamaFlg(int index) { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	private bool IsFavoritMode() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void MoveCursor(AxisEventData eventData, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	public void MovePageCursor(AxisEventData eventData) { }

	[AsyncStateMachine(typeof(<Open>d__66))]
	public override UniTask Open(bool visible) { }

	private void OpenHelpDialogMain() { }

	private void OpenHelpDialogSub() { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	private void RebuildPanelList() { }

	protected virtual bool ReleaseLayer() { }

	public void SelectAction(int index) { }

	private void SelectMitama(int index) { }

	[CompilerGenerated]
	public void set_OnClose(Action value) { }

	private void SetMitamaSelectIndex() { }

	public override void SetTopLayer(GalleryTopLayer galleryTopLayer) { }

	public void SubmitAction(int index) { }

	public void TargetPanelFocus(int index) { }

	protected virtual void Update(bool is_active) { }

	private void UpdateSortAndFilterDisp() { }

	public void VisibledNewMark(int index) { }

	public void WhilePressedButtonActon(int btn_id) { }

}

