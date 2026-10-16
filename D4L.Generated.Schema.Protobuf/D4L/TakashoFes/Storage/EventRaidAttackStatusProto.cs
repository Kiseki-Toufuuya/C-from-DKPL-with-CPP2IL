namespace D4L.TakashoFes.Storage;

public sealed class EventRaidAttackStatusProto : IMessage<EventRaidAttackStatusProto>, IMessage, IEquatable<EventRaidAttackStatusProto>, IDeepCloneable<EventRaidAttackStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal EventRaidAttackStatusProto <.cctor>b__70_0() { }

	}

	private static readonly MessageParser<EventRaidAttackStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long dailyAttackBf_; //Field offset: 0x18
	private long dailyAttackAf_; //Field offset: 0x20
	private long eventAttackBf_; //Field offset: 0x28
	private long eventAttackAf_; //Field offset: 0x30
	private long totalAttackBf_; //Field offset: 0x38
	private long totalAttackAf_; //Field offset: 0x40
	private string raidBossInstanceID_; //Field offset: 0x48
	private long lastAttackAt_; //Field offset: 0x50
	private int eventID_; //Field offset: 0x58

	[DebuggerNonUserCode]
	public long DailyAttackAf
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long DailyAttackBf
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
	public long EventAttackAf
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long EventAttackBf
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int EventID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long LastAttackAt
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<EventRaidAttackStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string RaidBossInstanceID
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public long TotalAttackAf
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long TotalAttackBf
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static EventRaidAttackStatusProto() { }

	[DebuggerNonUserCode]
	public EventRaidAttackStatusProto() { }

	[DebuggerNonUserCode]
	public EventRaidAttackStatusProto(EventRaidAttackStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override EventRaidAttackStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EventRaidAttackStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_DailyAttackAf() { }

	public long get_DailyAttackBf() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_EventAttackAf() { }

	public long get_EventAttackBf() { }

	public int get_EventID() { }

	public long get_ID() { }

	public long get_LastAttackAt() { }

	public static MessageParser<EventRaidAttackStatusProto> get_Parser() { }

	public string get_RaidBossInstanceID() { }

	public long get_TotalAttackAf() { }

	public long get_TotalAttackBf() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EventRaidAttackStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_DailyAttackAf(long value) { }

	public void set_DailyAttackBf(long value) { }

	public void set_EventAttackAf(long value) { }

	public void set_EventAttackBf(long value) { }

	public void set_EventID(int value) { }

	public void set_ID(long value) { }

	public void set_LastAttackAt(long value) { }

	public void set_RaidBossInstanceID(string value) { }

	public void set_TotalAttackAf(long value) { }

	public void set_TotalAttackBf(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

