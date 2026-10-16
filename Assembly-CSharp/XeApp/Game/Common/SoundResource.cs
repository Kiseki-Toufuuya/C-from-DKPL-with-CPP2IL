namespace XeApp.Game.Common;

public class SoundResource
{
	internal struct SubDirectory
	{
		public string name; //Field offset: 0x0
		public string dirname; //Field offset: 0x4

	}

	private static bool IsInit; //Field offset: 0x0
	private static String[] withAwb; //Field offset: 0x4
	private static readonly SubDirectory[] SubDirectories; //Field offset: 0x8

	private static SoundResource() { }

	public SoundResource() { }

	public static CriAtomCueSheet Add(string cueSheetName) { }

	public static long CalcDownloadSize(string cueSheetName) { }

	public static bool Exists(string cueSheetName) { }

	public static AssetPathEntry GetCueSheetPathEntiry(string cueSheetName, string ext = ".acb") { }

	public static string GetCueSheetSubDirectoryName(string cueSheetName) { }

	public static string GetInstallCueSheetPath(string cueSheetName, string ext = ".acb") { }

	public static string GetStreamingAssetCueSheetPath(string cueSheetName, string ext = ".acb") { }

	public static void Init() { }

	public static bool IsBuiltinSheet(string cueSheetName) { }

	public static bool IsHaveAwb(string cueSheetName) { }

	public static bool IsInstalled(string cueSheetName) { }

	public static void Remove(string cueSheetName) { }

	public static void TryInstall(string cueSheetName) { }

}

