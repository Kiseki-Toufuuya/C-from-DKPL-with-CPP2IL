namespace Google.Protobuf.WellKnownTypes;

public sealed class UInt32Value : IMessage<UInt32Value>, IMessage, IEquatable<UInt32Value>, IDeepCloneable<UInt32Value>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal UInt32Value <.cctor>b__25_0() { }

	}

	private static readonly MessageParser<UInt32Value> _parser; //Field offset: 0x0
	public const int ValueFieldNumber = 1; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private uint value_; //Field offset: 0xC

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<UInt32Value> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public uint Value
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static UInt32Value() { }

	[DebuggerNonUserCode]
	public UInt32Value() { }

	[DebuggerNonUserCode]
	public UInt32Value(UInt32Value other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override UInt32Value Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(UInt32Value other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<UInt32Value> get_Parser() { }

	public uint get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(UInt32Value other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Value(uint value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

