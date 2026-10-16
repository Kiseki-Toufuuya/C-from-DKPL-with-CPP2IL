namespace D4L.TakashoFes.Struct;

public sealed class ExpeditionChallengeStatusProto : IMessage<ExpeditionChallengeStatusProto>, IMessage, IEquatable<ExpeditionChallengeStatusProto>, IDeepCloneable<ExpeditionChallengeStatusProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ExpeditionChallengeStatusProto <.cctor>b__35_0() { }

	}

	private static readonly MessageParser<ExpeditionChallengeStatusProto> _parser; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long iD_; //Field offset: 0x10
	private int bonusValue_; //Field offset: 0x18
	private int powerValue_; //Field offset: 0x1C

	[DebuggerNonUserCode]
	public int BonusValue
	{
		 get { } //Length: 11
		 set { } //Length: 14
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
	public static MessageParser<ExpeditionChallengeStatusProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int PowerValue
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static ExpeditionChallengeStatusProto() { }

	[DebuggerNonUserCode]
	public ExpeditionChallengeStatusProto() { }

	[DebuggerNonUserCode]
	public ExpeditionChallengeStatusProto(ExpeditionChallengeStatusProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override ExpeditionChallengeStatusProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(ExpeditionChallengeStatusProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_BonusValue() { }

	public static MessageDescriptor get_Descriptor() { }

	public long get_ID() { }

	public static MessageParser<ExpeditionChallengeStatusProto> get_Parser() { }

	public int get_PowerValue() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(ExpeditionChallengeStatusProto other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_BonusValue(int value) { }

	public void set_ID(long value) { }

	public void set_PowerValue(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

