namespace Google.Protobuf.Reflection;

public sealed class ServiceDescriptor : DescriptorBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public FileDescriptor file; //Field offset: 0x8
		public ServiceDescriptor <>4__this; //Field offset: 0xC

		public <>c__DisplayClass2_0() { }

		internal MethodDescriptor <.ctor>b__0(MethodDescriptorProto method, int i) { }

	}

	private readonly ServiceDescriptorProto proto; //Field offset: 0x14
	private readonly IList<MethodDescriptor> methods; //Field offset: 0x18

	public CustomOptions CustomOptions
	{
		 get { } //Length: 93
	}

	public IList<MethodDescriptor> Methods
	{
		 get { } //Length: 11
	}

	public virtual string Name
	{
		 get { } //Length: 34
	}

	internal ServiceDescriptorProto Proto
	{
		internal get { } //Length: 11
	}

	internal ServiceDescriptor(ServiceDescriptorProto proto, FileDescriptor file, int index) { }

	internal void CrossLink() { }

	public MethodDescriptor FindMethodByName(string name) { }

	public CustomOptions get_CustomOptions() { }

	public IList<MethodDescriptor> get_Methods() { }

	public virtual string get_Name() { }

	internal ServiceDescriptorProto get_Proto() { }

	internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

}

