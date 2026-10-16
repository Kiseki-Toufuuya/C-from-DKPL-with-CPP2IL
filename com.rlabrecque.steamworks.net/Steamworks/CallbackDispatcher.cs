namespace Steamworks;

public static class CallbackDispatcher
{
	private static Dictionary<Int32, List`1<Callback>> m_registeredCallbacks; //Field offset: 0x0
	private static Dictionary<Int32, List`1<Callback>> m_registeredGameServerCallbacks; //Field offset: 0x4
	private static Dictionary<UInt64, List`1<CallResult>> m_registeredCallResults; //Field offset: 0x8
	private static object m_sync; //Field offset: 0xC
	private static IntPtr m_pCallbackMsg; //Field offset: 0x10
	private static int m_initCount; //Field offset: 0x14

	public static bool IsInitialized
	{
		 get { } //Length: 65
	}

	private static CallbackDispatcher() { }

	public static void ExceptionHandler(Exception e) { }

	public static bool get_IsInitialized() { }

	internal static void Initialize() { }

	internal static void RunFrame(bool isGameServer) { }

	internal static void Shutdown() { }

	private static void UnregisterAll() { }

}

