namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Interface (1024), Inherited = False)]
[ComVisible(True)]
public sealed class InterfaceTypeAttribute : Attribute
{
	internal ComInterfaceType _val; //Field offset: 0x8

	public InterfaceTypeAttribute(ComInterfaceType interfaceType) { }

}

