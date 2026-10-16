namespace Google.Protobuf.WellKnownTypes;

public sealed class Int64Value : IMessage<Int64Value>, IMessage, IEquatable<Int64Value>, IDeepCloneable<Int64Value>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Int64Value <.cctor>b__25_0() { }

	}

	private static readonly MessageParser<Int64Value> _parser; //Field offset: 0x0
	public const int ValueFieldNumber = 1; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private long value_; //Field offset: 0x10

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<Int64Value> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public long Value
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static Int64Value() { }

	[DebuggerNonUserCode]
	public Int64Value() { }

	[DebuggerNonUserCode]
	public Int64Value(Int64Value other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Int64Value Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Int64Value other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<Int64Value> get_Parser() { }

	public long get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Int64Value other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Value(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

