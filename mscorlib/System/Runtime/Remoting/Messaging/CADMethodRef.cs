namespace System.Runtime.Remoting.Messaging;

internal class CADMethodRef
{
	private bool ctor; //Field offset: 0x8
	private string typeName; //Field offset: 0xC
	private string methodName; //Field offset: 0x10
	private String[] param_names; //Field offset: 0x14
	private String[] generic_arg_names; //Field offset: 0x18

	public CADMethodRef(IMethodMessage msg) { }

	private Type[] GetTypes(String[] typeArray) { }

	public MethodBase Resolve() { }

}

