namespace Google.Protobuf.WellKnownTypes;

public sealed class Timestamp : IMessage<Timestamp>, IMessage, IEquatable<Timestamp>, IDeepCloneable<Timestamp>, ICustomDiagnosticMessage, IComparable<Timestamp>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Timestamp <.cctor>b__53_0() { }

	}

	private static readonly MessageParser<Timestamp> _parser; //Field offset: 0x0
	public const int SecondsFieldNumber = 1; //Field offset: 0x0
	public const int NanosFieldNumber = 2; //Field offset: 0x0
	private const long BclSecondsAtUnixEpoch = 62135596800; //Field offset: 0x0
	internal const long UnixSecondsAtBclMaxValue = 253402300799; //Field offset: 0x0
	internal const long UnixSecondsAtBclMinValue = -62135596800; //Field offset: 0x0
	internal const int MaxNanos = 999999999; //Field offset: 0x0
	private static readonly DateTime UnixEpoch; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long seconds_; //Field offset: 0x10
	private int nanos_; //Field offset: 0x18

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public int Nanos
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public static MessageParser<Timestamp> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public long Seconds
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static Timestamp() { }

	[DebuggerNonUserCode]
	public Timestamp() { }

	[DebuggerNonUserCode]
	public Timestamp(Timestamp other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Timestamp Clone() { }

	public override int CompareTo(Timestamp other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	[DebuggerNonUserCode]
	public override bool Equals(Timestamp other) { }

	public static Timestamp FromDateTime(DateTime dateTime) { }

	public static Timestamp FromDateTimeOffset(DateTimeOffset dateTimeOffset) { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_Nanos() { }

	public static MessageParser<Timestamp> get_Parser() { }

	public long get_Seconds() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	private static bool IsNormalized(long seconds, int nanoseconds) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Timestamp other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	internal static Timestamp Normalize(long seconds, int nanoseconds) { }

	public static Timestamp op_Addition(Timestamp lhs, Duration rhs) { }

	public static bool op_Equality(Timestamp a, Timestamp b) { }

	public static bool op_GreaterThan(Timestamp a, Timestamp b) { }

	public static bool op_GreaterThanOrEqual(Timestamp a, Timestamp b) { }

	public static bool op_Inequality(Timestamp a, Timestamp b) { }

	public static bool op_LessThan(Timestamp a, Timestamp b) { }

	public static bool op_LessThanOrEqual(Timestamp a, Timestamp b) { }

	public static Duration op_Subtraction(Timestamp lhs, Timestamp rhs) { }

	public static Timestamp op_Subtraction(Timestamp lhs, Duration rhs) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Nanos(int value) { }

	public void set_Seconds(long value) { }

	public DateTime ToDateTime() { }

	public DateTimeOffset ToDateTimeOffset() { }

	public override string ToDiagnosticString() { }

	internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

