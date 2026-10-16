namespace Heqet.DlcList;

public class DlcListTopDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public DlcListTopDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		BACK = 0,
		SELECT = 1,
		HELP = 2,
		NUM = 3,
	}

	private enum eCommonLayerId
	{
		SCROLL_ROOT = 0,
		Max = 1,
	}

	private enum eTextId
	{
		Max = 0,
	}

	internal enum eUIState
	{
		NONE = 0,
		IN = 1,
		OUT = 2,
	}

	private static readonly String[] m_ButtonIdList; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private String[] m_TextList; //Field offset: 0x114
	[CompilerGenerated]
	private Action<Int32> <OnPressButtonAction>k__BackingField; //Field offset: 0x118
	public Action<AxisEventData> OnMoveAction; //Field offset: 0x11C
	public Func<GameObject> GetSelectGameobjectAction; //Field offset: 0x120

	public Action<Int32> OnPressButtonAction
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static DlcListTopDisp() { }

	public DlcListTopDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__16_0(int v) { }

	[CompilerGenerated]
	private bool <Open>b__20_0() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButtonAction() { }

	public CreditDialog GetCreditDialogComponent() { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__20))]
	public UniTask Open(bool visible) { }

	[CompilerGenerated]
	public void set_OnPressButtonAction(Action<Int32> value) { }

	public void SetupDisp() { }

	protected virtual void UpdateDispMain() { }

}

