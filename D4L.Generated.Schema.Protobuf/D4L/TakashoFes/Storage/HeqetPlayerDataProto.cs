namespace D4L.TakashoFes.Storage;

public sealed class HeqetPlayerDataProto : IMessage<HeqetPlayerDataProto>, IMessage, IEquatable<HeqetPlayerDataProto>, IDeepCloneable<HeqetPlayerDataProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal HeqetPlayerDataProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<HeqetPlayerDataProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private string playerName_; //Field offset: 0x18

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
	public static MessageParser<HeqetPlayerDataProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string PlayerName
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	private static HeqetPlayerDataProto() { }

	[DebuggerNonUserCode]
	public HeqetPlayerDataProto() { }

	[DebuggerNonUserCode]
	public HeqetPlayerDataProto(HeqetPlayerDataProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override HeqetPlayerDataProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(HeqetPlayerDataProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<HeqetPlayerDataProto> get_Parser() { }

	public string get_PlayerName() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(HeqetPlayerDataProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	public void set_PlayerName(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

