namespace LCX.Purchase;

public class PurchaseResult
{
	public List<PurchaseFailedTransaction> PurchaseFailedTransactions; //Field offset: 0x8
	public List<PurchaseSucceedTransaction> PurchaseSucceedTransactions; //Field offset: 0xC

	public PurchaseResult() { }

}

