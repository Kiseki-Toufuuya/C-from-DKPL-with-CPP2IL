namespace Google.Protobuf.Reflection;

public sealed class MethodDescriptor : DescriptorBase
{
	private readonly MethodDescriptorProto proto; //Field offset: 0x14
	private readonly ServiceDescriptor service; //Field offset: 0x18
	private MessageDescriptor inputType; //Field offset: 0x1C
	private MessageDescriptor outputType; //Field offset: 0x20

	public CustomOptions CustomOptions
	{
		 get { } //Length: 93
	}

	public MessageDescriptor InputType
	{
		 get { } //Length: 11
	}

	public bool IsClientStreaming
	{
		 get { } //Length: 34
	}

	public bool IsServerStreaming
	{
		 get { } //Length: 34
	}

	public virtual string Name
	{
		 get { } //Length: 34
	}

	public MessageDescriptor OutputType
	{
		 get { } //Length: 11
	}

	internal MethodDescriptorProto Proto
	{
		internal get { } //Length: 11
	}

	public ServiceDescriptor Service
	{
		 get { } //Length: 11
	}

	internal MethodDescriptor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index) { }

	internal void CrossLink() { }

	public CustomOptions get_CustomOptions() { }

	public MessageDescriptor get_InputType() { }

	public bool get_IsClientStreaming() { }

	public bool get_IsServerStreaming() { }

	public virtual string get_Name() { }

	public MessageDescriptor get_OutputType() { }

	internal MethodDescriptorProto get_Proto() { }

	public ServiceDescriptor get_Service() { }

}

