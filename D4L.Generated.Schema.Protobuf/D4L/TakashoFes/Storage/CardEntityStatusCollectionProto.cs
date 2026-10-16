namespace D4L.TakashoFes.Storage;

public sealed class CardEntityStatusCollectionProto : IMessage<CardEntityStatusCollectionProto>, IMessage, IEquatable<CardEntityStatusCollectionProto>, IDeepCloneable<CardEntityStatusCollectionProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal CardEntityStatusCollectionProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<CardEntityStatusCollectionProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<CardEntityStatusProto> _repeated_cards_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<CardEntityStatusProto> cards_; //Field offset: 0x18

	[DebuggerNonUserCode]
	public RepeatedField<CardEntityStatusProto> Cards
	{
		 get { } //Length: 11
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
	public static MessageParser<CardEntityStatusCollectionProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static CardEntityStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public CardEntityStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public CardEntityStatusCollectionProto(CardEntityStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override CardEntityStatusCollectionProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(CardEntityStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public RepeatedField<CardEntityStatusProto> get_Cards() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<CardEntityStatusCollectionProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CardEntityStatusCollectionProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

