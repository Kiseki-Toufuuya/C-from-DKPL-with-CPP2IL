namespace System.Xml;

[Extension]
internal static class AsyncHelper
{
	[CompilerGenerated]
	private struct <_CallVoidFuncWhenFinish>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public Task task; //Field offset: 0x10
		public Action func; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static readonly Task DoneTask; //Field offset: 0x0
	public static readonly Task<Boolean> DoneTaskTrue; //Field offset: 0x4
	public static readonly Task<Boolean> DoneTaskFalse; //Field offset: 0x8
	public static readonly Task<Int32> DoneTaskZero; //Field offset: 0xC

	[AsyncStateMachine(typeof(<_CallVoidFuncWhenFinish>d__6))]
	[Extension]
	private static Task _CallVoidFuncWhenFinish(Task task, Action func) { }

	private static AsyncHelper() { }

	[Extension]
	public static Task CallVoidFuncWhenFinish(Task task, Action func) { }

	[Extension]
	public static bool IsSuccess(Task task) { }

}

