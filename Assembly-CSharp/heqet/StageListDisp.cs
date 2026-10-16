namespace Heqet;

public class StageListDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public StageListDisp <>4__this; //Field offset: 0xC
		public bool visible; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Screen = 0,
		NUM = 1,
	}

	private enum eCommonLayerId
	{
		SCROLL_ROOT = 0,
		NUM = 1,
	}

	private enum eImageId
	{
		progress_icon_1 = 0,
		progress_icon_2 = 1,
		progress_icon_3 = 2,
		Max = 3,
	}

	private enum eTextId
	{
		SPOT_NAME = 0,
		NUM = 1,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x4
	private StageListLayer m_Layer; //Field offset: 0x114
	private String[] m_ImageList; //Field offset: 0x118
	private String[] m_ButtonDataList; //Field offset: 0x11C
	private Animator RootAnimator; //Field offset: 0x120
	[CompilerGenerated]
	private Action<Int32> <OnPressButtonAction>k__BackingField; //Field offset: 0x124

	public Action<Int32> OnPressButtonAction
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static StageListDisp() { }

	public StageListDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__15_0(AxisEventData eventData) { }

	[CompilerGenerated]
	private void <InitUguiOther>b__15_1(AxisEventData eventData) { }

	[CompilerGenerated]
	private GameObject <InitUguiOther>b__15_2() { }

	[CompilerGenerated]
	private bool <Open>b__18_0() { }

	public void CallbackButton(int id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButtonAction() { }

	public GameObject GetScrollRoot() { }

	public virtual void InitLoadAfter() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__18))]
	public UniTask Open(bool visible) { }

	[CompilerGenerated]
	public void set_OnPressButtonAction(Action<Int32> value) { }

	public void UpdateDisp(SpotPoint targetSpot, WorldSpotModel spotModel) { }

	protected virtual void UpdateDispMain() { }

}

