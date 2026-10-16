namespace Heqet;

public class WorldMapHeaderDisp : DispBase
{
	[CompilerGenerated]
	private struct <Open>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public WorldMapHeaderDisp <>4__this; //Field offset: 0xC
		public bool visible; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		Help = 0,
		Max = 1,
	}

	private enum eCommonLayerId
	{
		Max = 0,
	}

	internal enum eTextId
	{
		Title = 0,
		Max = 1,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private WorldMapLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private String[] m_TextList; //Field offset: 0x11C
	private Animator RootAnimator; //Field offset: 0x120
	[CompilerGenerated]
	private Action<Int32> <OnPressButton>k__BackingField; //Field offset: 0x124
	[CompilerGenerated]
	private eCanvas <TargetCanvas>k__BackingField; //Field offset: 0x128

	public Action<Int32> OnPressButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public eCanvas TargetCanvas
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	private static WorldMapHeaderDisp() { }

	public WorldMapHeaderDisp() { }

	[CompilerGenerated]
	private bool <Open>b__22_0() { }

	public void CallbackButton(int btn_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public Action<Int32> get_OnPressButton() { }

	[CompilerGenerated]
	public eCanvas get_TargetCanvas() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__22))]
	public UniTask Open(bool visible) { }

	[CompilerGenerated]
	public void set_OnPressButton(Action<Int32> value) { }

	[CompilerGenerated]
	public void set_TargetCanvas(eCanvas value) { }

	public void SetTitle(string text) { }

	protected virtual void UpdateDispMain() { }

}

