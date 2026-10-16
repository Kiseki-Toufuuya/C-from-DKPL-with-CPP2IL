namespace LCX.Purchase;

public class UserBalance
{
	[CompilerGenerated]
	private struct <GetUserBalance>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<UserBalance>> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public string InGameCurrencyName; //Field offset: 0x8
	public int PaidAmount; //Field offset: 0xC

	public UserBalance() { }

	[AsyncStateMachine(typeof(<GetUserBalance>d__2))]
	public static Task<List`1<UserBalance>> GetUserBalance() { }

}

