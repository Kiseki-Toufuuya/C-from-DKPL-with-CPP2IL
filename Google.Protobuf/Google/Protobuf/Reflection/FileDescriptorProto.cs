namespace Google.Protobuf.Reflection;

internal sealed class FileDescriptorProto : IMessage<FileDescriptorProto>, IMessage, IEquatable<FileDescriptorProto>, IDeepCloneable<FileDescriptorProto>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal FileDescriptorProto <.cctor>b__98_0() { }

	}

	private static readonly MessageParser<FileDescriptorProto> _parser; //Field offset: 0x0
	public const int SyntaxFieldNumber = 12; //Field offset: 0x0
	public const int SourceCodeInfoFieldNumber = 9; //Field offset: 0x0
	public const int OptionsFieldNumber = 8; //Field offset: 0x0
	public const int ExtensionFieldNumber = 7; //Field offset: 0x0
	public const int ServiceFieldNumber = 6; //Field offset: 0x0
	public const int EnumTypeFieldNumber = 5; //Field offset: 0x0
	public const int WeakDependencyFieldNumber = 11; //Field offset: 0x0
	public const int PublicDependencyFieldNumber = 10; //Field offset: 0x0
	public const int MessageTypeFieldNumber = 4; //Field offset: 0x0
	public const int DependencyFieldNumber = 3; //Field offset: 0x0
	public const int NameFieldNumber = 1; //Field offset: 0x0
	public const int PackageFieldNumber = 2; //Field offset: 0x0
	private static readonly string NameDefaultValue; //Field offset: 0x4
	private static readonly string PackageDefaultValue; //Field offset: 0x8
	private static readonly FieldCodec<String> _repeated_dependency_codec; //Field offset: 0xC
	private static readonly FieldCodec<Int32> _repeated_publicDependency_codec; //Field offset: 0x10
	private static readonly FieldCodec<Int32> _repeated_weakDependency_codec; //Field offset: 0x14
	private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec; //Field offset: 0x18
	private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; //Field offset: 0x1C
	private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec; //Field offset: 0x20
	private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; //Field offset: 0x24
	private static readonly string SyntaxDefaultValue; //Field offset: 0x28
	private UnknownFieldSet _unknownFields; //Field offset: 0x8
	private string name_; //Field offset: 0xC
	private string package_; //Field offset: 0x10
	private readonly RepeatedField<String> dependency_; //Field offset: 0x14
	private readonly RepeatedField<Int32> publicDependency_; //Field offset: 0x18
	private readonly RepeatedField<Int32> weakDependency_; //Field offset: 0x1C
	private readonly RepeatedField<DescriptorProto> messageType_; //Field offset: 0x20
	private readonly RepeatedField<EnumDescriptorProto> enumType_; //Field offset: 0x24
	private readonly RepeatedField<ServiceDescriptorProto> service_; //Field offset: 0x28
	private readonly RepeatedField<FieldDescriptorProto> extension_; //Field offset: 0x2C
	private FileOptions options_; //Field offset: 0x30
	private SourceCodeInfo sourceCodeInfo_; //Field offset: 0x34
	private string syntax_; //Field offset: 0x38

	[DebuggerNonUserCode]
	public RepeatedField<String> Dependency
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 154
	}

	[DebuggerNonUserCode]
	public RepeatedField<EnumDescriptorProto> EnumType
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<FieldDescriptorProto> Extension
	{
		 get { } //Length: 11
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
	public bool HasPackage
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasSourceCodeInfo
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public bool HasSyntax
	{
		 get { } //Length: 15
	}

	[DebuggerNonUserCode]
	public RepeatedField<DescriptorProto> MessageType
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public string Name
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public FileOptions Options
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[DebuggerNonUserCode]
	public string Package
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public static MessageParser<FileDescriptorProto> Parser
	{
		 get { } //Length: 60
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 203
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> PublicDependency
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public RepeatedField<ServiceDescriptorProto> Service
	{
		 get { } //Length: 11
	}

	[DebuggerNonUserCode]
	public SourceCodeInfo SourceCodeInfo
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	[DebuggerNonUserCode]
	public string Syntax
	{
		 get { } //Length: 75
		 set { } //Length: 83
	}

	[DebuggerNonUserCode]
	public RepeatedField<Int32> WeakDependency
	{
		 get { } //Length: 11
	}

	private static FileDescriptorProto() { }

	[DebuggerNonUserCode]
	public FileDescriptorProto() { }

	[DebuggerNonUserCode]
	public FileDescriptorProto(FileDescriptorProto other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public void ClearName() { }

	[DebuggerNonUserCode]
	public void ClearOptions() { }

	[DebuggerNonUserCode]
	public void ClearPackage() { }

	[DebuggerNonUserCode]
	public void ClearSourceCodeInfo() { }

	[DebuggerNonUserCode]
	public void ClearSyntax() { }

	[DebuggerNonUserCode]
	public override FileDescriptorProto Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(FileDescriptorProto other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public RepeatedField<String> get_Dependency() { }

	public static MessageDescriptor get_Descriptor() { }

	public RepeatedField<EnumDescriptorProto> get_EnumType() { }

	public RepeatedField<FieldDescriptorProto> get_Extension() { }

	public bool get_HasName() { }

	public bool get_HasOptions() { }

	public bool get_HasPackage() { }

	public bool get_HasSourceCodeInfo() { }

	public bool get_HasSyntax() { }

	public RepeatedField<DescriptorProto> get_MessageType() { }

	public string get_Name() { }

	public FileOptions get_Options() { }

	public string get_Package() { }

	public static MessageParser<FileDescriptorProto> get_Parser() { }

	public RepeatedField<Int32> get_PublicDependency() { }

	public RepeatedField<ServiceDescriptorProto> get_Service() { }

	public SourceCodeInfo get_SourceCodeInfo() { }

	public string get_Syntax() { }

	public RepeatedField<Int32> get_WeakDependency() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(FileDescriptorProto other) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Name(string value) { }

	public void set_Options(FileOptions value) { }

	public void set_Package(string value) { }

	public void set_SourceCodeInfo(SourceCodeInfo value) { }

	public void set_Syntax(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

