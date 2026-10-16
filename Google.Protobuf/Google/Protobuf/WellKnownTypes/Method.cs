namespace Google.Protobuf.WellKnownTypes;

public sealed class Method : IMessage<Method>, IMessage, IEquatable<Method>, IDeepCloneable<Method>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Method <.cctor>b__55_0() { }

	}

	private static readonly MessageParser<Method> _parser; //Field offset: 0x0
	public const int OptionsFieldNumber = 6; //Field offset: 0x0
	public const int ResponseStreamingFieldNumber = 5; //Field offset: 0x0
	public const int SyntaxFieldNumber = 7; //Field offset: 0x0
	public const int RequestStreamingFieldNumber = 3; //Field offset: 0x0
	public const int ResponseTypeUrlFieldNumber = 4; //Field offset: 0x0
	public const int RequestTypeUrlFieldNumber = 2; //Field offset: 0x0
	public const int NameFieldNumber = 1; //Field offset: 0x0
	private static readonly FieldCodec<Option> _repeated_options_codec; //Field offset: 0x4
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private string name_; //Field offset: 0xC
	private string requestTypeUrl_; //Field offset: 0x10
	private bool requestStreaming_; //Field offset: 0x14
	private string responseTypeUrl_; //Field offset: 0x18
	private bool responseStreaming_; //Field offset: 0x1C
	private readonly RepeatedField<Option> options_; //Field offset: 0x20
	private Syntax syntax_; //Field offset: 0x24

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
	public RepeatedField<Option> Options
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public static MessageParser<Method> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public bool RequestStreaming
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public string RequestTypeUrl
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public bool ResponseStreaming
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	[DebuggerNonUserCode]
	public string ResponseTypeUrl
	{
		 get { } //Length: 11
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public Syntax Syntax
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private static Method() { }

	[DebuggerNonUserCode]
	public Method() { }

	[DebuggerNonUserCode]
	public Method(Method other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override Method Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(Method other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public string get_Name() { }

	public RepeatedField<Option> get_Options() { }

	public static MessageParser<Method> get_Parser() { }

	public bool get_RequestStreaming() { }

	public string get_RequestTypeUrl() { }

	public bool get_ResponseStreaming() { }

	public string get_ResponseTypeUrl() { }

	public Syntax get_Syntax() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(Method other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_RequestStreaming(bool value) { }

	public void set_RequestTypeUrl(string value) { }

	public void set_ResponseStreaming(bool value) { }

	public void set_ResponseTypeUrl(string value) { }

	public void set_Syntax(Syntax value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

