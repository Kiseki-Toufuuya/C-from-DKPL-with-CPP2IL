namespace Google.Protobuf.WellKnownTypes;

public sealed class Type : IMessage<Type>, IMessage, IEquatable<Type>, IDeepCloneable<Type>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Type <.cctor>b__50_0() { }

	}

	private static readonly MessageParser<Type> _parser; //Field offset: 0x0
	public const int SourceContextFieldNumber = 5; //Field offset: 0x0
	public const int NameFieldNumber = 1; //Field offset: 0x0
	public const int OptionsFieldNumber = 4; //Field offset: 0x0
	public const int FieldsFieldNumber = 2; //Field offset: 0x0
	public const int SyntaxFieldNumber = 6; //Field offset: 0x0
	public const int OneofsFieldNumber = 3; //Field offset: 0x0
	private static readonly FieldCodec<Field> _repeated_fields_codec; //Field offset: 0x4
	private static readonly FieldCodec<String> _repeated_oneofs_codec; //Field offset: 0x8
	private static readonly FieldCodec<Option> _repeated_options_codec; //Field offset: 0xC
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private string name_; //Field offset: 0xC
	private readonly RepeatedField<Field> fields_; //Field offset: 0x10
	private readonly RepeatedField<String> oneofs_; //Field offset: 0x14
	private readonly RepeatedField<Option> options_; //Field offset: 0x18
	private SourceContext sourceContext_; //Field offset: 0x1C
	private Syntax syntax_; //Field offset: 0x20

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public RepeatedField<Field> Fields
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
	public RepeatedField<String> Oneofs
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<Option> Options
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public static MessageParser<Type> Parser
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

	private static Type() { }

	[DebuggerNonUserCode]
	public Type() { }

	[DebuggerNonUserCode]
	public Type(Type other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Type Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Type other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<Field> get_Fields() { }

	public string get_Name() { }

	public RepeatedField<String> get_Oneofs() { }

	public RepeatedField<Option> get_Options() { }

	public static MessageParser<Type> get_Parser() { }

	public SourceContext get_SourceContext() { }

	public Syntax get_Syntax() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Type other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_SourceContext(SourceContext value) { }

	public void set_Syntax(Syntax value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

