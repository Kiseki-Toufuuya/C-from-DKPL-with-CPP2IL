namespace LCX;

public class LCXSDK
{
	[CompilerGenerated]
	private struct <DeleteLCXUser>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EstablishSession>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LCXUser> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExecuteAccountTransfer>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LCXUser> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAccountTransferCredentialSuggestion>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AccountTransferCredentialSuggestion> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetStoreType>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IList`1<SignInStoreType>> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RegisterAccountTransfer>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AccountTransferCredential> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SignIn>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LCXUser> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal interface LCXEventHandler
	{

		public void OnReceiveMessage(string data) { }

		public void OnSignOutEvent(LCXError error) { }

	}

	private static LCXSDK instance; //Field offset: 0x0
	public bool IsChild; //Field offset: 0x8

	public LCXSDK() { }

	[AsyncStateMachine(typeof(<DeleteLCXUser>d__3))]
	public Task DeleteLCXUser() { }

	[AsyncStateMachine(typeof(<EstablishSession>d__4))]
	public Task<LCXUser> EstablishSession() { }

	[AsyncStateMachine(typeof(<ExecuteAccountTransfer>d__5))]
	public Task<LCXUser> ExecuteAccountTransfer(string id, string user) { }

	[AsyncStateMachine(typeof(<GetAccountTransferCredentialSuggestion>d__10))]
	public Task<AccountTransferCredentialSuggestion> GetAccountTransferCredentialSuggestion() { }

	public static LCXSDK GetInstance() { }

	[AsyncStateMachine(typeof(<GetStoreType>d__9))]
	public Task<IList`1<SignInStoreType>> GetStoreType() { }

	[AsyncStateMachine(typeof(<Init>d__6))]
	public Task Init(LCXEventHandler eventHandler) { }

	[AsyncStateMachine(typeof(<RegisterAccountTransfer>d__11))]
	public Task<AccountTransferCredential> RegisterAccountTransfer(string id, string pass) { }

	[AsyncStateMachine(typeof(<SignIn>d__8))]
	public Task<LCXUser> SignIn(SignInStoreType signInStoreType) { }

	public void SignOut() { }

}

