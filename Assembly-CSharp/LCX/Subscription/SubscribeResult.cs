namespace LCX.Subscription;

public class SubscribeResult
{
	public List<SubscribeFailedTransaction> SubscribeFailedTransactions; //Field offset: 0x8
	public List<SubscribeSucceedTransaction> SubscribeSucceedTransactions; //Field offset: 0xC

	public SubscribeResult() { }

}

