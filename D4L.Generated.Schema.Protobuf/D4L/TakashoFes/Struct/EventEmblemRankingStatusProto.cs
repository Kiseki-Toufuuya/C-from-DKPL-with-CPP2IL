namespace D4L.TakashoFes.Struct;

public sealed class EventEmblemRankingStatusProto : IMessage<EventEmblemRankingStatusProto>, IMessage, IEquatable<EventEmblemRankingStatusProto>, IDeepCloneable<EventEmblemRankingStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal EventEmblemRankingStatusProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<EventEmblemRankingStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long rankingPosition_; //Field offset: 0x18

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
	public static MessageParser<EventEmblemRankingStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public long RankingPosition
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static EventEmblemRankingStatusProto() { }

	[DebuggerNonUserCode]
	public EventEmblemRankingStatusProto() { }

	[DebuggerNonUserCode]
	public EventEmblemRankingStatusProto(EventEmblemRankingStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override EventEmblemRankingStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EventEmblemRankingStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<EventEmblemRankingStatusProto> get_Parser() { }

	public long get_RankingPosition() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EventEmblemRankingStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	public void set_RankingPosition(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

