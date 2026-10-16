namespace LCX;

public class Platform
{
	[CompilerGenerated]
	private struct <AskPermissionToUseNotification>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshReceipt>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public Platform() { }

	[AsyncStateMachine(typeof(<AskPermissionToUseNotification>d__0))]
	public static Task AskPermissionToUseNotification() { }

	public static void FinishAskToBuySimulatorTransaction() { }

	[AsyncStateMachine(typeof(<RefreshReceipt>d__2))]
	public static Task RefreshReceipt() { }

}

