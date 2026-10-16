namespace D4L.TakashoFes.Storage;

public sealed class MissionControlStatusProto : IMessage<MissionControlStatusProto>, IMessage, IEquatable<MissionControlStatusProto>, IDeepCloneable<MissionControlStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal MissionControlStatusProto <.cctor>b__60_0() { }

	}

	private static readonly MessageParser<MissionControlStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long dailyResetDate_; //Field offset: 0x18
	private long weeklyResetDate_; //Field offset: 0x20
	private long todayCounter_; //Field offset: 0x28
	private int todayPoint_; //Field offset: 0x30
	private int weeklyPoint_; //Field offset: 0x34
	private int dailyAchievementSlotNo_; //Field offset: 0x38
	private int weeklyAchievementSlotNo_; //Field offset: 0x3C

	[DebuggerNonUserCode]
	public int DailyAchievementSlotNo
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long DailyResetDate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<MissionControlStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public long TodayCounter
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int TodayPoint
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int WeeklyAchievementSlotNo
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int WeeklyPoint
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long WeeklyResetDate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static MissionControlStatusProto() { }

	[DebuggerNonUserCode]
	public MissionControlStatusProto() { }

	[DebuggerNonUserCode]
	public MissionControlStatusProto(MissionControlStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override MissionControlStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MissionControlStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_DailyAchievementSlotNo() { }

	public long get_DailyResetDate() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<MissionControlStatusProto> get_Parser() { }

	public long get_TodayCounter() { }

	public int get_TodayPoint() { }

	public int get_WeeklyAchievementSlotNo() { }

	public int get_WeeklyPoint() { }

	public long get_WeeklyResetDate() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MissionControlStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_DailyAchievementSlotNo(int value) { }

	public void set_DailyResetDate(long value) { }

	public void set_ID(long value) { }

	public void set_TodayCounter(long value) { }

	public void set_TodayPoint(int value) { }

	public void set_WeeklyAchievementSlotNo(int value) { }

	public void set_WeeklyPoint(int value) { }

	public void set_WeeklyResetDate(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

