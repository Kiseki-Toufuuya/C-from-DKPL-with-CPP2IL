namespace Google.Protobuf.WellKnownTypes;

public sealed class DoubleValue : IMessage<DoubleValue>, IMessage, IEquatable<DoubleValue>, IDeepCloneable<DoubleValue>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal DoubleValue <.cctor>b__25_0() { }

	}

	private static readonly MessageParser<DoubleValue> _parser; //Field offset: 0x0
	public const int ValueFieldNumber = 1; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private double value_; //Field offset: 0x10

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<DoubleValue> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public double Value
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	private static DoubleValue() { }

	[DebuggerNonUserCode]
	public DoubleValue() { }

	[DebuggerNonUserCode]
	public DoubleValue(DoubleValue other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override DoubleValue Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(DoubleValue other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<DoubleValue> get_Parser() { }

	public double get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(DoubleValue other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Value(double value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

