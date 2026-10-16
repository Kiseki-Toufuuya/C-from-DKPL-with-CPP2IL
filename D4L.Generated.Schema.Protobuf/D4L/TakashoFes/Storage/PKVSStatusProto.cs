namespace D4L.TakashoFes.Storage;

public sealed class PKVSStatusProto : IMessage<PKVSStatusProto>, IMessage, IEquatable<PKVSStatusProto>, IDeepCloneable<PKVSStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PKVSStatusProto <.cctor>b__35_0() { }

	}

	private static readonly MessageParser<PKVSStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private long receiveDate_; //Field offset: 0x18
	private long delta_; //Field offset: 0x20

	[DebuggerNonUserCode]
	public long Delta
	{
		 get { } //Length: 14
		 set { } //Length: 20
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
	public static MessageParser<PKVSStatusProto> Parser
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

	private static PKVSStatusProto() { }

	[DebuggerNonUserCode]
	public PKVSStatusProto() { }

	[DebuggerNonUserCode]
	public PKVSStatusProto(PKVSStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override PKVSStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(PKVSStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_Delta() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<PKVSStatusProto> get_Parser() { }

	public long get_ReceiveDate() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(PKVSStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Delta(long value) { }

	public void set_ID(long value) { }

	public void set_ReceiveDate(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

