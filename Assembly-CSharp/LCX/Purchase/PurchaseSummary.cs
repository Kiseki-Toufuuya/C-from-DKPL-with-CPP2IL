namespace LCX.Purchase;

public class PurchaseSummary
{
	public double Amount; //Field offset: 0x8
	public int Count; //Field offset: 0x10
	public string CurrencyCode; //Field offset: 0x14
	public string Store; //Field offset: 0x18
	public string ProductId; //Field offset: 0x1C

	public PurchaseSummary() { }

}

