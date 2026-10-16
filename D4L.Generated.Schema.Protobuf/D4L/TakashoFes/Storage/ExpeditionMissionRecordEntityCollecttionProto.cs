namespace D4L.TakashoFes.Storage;

public sealed class ExpeditionMissionRecordEntityCollecttionProto : IMessage<ExpeditionMissionRecordEntityCollecttionProto>, IMessage, IEquatable<ExpeditionMissionRecordEntityCollecttionProto>, IDeepCloneable<ExpeditionMissionRecordEntityCollecttionProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ExpeditionMissionRecordEntityCollecttionProto <.cctor>b__30_0() { }

	}

	private static readonly MessageParser<ExpeditionMissionRecordEntityCollecttionProto> _parser; //Field offset: 0x0
	private static readonly FieldCodec<ExpeditionMissionRecordEntityProto> _repeated_expeditionMissionRecords_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private readonly RepeatedField<ExpeditionMissionRecordEntityProto> expeditionMissionRecords_; //Field offset: 0x18

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public RepeatedField<ExpeditionMissionRecordEntityProto> ExpeditionMissionRecords
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
	public static MessageParser<ExpeditionMissionRecordEntityCollecttionProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static ExpeditionMissionRecordEntityCollecttionProto() { }

	[DebuggerNonUserCode]
	public ExpeditionMissionRecordEntityCollecttionProto() { }

	[DebuggerNonUserCode]
	public ExpeditionMissionRecordEntityCollecttionProto(ExpeditionMissionRecordEntityCollecttionProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ExpeditionMissionRecordEntityCollecttionProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ExpeditionMissionRecordEntityCollecttionProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<ExpeditionMissionRecordEntityProto> get_ExpeditionMissionRecords() { }

	public long get_ID() { }

	public static MessageParser<ExpeditionMissionRecordEntityCollecttionProto> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ExpeditionMissionRecordEntityCollecttionProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ID(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

