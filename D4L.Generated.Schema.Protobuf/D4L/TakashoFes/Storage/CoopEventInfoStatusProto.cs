namespace D4L.TakashoFes.Storage;

public sealed class CoopEventInfoStatusProto : IMessage<CoopEventInfoStatusProto>, IMessage, IEquatable<CoopEventInfoStatusProto>, IDeepCloneable<CoopEventInfoStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal CoopEventInfoStatusProto <.cctor>b__50_0() { }

	}

	private static readonly MessageParser<CoopEventInfoStatusProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int32> _repeated_phaseUnlockedProgress_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<Int32> phaseUnlockedProgress_; //Field offset: 0x18
	private int show_; //Field offset: 0x1C
	private long lastUpdate_; //Field offset: 0x20
	private long tweetLastReadTime_; //Field offset: 0x28
	private long totalTicketCount_; //Field offset: 0x30

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
	public static MessageParser<CoopEventInfoStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> PhaseUnlockedProgress
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public int Show
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long TotalTicketCount
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long TweetLastReadTime
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static CoopEventInfoStatusProto() { }

	[DebuggerNonUserCode]
	public CoopEventInfoStatusProto() { }

	[DebuggerNonUserCode]
	public CoopEventInfoStatusProto(CoopEventInfoStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override CoopEventInfoStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(CoopEventInfoStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public static MessageParser<CoopEventInfoStatusProto> get_Parser() { }

	public RepeatedField<Int32> get_PhaseUnlockedProgress() { }

	public int get_Show() { }

	public long get_TotalTicketCount() { }

	public long get_TweetLastReadTime() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CoopEventInfoStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_Show(int value) { }

	public void set_TotalTicketCount(long value) { }

	public void set_TweetLastReadTime(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

