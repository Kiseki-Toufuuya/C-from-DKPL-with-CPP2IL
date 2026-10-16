namespace CriWare;

public class CriFsWebInstaller : CriDisposable
{
	internal enum Error
	{
		None = 0,
		Timeout = 1,
		Memory = 2,
		LocalFs = 3,
		DNS = 4,
		Connection = 5,
		SSL = 6,
		HTTP = 7,
		Internal = 8,
	}

	internal struct ModuleConfig
	{
		public uint numInstallers; //Field offset: 0x0
		public string proxyHost; //Field offset: 0x4
		public ushort proxyPort; //Field offset: 0x8
		public string userAgent; //Field offset: 0xC
		public uint inactiveTimeoutSec; //Field offset: 0x10
		public bool allowInsecureSSL; //Field offset: 0x14
		public bool crcEnabled; //Field offset: 0x15
		public ModulePlatformConfig platformConfig; //Field offset: 0x16

	}

	internal struct ModulePlatformConfig
	{
		public byte reserved; //Field offset: 0x0

		public static ModulePlatformConfig defaultConfig
		{
			 get { } //Length: 3
		}

		public static ModulePlatformConfig get_defaultConfig() { }

	}

	internal enum Status
	{
		Stop = 0,
		Busy = 1,
		Complete = 2,
		Error = 3,
	}

	internal struct StatusInfo
	{
		public Status status; //Field offset: 0x0
		public Error error; //Field offset: 0x4
		public int httpStatusCode; //Field offset: 0x8
		public long contentsSize; //Field offset: 0x10
		public long receivedSize; //Field offset: 0x18

	}

	[CompilerGenerated]
	private static bool <isInitialized>k__BackingField; //Field offset: 0x0
	public const int InvalidHttpStatusCode = -1; //Field offset: 0x0
	public const long InvalidContentsSize = -1; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <isCrcEnabled>k__BackingField; //Field offset: 0x1
	private IntPtr handle; //Field offset: 0x18

	public static ModuleConfig defaultModuleConfig
	{
		 get { } //Length: 103
	}

	public private static bool isCrcEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 48
	}

	public private static bool isInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 47
	}

	public CriFsWebInstaller() { }

	public void Copy(string url, string dstPath) { }

	private static int criFsWebInstaller_Copy(IntPtr installer, string url, string dstPath) { }

	private static int criFsWebInstaller_Create(out IntPtr installer) { }

	private static int criFsWebInstaller_Destroy(IntPtr installer) { }

	private static int criFsWebInstaller_ExecuteMain() { }

	private static int criFsWebInstaller_Finalize() { }

	private static int criFsWebInstaller_GetCRC32(IntPtr installer, out uint crc32) { }

	private static int criFsWebInstaller_GetStatusInfo(IntPtr installer, out StatusInfo status) { }

	private static int criFsWebInstaller_Initialize(in ModuleConfig config) { }

	private static int criFsWebInstaller_SetRequestHeader(string field, string value) { }

	private static int criFsWebInstaller_Stop(IntPtr installer) { }

	public virtual void Dispose() { }

	private void Dispose(bool disposing) { }

	public static void ExecuteMain() { }

	protected virtual void Finalize() { }

	public static void FinalizeModule() { }

	public static ModuleConfig get_defaultModuleConfig() { }

	[CompilerGenerated]
	public static bool get_isCrcEnabled() { }

	[CompilerGenerated]
	public static bool get_isInitialized() { }

	public bool GetCRC32(out uint ret_val) { }

	private static Type GetCriFsWebInstallerCurlExpansionClass() { }

	public StatusInfo GetStatusInfo() { }

	public static void InitializeModule(ModuleConfig config) { }

	[CompilerGenerated]
	private static void set_isCrcEnabled(bool value) { }

	[CompilerGenerated]
	private static void set_isInitialized(bool value) { }

	public static bool SetRequestHeader(string field, string value) { }

	public void Stop() { }

}

