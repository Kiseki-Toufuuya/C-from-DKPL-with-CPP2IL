namespace Heqet;

public class ShopLayer : UiScrollListLayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__35_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public ShopLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__35_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public ShopLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<ItemData> <>9__29_0; //Field offset: 0x4
		public static Action<LayerBase> <>9__36_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OpenHelpDialog>b__36_0(LayerBase _layer) { }

		internal int <SortLineupList>b__29_0(ItemData a, ItemData b) { }

	}

	private enum eContStep
	{
		FIRST_HELP = 0,
		MAIN = 1,
		WAIT_DIALOG = 2,
		PURCHASED_ITEM = 3,
		NONE = 4,
	}

	private enum eMainStep
	{
		OPEN = 0,
		OPENING = 1,
		MAIN = 2,
		CLOSE = 3,
		CLOSEING = 4,
		WAIT_HELP = 5,
		DO_SAVE = 6,
		WAIT_SYSTEM_ERROR_DIALOG = 7,
		NONE = 8,
	}

	internal class ItemData
	{
		public WorldShopItemModel model; //Field offset: 0x8
		public bool isPurchased; //Field offset: 0xC
		public bool isShortmoney; //Field offset: 0xD
		public string name; //Field offset: 0x10
		public string ownerName; //Field offset: 0x14

		public bool IsCanBuy
		{
			 get { } //Length: 25
		}

		public int Price
		{
			 get { } //Length: 23
		}

		public ItemData() { }

		public bool get_IsCanBuy() { }

		public int get_Price() { }

	}

	private const string PAYMENT_DIALOG_NAME = "shop_payment"; //Field offset: 0x0
	private static int ONE_LINE_NUM; //Field offset: 0x0
	private ShopDisp m_ShopDisp; //Field offset: 0x7C
	private InputAction m_Cancel; //Field offset: 0x80
	private TransitionInfo m_transitionInfo; //Field offset: 0x84
	private GameObject m_ScroolRoot; //Field offset: 0x88
	private ItemData m_cartItem; //Field offset: 0x8C
	private eMainStep m_MainStep; //Field offset: 0x90
	private eContStep m_ContStep; //Field offset: 0x94
	private int m_select_index; //Field offset: 0x98
	private int m_max_count; //Field offset: 0x9C
	private List<ItemData> m_item_list; //Field offset: 0xA0

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

	public int SelectIndex
	{
		 get { } //Length: 14
	}

	private static ShopLayer() { }

	public ShopLayer() { }

	[CompilerGenerated]
	private void <RequestPaymentDialog>b__46_0(ButtonType btn) { }

	[AsyncStateMachine(typeof(<<Update>b__35_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__35_0() { }

	[AsyncStateMachine(typeof(<<Update>b__35_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__35_1() { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public int get_SelectIndex() { }

	public ItemData GetItemModel(int index) { }

	protected virtual void InitAll() { }

	private void InitInputAction() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	public static bool IsInPossessionItem(WorldShopItemModel model) { }

	public void MoveCursor(AxisEventData eventData) { }

	public void Open(bool visible) { }

	private void OpenHelpDialog() { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	protected virtual bool ReleaseLayer() { }

	public void RequestPaymentDialog(ItemData targetItem) { }

	public void SelectAction(int index, bool forceUpdate = false) { }

	private void SelectItem(int index) { }

	private void SortLineupList() { }

	public void SubmitAction(int index) { }

	protected virtual void Update(bool is_active) { }

	public void UpdateDisp() { }

	public static void UpdateLineup(List<Int32> lineup) { }

}

