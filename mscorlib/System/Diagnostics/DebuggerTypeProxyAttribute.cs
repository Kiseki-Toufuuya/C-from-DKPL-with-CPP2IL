namespace System.Diagnostics;

[AttributeUsage(13, AllowMultiple = True)]
[ComVisible(True)]
public sealed class DebuggerTypeProxyAttribute : Attribute
{
	private string typeName; //Field offset: 0x8

	public DebuggerTypeProxyAttribute(Type type) { }

}

