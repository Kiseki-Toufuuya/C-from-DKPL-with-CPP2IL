namespace D4L.TakashoFes.Struct;

public sealed class PlayCounterStatusProto : IMessage<PlayCounterStatusProto>, IMessage, IEquatable<PlayCounterStatusProto>, IDeepCloneable<PlayCounterStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PlayCounterStatusProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<PlayCounterStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private int iD_; //Field offset: 0xC
	private int count_; //Field offset: 0x10

	[DebuggerNonUserCode]
	public int Count
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
	public int ID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<PlayCounterStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static PlayCounterStatusProto() { }

	[DebuggerNonUserCode]
	public PlayCounterStatusProto() { }

	[DebuggerNonUserCode]
	public PlayCounterStatusProto(PlayCounterStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override PlayCounterStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(PlayCounterStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_Count() { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_ID() { }

	public static MessageParser<PlayCounterStatusProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(PlayCounterStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Count(int value) { }

	public void set_ID(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

