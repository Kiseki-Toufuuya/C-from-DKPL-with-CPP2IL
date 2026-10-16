namespace D4L.TakashoFes.Struct;

public class ShopPurchaseStatus
{
	public long ID; //Field offset: 0x8
	public GuardLong PurchaseCount; //Field offset: 0x10
	public GuardLong LastPurchaseDate; //Field offset: 0x20

	public ShopPurchaseStatus() { }

	public static ShopPurchaseStatus Parse(ShopPurchaseStatusProto source) { }

	public ShopPurchaseStatusProto ToProtobuf() { }

}

