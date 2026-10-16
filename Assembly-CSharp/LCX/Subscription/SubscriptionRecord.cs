namespace LCX.Subscription;

public class SubscriptionRecord
{
	public long EndDate; //Field offset: 0x8
	public string ProductId; //Field offset: 0x10
	public string Store; //Field offset: 0x14
	public bool IsFreeTrial; //Field offset: 0x18
	public bool IsRevoked; //Field offset: 0x19

	public SubscriptionRecord() { }

}

