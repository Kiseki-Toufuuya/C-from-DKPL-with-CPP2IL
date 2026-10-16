namespace XeSys;

public class DebugLog
{

	public DebugLog() { }

	public static void AddGroup(string groupName) { }

	[Conditional("XESYS_DEBUG")]
	public static void Error(string groupName, object message) { }

	[Conditional("XESYS_DEBUG")]
	public static void Error(object message) { }

	[Conditional("XESYS_DEBUG")]
	public static void Info(string groupName, object message) { }

	[Conditional("XESYS_DEBUG")]
	public static void Info(object message) { }

	private static bool IsDisp() { }

	private static bool IsEnabled(string groupName) { }

	public static void RemoveGroup(string groupName) { }

	public static void SetDisplay(string groupName, bool display) { }

	[Conditional("XESYS_DEBUG")]
	public static void Warning(string groupName, object message) { }

	[Conditional("XESYS_DEBUG")]
	public static void Warning(object message) { }

}

