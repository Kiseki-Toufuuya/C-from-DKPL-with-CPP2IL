namespace D4L.TakashoFes.Storage;

public sealed class PlayCounterStatusCollectionProto : IMessage<PlayCounterStatusCollectionProto>, IMessage, IEquatable<PlayCounterStatusCollectionProto>, IDeepCloneable<PlayCounterStatusCollectionProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PlayCounterStatusCollectionProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<PlayCounterStatusCollectionProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<PlayCounterStatusProto> _repeated_statuses_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<PlayCounterStatusProto> statuses_; //Field offset: 0x18

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
	public static MessageParser<PlayCounterStatusCollectionProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public RepeatedField<PlayCounterStatusProto> Statuses
	{
		 get { } //Length: 11
	}

	private static PlayCounterStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public PlayCounterStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public PlayCounterStatusCollectionProto(PlayCounterStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override PlayCounterStatusCollectionProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(PlayCounterStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<PlayCounterStatusCollectionProto> get_Parser() { }

	public RepeatedField<PlayCounterStatusProto> get_Statuses() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(PlayCounterStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

