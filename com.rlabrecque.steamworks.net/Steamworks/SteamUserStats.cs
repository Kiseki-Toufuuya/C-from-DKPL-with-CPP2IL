namespace Steamworks;

public static class SteamUserStats
{

	public static bool GetStat(string pchName, out int pData) { }

	public static bool GetStat(string pchName, out float pData) { }

	public static bool RequestCurrentStats() { }

	public static bool SetAchievement(string pchName) { }

	public static bool SetStat(string pchName, int nData) { }

	public static bool SetStat(string pchName, float fData) { }

	public static bool StoreStats() { }

	public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength) { }

}

