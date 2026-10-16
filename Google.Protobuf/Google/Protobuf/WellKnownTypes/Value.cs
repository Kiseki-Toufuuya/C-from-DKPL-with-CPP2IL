namespace Google.Protobuf.WellKnownTypes;

public sealed class Value : IMessage<Value>, IMessage, IEquatable<Value>, IDeepCloneable<Value>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Value <.cctor>b__56_0() { }

	}

	internal enum KindOneofCase
	{
		None = 0,
		NullValue = 1,
		NumberValue = 2,
		StringValue = 3,
		BoolValue = 4,
		StructValue = 5,
		ListValue = 6,
	}

	private static readonly MessageParser<Value> _parser; //Field offset: 0x0
	public const int NullValueFieldNumber = 1; //Field offset: 0x0
	public const int NumberValueFieldNumber = 2; //Field offset: 0x0
	public const int StringValueFieldNumber = 3; //Field offset: 0x0
	public const int BoolValueFieldNumber = 4; //Field offset: 0x0
	public const int StructValueFieldNumber = 5; //Field offset: 0x0
	public const int ListValueFieldNumber = 6; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private object kind_; //Field offset: 0xC
	private KindOneofCase kindCase_; //Field offset: 0x10

	[DebuggerNonUserCode]
	public bool BoolValue
	{
		 get { } //Length: 64
		 set { } //Length: 54
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public KindOneofCase KindCase
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public ListValue ListValue
	{
		 get { } //Length: 74
		 set { } //Length: 41
	}

	[DebuggerNonUserCode]
	public NullValue NullValue
	{
		 get { } //Length: 93
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public double NumberValue
	{
		 get { } //Length: 64
		 set { } //Length: 58
	}

	[DebuggerNonUserCode]
	public static MessageParser<Value> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public string StringValue
	{
		 get { } //Length: 81
		 set { } //Length: 92
	}

	[DebuggerNonUserCode]
	public Struct StructValue
	{
		 get { } //Length: 74
		 set { } //Length: 41
	}

	private static Value() { }

	[DebuggerNonUserCode]
	public Value(Value other) { }

	[DebuggerNonUserCode]
	public Value() { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public void ClearKind() { }

	[DebuggerNonUserCode]
	public override Value Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Value other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static Value ForBool(bool value) { }

	public static Value ForList(Value[] values) { }

	public static Value ForNull() { }

	public static Value ForNumber(double value) { }

	public static Value ForString(string value) { }

	public static Value ForStruct(Struct value) { }

	public bool get_BoolValue() { }

	public static MessageDescriptor get_Descriptor() { }

	public KindOneofCase get_KindCase() { }

	public ListValue get_ListValue() { }

	public NullValue get_NullValue() { }

	public double get_NumberValue() { }

	public static MessageParser<Value> get_Parser() { }

	public string get_StringValue() { }

	public Struct get_StructValue() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Value other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_BoolValue(bool value) { }

	public void set_ListValue(ListValue value) { }

	public void set_NullValue(NullValue value) { }

	public void set_NumberValue(double value) { }

	public void set_StringValue(string value) { }

	public void set_StructValue(Struct value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

