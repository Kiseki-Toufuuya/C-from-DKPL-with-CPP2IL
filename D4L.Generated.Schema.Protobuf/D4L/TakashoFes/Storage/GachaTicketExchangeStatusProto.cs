namespace D4L.TakashoFes.Storage;

public sealed class GachaTicketExchangeStatusProto : IMessage<GachaTicketExchangeStatusProto>, IMessage, IEquatable<GachaTicketExchangeStatusProto>, IDeepCloneable<GachaTicketExchangeStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal GachaTicketExchangeStatusProto <.cctor>b__35_0() { }

	}

	private static readonly MessageParser<GachaTicketExchangeStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int gachaTikectID_; //Field offset: 0x18
	private int delta_; //Field offset: 0x1C

	[DebuggerNonUserCode]
	public int Delta
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
	public int GachaTikectID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public long ID
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<GachaTicketExchangeStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static GachaTicketExchangeStatusProto() { }

	[DebuggerNonUserCode]
	public GachaTicketExchangeStatusProto() { }

	[DebuggerNonUserCode]
	public GachaTicketExchangeStatusProto(GachaTicketExchangeStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override GachaTicketExchangeStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(GachaTicketExchangeStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_Delta() { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_GachaTikectID() { }

	public long get_ID() { }

	public static MessageParser<GachaTicketExchangeStatusProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(GachaTicketExchangeStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Delta(int value) { }

	public void set_GachaTikectID(int value) { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

