namespace Heqet;

public class SettingHeaderDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int32, BaseEventData> <>9__15_2; //Field offset: 0x4
		public static Func<String, String> <>9__15_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <InitUguiOther>b__15_0(string _label) { }

		internal void <InitUguiOther>b__15_2(int _id, BaseEventData _data) { }

	}

	[CompilerGenerated]
	private struct <Open>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public SettingHeaderDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Kagura = 0,
		Danmaku = 1,
		Sound = 2,
		Other = 3,
		KeyConfig = 4,
		Help = 5,
	}

	private enum eLayerId
	{
		Kagura = 0,
		Danmeku = 1,
		Sound = 2,
		Other = 3,
		Keyconfig = 4,
	}

	private enum eTextId
	{
		Label = 0,
		Kagura = 1,
		Danmeku = 2,
		Sound = 3,
		Other = 4,
		Keyconfig = 5,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_LayerList; //Field offset: 0x4
	private String[] m_ButtonDataList; //Field offset: 0x114
	private Animator RootAnimator; //Field offset: 0x118
	[CompilerGenerated]
	private Action<Int32> <OnPressButton>k__BackingField; //Field offset: 0x11C
	private List<UIWrapperButton> m_CategoryButtons; //Field offset: 0x120
	protected CriAtomExPlayback m_TabSeHandle; //Field offset: 0x124

	public Action<Int32> OnPressButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static SettingHeaderDisp() { }

	public SettingHeaderDisp() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__15_1(int _id) { }

	[CompilerGenerated]
	private bool <Open>b__22_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public void CallbackSelect(int button_id, BaseEventData _data) { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButton() { }

	public UIWrapperButton GetCategoryButton(eButtonId _id) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__22))]
	public UniTask Open(bool visible) { }

	protected CriAtomExPlayback PlaySoundStart(ALL_SE _sound) { }

	public void PlaySoundTab() { }

	public void SelectFirstButton() { }

	[CompilerGenerated]
	public void set_OnPressButton(Action<Int32> value) { }

	private void UpdateActiveTab(int button_id) { }

	public void UpdateButtonHit(bool _enable) { }

	protected virtual void UpdateDispMain() { }

}

