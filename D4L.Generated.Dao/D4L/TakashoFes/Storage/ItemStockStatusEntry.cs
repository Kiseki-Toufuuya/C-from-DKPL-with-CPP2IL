namespace D4L.TakashoFes.Storage;

public sealed class ItemStockStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override ItemStockStatusEntry Parse(Byte[] source) { }

		public ItemStockStatusEntry Parse(ItemStockStatusProto source) { }

		public override Byte[] ToBytes(ItemStockStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardInt <Count>k__BackingField; //Field offset: 0x10

	public GuardInt Count
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public ItemStockStatusEntry() { }

	[Preserve]
	public override ItemStockStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardInt get_Count() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public void set_Count(GuardInt value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

