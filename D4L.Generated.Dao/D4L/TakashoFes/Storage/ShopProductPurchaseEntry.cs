namespace D4L.TakashoFes.Storage;

public sealed class ShopProductPurchaseEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override ShopProductPurchaseEntry Parse(Byte[] source) { }

		public ShopProductPurchaseEntry Parse(ShopProductPurchaseProto source) { }

		public override Byte[] ToBytes(ShopProductPurchaseEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardLong <PurchaseCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardLong <LastPurchaseDate>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <IsNew>k__BackingField; //Field offset: 0x30

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public int IsNew
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public GuardLong LastPurchaseDate
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong PurchaseCount
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public ShopProductPurchaseEntry() { }

	[Preserve]
	public override ShopProductPurchaseEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public int get_IsNew() { }

	[CompilerGenerated]
	public GuardLong get_LastPurchaseDate() { }

	[CompilerGenerated]
	public GuardLong get_PurchaseCount() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_IsNew(int value) { }

	[CompilerGenerated]
	public void set_LastPurchaseDate(GuardLong value) { }

	[CompilerGenerated]
	public void set_PurchaseCount(GuardLong value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

