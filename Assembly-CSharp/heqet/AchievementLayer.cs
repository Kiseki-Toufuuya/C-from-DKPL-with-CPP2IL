namespace Heqet;

public class AchievementLayer : LayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__17_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public AchievementLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eMainStep
	{
		OPEN = 0,
		MAIN = 1,
		CLOSE = 2,
	}

	private AchievementDisp m_AchievementDisp; //Field offset: 0x58
	private eMainStep m_MainStep; //Field offset: 0x5C

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_STATIC_LAYER
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

	public AchievementLayer() { }

	[AsyncStateMachine(typeof(<<Update>b__17_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__17_0() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_STATIC_LAYER() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	public bool IsClose() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void Open() { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SetId(int id) { }

	protected virtual void Update(bool is_active) { }

}

