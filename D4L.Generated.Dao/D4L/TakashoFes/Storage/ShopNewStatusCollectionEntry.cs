namespace D4L.TakashoFes.Storage;

public sealed class ShopNewStatusCollectionEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override ShopNewStatusCollectionEntry Parse(Byte[] source) { }

		public ShopNewStatusCollectionEntry Parse(ShopNewStatusCollectionProto source) { }

		public override Byte[] ToBytes(ShopNewStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Dictionary<Int64, Int64> <NewOff>k__BackingField; //Field offset: 0x10

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Dictionary<Int64, Int64> NewOff
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public ShopNewStatusCollectionEntry() { }

	[Preserve]
	public override ShopNewStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public Dictionary<Int64, Int64> get_NewOff() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_NewOff(Dictionary<Int64, Int64> value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

