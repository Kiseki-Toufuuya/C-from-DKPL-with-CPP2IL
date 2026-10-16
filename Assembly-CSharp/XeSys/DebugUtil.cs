namespace XeSys;

public static class DebugUtil
{

	public static double AnalyzeProcessingLoad(int count, Action<Int32> action) { }

	[Conditional("XESYS_DEBUG")]
	public static void Assert(bool condition, string message) { }

}

