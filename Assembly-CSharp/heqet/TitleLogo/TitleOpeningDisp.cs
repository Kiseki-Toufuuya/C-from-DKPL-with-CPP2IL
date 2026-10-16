namespace Heqet.TitleLogo;

public class TitleOpeningDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<ButtonType> <>9__13_0; //Field offset: 0x4
		public static Action <>9__13_1; //Field offset: 0x8
		public static Action <>9__13_2; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal void <ShowMsgBox>b__13_0(ButtonType btn) { }

		internal void <ShowMsgBox>b__13_1() { }

		internal void <ShowMsgBox>b__13_2() { }

	}

	[CompilerGenerated]
	private struct <ShowMsgBox>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public TitleOpeningDisp <>4__this; //Field offset: 0x8
		private string <tag>5__2; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartLogo>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public TitleOpeningDisp <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC
		private TweenAwaiter <>u__2; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string DLC_MSG = "dlc_msg"; //Field offset: 0x0
	private const string CAUTION_MSG = "caution_msg"; //Field offset: 0x0
	private const string LOGO = "logo"; //Field offset: 0x0
	private TitleOpeningLayer m_Layer; //Field offset: 0x114
	private TextMeshProUGUI m_DlcMsgText; //Field offset: 0x118
	private TextMeshProUGUI m_CautionMsgText; //Field offset: 0x11C
	private Image m_LogoImage; //Field offset: 0x120
	private MoviePlayerUI m_moviePlayer; //Field offset: 0x124

	public TitleOpeningDisp() { }

	[CompilerGenerated]
	private bool <StartLogo>b__12_0() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void InitLayout() { }

	public bool IsMovieReady() { }

	protected virtual void LateUpdate() { }

	public void PlayMovie() { }

	[AsyncStateMachine(typeof(<ShowMsgBox>d__13))]
	private UniTaskVoid ShowMsgBox() { }

	[AsyncStateMachine(typeof(<StartLogo>d__12))]
	private UniTaskVoid StartLogo() { }

	protected virtual void UpdateDispMain() { }

}

