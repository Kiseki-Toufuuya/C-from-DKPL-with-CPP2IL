namespace Heqet;

public class StageListLayer : UiScrollListLayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__34_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public StageListLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__34_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public StageListLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__29_2; //Field offset: 0x4
		public static Comparison<WorldStageModel> <>9__42_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <InitAll>b__29_2(LayerBase _layer) { }

		internal int <SortStageList>b__42_0(WorldStageModel a, WorldStageModel b) { }

	}

	private enum eContStep
	{
		MAIN = 0,
		NONE = 1,
	}

	private enum eMainStep
	{
		OPEN = 0,
		OPENING = 1,
		MAIN = 2,
		CLOSE = 3,
		CLOSEING = 4,
		WAIT_HELP = 5,
		NONE = 6,
	}

	private StageListDisp m_StageListDisp; //Field offset: 0x7C
	private StageListHooterDisp m_FooterDisp; //Field offset: 0x80
	[CompilerGenerated]
	private Action<Int32> <OnSubmitStage>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private SpotManager <SpotManager>k__BackingField; //Field offset: 0x88
	private int m_current_spot_index; //Field offset: 0x8C
	private int m_select_panel_index; //Field offset: 0x90
	private List<WorldStageModel> m_stageModelList; //Field offset: 0x94
	private GameObject m_lastSelected; //Field offset: 0x98
	private eMainStep m_MainStep; //Field offset: 0x9C
	private eContStep m_ContStep; //Field offset: 0xA0

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

	public Action<Int32> OnSubmitStage
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public int SelectPanelIndex
	{
		 get { } //Length: 14
	}

	public private SpotManager SpotManager
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public StageListLayer() { }

	[CompilerGenerated]
	private void <InitAll>b__29_0(int btn_id) { }

	[CompilerGenerated]
	private void <InitAll>b__29_1(int btn_id) { }

	[AsyncStateMachine(typeof(<<Update>b__34_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__34_0() { }

	[AsyncStateMachine(typeof(<<Update>b__34_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__34_1() { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	public Action<Int32> get_OnSubmitStage() { }

	public int get_SelectPanelIndex() { }

	[CompilerGenerated]
	private SpotManager get_SpotManager() { }

	public GameObject GetSelectObject() { }

	private List<WorldStageModel> GetStageList(SpotPoint spotPoint) { }

	public WorldStageModel GetStageModel(int index) { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	public bool IsDispStageList() { }

	public void MoveCursor(AxisEventData eventData, int offsetX = 1, int offsetY = 1, bool isRound = true) { }

	public void MovePageCursor(AxisEventData eventData) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SelectAction(int index) { }

	public void SelectStageDataIdPanel(int stageDataId) { }

	public void SequentialSpot(int offset) { }

	[CompilerGenerated]
	public void set_OnSubmitStage(Action<Int32> value) { }

	[CompilerGenerated]
	public void set_SpotManager(SpotManager value) { }

	private void SortStageList(List<WorldStageModel> stageList) { }

	public void SubmitAction(int stage_data_id) { }

	private void ToggleFavorite() { }

	protected virtual void Update(bool is_active) { }

	public void UpdateSpotList(SpotPoint spotPoint) { }

}

