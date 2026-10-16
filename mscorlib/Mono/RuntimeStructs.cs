namespace Mono;

internal static class RuntimeStructs
{
	public struct GenericParamInfo
	{
		internal MonoClass* pklass; //Field offset: 0x0
		internal IntPtr name; //Field offset: 0x4
		internal ushort flags; //Field offset: 0x8
		internal uint token; //Field offset: 0xC
		internal MonoClass** constraints; //Field offset: 0x10

	}

	public struct GPtrArray
	{
		internal IntPtr* data; //Field offset: 0x0
		internal int len; //Field offset: 0x4

	}

	public struct MonoClass
	{

	}

	public struct RemoteClass
	{
		internal IntPtr default_vtable; //Field offset: 0x0
		internal IntPtr xdomain_vtable; //Field offset: 0x4
		internal MonoClass* proxy_class; //Field offset: 0x8
		internal IntPtr proxy_class_name; //Field offset: 0xC
		internal uint interface_count; //Field offset: 0x10

	}


}

