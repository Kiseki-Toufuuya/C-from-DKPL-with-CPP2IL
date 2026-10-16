namespace Google.Protobuf.WellKnownTypes;

public sealed class Int32Value : IMessage<Int32Value>, IMessage, IEquatable<Int32Value>, IDeepCloneable<Int32Value>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Int32Value <.cctor>b__25_0() { }

	}

	private static readonly MessageParser<Int32Value> _parser; //Field offset: 0x0
	public const int ValueFieldNumber = 1; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private int value_; //Field offset: 0xC

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public static MessageParser<Int32Value> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public int Value
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static Int32Value() { }

	[DebuggerNonUserCode]
	public Int32Value() { }

	[DebuggerNonUserCode]
	public Int32Value(Int32Value other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Int32Value Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Int32Value other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public static MessageParser<Int32Value> get_Parser() { }

	public int get_Value() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Int32Value other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Value(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

