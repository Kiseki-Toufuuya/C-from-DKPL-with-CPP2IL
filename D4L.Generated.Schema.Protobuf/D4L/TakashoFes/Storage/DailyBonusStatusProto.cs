namespace D4L.TakashoFes.Storage;

public sealed class DailyBonusStatusProto : IMessage<DailyBonusStatusProto>, IMessage, IEquatable<DailyBonusStatusProto>, IDeepCloneable<DailyBonusStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal DailyBonusStatusProto <.cctor>b__40_0() { }

	}

	private static readonly MessageParser<DailyBonusStatusProto> _parser; //Field offset: 0x0
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
	public static MessageParser<DailyBonusStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static DailyBonusStatusProto() { }

	[DebuggerNonUserCode]
	public DailyBonusStatusProto() { }

	[DebuggerNonUserCode]
	public DailyBonusStatusProto(DailyBonusStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override DailyBonusStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(DailyBonusStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_Count() { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public static MessageParser<DailyBonusStatusProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(DailyBonusStatusProto other) { }

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

