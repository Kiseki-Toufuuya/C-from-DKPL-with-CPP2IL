namespace D4L.TakashoFes.Storage;

public sealed class SpotRepairStatusProto : IMessage<SpotRepairStatusProto>, IMessage, IEquatable<SpotRepairStatusProto>, IDeepCloneable<SpotRepairStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal SpotRepairStatusProto <.cctor>b__35_0() { }

	}

	private static readonly MessageParser<SpotRepairStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int repairStatus_; //Field offset: 0x18
	private long createDate_; //Field offset: 0x20

	[DebuggerNonUserCode]
	public long CreateDate
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
	public static MessageParser<SpotRepairStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int RepairStatus
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static SpotRepairStatusProto() { }

	[DebuggerNonUserCode]
	public SpotRepairStatusProto() { }

	[DebuggerNonUserCode]
	public SpotRepairStatusProto(SpotRepairStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override SpotRepairStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(SpotRepairStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreateDate() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<SpotRepairStatusProto> get_Parser() { }

	public int get_RepairStatus() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(SpotRepairStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreateDate(long value) { }

	public void set_ID(long value) { }

	public void set_RepairStatus(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

