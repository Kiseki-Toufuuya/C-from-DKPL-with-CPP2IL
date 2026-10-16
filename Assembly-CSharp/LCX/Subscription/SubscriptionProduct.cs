namespace LCX.Subscription;

public class SubscriptionProduct
{
	[CompilerGenerated]
	private struct <GetProductList>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<SubscriptionProduct>> <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Subscribe>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class ExchangedInfo
	{
		public string InGameCurrencyName; //Field offset: 0x8
		public int PaidAmount; //Field offset: 0xC
		public int FreeAmount; //Field offset: 0x10

		public ExchangedInfo() { }

	}

	public string Description; //Field offset: 0x8
	public string DisplayPrice; //Field offset: 0xC
	public double Price; //Field offset: 0x10
	public string PriceCode; //Field offset: 0x18
	public string ProductId; //Field offset: 0x1C
	public string ProductPayload; //Field offset: 0x20
	public double TierPrice; //Field offset: 0x28
	public string Title; //Field offset: 0x30
	public ExchangedInfo Exchanged; //Field offset: 0x34

	public SubscriptionProduct() { }

	[AsyncStateMachine(typeof(<GetProductList>d__10))]
	public static Task<List`1<SubscriptionProduct>> GetProductList() { }

	[AsyncStateMachine(typeof(<Subscribe>d__11))]
	public Task Subscribe() { }

}

