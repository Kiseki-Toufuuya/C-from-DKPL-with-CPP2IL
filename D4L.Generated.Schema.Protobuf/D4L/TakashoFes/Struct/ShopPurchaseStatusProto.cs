namespace D4L.TakashoFes.Struct;

public sealed class ShopPurchaseStatusProto : IMessage<ShopPurchaseStatusProto>, IMessage, IEquatable<ShopPurchaseStatusProto>, IDeepCloneable<ShopPurchaseStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ShopPurchaseStatusProto <.cctor>b__35_0() { }

	}

	private static readonly MessageParser<ShopPurchaseStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long purchaseCount_; //Field offset: 0x18
	private long lastPurchaseDate_; //Field offset: 0x20

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
	public long LastPurchaseDate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<ShopPurchaseStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public long PurchaseCount
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static ShopPurchaseStatusProto() { }

	[DebuggerNonUserCode]
	public ShopPurchaseStatusProto() { }

	[DebuggerNonUserCode]
	public ShopPurchaseStatusProto(ShopPurchaseStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ShopPurchaseStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ShopPurchaseStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public long get_LastPurchaseDate() { }

	public static MessageParser<ShopPurchaseStatusProto> get_Parser() { }

	public long get_PurchaseCount() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ShopPurchaseStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	public void set_LastPurchaseDate(long value) { }

	public void set_PurchaseCount(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

