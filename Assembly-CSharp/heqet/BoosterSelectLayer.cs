namespace Heqet;

public class BoosterSelectLayer : UiScrollListLayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__33_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public BoosterSelectLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__33_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public BoosterSelectLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

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
		NONE = 5,
	}

	internal class ItemData
	{
		public WorldBoosterModel model; //Field offset: 0x8
		public bool isEnable; //Field offset: 0xC

		public ItemData() { }

	}

	private const int ONE_LINE_NUM = 4; //Field offset: 0x0
	private BoosterSelectDisp m_BoosterSelectDisp; //Field offset: 0x7C
	public Action<BoosterSelectLayer, Int32> OnPressButton; //Field offset: 0x80
	private IList<ItemData> m_item_list; //Field offset: 0x84
	private int m_max_count; //Field offset: 0x88
	private int m_select_index; //Field offset: 0x8C
	private int m_last_select_index; //Field offset: 0x90
	private bool m_canPay; //Field offset: 0x94
	[CompilerGenerated]
	private RythmGameType <RythmGameType>k__BackingField; //Field offset: 0x98
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

	public private RythmGameType RythmGameType
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public int SelectIndex
	{
		 get { } //Length: 14
	}

	public BoosterSelectLayer() { }

	[AsyncStateMachine(typeof(<<Update>b__33_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__33_0() { }

	[AsyncStateMachine(typeof(<<Update>b__33_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__33_1() { }

	public void ApplySetting() { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	public void DeselectList(BaseEventData eventData) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	private RythmGameType get_RythmGameType() { }

	public int get_SelectIndex() { }

	public ItemData GetItemModel(int index) { }

	public GameObject GetSelectedGameObject() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public bool MoveCursor(AxisEventData eventData) { }

	public void Open(bool visible) { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	protected virtual bool ReleaseLayer() { }

	private void ResetItem() { }

	public void SelectAction(int index) { }

	private void SelectItem(int index) { }

	public void SelectList(BaseEventData eventData) { }

	[CompilerGenerated]
	public void set_RythmGameType(RythmGameType value) { }

	public void SubmitAction(int index) { }

	protected virtual void Update(bool is_active) { }

	public void UpdateGotoPlayButton() { }

}

