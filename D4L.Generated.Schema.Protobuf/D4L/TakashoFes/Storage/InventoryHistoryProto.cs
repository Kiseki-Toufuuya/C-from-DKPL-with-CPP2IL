namespace D4L.TakashoFes.Storage;

public sealed class InventoryHistoryProto : IMessage<InventoryHistoryProto>, IMessage, IEquatable<InventoryHistoryProto>, IDeepCloneable<InventoryHistoryProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal InventoryHistoryProto <.cctor>b__40_0() { }

	}

	private static readonly MessageParser<InventoryHistoryProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private string message_; //Field offset: 0x18
	private string value_; //Field offset: 0x1C
	private long receiveDate_; //Field offset: 0x20

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
	public string Message
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public static MessageParser<InventoryHistoryProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public long ReceiveDate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public string Value
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	private static InventoryHistoryProto() { }

	[DebuggerNonUserCode]
	public InventoryHistoryProto() { }

	[DebuggerNonUserCode]
	public InventoryHistoryProto(InventoryHistoryProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override InventoryHistoryProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(InventoryHistoryProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public string get_Message() { }

	public static MessageParser<InventoryHistoryProto> get_Parser() { }

	public long get_ReceiveDate() { }

	public string get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(InventoryHistoryProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	public void set_Message(string value) { }

	public void set_ReceiveDate(long value) { }

	public void set_Value(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

