namespace XeApp.Game;

public class DebugEventLogger
{
	[CompilerGenerated]
	private static DebugEventLogger <Instance>k__BackingField; //Field offset: 0x0
	public static bool isShow; //Field offset: 0x4
	public static bool enableLoadEvent; //Field offset: 0x5
	private List<String> logs; //Field offset: 0x8
	private Stopwatch stopwatch; //Field offset: 0xC
	private StringBuilder sb; //Field offset: 0x10
	private StringBuilder sb2; //Field offset: 0x14
	public int MaxLen; //Field offset: 0x18
	private object sync; //Field offset: 0x1C
	private GUIStyle style; //Field offset: 0x20

	public private static DebugEventLogger Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public DebugEventLogger() { }

	[Conditional("GAME_DEBUG")]
	public static void AddEvent(string name) { }

	[Conditional("GAME_DEBUG")]
	private void AddEvent0(string name) { }

	[Conditional("GAME_DEBUG")]
	public void DrawGUI() { }

	[CompilerGenerated]
	public static DebugEventLogger get_Instance() { }

	public void Init() { }

	[Conditional("GAME_DEBUG")]
	public static void LoadEvent(string name) { }

	[Conditional("GAME_DEBUG")]
	public static void LogEvent(string message) { }

	[Conditional("GAME_DEBUG")]
	private void LogEvent0(string message) { }

	[Conditional("GAME_DEBUG")]
	public static void ReStart() { }

	[Conditional("GAME_DEBUG")]
	private void ReStart0() { }

	[CompilerGenerated]
	private static void set_Instance(DebugEventLogger value) { }

}

