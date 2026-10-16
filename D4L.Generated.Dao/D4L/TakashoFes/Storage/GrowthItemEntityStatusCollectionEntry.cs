namespace D4L.TakashoFes.Storage;

public sealed class GrowthItemEntityStatusCollectionEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GrowthItemEntityStatus, Dictionary`2<String, Object>> <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__17_0(GrowthItemEntityStatus ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override GrowthItemEntityStatusCollectionEntry Parse(Byte[] source) { }

		public GrowthItemEntityStatusCollectionEntry Parse(GrowthItemEntityStatusCollectionProto source) { }

		public override Byte[] ToBytes(GrowthItemEntityStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GrowthItemEntityStatus[] <GrowthItemEntityStatuses>k__BackingField; //Field offset: 0x10

	public GrowthItemEntityStatus[] GrowthItemEntityStatuses
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

	public GrowthItemEntityStatusCollectionEntry() { }

	[Preserve]
	public override GrowthItemEntityStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public GrowthItemEntityStatus[] get_GrowthItemEntityStatuses() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public void set_GrowthItemEntityStatuses(GrowthItemEntityStatus[] value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

