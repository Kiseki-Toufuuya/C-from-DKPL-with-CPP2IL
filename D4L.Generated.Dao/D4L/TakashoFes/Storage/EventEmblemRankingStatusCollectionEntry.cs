namespace D4L.TakashoFes.Storage;

public sealed class EventEmblemRankingStatusCollectionEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<EventEmblemRankingStatus, Dictionary`2<String, Object>> <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__17_0(EventEmblemRankingStatus ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override EventEmblemRankingStatusCollectionEntry Parse(Byte[] source) { }

		public EventEmblemRankingStatusCollectionEntry Parse(EventEmblemRankingStatusCollectionProto source) { }

		public override Byte[] ToBytes(EventEmblemRankingStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private EventEmblemRankingStatus[] <EmblemRankings>k__BackingField; //Field offset: 0x10

	public EventEmblemRankingStatus[] EmblemRankings
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

	public EventEmblemRankingStatusCollectionEntry() { }

	[Preserve]
	public override EventEmblemRankingStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public EventEmblemRankingStatus[] get_EmblemRankings() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public void set_EmblemRankings(EventEmblemRankingStatus[] value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

