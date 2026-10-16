namespace XeApp.Game;

public static class UtilString
{

	public static int Int(string st1, int def = -1) { }

	public static int Int(int st1, int def = -1) { }

	[Obsolete("longが期待されていますが、intで値を返しています")]
	public static int Int(long st1, int def = -1) { }

	public static long Long(string st1, long def = -1) { }

	public static long Long(long st1, long def = -1) { }

	public static string String(string st1) { }

	public static string String(long st1) { }

}

