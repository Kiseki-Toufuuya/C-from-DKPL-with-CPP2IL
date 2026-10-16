namespace XeApp.Game.Net;

public class StoragePath : MonoBehaviour
{
	[CompilerGenerated]
	private static string <InstallDataPath>k__BackingField; //Field offset: 0x0
	public const string LocalSaveDataDirectoryName = "save"; //Field offset: 0x0
	public const string DebugDirectoryName = "debug"; //Field offset: 0x0
	[CompilerGenerated]
	private static string <LocalSaveDataPath>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static string <DebugPath>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static string <EventLogPath>k__BackingField; //Field offset: 0xC

	public private static string DebugPath
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	public private static string EventLogPath
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	public private static string InstallDataPath
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public private static string LocalSaveDataPath
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	public StoragePath() { }

	public static void DeleteOldFile() { }

	[CompilerGenerated]
	public static string get_DebugPath() { }

	[CompilerGenerated]
	public static string get_EventLogPath() { }

	[CompilerGenerated]
	public static string get_InstallDataPath() { }

	[CompilerGenerated]
	public static string get_LocalSaveDataPath() { }

	public static void Init() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	public static void OnRuntimeMethodLoad() { }

	[CompilerGenerated]
	private static void set_DebugPath(string value) { }

	[CompilerGenerated]
	private static void set_EventLogPath(string value) { }

	[CompilerGenerated]
	private static void set_InstallDataPath(string value) { }

	[CompilerGenerated]
	private static void set_LocalSaveDataPath(string value) { }

}

