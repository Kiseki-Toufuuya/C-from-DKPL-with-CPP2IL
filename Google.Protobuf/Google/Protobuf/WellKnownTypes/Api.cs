namespace Google.Protobuf.WellKnownTypes;

public sealed class Api : IMessage<Api>, IMessage, IEquatable<Api>, IDeepCloneable<Api>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Api <.cctor>b__55_0() { }

	}

	private static readonly MessageParser<Api> _parser; //Field offset: 0x0
	public const int NameFieldNumber = 1; //Field offset: 0x0
	public const int MethodsFieldNumber = 2; //Field offset: 0x0
	public const int OptionsFieldNumber = 3; //Field offset: 0x0
	public const int SyntaxFieldNumber = 7; //Field offset: 0x0
	public const int VersionFieldNumber = 4; //Field offset: 0x0
	public const int SourceContextFieldNumber = 5; //Field offset: 0x0
	public const int MixinsFieldNumber = 6; //Field offset: 0x0
	private static readonly FieldCodec<Method> _repeated_methods_codec; //Field offset: 0x4
	private static readonly FieldCodec<Option> _repeated_options_codec; //Field offset: 0x8
	private static readonly FieldCodec<Mixin> _repeated_mixins_codec; //Field offset: 0xC
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private string name_; //Field offset: 0xC
	private readonly RepeatedField<Method> methods_; //Field offset: 0x10
	private readonly RepeatedField<Option> options_; //Field offset: 0x14
	private string version_; //Field offset: 0x18
	private SourceContext sourceContext_; //Field offset: 0x1C
	private readonly RepeatedField<Mixin> mixins_; //Field offset: 0x20
	private Syntax syntax_; //Field offset: 0x24

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public RepeatedField<Method> Methods
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<Mixin> Mixins
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
	public static MessageParser<Api> Parser
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

	[DebuggerNonUserCode]
	public string Version
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	private static Api() { }

	[DebuggerNonUserCode]
	public Api() { }

	[DebuggerNonUserCode]
	public Api(Api other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Api Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Api other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<Method> get_Methods() { }

	public RepeatedField<Mixin> get_Mixins() { }

	public string get_Name() { }

	public RepeatedField<Option> get_Options() { }

	public static MessageParser<Api> get_Parser() { }

	public SourceContext get_SourceContext() { }

	public Syntax get_Syntax() { }

	public string get_Version() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Api other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_SourceContext(SourceContext value) { }

	public void set_Syntax(Syntax value) { }

	public void set_Version(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

