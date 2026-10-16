namespace D4L.TakashoFes.Storage;

public sealed class PartyExecStatusProto : IMessage<PartyExecStatusProto>, IMessage, IEquatable<PartyExecStatusProto>, IDeepCloneable<PartyExecStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PartyExecStatusProto <.cctor>b__55_0() { }

	}

	private static readonly MessageParser<PartyExecStatusProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int32> _repeated_partyMemberID_codec; //Field offset: 0x4
	private static readonly FieldCodec<Int32> _repeated_partyRewardID_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<Int32> partyMemberID_; //Field offset: 0x18
	private readonly RepeatedField<Int32> partyRewardID_; //Field offset: 0x1C
	private long startTime_; //Field offset: 0x20
	private long endTime_; //Field offset: 0x28
	private long createdAt_; //Field offset: 0x30
	private long lastUpdate_; //Field offset: 0x38

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
	public long EndTime
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
	public static MessageParser<PartyExecStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> PartyMemberID
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> PartyRewardID
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public long StartTime
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static PartyExecStatusProto() { }

	[DebuggerNonUserCode]
	public PartyExecStatusProto() { }

	[DebuggerNonUserCode]
	public PartyExecStatusProto(PartyExecStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override PartyExecStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(PartyExecStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_EndTime() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public static MessageParser<PartyExecStatusProto> get_Parser() { }

	public RepeatedField<Int32> get_PartyMemberID() { }

	public RepeatedField<Int32> get_PartyRewardID() { }

	public long get_StartTime() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(PartyExecStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_EndTime(long value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_StartTime(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

