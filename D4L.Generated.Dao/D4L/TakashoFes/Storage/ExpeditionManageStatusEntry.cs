namespace D4L.TakashoFes.Storage;

public sealed class ExpeditionManageStatusEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int64> <>9__37_0; //Field offset: 0x4
		public static Func<ExpeditionMissionExec, Dictionary`2<String, Object>> <>9__37_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal long <ToDict>b__37_0(int ____) { }

		internal Dictionary<String, Object> <ToDict>b__37_1(ExpeditionMissionExec ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override ExpeditionManageStatusEntry Parse(Byte[] source) { }

		public ExpeditionManageStatusEntry Parse(ExpeditionManageStatusProto source) { }

		public override Byte[] ToBytes(ExpeditionManageStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Int32[] <MissionIDs>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <CreatedAt>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <LastUpdate>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private long <BossUpdate>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuardInt <BossMissionID>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private ExpeditionMissionExec[] <Execs>k__BackingField; //Field offset: 0x38

	public GuardInt BossMissionID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long BossUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public ExpeditionMissionExec[] Execs
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

	public long LastUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Int32[] MissionIDs
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public ExpeditionManageStatusEntry() { }

	[Preserve]
	public override ExpeditionManageStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardInt get_BossMissionID() { }

	[CompilerGenerated]
	public long get_BossUpdate() { }

	[CompilerGenerated]
	public long get_CreatedAt() { }

	[CompilerGenerated]
	public ExpeditionMissionExec[] get_Execs() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_LastUpdate() { }

	[CompilerGenerated]
	public Int32[] get_MissionIDs() { }

	[CompilerGenerated]
	public void set_BossMissionID(GuardInt value) { }

	[CompilerGenerated]
	public void set_BossUpdate(long value) { }

	[CompilerGenerated]
	public void set_CreatedAt(long value) { }

	[CompilerGenerated]
	public void set_Execs(ExpeditionMissionExec[] value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_LastUpdate(long value) { }

	[CompilerGenerated]
	public void set_MissionIDs(Int32[] value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

