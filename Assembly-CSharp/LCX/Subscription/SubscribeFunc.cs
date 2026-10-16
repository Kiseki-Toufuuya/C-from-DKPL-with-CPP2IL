namespace LCX.Subscription;

public class SubscribeFunc
{
	[CompilerGenerated]
	private struct <GetSubscriptionRecords>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IList`1<SubscriptionRecord>> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RecoverSubscriptions>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IList`1<SubscriptionStoreProduct>> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RetryIncompleteSubscriptions>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SubscribeResult> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public SubscribeFunc() { }

	public static List<SubscribeTransaction> GetIncompleteSubscriptions() { }

	[AsyncStateMachine(typeof(<GetSubscriptionRecords>d__1))]
	public static Task<IList`1<SubscriptionRecord>> GetSubscriptionRecords() { }

	[AsyncStateMachine(typeof(<RecoverSubscriptions>d__2))]
	public static Task<IList`1<SubscriptionStoreProduct>> RecoverSubscriptions() { }

	[AsyncStateMachine(typeof(<RetryIncompleteSubscriptions>d__0))]
	public static Task<SubscribeResult> RetryIncompleteSubscriptions() { }

}

