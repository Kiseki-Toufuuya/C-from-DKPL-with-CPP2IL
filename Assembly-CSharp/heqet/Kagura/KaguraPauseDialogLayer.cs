namespace Heqet.Kagura;

public class KaguraPauseDialogLayer : LayerBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__37_1; //Field offset: 0x4
		public static Action <>9__37_2; //Field offset: 0x8
		public static Action <>9__38_1; //Field offset: 0xC
		public static Action <>9__38_2; //Field offset: 0x10
		public static Action <>9__39_1; //Field offset: 0x14
		public static Action <>9__39_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <InnerOpenPauseDialog>b__37_1() { }

		internal void <InnerOpenPauseDialog>b__37_2() { }

		internal void <InnerRetireDialog>b__38_1() { }

		internal void <InnerRetireDialog>b__38_2() { }

		internal void <InnerRetryDialog>b__39_1() { }

		internal void <InnerRetryDialog>b__39_2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public KaguraPauseDialogLayer <>4__this; //Field offset: 0x8
		public string tag; //Field offset: 0xC

		public <>c__DisplayClass36_0() { }

		internal bool <OpenDialogAsync>b__0() { }

		internal bool <OpenDialogAsync>b__1() { }

	}

	[CompilerGenerated]
	private struct <OpenDialogAsync>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public KaguraPauseDialogLayer <>4__this; //Field offset: 0xC
		private <>c__DisplayClass36_0 <>8__1; //Field offset: 0x10
		public eDialogType type; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eDialogType
	{
		Pause = 0,
		Retire = 1,
		Retry = 2,
		Restart = 3,
	}

	private enum eMainStep
	{
		OPEN = 0,
		OPENING = 1,
		MAIN = 2,
		CLOSE = 3,
		CLOSEING = 4,
		OTHER_LAYER = 5,
		NONE = 6,
	}

	[CompilerGenerated]
	private bool <IsBack>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private bool <IsExit>k__BackingField; //Field offset: 0x59
	[CompilerGenerated]
	private bool <IsRetry>k__BackingField; //Field offset: 0x5A
	private CountDownDisp m_CountDownDisp; //Field offset: 0x5C
	private eMainStep m_MainStep; //Field offset: 0x60
	[CompilerGenerated]
	private bool <IsOpeningDialog>k__BackingField; //Field offset: 0x64

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

	public private bool IsBack
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private bool IsExit
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private bool IsOpeningDialog
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private bool IsRetry
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public KaguraPauseDialogLayer() { }

	[CompilerGenerated]
	private void <DoRestart>b__40_0() { }

	[CompilerGenerated]
	private void <InnerOpenPauseDialog>b__37_0(ButtonType btnId) { }

	[CompilerGenerated]
	private void <InnerRetireDialog>b__38_0(ButtonType btnId) { }

	[CompilerGenerated]
	private void <InnerRetryDialog>b__39_0(ButtonType btnId) { }

	private void DoRestart() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	public bool get_IsBack() { }

	[CompilerGenerated]
	public bool get_IsExit() { }

	[CompilerGenerated]
	public bool get_IsOpeningDialog() { }

	[CompilerGenerated]
	public bool get_IsRetry() { }

	private string GetMusicDifficulty(MusicDifficulty musicDifficulty) { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	private void InnerOpenPauseDialog(string tag) { }

	private void InnerRetireDialog(string tag) { }

	private void InnerRetryDialog(string tag) { }

	protected virtual void LateUpdate(bool is_active) { }

	[AsyncStateMachine(typeof(<OpenDialogAsync>d__36))]
	private UniTask OpenDialogAsync(eDialogType type) { }

	public void OpenPauseDialog() { }

	private void OpenRetireDialog() { }

	private void OpenRetryDialog() { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	private void set_IsBack(bool value) { }

	[CompilerGenerated]
	private void set_IsExit(bool value) { }

	[CompilerGenerated]
	private void set_IsOpeningDialog(bool value) { }

	[CompilerGenerated]
	private void set_IsRetry(bool value) { }

	protected virtual void Update(bool is_active) { }

}

