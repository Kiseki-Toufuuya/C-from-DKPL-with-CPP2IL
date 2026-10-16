namespace D4L.TakashoFes.Storage;

public sealed class ExpeditionManageStatusProto : IMessage<ExpeditionManageStatusProto>, IMessage, IEquatable<ExpeditionManageStatusProto>, IDeepCloneable<ExpeditionManageStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ExpeditionManageStatusProto <.cctor>b__55_0() { }

	}

	private static readonly MessageParser<ExpeditionManageStatusProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int32> _repeated_missionIDs_codec; //Field offset: 0x4
	private static readonly FieldCodec<ExpeditionMissionExecProto> _repeated_execs_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<Int32> missionIDs_; //Field offset: 0x18
	private long createdAt_; //Field offset: 0x20
	private long lastUpdate_; //Field offset: 0x28
	private long bossUpdate_; //Field offset: 0x30
	private int bossMissionID_; //Field offset: 0x38
	private readonly RepeatedField<ExpeditionMissionExecProto> execs_; //Field offset: 0x3C

	[DebuggerNonUserCode]
	public int BossMissionID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long BossUpdate
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
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public RepeatedField<ExpeditionMissionExecProto> Execs
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
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> MissionIDs
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public static MessageParser<ExpeditionManageStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static ExpeditionManageStatusProto() { }

	[DebuggerNonUserCode]
	public ExpeditionManageStatusProto() { }

	[DebuggerNonUserCode]
	public ExpeditionManageStatusProto(ExpeditionManageStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ExpeditionManageStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ExpeditionManageStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_BossMissionID() { }

	public long get_BossUpdate() { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<ExpeditionMissionExecProto> get_Execs() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public RepeatedField<Int32> get_MissionIDs() { }

	public static MessageParser<ExpeditionManageStatusProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ExpeditionManageStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_BossMissionID(int value) { }

	public void set_BossUpdate(long value) { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

