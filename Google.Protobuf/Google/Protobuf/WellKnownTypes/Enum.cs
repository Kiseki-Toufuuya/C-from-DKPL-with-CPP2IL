namespace Google.Protobuf.WellKnownTypes;

public sealed class Enum : IMessage<Enum>, IMessage, IEquatable<Enum>, IDeepCloneable<Enum>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Enum <.cctor>b__45_0() { }

	}

	private static readonly MessageParser<Enum> _parser; //Field offset: 0x0
	public const int NameFieldNumber = 1; //Field offset: 0x0
	public const int EnumvalueFieldNumber = 2; //Field offset: 0x0
	public const int OptionsFieldNumber = 3; //Field offset: 0x0
	public const int SourceContextFieldNumber = 4; //Field offset: 0x0
	public const int SyntaxFieldNumber = 5; //Field offset: 0x0
	private static readonly FieldCodec<EnumValue> _repeated_enumvalue_codec; //Field offset: 0x4
	private static readonly FieldCodec<Option> _repeated_options_codec; //Field offset: 0x8
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private string name_; //Field offset: 0xC
	private readonly RepeatedField<EnumValue> enumvalue_; //Field offset: 0x10
	private readonly RepeatedField<Option> options_; //Field offset: 0x14
	private SourceContext sourceContext_; //Field offset: 0x18
	private Syntax syntax_; //Field offset: 0x1C

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public RepeatedField<EnumValue> Enumvalue
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public RepeatedField<Option> Options
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public static MessageParser<Enum> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public SourceContext SourceContext
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[DebuggerNonUserCode]
	public Syntax Syntax
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static Enum() { }

	[DebuggerNonUserCode]
	public Enum() { }

	[DebuggerNonUserCode]
	public Enum(Enum other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Enum Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Enum other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<EnumValue> get_Enumvalue() { }

	public string get_Name() { }

	public RepeatedField<Option> get_Options() { }

	public static MessageParser<Enum> get_Parser() { }

	public SourceContext get_SourceContext() { }

	public Syntax get_Syntax() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Enum other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_SourceContext(SourceContext value) { }

	public void set_Syntax(Syntax value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

