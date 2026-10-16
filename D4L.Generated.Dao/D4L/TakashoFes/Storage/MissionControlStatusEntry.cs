namespace D4L.TakashoFes.Storage;

public sealed class MissionControlStatusEntry
{
	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override MissionControlStatusEntry Parse(Byte[] source) { }

		public MissionControlStatusEntry Parse(MissionControlStatusProto source) { }

		public override Byte[] ToBytes(MissionControlStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private long <DailyResetDate>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <WeeklyResetDate>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private long <TodayCounter>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GuardInt <TodayPoint>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuardInt <WeeklyPoint>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GuardInt <DailyAchievementSlotNo>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private GuardInt <WeeklyAchievementSlotNo>k__BackingField; //Field offset: 0x40

	public GuardInt DailyAchievementSlotNo
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long DailyResetDate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public override long ID
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long TodayCounter
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt TodayPoint
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt WeeklyAchievementSlotNo
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt WeeklyPoint
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public long WeeklyResetDate
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public MissionControlStatusEntry() { }

	[Preserve]
	public override MissionControlStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardInt get_DailyAchievementSlotNo() { }

	[CompilerGenerated]
	public long get_DailyResetDate() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public long get_TodayCounter() { }

	[CompilerGenerated]
	public GuardInt get_TodayPoint() { }

	[CompilerGenerated]
	public GuardInt get_WeeklyAchievementSlotNo() { }

	[CompilerGenerated]
	public GuardInt get_WeeklyPoint() { }

	[CompilerGenerated]
	public long get_WeeklyResetDate() { }

	[CompilerGenerated]
	public void set_DailyAchievementSlotNo(GuardInt value) { }

	[CompilerGenerated]
	public void set_DailyResetDate(long value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_TodayCounter(long value) { }

	[CompilerGenerated]
	public void set_TodayPoint(GuardInt value) { }

	[CompilerGenerated]
	public void set_WeeklyAchievementSlotNo(GuardInt value) { }

	[CompilerGenerated]
	public void set_WeeklyPoint(GuardInt value) { }

	[CompilerGenerated]
	public void set_WeeklyResetDate(long value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

