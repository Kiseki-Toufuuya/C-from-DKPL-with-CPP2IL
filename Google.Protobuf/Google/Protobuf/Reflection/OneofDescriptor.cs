namespace Google.Protobuf.Reflection;

public sealed class OneofDescriptor : DescriptorBase
{
	private readonly OneofDescriptorProto proto; //Field offset: 0x14
	private MessageDescriptor containingType; //Field offset: 0x18
	private IList<FieldDescriptor> fields; //Field offset: 0x1C
	private readonly OneofAccessor accessor; //Field offset: 0x20

	public OneofAccessor Accessor
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

	public IList<FieldDescriptor> Fields
	{
		 get { } //Length: 11
	}

	public virtual string Name
	{
		 get { } //Length: 34
	}

	internal OneofDescriptor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName) { }

	private OneofAccessor CreateAccessor(string clrName) { }

	internal void CrossLink() { }

	public OneofAccessor get_Accessor() { }

	public MessageDescriptor get_ContainingType() { }

	public CustomOptions get_CustomOptions() { }

	public IList<FieldDescriptor> get_Fields() { }

	public virtual string get_Name() { }

}

