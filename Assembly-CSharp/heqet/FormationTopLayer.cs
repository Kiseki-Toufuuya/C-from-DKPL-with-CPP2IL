namespace Heqet;

public class FormationTopLayer : LayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__20_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public FormationTopLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__20_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public FormationTopLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__20_2>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public FormationTopLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__21_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <OpenHelpDialog>b__21_0(LayerBase _layer) { }

	}

	private enum eContStep
	{
		FIRST_HELP = 0,
		MAIN = 1,
		NONE = 2,
	}

	private enum eMainStep
	{
		OPEN = 0,
		OPENING = 1,
		MAIN = 2,
		CLOSE = 3,
		CLOSEING = 4,
		OTHER_LAYER = 5,
		HELP_DIALOG = 6,
		RETURNING = 7,
		DO_SAVE = 8,
		WAIT_SYSTEM_DIALOG = 9,
		NONE = 10,
	}

	private FormationTopDisp m_FormationTopDisp; //Field offset: 0x58
	private TransitionInfo m_transitionInfo; //Field offset: 0x5C
	private GameObject m_lastSelected; //Field offset: 0x60
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

	public FormationTopLayer() { }

	[AsyncStateMachine(typeof(<<Update>b__20_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__20_0() { }

	[AsyncStateMachine(typeof(<<Update>b__20_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__20_1() { }

	[AsyncStateMachine(typeof(<<Update>b__20_2>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__20_2() { }

	private void ContMain() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void Open(bool visible) { }

	private void OpenHelpDialog() { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	protected virtual bool ReleaseLayer() { }

	protected virtual void Update(bool is_active) { }

	public void UpdateDisp() { }

}

