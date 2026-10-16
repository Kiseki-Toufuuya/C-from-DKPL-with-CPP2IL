namespace D4L.TakashoFes.Storage;

public sealed class UnlockEntityStatusCollectionEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<UnlockEntityStatus, Dictionary`2<String, Object>> <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__17_0(UnlockEntityStatus ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override UnlockEntityStatusCollectionEntry Parse(Byte[] source) { }

		public UnlockEntityStatusCollectionEntry Parse(UnlockEntityStatusCollectionProto source) { }

		public override Byte[] ToBytes(UnlockEntityStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private UnlockEntityStatus[] <UnlockEntityStatuses>k__BackingField; //Field offset: 0x10

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public UnlockEntityStatus[] UnlockEntityStatuses
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public UnlockEntityStatusCollectionEntry() { }

	[Preserve]
	public override UnlockEntityStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public UnlockEntityStatus[] get_UnlockEntityStatuses() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_UnlockEntityStatuses(UnlockEntityStatus[] value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

