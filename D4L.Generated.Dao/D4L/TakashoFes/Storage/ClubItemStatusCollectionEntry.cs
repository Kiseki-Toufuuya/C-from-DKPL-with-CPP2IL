namespace D4L.TakashoFes.Storage;

public sealed class ClubItemStatusCollectionEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override ClubItemStatusCollectionEntry Parse(Byte[] source) { }

		public ClubItemStatusCollectionEntry Parse(ClubItemStatusCollectionProto source) { }

		public override Byte[] ToBytes(ClubItemStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Dictionary<Int32, Int32> <HaveItems>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<Int32, Int64> <ReceiveDate>k__BackingField; //Field offset: 0x14

	public Dictionary<Int32, Int32> HaveItems
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Dictionary<Int32, Int64> ReceiveDate
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public ClubItemStatusCollectionEntry() { }

	[Preserve]
	public override ClubItemStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public Dictionary<Int32, Int32> get_HaveItems() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public Dictionary<Int32, Int64> get_ReceiveDate() { }

	[CompilerGenerated]
	public void set_HaveItems(Dictionary<Int32, Int32> value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_ReceiveDate(Dictionary<Int32, Int64> value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

