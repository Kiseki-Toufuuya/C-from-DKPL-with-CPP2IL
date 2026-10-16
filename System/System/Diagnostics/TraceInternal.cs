namespace System.Diagnostics;

internal static class TraceInternal
{
	[ThreadStatic]
	private static int indentLevel; //Field offset: 0x80000000
	private static string appName; //Field offset: 0x0
	private static bool useGlobalLock; //Field offset: 0x4
	private static int indentSize; //Field offset: 0x8
	internal static readonly object critSec; //Field offset: 0xC

	public static int IndentLevel
	{
		 get { } //Length: 66
	}

	public static int IndentSize
	{
		 get { } //Length: 70
	}

	public static bool UseGlobalLock
	{
		 get { } //Length: 70
	}

	private static TraceInternal() { }

	public static int get_IndentLevel() { }

	public static int get_IndentSize() { }

	public static bool get_UseGlobalLock() { }

	private static void InitializeSettings() { }

}

