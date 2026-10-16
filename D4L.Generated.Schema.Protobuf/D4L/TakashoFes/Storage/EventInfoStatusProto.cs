namespace D4L.TakashoFes.Storage;

public sealed class EventInfoStatusProto : IMessage<EventInfoStatusProto>, IMessage, IEquatable<EventInfoStatusProto>, IDeepCloneable<EventInfoStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal EventInfoStatusProto <.cctor>b__105_0() { }

	}

	private static readonly MessageParser<EventInfoStatusProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int32> _repeated_expedtionCount_codec; //Field offset: 0x4
	private static readonly FieldCodec<Int64> _repeated_totalRewardReceivedIDs_codec; //Field offset: 0x8
	private static readonly FieldCodec<EventRaidBossEntityProto> _repeated_raidBossEntityList_codec; //Field offset: 0xC
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long eventPoint_; //Field offset: 0x18
	private long resourcePoint_; //Field offset: 0x20
	private int show_; //Field offset: 0x28
	private long maxScore_; //Field offset: 0x30
	private readonly RepeatedField<Int32> expedtionCount_; //Field offset: 0x38
	private long lastUpdate_; //Field offset: 0x40
	private int progress_; //Field offset: 0x48
	private int dailyProgress_; //Field offset: 0x4C
	private bool isReceiveRankingReward_; //Field offset: 0x50
	private long expeditionRecoverTime_; //Field offset: 0x58
	private readonly RepeatedField<Int64> totalRewardReceivedIDs_; //Field offset: 0x60
	private string selectBossId_; //Field offset: 0x64
	private int vitalityValue_; //Field offset: 0x68
	private long vitalityDate_; //Field offset: 0x70
	private int raidBossEncounterPoint_; //Field offset: 0x78
	private readonly RepeatedField<EventRaidBossEntityProto> raidBossEntityList_; //Field offset: 0x7C

	[DebuggerNonUserCode]
	public int DailyProgress
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public long EventPoint
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long ExpeditionRecoverTime
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> ExpedtionCount
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public bool IsReceiveRankingReward
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long MaxScore
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<EventInfoStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int Progress
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int RaidBossEncounterPoint
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public RepeatedField<EventRaidBossEntityProto> RaidBossEntityList
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public long ResourcePoint
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public string SelectBossId
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public int Show
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int64> TotalRewardReceivedIDs
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public long VitalityDate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int VitalityValue
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static EventInfoStatusProto() { }

	[DebuggerNonUserCode]
	public EventInfoStatusProto() { }

	[DebuggerNonUserCode]
	public EventInfoStatusProto(EventInfoStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override EventInfoStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EventInfoStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_DailyProgress() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_EventPoint() { }

	public long get_ExpeditionRecoverTime() { }

	public RepeatedField<Int32> get_ExpedtionCount() { }

	public long get_ID() { }

	public bool get_IsReceiveRankingReward() { }

	public long get_LastUpdate() { }

	public long get_MaxScore() { }

	public static MessageParser<EventInfoStatusProto> get_Parser() { }

	public int get_Progress() { }

	public int get_RaidBossEncounterPoint() { }

	public RepeatedField<EventRaidBossEntityProto> get_RaidBossEntityList() { }

	public long get_ResourcePoint() { }

	public string get_SelectBossId() { }

	public int get_Show() { }

	public RepeatedField<Int64> get_TotalRewardReceivedIDs() { }

	public long get_VitalityDate() { }

	public int get_VitalityValue() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EventInfoStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_DailyProgress(int value) { }

	public void set_EventPoint(long value) { }

	public void set_ExpeditionRecoverTime(long value) { }

	public void set_ID(long value) { }

	public void set_IsReceiveRankingReward(bool value) { }

	public void set_LastUpdate(long value) { }

	public void set_MaxScore(long value) { }

	public void set_Progress(int value) { }

	public void set_RaidBossEncounterPoint(int value) { }

	public void set_ResourcePoint(long value) { }

	public void set_SelectBossId(string value) { }

	public void set_Show(int value) { }

	public void set_VitalityDate(long value) { }

	public void set_VitalityValue(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

