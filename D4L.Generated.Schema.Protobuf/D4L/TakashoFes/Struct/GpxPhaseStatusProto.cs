namespace D4L.TakashoFes.Struct;

public sealed class GpxPhaseStatusProto : IMessage<GpxPhaseStatusProto>, IMessage, IEquatable<GpxPhaseStatusProto>, IDeepCloneable<GpxPhaseStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal GpxPhaseStatusProto <.cctor>b__50_0() { }

	}

	private static readonly MessageParser<GpxPhaseStatusProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<Boolean> _repeated_isClear_codec; //Field offset: 0x4
	private static readonly FieldCodec<Int64> _repeated_maxScore_codec; //Field offset: 0x8
	private static readonly FieldCodec<Int64> _repeated_score_codec; //Field offset: 0xC
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<Boolean> isClear_; //Field offset: 0x18
	private readonly RepeatedField<Int64> maxScore_; //Field offset: 0x1C
	private readonly RepeatedField<Int64> score_; //Field offset: 0x20
	private long maxTotalScore_; //Field offset: 0x28
	private int receiveReward_; //Field offset: 0x30

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
	public RepeatedField<Boolean> IsClear
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int64> MaxScore
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public long MaxTotalScore
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	[DebuggerNonUserCode]
	public static MessageParser<GpxPhaseStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int ReceiveReward
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int64> Score
	{
		 get { } //Length: 11
	}

	private static GpxPhaseStatusProto() { }

	[DebuggerNonUserCode]
	public GpxPhaseStatusProto() { }

	[DebuggerNonUserCode]
	public GpxPhaseStatusProto(GpxPhaseStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override GpxPhaseStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(GpxPhaseStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public RepeatedField<Boolean> get_IsClear() { }

	public RepeatedField<Int64> get_MaxScore() { }

	public long get_MaxTotalScore() { }

	public static MessageParser<GpxPhaseStatusProto> get_Parser() { }

	public int get_ReceiveReward() { }

	public RepeatedField<Int64> get_Score() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(GpxPhaseStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	public void set_MaxTotalScore(long value) { }

	public void set_ReceiveReward(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

