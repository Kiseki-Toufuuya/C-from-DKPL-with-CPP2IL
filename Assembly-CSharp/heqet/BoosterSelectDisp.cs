namespace Heqet;

public class BoosterSelectDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public BoosterSelectDisp <>4__this; //Field offset: 0xC
		public bool visible; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		ApplySetting = 0,
		Reset = 1,
		Cancel = 2,
		Max = 3,
	}

	private enum eCommonLayerId
	{
		ScrollRoot = 0,
		ListNavigationRoot = 1,
		Max = 2,
	}

	private enum eImageId
	{
		Max = 0,
	}

	private enum eTextId
	{
		Money = 0,
		Max = 1,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private BoosterSelectLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private TextMeshProUGUI m_MoneyText; //Field offset: 0x120

	private static BoosterSelectDisp() { }

	public BoosterSelectDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__12_0(BaseEventData eventData) { }

	[CompilerGenerated]
	private void <InitUguiOther>b__12_1(BaseEventData eventData) { }

	[CompilerGenerated]
	private bool <InitUguiOther>b__12_2(AxisEventData eventData) { }

	[CompilerGenerated]
	private GameObject <InitUguiOther>b__12_3() { }

	[CompilerGenerated]
	private bool <Open>b__17_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public GameObject GetListNavigationRoot() { }

	public GameObject GetScrollRoot() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__17))]
	public UniTask Open(bool visible) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateMoney(int money) { }

}

