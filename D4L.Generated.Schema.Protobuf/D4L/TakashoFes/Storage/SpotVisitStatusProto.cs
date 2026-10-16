namespace D4L.TakashoFes.Storage;

public sealed class SpotVisitStatusProto : IMessage<SpotVisitStatusProto>, IMessage, IEquatable<SpotVisitStatusProto>, IDeepCloneable<SpotVisitStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal SpotVisitStatusProto <.cctor>b__45_0() { }

	}

	private static readonly MessageParser<SpotVisitStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int spotVisitID_; //Field offset: 0x18
	private int flVistWeight_; //Field offset: 0x1C
	private long createdAt_; //Field offset: 0x20
	private long lastUpdate_; //Field offset: 0x28

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
	public int FlVistWeight
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
	public long LastUpdate
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<SpotVisitStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int SpotVisitID
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static SpotVisitStatusProto() { }

	[DebuggerNonUserCode]
	public SpotVisitStatusProto() { }

	[DebuggerNonUserCode]
	public SpotVisitStatusProto(SpotVisitStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override SpotVisitStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(SpotVisitStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_FlVistWeight() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public static MessageParser<SpotVisitStatusProto> get_Parser() { }

	public int get_SpotVisitID() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(SpotVisitStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CreatedAt(long value) { }

	public void set_FlVistWeight(int value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_SpotVisitID(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

