namespace XeApp.Game.Net;

public class BannedWordProvider
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Action onErrorToTitle; //Field offset: 0x8

		public <>c__DisplayClass4_0() { }

		internal void <Validate>b__0(object _) { }

	}

	[CompilerGenerated]
	private struct <Validate>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Validate>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x4
		public Action onErrorToTitle; //Field offset: 0x10
		public BannedWordProvider <>4__this; //Field offset: 0x14
		public string word; //Field offset: 0x18
		private <>c__DisplayClass4_0 <>8__1; //Field offset: 0x1C
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static BannedWordProvider m_instance; //Field offset: 0x0

	public static BannedWordProvider Instance
	{
		 get { } //Length: 100
	}

	public BannedWordProvider() { }

	public static BannedWordProvider get_Instance() { }

	[AsyncStateMachine(typeof(<Validate>d__3))]
	public Task<Boolean> Validate(string word, string code = "ja", bool isShowDialog = true) { }

	[AsyncStateMachine(typeof(<Validate>d__4))]
	public Task<Boolean> Validate(string word, Action onErrorToTitle, string code = "ja", bool isShowDialog = true) { }

	public static bool ValidateNickName(string nickname) { }

}

