namespace D4L.TakashoFes.Struct;

public sealed class EventRaidBossEntityProto : IMessage<EventRaidBossEntityProto>, IMessage, IEquatable<EventRaidBossEntityProto>, IDeepCloneable<EventRaidBossEntityProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal EventRaidBossEntityProto <.cctor>b__55_0() { }

	}

	private static readonly MessageParser<EventRaidBossEntityProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private string raidBossId_; //Field offset: 0xC
	private long bossId_; //Field offset: 0x10
	private long bossMaxHp_; //Field offset: 0x18
	private long dissappearTime_; //Field offset: 0x20
	private string discoverPlayerId_; //Field offset: 0x28
	private int bossLv_; //Field offset: 0x2C
	private int userRelation_; //Field offset: 0x30

	[DebuggerNonUserCode]
	public long BossId
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int BossLv
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long BossMaxHp
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
	public string DiscoverPlayerId
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public long DissappearTime
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<EventRaidBossEntityProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string RaidBossId
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public int UserRelation
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static EventRaidBossEntityProto() { }

	[DebuggerNonUserCode]
	public EventRaidBossEntityProto() { }

	[DebuggerNonUserCode]
	public EventRaidBossEntityProto(EventRaidBossEntityProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override EventRaidBossEntityProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EventRaidBossEntityProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_BossId() { }

	public int get_BossLv() { }

	public long get_BossMaxHp() { }

	public static MessageDescriptor get_Descriptor() { }

	public string get_DiscoverPlayerId() { }

	public long get_DissappearTime() { }

	public static MessageParser<EventRaidBossEntityProto> get_Parser() { }

	public string get_RaidBossId() { }

	public int get_UserRelation() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EventRaidBossEntityProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_BossId(long value) { }

	public void set_BossLv(int value) { }

	public void set_BossMaxHp(long value) { }

	public void set_DiscoverPlayerId(string value) { }

	public void set_DissappearTime(long value) { }

	public void set_RaidBossId(string value) { }

	public void set_UserRelation(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

