namespace Mono.Btls;

internal static class MonoBtlsX509StoreManager
{
	private static bool initialized; //Field offset: 0x0
	private static string machineTrustedRootPath; //Field offset: 0x4
	private static string machineIntermediateCAPath; //Field offset: 0x8
	private static string machineUntrustedPath; //Field offset: 0xC
	private static string userTrustedRootPath; //Field offset: 0x10
	private static string userIntermediateCAPath; //Field offset: 0x14
	private static string userUntrustedPath; //Field offset: 0x18

	private static void DoInitialize() { }

	public static string GetStorePath(MonoBtlsX509StoreType type) { }

	private static void Initialize() { }

}

