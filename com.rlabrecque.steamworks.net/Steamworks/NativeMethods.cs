namespace Steamworks;

internal static class NativeMethods
{

	public static bool ISteamApps_BIsDlcInstalled(IntPtr instancePtr, AppId_t appID) { }

	public static IntPtr ISteamApps_GetCurrentGameLanguage(IntPtr instancePtr) { }

	public static IntPtr ISteamClient_GetISteamAppList(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamGameSearch(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamInput(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamParties(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamRemotePlay(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static void ISteamClient_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction) { }

	public static void ISteamFriends_ActivateGameOverlayToStore(IntPtr instancePtr, AppId_t nAppID, EOverlayToStoreFlag eFlag) { }

	public static void ISteamFriends_ActivateGameOverlayToWebPage(IntPtr instancePtr, UTF8StringHandle pchURL, EActivateGameOverlayToWebPageMode eMode) { }

	public static IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr) { }

	public static ulong ISteamUser_GetSteamID(IntPtr instancePtr) { }

	public static bool ISteamUserStats_GetStatFloat(IntPtr instancePtr, UTF8StringHandle pchName, out float pData) { }

	public static bool ISteamUserStats_GetStatInt32(IntPtr instancePtr, UTF8StringHandle pchName, out int pData) { }

	public static bool ISteamUserStats_RequestCurrentStats(IntPtr instancePtr) { }

	public static bool ISteamUserStats_SetAchievement(IntPtr instancePtr, UTF8StringHandle pchName) { }

	public static bool ISteamUserStats_SetStatFloat(IntPtr instancePtr, UTF8StringHandle pchName, float fData) { }

	public static bool ISteamUserStats_SetStatInt32(IntPtr instancePtr, UTF8StringHandle pchName, int nData) { }

	public static bool ISteamUserStats_StoreStats(IntPtr instancePtr) { }

	public static bool ISteamUserStats_UpdateAvgRateStat(IntPtr instancePtr, UTF8StringHandle pchName, float flCountThisSession, double dSessionLength) { }

	public static int SteamAPI_GetHSteamPipe() { }

	public static int SteamAPI_GetHSteamUser() { }

	public static bool SteamAPI_Init() { }

	public static void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe) { }

	public static bool SteamAPI_ManualDispatch_GetAPICallResult(HSteamPipe hSteamPipe, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	public static bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, IntPtr pCallbackMsg) { }

	public static void SteamAPI_ManualDispatch_Init() { }

	public static void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe) { }

	public static bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID) { }

	public static void SteamAPI_Shutdown() { }

	public static int SteamGameServer_GetHSteamPipe() { }

	public static IntPtr SteamInternal_CreateInterface(UTF8StringHandle ver) { }

	public static IntPtr SteamInternal_FindOrCreateGameServerInterface(HSteamUser hSteamUser, UTF8StringHandle pszVersion) { }

	public static IntPtr SteamInternal_FindOrCreateUserInterface(HSteamUser hSteamUser, UTF8StringHandle pszVersion) { }

}

