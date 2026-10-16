namespace D4L.TakashoFes.Storage;

public sealed class MissionCounterStatusCollectionProto : IMessage<MissionCounterStatusCollectionProto>, IMessage, IEquatable<MissionCounterStatusCollectionProto>, IDeepCloneable<MissionCounterStatusCollectionProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal MissionCounterStatusCollectionProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<MissionCounterStatusCollectionProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<MissionCounterStatusProto> _repeated_statuses_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<MissionCounterStatusProto> statuses_; //Field offset: 0x18

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
	public static MessageParser<MissionCounterStatusCollectionProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public RepeatedField<MissionCounterStatusProto> Statuses
	{
		 get { } //Length: 11
	}

	private static MissionCounterStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public MissionCounterStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public MissionCounterStatusCollectionProto(MissionCounterStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override MissionCounterStatusCollectionProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MissionCounterStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<MissionCounterStatusCollectionProto> get_Parser() { }

	public RepeatedField<MissionCounterStatusProto> get_Statuses() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MissionCounterStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

