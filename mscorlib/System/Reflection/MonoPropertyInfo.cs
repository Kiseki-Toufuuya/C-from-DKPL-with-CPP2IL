namespace System.Reflection;

internal struct MonoPropertyInfo
{
	public Type parent; //Field offset: 0x0
	public Type declaring_type; //Field offset: 0x4
	public string name; //Field offset: 0x8
	public MethodInfo get_method; //Field offset: 0xC
	public MethodInfo set_method; //Field offset: 0x10
	public PropertyAttributes attrs; //Field offset: 0x14

}

