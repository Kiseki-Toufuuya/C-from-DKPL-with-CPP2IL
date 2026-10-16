namespace Heqet;

public class SkinSelectLayer : LayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__23_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SkinSelectLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__23_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SkinSelectLayer <>4__this; //Field offset: 0x8
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

	private SkinSelectDisp m_skinSelectDisp; //Field offset: 0x58
	public Action<Int32> m_onChangeSkin; //Field offset: 0x5C
	[CompilerGenerated]
	private int <SelectSkinId>k__BackingField; //Field offset: 0x60
	private eMainStep m_MainStep; //Field offset: 0x64
	private eContStep m_ContStep; //Field offset: 0x68

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

	public int SelectSkinId
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public SkinSelectLayer() { }

	[AsyncStateMachine(typeof(<<Update>b__23_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__23_0() { }

	[AsyncStateMachine(typeof(<<Update>b__23_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__23_1() { }

	public void ChangeSkinAction(int skin_id) { }

	private void ContMain() { }

	public void DisableLawsonSkin() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	public int get_SelectSkinId() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void Open(bool visible) { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	public void set_SelectSkinId(int value) { }

	protected virtual void Update(bool is_active) { }

}

