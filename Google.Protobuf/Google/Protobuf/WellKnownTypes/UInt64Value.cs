namespace Google.Protobuf.WellKnownTypes;

public sealed class UInt64Value : IMessage<UInt64Value>, IMessage, IEquatable<UInt64Value>, IDeepCloneable<UInt64Value>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal UInt64Value <.cctor>b__25_0() { }

	}

	private static readonly MessageParser<UInt64Value> _parser; //Field offset: 0x0
	public const int ValueFieldNumber = 1; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private ulong value_; //Field offset: 0x10

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<UInt64Value> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public ulong Value
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	private static UInt64Value() { }

	[DebuggerNonUserCode]
	public UInt64Value() { }

	[DebuggerNonUserCode]
	public UInt64Value(UInt64Value other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override UInt64Value Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(UInt64Value other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<UInt64Value> get_Parser() { }

	public ulong get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(UInt64Value other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Value(ulong value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

