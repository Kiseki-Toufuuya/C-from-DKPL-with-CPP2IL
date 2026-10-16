namespace D4L.TakashoFes.Struct;

public sealed class GrowthItemEntityStatusProto : IMessage<GrowthItemEntityStatusProto>, IMessage, IEquatable<GrowthItemEntityStatusProto>, IDeepCloneable<GrowthItemEntityStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal GrowthItemEntityStatusProto <.cctor>b__40_0() { }

	}

	private static readonly MessageParser<GrowthItemEntityStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int count_; //Field offset: 0x18
	private long createdAt_; //Field offset: 0x20
	private long lastUpdate_; //Field offset: 0x28

	[DebuggerNonUserCode]
	public int Count
	{
		 get { } //Length: 11
		 set { } //Length: 14
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
	public static MessageParser<GrowthItemEntityStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static GrowthItemEntityStatusProto() { }

	[DebuggerNonUserCode]
	public GrowthItemEntityStatusProto() { }

	[DebuggerNonUserCode]
	public GrowthItemEntityStatusProto(GrowthItemEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override GrowthItemEntityStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(GrowthItemEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_Count() { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public static MessageParser<GrowthItemEntityStatusProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(GrowthItemEntityStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Count(int value) { }

	public void set_CreatedAt(long value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

