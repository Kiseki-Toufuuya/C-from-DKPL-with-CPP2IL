namespace D4L.TakashoFes.Storage;

public sealed class CardEntityStatusCollectionEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CardEntityStatus, Dictionary`2<String, Object>> <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__17_0(CardEntityStatus ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override CardEntityStatusCollectionEntry Parse(Byte[] source) { }

		public CardEntityStatusCollectionEntry Parse(CardEntityStatusCollectionProto source) { }

		public override Byte[] ToBytes(CardEntityStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private CardEntityStatus[] <Cards>k__BackingField; //Field offset: 0x10

	public CardEntityStatus[] Cards
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

	public CardEntityStatusCollectionEntry() { }

	[Preserve]
	public override CardEntityStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public CardEntityStatus[] get_Cards() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public void set_Cards(CardEntityStatus[] value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

