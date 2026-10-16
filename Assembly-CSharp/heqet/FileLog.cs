namespace Heqet;

public class FileLog : MonoBehaviour
{
	private static string logFileName; //Field offset: 0x0

	private static FileLog() { }

	public FileLog() { }

	public static bool CompleteDirectory(string dir) { }

	public static void Delete() { }

	[Conditional("__DEBUG__")]
	[Conditional("__SCORE_PREVIEW__")]
	public static void Log(string text) { }

}

