namespace Google.Protobuf.Reflection;

public sealed class FileDescriptor : IDescriptor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FileDescriptor, String> <>9__9_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal string <DeterminePublicDependencies>b__9_0(FileDescriptor file) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public FileDescriptor <>4__this; //Field offset: 0x8
		public GeneratedClrTypeInfo generatedCodeInfo; //Field offset: 0xC

		public <>c__DisplayClass2_0() { }

		internal MessageDescriptor <.ctor>b__0(DescriptorProto message, int index) { }

		internal EnumDescriptor <.ctor>b__1(EnumDescriptorProto enumType, int index) { }

		internal ServiceDescriptor <.ctor>b__2(ServiceDescriptorProto service, int index) { }

	}

	private readonly Lazy<Dictionary`2<IDescriptor, DescriptorDeclaration>> declarations; //Field offset: 0x8
	[CompilerGenerated]
	private readonly FileDescriptorProto <Proto>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly IList<MessageDescriptor> <MessageTypes>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly IList<EnumDescriptor> <EnumTypes>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly IList<ServiceDescriptor> <Services>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly IList<FileDescriptor> <Dependencies>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly IList<FileDescriptor> <PublicDependencies>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly ByteString <SerializedData>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private readonly DescriptorPool <DescriptorPool>k__BackingField; //Field offset: 0x28

	public CustomOptions CustomOptions
	{
		 get { } //Length: 93
	}

	public IList<FileDescriptor> Dependencies
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal DescriptorPool DescriptorPool
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	public static FileDescriptor DescriptorProtoFileDescriptor
	{
		 get { } //Length: 114
	}

	public IList<EnumDescriptor> EnumTypes
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	private override FileDescriptor Google.Protobuf.Reflection.IDescriptor.File
	{
		private get { } //Length: 8
	}

	private override string Google.Protobuf.Reflection.IDescriptor.FullName
	{
		private get { } //Length: 34
	}

	public IList<MessageDescriptor> MessageTypes
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public override string Name
	{
		 get { } //Length: 34
	}

	public string Package
	{
		 get { } //Length: 34
	}

	internal FileDescriptorProto Proto
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	public IList<FileDescriptor> PublicDependencies
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public ByteString SerializedData
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public IList<ServiceDescriptor> Services
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	private static FileDescriptor() { }

	private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) { }

	private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) { }

	public static IReadOnlyList<FileDescriptor> BuildFromByteStrings(IEnumerable<ByteString> descriptorData) { }

	internal string ComputeFullName(MessageDescriptor parent, string name) { }

	private Dictionary<IDescriptor, DescriptorDeclaration> CreateDeclarationMap() { }

	private void CrossLink() { }

	private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor this, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, bool allowUnknownDependencies) { }

	private IDescriptor FindDescriptorForPath(IList<Int32> path) { }

	public T FindTypeByName(string name) { }

	public static void ForceReflectionInitialization() { }

	public static FileDescriptor FromGeneratedCode(Byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo) { }

	public CustomOptions get_CustomOptions() { }

	[CompilerGenerated]
	public IList<FileDescriptor> get_Dependencies() { }

	[CompilerGenerated]
	internal DescriptorPool get_DescriptorPool() { }

	public static FileDescriptor get_DescriptorProtoFileDescriptor() { }

	[CompilerGenerated]
	public IList<EnumDescriptor> get_EnumTypes() { }

	[CompilerGenerated]
	public IList<MessageDescriptor> get_MessageTypes() { }

	public override string get_Name() { }

	public string get_Package() { }

	[CompilerGenerated]
	internal FileDescriptorProto get_Proto() { }

	[CompilerGenerated]
	public IList<FileDescriptor> get_PublicDependencies() { }

	[CompilerGenerated]
	public ByteString get_SerializedData() { }

	[CompilerGenerated]
	public IList<ServiceDescriptor> get_Services() { }

	internal DescriptorDeclaration GetDeclaration(IDescriptor descriptor) { }

	private DescriptorBase GetDescriptorFromList(IReadOnlyList<DescriptorBase> list, int index) { }

	private IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

	private override FileDescriptor Google.Protobuf.Reflection.IDescriptor.get_File() { }

	private override string Google.Protobuf.Reflection.IDescriptor.get_FullName() { }

	public virtual string ToString() { }

}

