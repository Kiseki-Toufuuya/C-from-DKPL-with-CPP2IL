namespace CriWare;

public class Common
{
	internal struct CpuUsage
	{
		public float last; //Field offset: 0x0
		public float average; //Field offset: 0x4
		public float peak; //Field offset: 0x8

	}

	private const string scriptVersionString = "1.0.0 (2.45.26-NSDK214)"; //Field offset: 0x0
	public const bool supportsCriFsInstaller = True; //Field offset: 0x0
	public const bool supportsCriFsWebInstaller = True; //Field offset: 0x0
	public const string pluginName = "cri_ware_unity"; //Field offset: 0x0
	public const CallingConvention pluginCallingConvention = 2; //Field offset: 0x0
	public const string engineName = "Unity"; //Field offset: 0x0
	private static GameObject _managerObject; //Field offset: 0x0

	public static string installCachePath
	{
		 get { } //Length: 32
	}

	public static string installTargetPath
	{
		 get { } //Length: 60
	}

	public static GameObject managerObject
	{
		 get { } //Length: 317
	}

	public static string streamingAssetsPath
	{
		 get { } //Length: 111
	}

	public Common() { }

	public static bool CheckBinaryVersionCompatibility() { }

	public static int CRIWAREF0D62767() { }

	public static void criWareUnity_SetRenderingEventOffsetForMana(int offset) { }

	public static string get_installCachePath() { }

	public static string get_installTargetPath() { }

	public static GameObject get_managerObject() { }

	public static string get_streamingAssetsPath() { }

	public static CpuUsage GetAtomCpuUsage() { }

	public static uint GetAtomMemoryUsage() { }

	public static int GetBinaryVersionNumber() { }

	public static uint GetFsMemoryUsage() { }

	public static uint GetManaMemoryUsage() { }

	public static int GetRequiredBinaryVersionNumber() { }

	public static string GetScriptVersionString() { }

	public static bool IsStreamingAssetsPath(string path) { }

}

