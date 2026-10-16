namespace Google.Protobuf.Reflection;

public sealed class OneofAccessor
{
	private readonly Func<IMessage, Int32> caseDelegate; //Field offset: 0x8
	private readonly Action<IMessage> clearDelegate; //Field offset: 0xC
	private OneofDescriptor descriptor; //Field offset: 0x10

	public OneofDescriptor Descriptor
	{
		 get { } //Length: 11
	}

	internal OneofAccessor(PropertyInfo caseProperty, MethodInfo clearMethod, OneofDescriptor descriptor) { }

	public void Clear(IMessage message) { }

	public OneofDescriptor get_Descriptor() { }

	public FieldDescriptor GetCaseFieldDescriptor(IMessage message) { }

}

