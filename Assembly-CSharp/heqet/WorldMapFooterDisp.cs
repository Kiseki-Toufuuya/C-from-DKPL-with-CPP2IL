namespace Heqet;

public class WorldMapFooterDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WorldMapFooterDisp <>4__this; //Field offset: 0xC
		public bool visible; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Select = 0,
		StageList = 1,
		OpenMenu = 2,
		BackWorld = 3,
		NUM = 4,
	}

	internal enum eMode
	{
		SelectSpot = 0,
		SelectStage = 1,
	}

	private WorldMapLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	[CompilerGenerated]
	private Action<Int32> <OnPressButton>k__BackingField; //Field offset: 0x120

	public Action<Int32> OnPressButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public WorldMapFooterDisp() { }

	[CompilerGenerated]
	private bool <Open>b__15_0() { }

	public void CallbackButton(int btn_id) { }

	public void CallbackInitLayout() { }

	public void ChangeMode(eMode mode) { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButton() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__15))]
	public UniTask Open(bool visible) { }

	[CompilerGenerated]
	public void set_OnPressButton(Action<Int32> value) { }

	internal void SetAllButtonHit(bool enable) { }

	protected virtual void UpdateDispMain() { }

}

