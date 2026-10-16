namespace Google.Protobuf.WellKnownTypes;

public sealed class BytesValue : IMessage<BytesValue>, IMessage, IEquatable<BytesValue>, IDeepCloneable<BytesValue>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal BytesValue <.cctor>b__25_0() { }

	}

	private static readonly MessageParser<BytesValue> _parser; //Field offset: 0x0
	public const int ValueFieldNumber = 1; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private ByteString value_; //Field offset: 0xC

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<BytesValue> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public ByteString Value
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	private static BytesValue() { }

	[DebuggerNonUserCode]
	public BytesValue() { }

	[DebuggerNonUserCode]
	public BytesValue(BytesValue other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override BytesValue Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(BytesValue other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<BytesValue> get_Parser() { }

	public ByteString get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(BytesValue other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Value(ByteString value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

