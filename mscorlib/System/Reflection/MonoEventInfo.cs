namespace System.Reflection;

internal struct MonoEventInfo
{
	public Type declaring_type; //Field offset: 0x0
	public Type reflected_type; //Field offset: 0x4
	public string name; //Field offset: 0x8
	public MethodInfo add_method; //Field offset: 0xC
	public MethodInfo remove_method; //Field offset: 0x10
	public MethodInfo raise_method; //Field offset: 0x14
	public EventAttributes attrs; //Field offset: 0x18
	public MethodInfo[] other_methods; //Field offset: 0x1C

}

