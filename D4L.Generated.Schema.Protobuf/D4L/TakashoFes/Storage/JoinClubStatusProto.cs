namespace D4L.TakashoFes.Storage;

public sealed class JoinClubStatusProto : IMessage<JoinClubStatusProto>, IMessage, IEquatable<JoinClubStatusProto>, IDeepCloneable<JoinClubStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal JoinClubStatusProto <.cctor>b__75_0() { }

	}

	private static readonly MessageParser<JoinClubStatusProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int32> _repeated_useStampHistory_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long createdAt_; //Field offset: 0x18
	private long lastUpdate_; //Field offset: 0x20
	private int status_; //Field offset: 0x28
	private string clubID_; //Field offset: 0x2C
	private string readedMessageID_; //Field offset: 0x30
	private readonly RepeatedField<Int32> useStampHistory_; //Field offset: 0x34
	private long withdrawedAt_; //Field offset: 0x38
	private int lastPositionID_; //Field offset: 0x40
	private string leaderShortID_; //Field offset: 0x44
	private string clubName_; //Field offset: 0x48

	[DebuggerNonUserCode]
	public string ClubID
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public string ClubName
	{
		 get { } //Length: 11
		 set { } //Length: 83
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
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public int LastPositionID
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
	public string LeaderShortID
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public static MessageParser<JoinClubStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string ReadedMessageID
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public int Status
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> UseStampHistory
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public long WithdrawedAt
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static JoinClubStatusProto() { }

	[DebuggerNonUserCode]
	public JoinClubStatusProto() { }

	[DebuggerNonUserCode]
	public JoinClubStatusProto(JoinClubStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override JoinClubStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(JoinClubStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public string get_ClubID() { }

	public string get_ClubName() { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public int get_LastPositionID() { }

	public long get_LastUpdate() { }

	public string get_LeaderShortID() { }

	public static MessageParser<JoinClubStatusProto> get_Parser() { }

	public string get_ReadedMessageID() { }

	public int get_Status() { }

	public RepeatedField<Int32> get_UseStampHistory() { }

	public long get_WithdrawedAt() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(JoinClubStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ClubID(string value) { }

	public void set_ClubName(string value) { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_LastPositionID(int value) { }

	public void set_LastUpdate(long value) { }

	public void set_LeaderShortID(string value) { }

	public void set_ReadedMessageID(string value) { }

	public void set_Status(int value) { }

	public void set_WithdrawedAt(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

