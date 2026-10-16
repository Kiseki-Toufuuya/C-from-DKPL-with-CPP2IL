namespace D4L.TakashoFes.Storage;

public sealed class EventTotalRewardStatusProto : IMessage<EventTotalRewardStatusProto>, IMessage, IEquatable<EventTotalRewardStatusProto>, IDeepCloneable<EventTotalRewardStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal EventTotalRewardStatusProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<EventTotalRewardStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int received_; //Field offset: 0x18

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
	public static MessageParser<EventTotalRewardStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int Received
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static EventTotalRewardStatusProto() { }

	[DebuggerNonUserCode]
	public EventTotalRewardStatusProto() { }

	[DebuggerNonUserCode]
	public EventTotalRewardStatusProto(EventTotalRewardStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override EventTotalRewardStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EventTotalRewardStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<EventTotalRewardStatusProto> get_Parser() { }

	public int get_Received() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EventTotalRewardStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	public void set_Received(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

