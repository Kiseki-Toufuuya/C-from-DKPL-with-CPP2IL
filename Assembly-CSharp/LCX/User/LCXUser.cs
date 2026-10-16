namespace LCX.User;

public class LCXUser
{
	[CompilerGenerated]
	private struct <GetIdToken>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HasAnyLink>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkAccount>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public string LCXUserId; //Field offset: 0x8
	public string SignInSessionId; //Field offset: 0xC

	public LCXUser() { }

	[AsyncStateMachine(typeof(<GetIdToken>d__2))]
	public Task<String> GetIdToken() { }

	[AsyncStateMachine(typeof(<HasAnyLink>d__4))]
	public Task<Boolean> HasAnyLink() { }

	[AsyncStateMachine(typeof(<LinkAccount>d__3))]
	public Task LinkAccount(SignInStoreType signInStoreType) { }

}

