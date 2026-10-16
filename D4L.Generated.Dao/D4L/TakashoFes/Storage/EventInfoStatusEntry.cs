namespace D4L.TakashoFes.Storage;

public sealed class EventInfoStatusEntry
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int64> <>9__77_0; //Field offset: 0x4
		public static Func<Int64, Int64> <>9__77_1; //Field offset: 0x8
		public static Func<EventRaidBossEntity, Dictionary`2<String, Object>> <>9__77_2; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal long <ToDict>b__77_0(int ____) { }

		internal long <ToDict>b__77_1(long ____) { }

		internal Dictionary<String, Object> <ToDict>b__77_2(EventRaidBossEntity ____) { }

	}

	internal sealed class Parser
	{
		public static readonly Parser Default; //Field offset: 0x0

		private static Parser() { }

		public Parser() { }

		public override EventInfoStatusEntry Parse(Byte[] source) { }

		public EventInfoStatusEntry Parse(EventInfoStatusProto source) { }

		public override Byte[] ToBytes(EventInfoStatusEntry entry) { }

	}

	[CompilerGenerated]
	private long <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private GuardLong <EventPoint>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuardLong <ResourcePoint>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <Show>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GuardLong <MaxScore>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Int32[] <ExpedtionCount>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private GuardLong <LastUpdate>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private GuardInt <Progress>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private GuardInt <DailyProgress>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private GuardBool <IsReceiveRankingReward>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private GuardLong <ExpeditionRecoverTime>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private Int64[] <TotalRewardReceivedIDs>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private GuardString <SelectBossId>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private GuardInt <VitalityValue>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	private GuardLong <VitalityDate>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private GuardInt <RaidBossEncounterPoint>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private EventRaidBossEntity[] <RaidBossEntityList>k__BackingField; //Field offset: 0xB8

	public GuardInt DailyProgress
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong EventPoint
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong ExpeditionRecoverTime
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public Int32[] ExpedtionCount
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

	public GuardBool IsReceiveRankingReward
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardLong LastUpdate
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardLong MaxScore
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardInt Progress
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public GuardInt RaidBossEncounterPoint
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public EventRaidBossEntity[] RaidBossEntityList
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public GuardLong ResourcePoint
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public GuardString SelectBossId
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 43
	}

	public int Show
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Int64[] TotalRewardReceivedIDs
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public GuardLong VitalityDate
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public GuardInt VitalityValue
	{
		[CompilerGenerated]
		 get { } //Length: 20
		[CompilerGenerated]
		 set { } //Length: 26
	}

	public EventInfoStatusEntry() { }

	[Preserve]
	public override EventInfoStatusEntry Clone() { }

	[CompilerGenerated]
	public GuardInt get_DailyProgress() { }

	[CompilerGenerated]
	public GuardLong get_EventPoint() { }

	[CompilerGenerated]
	public GuardLong get_ExpeditionRecoverTime() { }

	[CompilerGenerated]
	public Int32[] get_ExpedtionCount() { }

	[CompilerGenerated]
	public override long get_ID() { }

	[CompilerGenerated]
	public GuardBool get_IsReceiveRankingReward() { }

	[CompilerGenerated]
	public GuardLong get_LastUpdate() { }

	[CompilerGenerated]
	public GuardLong get_MaxScore() { }

	[CompilerGenerated]
	public GuardInt get_Progress() { }

	[CompilerGenerated]
	public GuardInt get_RaidBossEncounterPoint() { }

	[CompilerGenerated]
	public EventRaidBossEntity[] get_RaidBossEntityList() { }

	[CompilerGenerated]
	public GuardLong get_ResourcePoint() { }

	[CompilerGenerated]
	public GuardString get_SelectBossId() { }

	[CompilerGenerated]
	public int get_Show() { }

	[CompilerGenerated]
	public Int64[] get_TotalRewardReceivedIDs() { }

	[CompilerGenerated]
	public GuardLong get_VitalityDate() { }

	[CompilerGenerated]
	public GuardInt get_VitalityValue() { }

	[CompilerGenerated]
	public void set_DailyProgress(GuardInt value) { }

	[CompilerGenerated]
	public void set_EventPoint(GuardLong value) { }

	[CompilerGenerated]
	public void set_ExpeditionRecoverTime(GuardLong value) { }

	[CompilerGenerated]
	public void set_ExpedtionCount(Int32[] value) { }

	[CompilerGenerated]
	public override void set_ID(long value) { }

	[CompilerGenerated]
	public void set_IsReceiveRankingReward(GuardBool value) { }

	[CompilerGenerated]
	public void set_LastUpdate(GuardLong value) { }

	[CompilerGenerated]
	public void set_MaxScore(GuardLong value) { }

	[CompilerGenerated]
	public void set_Progress(GuardInt value) { }

	[CompilerGenerated]
	public void set_RaidBossEncounterPoint(GuardInt value) { }

	[CompilerGenerated]
	public void set_RaidBossEntityList(EventRaidBossEntity[] value) { }

	[CompilerGenerated]
	public void set_ResourcePoint(GuardLong value) { }

	[CompilerGenerated]
	public void set_SelectBossId(GuardString value) { }

	[CompilerGenerated]
	public void set_Show(int value) { }

	[CompilerGenerated]
	public void set_TotalRewardReceivedIDs(Int64[] value) { }

	[CompilerGenerated]
	public void set_VitalityDate(GuardLong value) { }

	[CompilerGenerated]
	public void set_VitalityValue(GuardInt value) { }

	[Preserve]
	public IDictionary ToDict() { }

	[Preserve]
	public string ToJson() { }

}

