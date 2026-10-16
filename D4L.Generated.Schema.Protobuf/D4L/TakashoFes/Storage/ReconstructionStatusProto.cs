namespace D4L.TakashoFes.Storage;

public sealed class ReconstructionStatusProto : IMessage<ReconstructionStatusProto>, IMessage, IEquatable<ReconstructionStatusProto>, IDeepCloneable<ReconstructionStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ReconstructionStatusProto <.cctor>b__45_0() { }

	}

	private static readonly MessageParser<ReconstructionStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int spotObjectID_; //Field offset: 0x18
	private long completeTime_; //Field offset: 0x20
	private long createdAt_; //Field offset: 0x28
	private long lastUpdate_; //Field offset: 0x30

	[DebuggerNonUserCode]
	public long CompleteTime
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public long CreatedAt
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
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<ReconstructionStatusProto> Parser
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

	private static ReconstructionStatusProto() { }

	[DebuggerNonUserCode]
	public ReconstructionStatusProto() { }

	[DebuggerNonUserCode]
	public ReconstructionStatusProto(ReconstructionStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ReconstructionStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ReconstructionStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CompleteTime() { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public static MessageParser<ReconstructionStatusProto> get_Parser() { }

	public int get_SpotObjectID() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ReconstructionStatusProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CompleteTime(long value) { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_SpotObjectID(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

