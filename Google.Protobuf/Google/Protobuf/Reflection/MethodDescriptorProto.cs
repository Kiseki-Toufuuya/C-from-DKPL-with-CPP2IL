namespace Google.Protobuf.Reflection;

internal sealed class MethodDescriptorProto : IMessage<MethodDescriptorProto>, IMessage, IEquatable<MethodDescriptorProto>, IDeepCloneable<MethodDescriptorProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal MethodDescriptorProto <.cctor>b__74_0() { }

	}

	private static readonly MessageParser<MethodDescriptorProto> _parser; //Field offset: 0x0
	public const int ServerStreamingFieldNumber = 6; //Field offset: 0x0
	public const int ClientStreamingFieldNumber = 5; //Field offset: 0x0
	public const int OptionsFieldNumber = 4; //Field offset: 0x0
	public const int InputTypeFieldNumber = 2; //Field offset: 0x0
	public const int OutputTypeFieldNumber = 3; //Field offset: 0x0
	public const int NameFieldNumber = 1; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x4
	private static readonly string InputTypeDefaultValue; //Field offset: 0x8
	private static readonly string OutputTypeDefaultValue; //Field offset: 0xC
	private static readonly bool ClientStreamingDefaultValue; //Field offset: 0x10
	private static readonly bool ServerStreamingDefaultValue; //Field offset: 0x11
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private int _hasBits0; //Field offset: 0xC
	private string name_; //Field offset: 0x10
	private string inputType_; //Field offset: 0x14
	private string outputType_; //Field offset: 0x18
	private MethodOptions options_; //Field offset: 0x1C
	private bool clientStreaming_; //Field offset: 0x20
	private bool serverStreaming_; //Field offset: 0x21

	[DebuggerNonUserCode]
	public bool ClientStreaming
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public bool HasClientStreaming
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasInputType
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasName
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasOptions
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasOutputType
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasServerStreaming
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public string InputType
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public MethodOptions Options
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[DebuggerNonUserCode]
	public string OutputType
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public static MessageParser<MethodDescriptorProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public bool ServerStreaming
	{
		 get { } //Length: 79
		 set { } //Length: 18
	}

	private static MethodDescriptorProto() { }

	[DebuggerNonUserCode]
	public MethodDescriptorProto() { }

	[DebuggerNonUserCode]
	public MethodDescriptorProto(MethodDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public void ClearClientStreaming() { }

	[DebuggerNonUserCode]
	public void ClearInputType() { }

	[DebuggerNonUserCode]
	public void ClearName() { }

	[DebuggerNonUserCode]
	public void ClearOptions() { }

	[DebuggerNonUserCode]
	public void ClearOutputType() { }

	[DebuggerNonUserCode]
	public void ClearServerStreaming() { }

	[DebuggerNonUserCode]
	public override MethodDescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(MethodDescriptorProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public bool get_ClientStreaming() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasClientStreaming() { }

	public bool get_HasInputType() { }

	public bool get_HasName() { }

	public bool get_HasOptions() { }

	public bool get_HasOutputType() { }

	public bool get_HasServerStreaming() { }

	public string get_InputType() { }

	public string get_Name() { }

	public MethodOptions get_Options() { }

	public string get_OutputType() { }

	public static MessageParser<MethodDescriptorProto> get_Parser() { }

	public bool get_ServerStreaming() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(MethodDescriptorProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_ClientStreaming(bool value) { }

	public void set_InputType(string value) { }

	public void set_Name(string value) { }

	public void set_Options(MethodOptions value) { }

	public void set_OutputType(string value) { }

	public void set_ServerStreaming(bool value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

