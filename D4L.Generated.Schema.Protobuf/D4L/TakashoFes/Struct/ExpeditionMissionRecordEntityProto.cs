namespace D4L.TakashoFes.Struct;

public sealed class ExpeditionMissionRecordEntityProto : IMessage<ExpeditionMissionRecordEntityProto>, IMessage, IEquatable<ExpeditionMissionRecordEntityProto>, IDeepCloneable<ExpeditionMissionRecordEntityProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ExpeditionMissionRecordEntityProto <.cctor>b__70_0() { }

	}

	private static readonly MessageParser<ExpeditionMissionRecordEntityProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Int64> _repeated_heroineIDArray_codec; //Field offset: 0x4
	private static readonly FieldCodec<Int64> _repeated_cardIDArray_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int successCount_; //Field offset: 0x18
	private int greatSuccessCount_; //Field offset: 0x1C
	private int superSuccessCount_; //Field offset: 0x20
	private long createdAt_; //Field offset: 0x28
	private long lastUpdate_; //Field offset: 0x30
	private readonly RepeatedField<Int64> heroineIDArray_; //Field offset: 0x38
	private readonly RepeatedField<Int64> cardIDArray_; //Field offset: 0x3C
	private int new_; //Field offset: 0x40
	private long completeTime_; //Field offset: 0x48

	[DebuggerNonUserCode]
	public RepeatedField<Int64> CardIDArray
	{
		 get { } //Length: 11
	}

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
	public int GreatSuccessCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int64> HeroineIDArray
	{
		 get { } //Length: 11
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
	public int New
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<ExpeditionMissionRecordEntityProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int SuccessCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public int SuperSuccessCount
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static ExpeditionMissionRecordEntityProto() { }

	[DebuggerNonUserCode]
	public ExpeditionMissionRecordEntityProto() { }

	[DebuggerNonUserCode]
	public ExpeditionMissionRecordEntityProto(ExpeditionMissionRecordEntityProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ExpeditionMissionRecordEntityProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ExpeditionMissionRecordEntityProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public RepeatedField<Int64> get_CardIDArray() { }

	public long get_CompleteTime() { }

	public long get_CreatedAt() { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_GreatSuccessCount() { }

	public RepeatedField<Int64> get_HeroineIDArray() { }

	public long get_ID() { }

	public long get_LastUpdate() { }

	public int get_New() { }

	public static MessageParser<ExpeditionMissionRecordEntityProto> get_Parser() { }

	public int get_SuccessCount() { }

	public int get_SuperSuccessCount() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ExpeditionMissionRecordEntityProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_CompleteTime(long value) { }

	public void set_CreatedAt(long value) { }

	public void set_GreatSuccessCount(int value) { }

	public void set_ID(long value) { }

	public void set_LastUpdate(long value) { }

	public void set_New(int value) { }

	public void set_SuccessCount(int value) { }

	public void set_SuperSuccessCount(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

