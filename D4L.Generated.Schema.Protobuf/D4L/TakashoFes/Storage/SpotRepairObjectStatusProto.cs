namespace D4L.TakashoFes.Storage;

public sealed class SpotRepairObjectStatusProto : IMessage<SpotRepairObjectStatusProto>, IMessage, IEquatable<SpotRepairObjectStatusProto>, IDeepCloneable<SpotRepairObjectStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal SpotRepairObjectStatusProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<SpotRepairObjectStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int spotObjectID_; //Field offset: 0x18

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
	public static MessageParser<SpotRepairObjectStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int SpotObjectID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static SpotRepairObjectStatusProto() { }

	[DebuggerNonUserCode]
	public SpotRepairObjectStatusProto() { }

	[DebuggerNonUserCode]
	public SpotRepairObjectStatusProto(SpotRepairObjectStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override SpotRepairObjectStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(SpotRepairObjectStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<SpotRepairObjectStatusProto> get_Parser() { }

	public int get_SpotObjectID() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(SpotRepairObjectStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	public void set_SpotObjectID(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

