namespace Heqet;

public class SettingHelpBarDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public SettingHelpBarDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Decide = 0,
		Cancel = 1,
		Reset = 2,
	}

	private enum eImageId
	{
	}

	private enum eLayerId
	{
		KeyconfigPreview = 0,
	}

	private enum eTextId
	{
	}

	private static readonly String[] m_LayerList; //Field offset: 0x0
	private static readonly String[] m_TextList; //Field offset: 0x4
	private static readonly String[] m_ImageList; //Field offset: 0x8
	private String[] m_ButtonDataList; //Field offset: 0x114
	private Animator RootAnimator; //Field offset: 0x118
	[CompilerGenerated]
	private Action<Int32> <OnPressButton>k__BackingField; //Field offset: 0x11C

	public Action<Int32> OnPressButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static SettingHelpBarDisp() { }

	public SettingHelpBarDisp() { }

	[CompilerGenerated]
	private bool <Open>b__19_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void DispKeyConfigPreview(bool _enable) { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButton() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__19))]
	public UniTask Open(bool visible) { }

	[CompilerGenerated]
	public void set_OnPressButton(Action<Int32> value) { }

	public void UpdateButtonHit(bool _enable) { }

	protected virtual void UpdateDispMain() { }

}

