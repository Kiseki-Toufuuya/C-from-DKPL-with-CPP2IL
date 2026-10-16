namespace Google.Protobuf.WellKnownTypes;

public sealed class EnumValue : IMessage<EnumValue>, IMessage, IEquatable<EnumValue>, IDeepCloneable<EnumValue>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal EnumValue <.cctor>b__35_0() { }

	}

	private static readonly MessageParser<EnumValue> _parser; //Field offset: 0x0
	public const int NameFieldNumber = 1; //Field offset: 0x0
	public const int NumberFieldNumber = 2; //Field offset: 0x0
	public const int OptionsFieldNumber = 3; //Field offset: 0x0
	private static readonly FieldCodec<Option> _repeated_options_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private string name_; //Field offset: 0xC
	private int number_; //Field offset: 0x10
	private readonly RepeatedField<Option> options_; //Field offset: 0x14

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public int Number
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public RepeatedField<Option> Options
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public static MessageParser<EnumValue> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	private static EnumValue() { }

	[DebuggerNonUserCode]
	public EnumValue() { }

	[DebuggerNonUserCode]
	public EnumValue(EnumValue other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override EnumValue Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(EnumValue other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public string get_Name() { }

	public int get_Number() { }

	public RepeatedField<Option> get_Options() { }

	public static MessageParser<EnumValue> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(EnumValue other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_Number(int value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

