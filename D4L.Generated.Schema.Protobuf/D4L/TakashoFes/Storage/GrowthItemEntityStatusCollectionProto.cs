namespace D4L.TakashoFes.Storage;

public sealed class GrowthItemEntityStatusCollectionProto : IMessage<GrowthItemEntityStatusCollectionProto>, IMessage, IEquatable<GrowthItemEntityStatusCollectionProto>, IDeepCloneable<GrowthItemEntityStatusCollectionProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal GrowthItemEntityStatusCollectionProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<GrowthItemEntityStatusCollectionProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<GrowthItemEntityStatusProto> _repeated_growthItemEntityStatuses_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<GrowthItemEntityStatusProto> growthItemEntityStatuses_; //Field offset: 0x18

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public RepeatedField<GrowthItemEntityStatusProto> GrowthItemEntityStatuses
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
	public static MessageParser<GrowthItemEntityStatusCollectionProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static GrowthItemEntityStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public GrowthItemEntityStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public GrowthItemEntityStatusCollectionProto(GrowthItemEntityStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override GrowthItemEntityStatusCollectionProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(GrowthItemEntityStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<GrowthItemEntityStatusProto> get_GrowthItemEntityStatuses() { }

	public long get_ID() { }

	public static MessageParser<GrowthItemEntityStatusCollectionProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(GrowthItemEntityStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

