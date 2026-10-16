namespace D4L.TakashoFes.Storage;

public sealed class ExpeditionMissionRecordEntityCollecttionEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int64, Int64> <>9__17_1; //Field offset: 0x4
		public static Func<Int64, Int64> <>9__17_2; //Field offset: 0x8
		public static Func<ExpeditionMissionRecordEntity, Dictionary`2<String, Object>> <>9__17_0; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal Dictionary<String, Object> <ToDict>b__17_0(ExpeditionMissionRecordEntity ____) { }

		internal long <ToDict>b__17_1(long ______) { }

		internal long <ToDict>b__17_2(long ______) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override ExpeditionMissionRecordEntityCollecttionEntry Parse(Byte[] source) { }

		public ExpeditionMissionRecordEntityCollecttionEntry Parse(ExpeditionMissionRecordEntityCollecttionProto source) { }

		public override Byte[] ToBytes(ExpeditionMissionRecordEntityCollecttionEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private ExpeditionMissionRecordEntity[] <ExpeditionMissionRecords>k__BackingField; //Field offset: 0x10

	public ExpeditionMissionRecordEntity[] ExpeditionMissionRecords
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

	public ExpeditionMissionRecordEntityCollecttionEntry() { }

	[Preserve]
	public override ExpeditionMissionRecordEntityCollecttionEntry Clone() { }

	[CompilerGenerated]
	public ExpeditionMissionRecordEntity[] get_ExpeditionMissionRecords() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public void set_ExpeditionMissionRecords(ExpeditionMissionRecordEntity[] value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

