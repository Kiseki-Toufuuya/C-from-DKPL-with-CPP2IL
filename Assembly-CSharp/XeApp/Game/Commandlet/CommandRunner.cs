namespace XeApp.Game.Commandlet;

public static class CommandRunner
{
	[CompilerGenerated]
	private struct <Batch>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x4
		public string batstr; //Field offset: 0x10
		private String[] <sep>5__2; //Field offset: 0x14
		private int <i>5__3; //Field offset: 0x18
		private TaskAwaiter<Int32> <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Run>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x4
		public string commandAndArgs; //Field offset: 0x10
		private TaskAwaiter<Int32> <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static Dictionary<String, ICommand> CommandMap; //Field offset: 0x0
	private static bool init; //Field offset: 0x4

	private static CommandRunner() { }

	[AsyncStateMachine(typeof(<Batch>d__5))]
	public static Task<Int32> Batch(string batstr) { }

	public static void Init() { }

	public static void Register(ICommand command) { }

	[AsyncStateMachine(typeof(<Run>d__4))]
	public static Task<Int32> Run(string commandAndArgs) { }

}

