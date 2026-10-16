namespace Google.Protobuf.Reflection;

public sealed class MessageDescriptor : DescriptorBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FieldDescriptor, Int32> <>9__4_4; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__4_4(FieldDescriptor field) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public FileDescriptor file; //Field offset: 0x8
		public MessageDescriptor <>4__this; //Field offset: 0xC
		public GeneratedClrTypeInfo generatedCodeInfo; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal OneofDescriptor <.ctor>b__0(OneofDescriptorProto oneof, int index) { }

		internal MessageDescriptor <.ctor>b__1(DescriptorProto type, int index) { }

		internal EnumDescriptor <.ctor>b__2(EnumDescriptorProto type, int index) { }

		internal FieldDescriptor <.ctor>b__3(FieldDescriptorProto field, int index) { }

	}

	[DefaultMember("Item")]
	internal sealed class FieldCollection
	{
		private readonly MessageDescriptor messageDescriptor; //Field offset: 0x8

		public FieldDescriptor Item
		{
			 get { } //Length: 103
		}

		public FieldDescriptor Item
		{
			 get { } //Length: 182
		}

		internal FieldCollection(MessageDescriptor messageDescriptor) { }

		internal IDictionary<String, FieldDescriptor> ByJsonName() { }

		public FieldDescriptor get_Item(int number) { }

		public FieldDescriptor get_Item(string name) { }

		public IList<FieldDescriptor> InDeclarationOrder() { }

		public IList<FieldDescriptor> InFieldNumberOrder() { }

	}

	private static readonly HashSet<String> WellKnownTypeNames; //Field offset: 0x0
	private readonly IList<FieldDescriptor> fieldsInDeclarationOrder; //Field offset: 0x14
	private readonly IList<FieldDescriptor> fieldsInNumberOrder; //Field offset: 0x18
	private readonly IDictionary<String, FieldDescriptor> jsonFieldMap; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly DescriptorProto <Proto>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Type <ClrType>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private readonly MessageParser <Parser>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly MessageDescriptor <ContainingType>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private readonly FieldCollection <Fields>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly IList<MessageDescriptor> <NestedTypes>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private readonly IList<EnumDescriptor> <EnumTypes>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly IList<OneofDescriptor> <Oneofs>k__BackingField; //Field offset: 0x3C

	public Type ClrType
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public MessageDescriptor ContainingType
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public CustomOptions CustomOptions
	{
		 get { } //Length: 93
	}

	public IList<EnumDescriptor> EnumTypes
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public FieldCollection Fields
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal bool IsWellKnownType
	{
		internal get { } //Length: 187
	}

	internal bool IsWrapperType
	{
		internal get { } //Length: 139
	}

	public virtual string Name
	{
		 get { } //Length: 34
	}

	public IList<MessageDescriptor> NestedTypes
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public IList<OneofDescriptor> Oneofs
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public MessageParser Parser
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal DescriptorProto Proto
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	private static MessageDescriptor() { }

	internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo) { }

	private static ReadOnlyDictionary<String, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields) { }

	internal void CrossLink() { }

	public T FindDescriptor(string name) { }

	public FieldDescriptor FindFieldByName(string name) { }

	public FieldDescriptor FindFieldByNumber(int number) { }

	[CompilerGenerated]
	public Type get_ClrType() { }

	[CompilerGenerated]
	public MessageDescriptor get_ContainingType() { }

	public CustomOptions get_CustomOptions() { }

	[CompilerGenerated]
	public IList<EnumDescriptor> get_EnumTypes() { }

	[CompilerGenerated]
	public FieldCollection get_Fields() { }

	internal bool get_IsWellKnownType() { }

	internal bool get_IsWrapperType() { }

	public virtual string get_Name() { }

	[CompilerGenerated]
	public IList<MessageDescriptor> get_NestedTypes() { }

	[CompilerGenerated]
	public IList<OneofDescriptor> get_Oneofs() { }

	[CompilerGenerated]
	public MessageParser get_Parser() { }

	[CompilerGenerated]
	internal DescriptorProto get_Proto() { }

	internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

}

