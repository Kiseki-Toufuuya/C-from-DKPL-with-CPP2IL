namespace Heqet;

public class AchievementRewardLayer : LayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__24_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public AchievementRewardLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__24_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public AchievementRewardLayer <>4__this; //Field offset: 0x8
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

	[CompilerGenerated]
	private int <CardId>k__BackingField; //Field offset: 0x58
	private AchievementRewardDisp m_AchievementRewardDisp; //Field offset: 0x5C
	private int m_dispIndex; //Field offset: 0x60
	private int m_rewardCount; //Field offset: 0x64
	private eMainStep m_MainStep; //Field offset: 0x68
	private eContStep m_ContStep; //Field offset: 0x6C

	public int CardId
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

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

	public AchievementRewardLayer() { }

	[AsyncStateMachine(typeof(<<Update>b__24_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__24_0() { }

	[AsyncStateMachine(typeof(<<Update>b__24_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__24_1() { }

	private void ContMain() { }

	private void DispItem(int dispIndex) { }

	protected virtual bool EndUpdateAfter() { }

	[CompilerGenerated]
	public int get_CardId() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void Open(bool visible) { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	public void set_CardId(int value) { }

	protected virtual void Update(bool is_active) { }

}

