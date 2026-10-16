namespace D4L.TakashoFes.Storage;

public sealed class ShopPurchaseStatusCollectionEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ShopPurchaseStatus, Dictionary`2<String, Object>> <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__17_0(ShopPurchaseStatus ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override ShopPurchaseStatusCollectionEntry Parse(Byte[] source) { }

		public ShopPurchaseStatusCollectionEntry Parse(ShopPurchaseStatusCollectionProto source) { }

		public override Byte[] ToBytes(ShopPurchaseStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private ShopPurchaseStatus[] <PurchaseStatuses>k__BackingField; //Field offset: 0x10

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public ShopPurchaseStatus[] PurchaseStatuses
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public ShopPurchaseStatusCollectionEntry() { }

	[Preserve]
	public override ShopPurchaseStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public ShopPurchaseStatus[] get_PurchaseStatuses() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_PurchaseStatuses(ShopPurchaseStatus[] value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

