namespace CriWare;

public static class CriFsPlugin
{
	private static int initializationCount; //Field offset: 0x0
	private static bool isConfigured; //Field offset: 0x4
	public static int defaultInstallBufferSize; //Field offset: 0x8
	public static int installBufferSize; //Field offset: 0xC

	public static bool isInitialized
	{
		 get { } //Length: 64
	}

	private static CriFsPlugin() { }

	private static int criFs_SetReadDeviceEnabled(int device_id, bool enabled) { }

	public static uint criFsLoader_GetRetryCount() { }

	public static uint CRIWARE8E37F276() { }

	private static void CRIWARE9F5E410B() { }

	public static bool CRIWAREBECB0D29() { }

	private static void CRIWAREC1618061() { }

	private static void CRIWAREC43AA84E(int num_loaders, int num_binders, int num_installers, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check) { }

	public static void FinalizeLibrary() { }

	public static bool get_isInitialized() { }

	public static void InitializeLibrary() { }

	public static bool IsLibraryInitialized() { }

	public static void SetConfigAdditionalParameters_ANDROID(int device_read_bps) { }

	public static void SetConfigAdditionalParameters_EDITOR(int additionalLoaders) { }

	public static void SetConfigParameters(int num_loaders, int num_binders, int num_installers, int argInstallBufferSize, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check) { }

	public static void SetDataDecompressionThreadPriorityExperimentalAndroid(int prio) { }

	public static void SetMemoryFileSystemThreadPriorityExperimentalAndroid(int prio) { }

	public static void SetReadDeviceEnabled(int deviceId, bool enabled) { }

}

