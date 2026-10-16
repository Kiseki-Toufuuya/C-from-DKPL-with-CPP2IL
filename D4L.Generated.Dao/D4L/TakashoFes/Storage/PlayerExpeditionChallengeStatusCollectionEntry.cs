namespace D4L.TakashoFes.Storage;

public sealed class PlayerExpeditionChallengeStatusCollectionEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ExpeditionChallengeStatus, Dictionary`2<String, Object>> <>9__17_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__17_0(ExpeditionChallengeStatus ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override PlayerExpeditionChallengeStatusCollectionEntry Parse(Byte[] source) { }

		public PlayerExpeditionChallengeStatusCollectionEntry Parse(PlayerExpeditionChallengeStatusCollectionProto source) { }

		public override Byte[] ToBytes(PlayerExpeditionChallengeStatusCollectionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private ExpeditionChallengeStatus[] <Statuses>k__BackingField; //Field offset: 0x10

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public ExpeditionChallengeStatus[] Statuses
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public PlayerExpeditionChallengeStatusCollectionEntry() { }

	[Preserve]
	public override PlayerExpeditionChallengeStatusCollectionEntry Clone() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public ExpeditionChallengeStatus[] get_Statuses() { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_Statuses(ExpeditionChallengeStatus[] value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

