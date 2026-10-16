namespace Microsoft.Win32;

public static class Registry
{
	public static readonly RegistryKey CurrentUser; //Field offset: 0x0
	public static readonly RegistryKey LocalMachine; //Field offset: 0x4
	public static readonly RegistryKey ClassesRoot; //Field offset: 0x8
	public static readonly RegistryKey Users; //Field offset: 0xC
	public static readonly RegistryKey PerformanceData; //Field offset: 0x10
	public static readonly RegistryKey CurrentConfig; //Field offset: 0x14
	[Obsolete("Use PerformanceData instead")]
	public static readonly RegistryKey DynData; //Field offset: 0x18

	private static Registry() { }

}

