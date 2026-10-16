namespace Google.Protobuf.WellKnownTypes;

public sealed class Duration : IMessage<Duration>, IMessage, IEquatable<Duration>, IDeepCloneable<Duration>, ICustomDiagnosticMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Duration <.cctor>b__46_0() { }

	}

	private static readonly MessageParser<Duration> _parser; //Field offset: 0x0
	public const int SecondsFieldNumber = 1; //Field offset: 0x0
	public const int NanosFieldNumber = 2; //Field offset: 0x0
	public const int NanosecondsPerSecond = 1000000000; //Field offset: 0x0
	public const int NanosecondsPerTick = 100; //Field offset: 0x0
	public const long MaxSeconds = 315576000000; //Field offset: 0x0
	public const long MinSeconds = -315576000000; //Field offset: 0x0
	internal const int MaxNanoseconds = 999999999; //Field offset: 0x0
	internal const int MinNanoseconds = -999999999; //Field offset: 0x0
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
	public static MessageParser<Duration> Parser
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

	private static Duration() { }

	[DebuggerNonUserCode]
	public Duration() { }

	[DebuggerNonUserCode]
	public Duration(Duration other) { }

	internal static void AppendNanoseconds(StringBuilder builder, int nanos) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Duration Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Duration other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static Duration FromTimeSpan(TimeSpan timeSpan) { }

	public static MessageDescriptor get_Descriptor() { }

	public int get_Nanos() { }

	public static MessageParser<Duration> get_Parser() { }

	public long get_Seconds() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	internal static bool IsNormalized(long seconds, int nanoseconds) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Duration other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	internal static Duration Normalize(long seconds, int nanoseconds) { }

	public static Duration op_Addition(Duration lhs, Duration rhs) { }

	public static Duration op_Subtraction(Duration lhs, Duration rhs) { }

	public static Duration op_UnaryNegation(Duration value) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Nanos(int value) { }

	public void set_Seconds(long value) { }

	public override string ToDiagnosticString() { }

	internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	public TimeSpan ToTimeSpan() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

