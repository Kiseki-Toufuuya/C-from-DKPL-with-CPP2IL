namespace Heqet;

public class SpotMapDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public SpotMapDisp <>4__this; //Field offset: 0xC
		public bool visible; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Screen = 0,
		Formation = 1,
		Gallery = 2,
		FreePlay = 3,
		Option = 4,
		Title = 5,
		NUM = 6,
	}

	private SpotMapLayer m_Layer; //Field offset: 0x114
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

	public SpotMapDisp() { }

	[CompilerGenerated]
	private bool <Open>b__17_0() { }

	public void CallbackButton(int btn_id) { }

	public void CallbackDeselectButton(int button_id, BaseEventData baseData) { }

	public void CallbackInitLayout() { }

	public void CallbackSelectButton(int button_id, BaseEventData baseData) { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButton() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__17))]
	public UniTask Open(bool visible) { }

	private void SelectButton(int button_id, bool isSelect) { }

	[CompilerGenerated]
	public void set_OnPressButton(Action<Int32> value) { }

	internal void SetAllButtonHit(bool enable) { }

	protected virtual void UpdateDispMain() { }

}

