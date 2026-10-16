namespace XeApp.Game.Net.Secure;

public static class BuildExpireDateChecker
{
	private static bool IsInit; //Field offset: 0x0
	private const string VALID_UNLOCK_PNG_MD5 = "3d44b65e88179e68a1a628abd34ffe5e"; //Field offset: 0x0
	private const int EXPIRE_DAYS = 30; //Field offset: 0x0
	private static bool IsExistValidUnlockPng; //Field offset: 0x1
	private static DateTime BuildDate; //Field offset: 0x8
	private static DateTime ExpiredDateAt; //Field offset: 0x10
	private static bool IsTargetExpiredDataEnable; //Field offset: 0x18

	public static string ExpiredDate
	{
		 get { } //Length: 35
	}

	public static bool IsCheckEnable
	{
		 get { } //Length: 3
	}

	public static bool IsExpired
	{
		 get { } //Length: 3
	}

	public static string get_ExpiredDate() { }

	public static bool get_IsCheckEnable() { }

	public static bool get_IsExpired() { }

	private static void Init() { }

}

