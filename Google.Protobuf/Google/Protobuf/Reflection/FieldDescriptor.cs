namespace Google.Protobuf.Reflection;

public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor>
{
	private EnumDescriptor enumType; //Field offset: 0x14
	private MessageDescriptor messageType; //Field offset: 0x18
	private FieldType fieldType; //Field offset: 0x1C
	private readonly string propertyName; //Field offset: 0x20
	private IFieldAccessor accessor; //Field offset: 0x24
	[CompilerGenerated]
	private readonly MessageDescriptor <ContainingType>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly OneofDescriptor <ContainingOneof>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private readonly string <JsonName>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly FieldDescriptorProto <Proto>k__BackingField; //Field offset: 0x34

	public IFieldAccessor Accessor
	{
		 get { } //Length: 11
	}

	public OneofDescriptor ContainingOneof
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

	public EnumDescriptor EnumType
	{
		 get { } //Length: 82
	}

	public int FieldNumber
	{
		 get { } //Length: 34
	}

	public FieldType FieldType
	{
		 get { } //Length: 11
	}

	public bool IsMap
	{
		 get { } //Length: 62
	}

	public bool IsPacked
	{
		 get { } //Length: 160
	}

	public bool IsRepeated
	{
		 get { } //Length: 37
	}

	public bool IsRequired
	{
		 get { } //Length: 37
	}

	public string JsonName
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public MessageDescriptor MessageType
	{
		 get { } //Length: 88
	}

	public virtual string Name
	{
		 get { } //Length: 34
	}

	internal FieldDescriptorProto Proto
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName) { }

	public override int CompareTo(FieldDescriptor other) { }

	private IFieldAccessor CreateAccessor() { }

	internal void CrossLink() { }

	public IFieldAccessor get_Accessor() { }

	[CompilerGenerated]
	public OneofDescriptor get_ContainingOneof() { }

	[CompilerGenerated]
	public MessageDescriptor get_ContainingType() { }

	public CustomOptions get_CustomOptions() { }

	public EnumDescriptor get_EnumType() { }

	public int get_FieldNumber() { }

	public FieldType get_FieldType() { }

	public bool get_IsMap() { }

	public bool get_IsPacked() { }

	public bool get_IsRepeated() { }

	public bool get_IsRequired() { }

	[CompilerGenerated]
	public string get_JsonName() { }

	public MessageDescriptor get_MessageType() { }

	public virtual string get_Name() { }

	[CompilerGenerated]
	internal FieldDescriptorProto get_Proto() { }

	private static FieldType GetFieldTypeFromProtoType(Type type) { }

}

