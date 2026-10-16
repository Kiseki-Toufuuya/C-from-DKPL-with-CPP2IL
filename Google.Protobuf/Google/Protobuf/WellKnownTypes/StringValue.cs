namespace Google.Protobuf.WellKnownTypes;

public sealed class StringValue : IMessage<StringValue>, IMessage, IEquatable<StringValue>, IDeepCloneable<StringValue>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal StringValue <.cctor>b__25_0() { }

	}

	private static readonly MessageParser<StringValue> _parser; //Field offset: 0x0
	public const int ValueFieldNumber = 1; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private string value_; //Field offset: 0xC

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<StringValue> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string Value
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	private static StringValue() { }

	[DebuggerNonUserCode]
	public StringValue() { }

	[DebuggerNonUserCode]
	public StringValue(StringValue other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override StringValue Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(StringValue other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<StringValue> get_Parser() { }

	public string get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(StringValue other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Value(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

