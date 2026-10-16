namespace D4L.TakashoFes.Storage;

public sealed class EpisodeEntityStatusCollectionEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<EpisodeEntityStatus, Dictionary`2<String, Object>> <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__17_0(EpisodeEntityStatus ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override EpisodeEntityStatusCollectionEntry Parse(Byte[] source) { }

		public EpisodeEntityStatusCollectionEntry Parse(EpisodeEntityStatusCollectionProto source) { }

		public override Byte[] ToBytes(EpisodeEntityStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private EpisodeEntityStatus[] <Episodes>k__BackingField; //Field offset: 0x10

	public EpisodeEntityStatus[] Episodes
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

	public EpisodeEntityStatusCollectionEntry() { }

	[Preserve]
	public override EpisodeEntityStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public EpisodeEntityStatus[] get_Episodes() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public void set_Episodes(EpisodeEntityStatus[] value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

