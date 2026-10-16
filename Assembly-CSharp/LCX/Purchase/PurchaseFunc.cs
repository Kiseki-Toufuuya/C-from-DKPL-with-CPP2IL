namespace LCX.Purchase;

public class PurchaseFunc
{
	[CompilerGenerated]
	private struct <GetPurchaseSummary>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IList`1<PurchaseSummary>> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RetryIncompletePurchases>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<PurchaseResult> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public PurchaseFunc() { }

	public static List<PurchaseTransaction> GetIncompletePurchases() { }

	[AsyncStateMachine(typeof(<GetPurchaseSummary>d__2))]
	public static Task<IList`1<PurchaseSummary>> GetPurchaseSummary(DateTimeOffset from, DateTimeOffset to) { }

	[AsyncStateMachine(typeof(<RetryIncompletePurchases>d__0))]
	public static Task<PurchaseResult> RetryIncompletePurchases() { }

}

