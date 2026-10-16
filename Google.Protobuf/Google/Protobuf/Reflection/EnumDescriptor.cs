namespace Google.Protobuf.Reflection;

public sealed class EnumDescriptor : DescriptorBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public FileDescriptor file; //Field offset: 0x8
		public EnumDescriptor <>4__this; //Field offset: 0xC

		public <>c__DisplayClass4_0() { }

		internal EnumValueDescriptor <.ctor>b__0(EnumValueDescriptorProto value, int i) { }

	}

	private readonly EnumDescriptorProto proto; //Field offset: 0x14
	private readonly MessageDescriptor containingType; //Field offset: 0x18
	private readonly IList<EnumValueDescriptor> values; //Field offset: 0x1C
	private readonly Type clrType; //Field offset: 0x20

	public Type ClrType
	{
		 get { } //Length: 11
	}

	public MessageDescriptor ContainingType
	{
		 get { } //Length: 11
	}

	public CustomOptions CustomOptions
	{
		 get { } //Length: 93
	}

	public virtual string Name
	{
		 get { } //Length: 34
	}

	internal EnumDescriptorProto Proto
	{
		internal get { } //Length: 11
	}

	public IList<EnumValueDescriptor> Values
	{
		 get { } //Length: 11
	}

	internal EnumDescriptor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, Type clrType) { }

	public EnumValueDescriptor FindValueByName(string name) { }

	public EnumValueDescriptor FindValueByNumber(int number) { }

	public Type get_ClrType() { }

	public MessageDescriptor get_ContainingType() { }

	public CustomOptions get_CustomOptions() { }

	public virtual string get_Name() { }

	internal EnumDescriptorProto get_Proto() { }

	public IList<EnumValueDescriptor> get_Values() { }

	internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

}

