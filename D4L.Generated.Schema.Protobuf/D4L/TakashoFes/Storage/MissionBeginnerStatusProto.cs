namespace D4L.TakashoFes.Storage;

public sealed class MissionBeginnerStatusProto : IMessage<MissionBeginnerStatusProto>, IMessage, IEquatable<MissionBeginnerStatusProto>, IDeepCloneable<MissionBeginnerStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal MissionBeginnerStatusProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<MissionBeginnerStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int receiveStatus_; //Field offset: 0x18

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
	public static MessageParser<MissionBeginnerStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int ReceiveStatus
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static MissionBeginnerStatusProto() { }

	[DebuggerNonUserCode]
	public MissionBeginnerStatusProto() { }

	[DebuggerNonUserCode]
	public MissionBeginnerStatusProto(MissionBeginnerStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override MissionBeginnerStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MissionBeginnerStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<MissionBeginnerStatusProto> get_Parser() { }

	public int get_ReceiveStatus() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MissionBeginnerStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	public void set_ReceiveStatus(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

