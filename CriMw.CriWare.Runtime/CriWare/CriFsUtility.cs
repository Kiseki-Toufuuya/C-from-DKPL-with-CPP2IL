namespace CriWare;

public static class CriFsUtility
{
	public const int DefaultReadUnitSize = 1048576; //Field offset: 0x0

	public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, string srcPath) { }

	public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath) { }

	public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath) { }

	public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, string srcPath) { }

	public static CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath) { }

	public static CriFsBindRequest BindFile(CriFsBinder targetBinder, string srcPath) { }

	private static bool CRIWARE43980959(string userAgentString) { }

	private static bool CRIWAREA5DCE646(string proxyPath, ushort proxyPort) { }

	private static bool CRIWAREC8E7BDEF(string filter) { }

	[Obsolete("CriFsUtility.Install is no longer working. Use CriFsUtility.WebInstall instead.")]
	public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath) { }

	[Obsolete("CriFsUtility.Install is no longer working. Use CriFsUtility.WebInstall instead.")]
	public static CriFsInstallRequest Install(string srcPath, string dstPath, DoneDelegate doneDeleagate) { }

	[Obsolete("CriFsUtility.Install is no longer working. Use CriFsUtility.WebInstall instead.")]
	public static CriFsInstallRequest Install(string srcPath, string dstPath) { }

	[Obsolete("CriFsUtility.Install is no longer working. Use CriFsUtility.WebInstall instead.")]
	public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, DoneDelegate doneDeleagate) { }

	public static CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize = 1048576) { }

	public static CriFsLoadAssetBundleRequest LoadAssetBundle(string path, int readUnitSize = 1048576) { }

	public static CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, int readUnitSize = 1048576) { }

	public static CriFsLoadFileRequest LoadFile(string path, DoneDelegate doneDelegate, int readUnitSize = 1048576) { }

	public static CriFsLoadFileRequest LoadFile(string path, int readUnitSize = 1048576) { }

	public static void SetPathSeparator(string filter) { }

	public static void SetProxyServer(string proxyPath, ushort proxyPort) { }

	public static void SetUserAgentString(string userAgentString) { }

	public static CriFsInstallRequest WebInstall(string srcPath, string dstPath, DoneDelegate doneDeleagate) { }

}

