namespace D4L.TakashoFes.Struct;

public sealed class ExpeditionMissionExecProto : IMessage<ExpeditionMissionExecProto>, IMessage, IEquatable<ExpeditionMissionExecProto>, IDeepCloneable<ExpeditionMissionExecProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ExpeditionMissionExecProto <.cctor>b__75_0() { }

	}

	private static readonly MessageParser<ExpeditionMissionExecProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private string sessionID_; //Field offset: 0x18
	private int missionID_; //Field offset: 0x1C
	private long formationID_; //Field offset: 0x20
	private long completeTime_; //Field offset: 0x28
	private int ustBoostID_; //Field offset: 0x30
	private bool useDialyBonus_; //Field offset: 0x34
	private long createdAt_; //Field offset: 0x38
	private long lastUpdate_; //Field offset: 0x40
	private uint dailyBonusNo_; //Field offset: 0x48
	private string targetBossID_; //Field offset: 0x4C

	[DebuggerNonUserCode]
	public long CompleteTime
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long CreatedAt
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public uint DailyBonusNo
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
	public long FormationID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int MissionID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<ExpeditionMissionExecProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string SessionID
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public string TargetBossID
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public bool UseDialyBonus
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int UstBoostID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static ExpeditionMissionExecProto() { }

	[DebuggerNonUserCode]
	public ExpeditionMissionExecProto() { }

	[DebuggerNonUserCode]
	public ExpeditionMissionExecProto(ExpeditionMissionExecProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ExpeditionMissionExecProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ExpeditionMissionExecProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CompleteTime() { }

	public long get_CreatedAt() { }

	public uint get_DailyBonusNo() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_FormationID() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public int get_MissionID() { }

	public static MessageParser<ExpeditionMissionExecProto> get_Parser() { }

	public string get_SessionID() { }

	public string get_TargetBossID() { }

	public bool get_UseDialyBonus() { }

	public int get_UstBoostID() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ExpeditionMissionExecProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CompleteTime(long value) { }

	public void set_CreatedAt(long value) { }

	public void set_DailyBonusNo(uint value) { }

	public void set_FormationID(long value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_MissionID(int value) { }

	public void set_SessionID(string value) { }

	public void set_TargetBossID(string value) { }

	public void set_UseDialyBonus(bool value) { }

	public void set_UstBoostID(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

