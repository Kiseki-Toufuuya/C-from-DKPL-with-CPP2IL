namespace System.Runtime.InteropServices;

[AttributeUsage(5149, Inherited = False)]
[ComVisible(True)]
public sealed class GuidAttribute : Attribute
{
	internal string _val; //Field offset: 0x8

	public GuidAttribute(string guid) { }

}

