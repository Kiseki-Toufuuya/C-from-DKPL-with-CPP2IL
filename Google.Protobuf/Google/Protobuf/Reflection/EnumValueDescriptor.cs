namespace Google.Protobuf.Reflection;

public sealed class EnumValueDescriptor : DescriptorBase
{
	private readonly EnumDescriptor enumDescriptor; //Field offset: 0x14
	private readonly EnumValueDescriptorProto proto; //Field offset: 0x18

	public CustomOptions CustomOptions
	{
		 get { } //Length: 93
	}

	public EnumDescriptor EnumDescriptor
	{
		 get { } //Length: 11
	}

	public virtual string Name
	{
		 get { } //Length: 34
	}

	public int Number
	{
		 get { } //Length: 34
	}

	internal EnumValueDescriptorProto Proto
	{
		internal get { } //Length: 11
	}

	internal EnumValueDescriptor(EnumValueDescriptorProto proto, FileDescriptor file, EnumDescriptor parent, int index) { }

	public CustomOptions get_CustomOptions() { }

	public EnumDescriptor get_EnumDescriptor() { }

	public virtual string get_Name() { }

	public int get_Number() { }

	internal EnumValueDescriptorProto get_Proto() { }

}

