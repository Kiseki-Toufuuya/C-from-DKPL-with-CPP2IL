namespace UnityEngine;

[NativeHeader("Runtime/Diagnostics/Validation.h")]
[NativeHeader("Runtime/Diagnostics/IntegrityCheck.h")]
[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
public class Debug
{
	internal static readonly ILogger s_DefaultLogger; //Field offset: 0x0
	internal static ILogger s_Logger; //Field offset: 0x4

	public static bool isDebugBuild
	{
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Debug.logger is obsolete. Please use Debug.unityLogger instead (UnityUpgradable) -> unityLogger")]
	public static ILogger logger
	{
		 get { } //Length: 61
	}

	public static ILogger unityLogger
	{
		 get { } //Length: 61
	}

	private static Debug() { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void Assert(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void Assert(bool condition) { }

	[FreeFunction("PauseEditor")]
	public static void Break() { }

	[RequiredByNativeCode]
	internal static bool CallOverridenDebugHandler(Exception exception, object obj) { }

	[FreeFunction("DebugDrawLine", IsThreadSafe = True)]
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	private static void DrawLine_Injected(in Vector3 start, in Vector3 end, in Color color, float duration, bool depthTest) { }

	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	[ThreadSafe]
	public static int ExtractStackTraceNoAlloc(Byte* buffer, int bufferMax, string projectFolder) { }

	private static int ExtractStackTraceNoAlloc_Injected(Byte* buffer, int bufferMax, ref ManagedSpanWrapper projectFolder) { }

	public static bool get_isDebugBuild() { }

	public static ILogger get_logger() { }

	public static ILogger get_unityLogger() { }

	[RequiredByNativeCode]
	internal static bool IsLoggingEnabled() { }

	public static void Log(object message) { }

	public static void Log(object message, object context) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void LogAssertion(object message) { }

	[Conditional("UNITY_ASSERTIONS")]
	public static void LogAssertionFormat(string format, Object[] args) { }

	public static void LogError(object message, object context) { }

	public static void LogError(object message) { }

	public static void LogErrorFormat(string format, Object[] args) { }

	public static void LogErrorFormat(object context, string format, Object[] args) { }

	public static void LogException(Exception exception) { }

	public static void LogException(Exception exception, object context) { }

	public static void LogFormat(LogType logType, LogOption logOptions, object context, string format, Object[] args) { }

	public static void LogFormat(string format, Object[] args) { }

	public static void LogWarning(object message, object context) { }

	public static void LogWarning(object message) { }

	public static void LogWarningFormat(string format, Object[] args) { }

	public static void LogWarningFormat(object context, string format, Object[] args) { }

}

