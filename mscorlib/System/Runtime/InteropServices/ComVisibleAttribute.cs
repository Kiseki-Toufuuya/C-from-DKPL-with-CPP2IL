namespace System.Runtime.InteropServices;

[AttributeUsage(5597, Inherited = False)]
[ComVisible(True)]
public sealed class ComVisibleAttribute : Attribute
{
	internal bool _val; //Field offset: 0x8

	public ComVisibleAttribute(bool visibility) { }

}

