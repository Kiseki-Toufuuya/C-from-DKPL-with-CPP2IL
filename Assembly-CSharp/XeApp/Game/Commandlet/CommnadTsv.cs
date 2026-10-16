namespace XeApp.Game.Commandlet;

public class CommnadTsv
{
	[CompilerGenerated]
	private struct <GetServerCommandFile>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x4
		public string fileName; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetServerCommandList>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public CommnadTsv <>4__this; //Field offset: 0x10
		private TaskAwaiter<String> <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadInitilaize>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public CommnadTsv <>4__this; //Field offset: 0x10
		private TaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Run>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public CommnadTsv <>4__this; //Field offset: 0x10
		public int index; //Field offset: 0x14
		private TaskAwaiter<String> <>u__1; //Field offset: 0x18
		private TaskAwaiter<Int32> <>u__2; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public List<String> CommandFiles; //Field offset: 0x8

	public CommnadTsv() { }

	public string GetHostIOCommandFile(string fileName) { }

	public void GetHostIOCommandList() { }

	[AsyncStateMachine(typeof(<GetServerCommandFile>d__3))]
	public Task<String> GetServerCommandFile(string fileName) { }

	[AsyncStateMachine(typeof(<GetServerCommandList>d__5))]
	public Task GetServerCommandList() { }

	[AsyncStateMachine(typeof(<LoadInitilaize>d__1))]
	public Task LoadInitilaize() { }

	[AsyncStateMachine(typeof(<Run>d__2))]
	public Task Run(int index) { }

}

