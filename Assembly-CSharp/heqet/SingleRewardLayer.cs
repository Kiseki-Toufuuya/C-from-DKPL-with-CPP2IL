namespace Heqet;

public class SingleRewardLayer : LayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__26_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SingleRewardLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__26_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SingleRewardLayer <>4__this; //Field offset: 0x8
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

	private int m_ItemType; //Field offset: 0x58
	private int m_ItemID; //Field offset: 0x5C
	private string m_TitleText; //Field offset: 0x60
	private string m_BodyText; //Field offset: 0x64
	private SingleRewardDisp m_StageRewardDisp; //Field offset: 0x68
	[CompilerGenerated]
	private Action <OnClose>k__BackingField; //Field offset: 0x6C
	private eMainStep m_MainStep; //Field offset: 0x70
	private eContStep m_ContStep; //Field offset: 0x74

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

	public Action OnClose
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public SingleRewardLayer() { }

	[AsyncStateMachine(typeof(<<Update>b__26_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__26_0() { }

	[AsyncStateMachine(typeof(<<Update>b__26_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__26_1() { }

	public void Close() { }

	private void ContMain() { }

	private void DispItem() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	public Action get_OnClose() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void Open(int ItemId, int itemType, string titleText, string bodyText) { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	public void set_OnClose(Action value) { }

	protected virtual void Update(bool is_active) { }

}

