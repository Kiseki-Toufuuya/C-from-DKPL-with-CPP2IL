namespace D4L.TakashoFes.Storage;

public sealed class ShopPurchaseStatusCollectionProto : IMessage<ShopPurchaseStatusCollectionProto>, IMessage, IEquatable<ShopPurchaseStatusCollectionProto>, IDeepCloneable<ShopPurchaseStatusCollectionProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ShopPurchaseStatusCollectionProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<ShopPurchaseStatusCollectionProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<ShopPurchaseStatusProto> _repeated_purchaseStatuses_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<ShopPurchaseStatusProto> purchaseStatuses_; //Field offset: 0x18

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
	public static MessageParser<ShopPurchaseStatusCollectionProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public RepeatedField<ShopPurchaseStatusProto> PurchaseStatuses
	{
		 get { } //Length: 11
	}

	private static ShopPurchaseStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public ShopPurchaseStatusCollectionProto() { }

	[DebuggerNonUserCode]
	public ShopPurchaseStatusCollectionProto(ShopPurchaseStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ShopPurchaseStatusCollectionProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ShopPurchaseStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<ShopPurchaseStatusCollectionProto> get_Parser() { }

	public RepeatedField<ShopPurchaseStatusProto> get_PurchaseStatuses() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ShopPurchaseStatusCollectionProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

