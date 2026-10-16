namespace Heqet.Title;

public class DlcListDIalogLayer : LayerBase
{
	[CompilerGenerated]
	private struct <<InitAll>b__8_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public DlcListDIalogLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<InitAll>b__8_2>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public DlcListDIalogLayer <>4__this; //Field offset: 0x8
		private string <dlcLayerName>5__2; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private DlcListDialogDisp m_dlcListDisp; //Field offset: 0x58
	private bool m_isClosing; //Field offset: 0x5C

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

	public DlcListDIalogLayer() { }

	[CompilerGenerated]
	private void <InitAll>b__8_0(int button_id) { }

	[AsyncStateMachine(typeof(<<InitAll>b__8_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <InitAll>b__8_1() { }

	[AsyncStateMachine(typeof(<<InitAll>b__8_2>d))]
	[CompilerGenerated]
	private UniTaskVoid <InitAll>b__8_2() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	protected virtual void Update(bool is_active) { }

}

