namespace XeApp.Game.Net;

public static class AppErrorCode
{
	public static readonly String[] Names; //Field offset: 0x0
	public static readonly Dictionary<String, Int32> NameToHash; //Field offset: 0x4
	public static readonly Dictionary<Int32, String> HashToName; //Field offset: 0x8
	public static readonly Dictionary<Int32, Int16> ErrorMessageIDMap; //Field offset: 0xC

	private static AppErrorCode() { }

	public static void DebugThrowException(int id) { }

	public static bool IsCancelBack(int id) { }

}

