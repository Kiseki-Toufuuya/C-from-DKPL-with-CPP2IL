namespace Steamworks;

internal static class CSteamAPIContext
{
	private static IntPtr m_pSteamClient; //Field offset: 0x0
	private static IntPtr m_pSteamUser; //Field offset: 0x4
	private static IntPtr m_pSteamFriends; //Field offset: 0x8
	private static IntPtr m_pSteamUtils; //Field offset: 0xC
	private static IntPtr m_pSteamMatchmaking; //Field offset: 0x10
	private static IntPtr m_pSteamUserStats; //Field offset: 0x14
	private static IntPtr m_pSteamApps; //Field offset: 0x18
	private static IntPtr m_pSteamMatchmakingServers; //Field offset: 0x1C
	private static IntPtr m_pSteamNetworking; //Field offset: 0x20
	private static IntPtr m_pSteamRemoteStorage; //Field offset: 0x24
	private static IntPtr m_pSteamScreenshots; //Field offset: 0x28
	private static IntPtr m_pSteamGameSearch; //Field offset: 0x2C
	private static IntPtr m_pSteamHTTP; //Field offset: 0x30
	private static IntPtr m_pController; //Field offset: 0x34
	private static IntPtr m_pSteamUGC; //Field offset: 0x38
	private static IntPtr m_pSteamAppList; //Field offset: 0x3C
	private static IntPtr m_pSteamMusic; //Field offset: 0x40
	private static IntPtr m_pSteamMusicRemote; //Field offset: 0x44
	private static IntPtr m_pSteamHTMLSurface; //Field offset: 0x48
	private static IntPtr m_pSteamInventory; //Field offset: 0x4C
	private static IntPtr m_pSteamVideo; //Field offset: 0x50
	private static IntPtr m_pSteamParentalSettings; //Field offset: 0x54
	private static IntPtr m_pSteamInput; //Field offset: 0x58
	private static IntPtr m_pSteamParties; //Field offset: 0x5C
	private static IntPtr m_pSteamRemotePlay; //Field offset: 0x60
	private static IntPtr m_pSteamNetworkingUtils; //Field offset: 0x64
	private static IntPtr m_pSteamNetworkingSockets; //Field offset: 0x68
	private static IntPtr m_pSteamNetworkingMessages; //Field offset: 0x6C

	internal static void Clear() { }

	internal static IntPtr GetSteamApps() { }

	internal static IntPtr GetSteamClient() { }

	internal static IntPtr GetSteamFriends() { }

	internal static IntPtr GetSteamUser() { }

	internal static IntPtr GetSteamUserStats() { }

	internal static bool Init() { }

}

