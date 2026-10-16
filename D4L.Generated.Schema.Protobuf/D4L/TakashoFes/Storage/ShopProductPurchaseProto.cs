namespace D4L.TakashoFes.Storage;

public sealed class ShopProductPurchaseProto : IMessage<ShopProductPurchaseProto>, IMessage, IEquatable<ShopProductPurchaseProto>, IDeepCloneable<ShopProductPurchaseProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ShopProductPurchaseProto <.cctor>b__40_0() { }

	}

	private static readonly MessageParser<ShopProductPurchaseProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long purchaseCount_; //Field offset: 0x18
	private long lastPurchaseDate_; //Field offset: 0x20
	private int isNew_; //Field offset: 0x28

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
	public int IsNew
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long LastPurchaseDate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<ShopProductPurchaseProto> Parser
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

	private static ShopProductPurchaseProto() { }

	[DebuggerNonUserCode]
	public ShopProductPurchaseProto() { }

	[DebuggerNonUserCode]
	public ShopProductPurchaseProto(ShopProductPurchaseProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ShopProductPurchaseProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ShopProductPurchaseProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public int get_IsNew() { }

	public long get_LastPurchaseDate() { }

	public static MessageParser<ShopProductPurchaseProto> get_Parser() { }

	public long get_PurchaseCount() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ShopProductPurchaseProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	public void set_IsNew(int value) { }

	public void set_LastPurchaseDate(long value) { }

	public void set_PurchaseCount(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

