namespace D4L.TakashoFes.Storage;

public sealed class DanmakuPassSeasonStatusProto : IMessage<DanmakuPassSeasonStatusProto>, IMessage, IEquatable<DanmakuPassSeasonStatusProto>, IDeepCloneable<DanmakuPassSeasonStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal DanmakuPassSeasonStatusProto <.cctor>b__45_0() { }

	}

	private static readonly MessageParser<DanmakuPassSeasonStatusProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int64> _repeated_received_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<Int64> received_; //Field offset: 0x18
	private long createdAt_; //Field offset: 0x20
	private long lastUpdate_; //Field offset: 0x28
	private long tierExp_; //Field offset: 0x30

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
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<DanmakuPassSeasonStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int64> Received
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public long TierExp
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static DanmakuPassSeasonStatusProto() { }

	[DebuggerNonUserCode]
	public DanmakuPassSeasonStatusProto() { }

	[DebuggerNonUserCode]
	public DanmakuPassSeasonStatusProto(DanmakuPassSeasonStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override DanmakuPassSeasonStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(DanmakuPassSeasonStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public static MessageParser<DanmakuPassSeasonStatusProto> get_Parser() { }

	public RepeatedField<Int64> get_Received() { }

	public long get_TierExp() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(DanmakuPassSeasonStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_TierExp(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

