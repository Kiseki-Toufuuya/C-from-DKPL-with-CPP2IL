namespace Heqet;

public class UnlockMusicDialogLayer : LayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__26_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public UnlockMusicDialogLayer <>4__this; //Field offset: 0x8
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
		public UnlockMusicDialogLayer <>4__this; //Field offset: 0x8
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

	private UnlockMusicDialogDisp m_UnlockMusicDisp; //Field offset: 0x58
	[CompilerGenerated]
	private Action <OnClose>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private int <MusicId>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private string <BodyText>k__BackingField; //Field offset: 0x64
	private eMainStep m_MainStep; //Field offset: 0x68
	private eContStep m_ContStep; //Field offset: 0x6C

	public private string BodyText
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
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

	public private int MusicId
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Action OnClose
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public UnlockMusicDialogLayer() { }

	[CompilerGenerated]
	private void <InitAll>b__23_0(int btn_id) { }

	[AsyncStateMachine(typeof(<<Update>b__26_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__26_0() { }

	[AsyncStateMachine(typeof(<<Update>b__26_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__26_1() { }

	private void ContMain() { }

	protected virtual bool EndUpdateAfter() { }

	[CompilerGenerated]
	private string get_BodyText() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	private int get_MusicId() { }

	[CompilerGenerated]
	public Action get_OnClose() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void Open() { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	public void set_BodyText(string value) { }

	[CompilerGenerated]
	public void set_MusicId(int value) { }

	[CompilerGenerated]
	public void set_OnClose(Action value) { }

	protected virtual void Update(bool is_active) { }

}

