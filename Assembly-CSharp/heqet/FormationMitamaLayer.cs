namespace Heqet;

public class FormationMitamaLayer : UiScrollListLayerBase
{
	[CompilerGenerated]
	private struct <<StartLevelUp>b__43_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public FormationMitamaLayer <>4__this; //Field offset: 0x8
		private int <roundCount>5__2; //Field offset: 0xC
		private float <roundPerTime>5__3; //Field offset: 0x10
		private float <roundTime>5__4; //Field offset: 0x14
		private CardData <cardData>5__5; //Field offset: 0x18
		private HeqetCardModel <cardModel>5__6; //Field offset: 0x1C
		private int <maxLevel>5__7; //Field offset: 0x20
		private int <subExp>5__8; //Field offset: 0x24
		private Awaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__39_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public FormationMitamaLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__39_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public FormationMitamaLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__40_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <OpenHelpDialog>b__40_0(LayerBase _layer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public Action<Object> ResultSort; //Field offset: 0x8

		public <>c__DisplayClass46_0() { }

		internal void <PressButtonActon>b__1(LayerBase _layerBase) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_1
	{
		public Action<Object> ResultSort; //Field offset: 0x8

		public <>c__DisplayClass46_1() { }

		internal void <PressButtonActon>b__3(LayerBase _layerBase) { }

	}

	private enum eContStep
	{
		FIRST_HELP = 0,
		MAIN = 1,
		LEVEL_UP = 2,
		NONE = 3,
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
	private FormationMitamaDisp m_FormationMitamaDisp; //Field offset: 0x7C
	private InputAction m_LevelUp; //Field offset: 0x80
	private TransitionInfo m_transitionInfo; //Field offset: 0x84
	private GameObject m_lastSelected; //Field offset: 0x88
	private eMainStep m_MainStep; //Field offset: 0x8C
	private eContStep m_ContStep; //Field offset: 0x90
	private int m_qeuip_card_id; //Field offset: 0x94
	private int m_select_card_index; //Field offset: 0x98
	private int m_equip_card_index; //Field offset: 0x9C
	private int m_max_count; //Field offset: 0xA0
	private List<Int32> m_card_list; //Field offset: 0xA4
	private bool m_isPressedLvUpButton; //Field offset: 0xA8

	public int EquipCardIndex
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

	public int PreviewCardId
	{
		 get { } //Length: 116
	}

	public int SelectCardIndex
	{
		 get { } //Length: 14
	}

	private static FormationMitamaLayer() { }

	public FormationMitamaLayer() { }

	[CompilerGenerated]
	private void <PressButtonActon>b__46_0(object _result) { }

	[CompilerGenerated]
	private void <PressButtonActon>b__46_2(object _result) { }

	[AsyncStateMachine(typeof(<<StartLevelUp>b__43_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <StartLevelUp>b__43_0() { }

	[AsyncStateMachine(typeof(<<Update>b__39_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__39_0() { }

	[AsyncStateMachine(typeof(<<Update>b__39_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__39_1() { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	protected virtual bool EndUpdateAfter() { }

	private void EquipCard(int index) { }

	public int get_EquipCardIndex() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public int get_PreviewCardId() { }

	public int get_SelectCardIndex() { }

	public int GetCardId(int index) { }

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

	public void SelectAction(int list_index) { }

	private void SelectCard(int index) { }

	public void StartLevelUp() { }

	public void SubmitAction(int index) { }

	protected virtual void Update(bool is_active) { }

	public void UpdateDisp() { }

	private void UpdateSortAndFilterDisp() { }

}

