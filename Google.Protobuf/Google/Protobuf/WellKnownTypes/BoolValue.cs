namespace Google.Protobuf.WellKnownTypes;

public sealed class BoolValue : IMessage<BoolValue>, IMessage, IEquatable<BoolValue>, IDeepCloneable<BoolValue>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal BoolValue <.cctor>b__25_0() { }

	}

	private static readonly MessageParser<BoolValue> _parser; //Field offset: 0x0
	public const int ValueFieldNumber = 1; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private bool value_; //Field offset: 0xC

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<BoolValue> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public bool Value
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static BoolValue() { }

	[DebuggerNonUserCode]
	public BoolValue() { }

	[DebuggerNonUserCode]
	public BoolValue(BoolValue other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override BoolValue Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(BoolValue other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<BoolValue> get_Parser() { }

	public bool get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(BoolValue other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Value(bool value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

